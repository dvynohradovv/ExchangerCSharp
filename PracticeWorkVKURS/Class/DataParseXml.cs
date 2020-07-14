using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Specialized;
using Serialization;
using System.Xml.Serialization;
using System.IO;

namespace PracticeWorkVKURS.Class
{
    static class DataParseXml
    {
        public static SourceData GetBanksAndCurrenciesData(out bool internetConnection)
        {
            string source = DonwloadXmlPage("http://resources.finance.ua/ru/public/currency-cash.xml");
            SourceData sourceData = new SourceData();
            if(source == "false")
            {
                sourceData = DeserializeXml(sourceData, @"sourceData");
                internetConnection = false;
                return sourceData;
            }
            internetConnection = true;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(source);//загрузили эллемент
            XmlElement xSource = xDoc.DocumentElement;//корневой эллемент
            sourceData.Date = xSource.Attributes.GetNamedItem("date").Value;
            foreach (XmlNode xnodes in xSource)
            {
                foreach (XmlNode xnode in xnodes)
                {
                    switch (xnode.Name)
                    {
                        case "organization":
                            {
                                Organization new_bank = new Organization();
                                List<BuySell> new_currenciesList = new List<BuySell>();

                                new_bank.Id = sourceData.Organizations.Count.ToString();
                                foreach (XmlNode childnode in xnode)
                                {
                                    switch (childnode.Name)
                                    {
                                        case "title":
                                            {
                                                new_bank.Name = childnode.Attributes.GetNamedItem("value").Value;
                                                break;
                                            }
                                        case "region":
                                            {
                                                new_bank.Region = childnode.Attributes.GetNamedItem("id").Value;
                                                break;
                                            }
                                        case "city":
                                            {
                                                new_bank.City = childnode.Attributes.GetNamedItem("id").Value;
                                                break;
                                            }
                                        case "address":
                                            {
                                                new_bank.Address = childnode.Attributes.GetNamedItem("value").Value;
                                                break;
                                            }
                                        case "currencies":
                                            {
                                                foreach (XmlNode currency in childnode)
                                                {
                                                    BuySell new_currency = new BuySell
                                                        (
                                                            currency.Attributes.GetNamedItem("id").Value,
                                                            currency.Attributes.GetNamedItem("br").Value,
                                                            currency.Attributes.GetNamedItem("ar").Value
                                                        );
                                                    new_currenciesList.Add(new_currency);
                                                }
                                                break;
                                            }
                                        default: break;
                                    }
                                }
                                new_bank.Currencies = new_currenciesList;
                                sourceData.Organizations.Add(new_bank);
                                break;
                            }
                        case "org_type":
                            {
                                break;
                            }
                        case "c":
                            {
                                sourceData.Currencies.Add(new Currency(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value));
                                break;
                            }
                        case "region":
                            {
                                sourceData.Regions.Add(new Region(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value));
                                break;
                            }
                        case "city":
                            {
                                sourceData.Cities.Add(new City(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value));
                                break;
                            }
                        default: break;
                    }
                }
            }

            sourceData.StructSourceData();
            SerializeClass(sourceData, @"sourceData");
            return sourceData;

        }
        public static void SerializeClass<T>(T item, string name)
        {
            string link = string.Format(@"..\..\XmlData\{0}.xml", name);
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
        public static T DeserializeXml<T>(T item, string name)
        {
            string link = string.Format(@"..\..\XmlData\{0}.xml", name);
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            // десериализация
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                T newPerson = (T)formatter.Deserialize(fs);
                return newPerson;
            }
        }
        private static string DonwloadXmlPage(string link)
        {
            string file = @"..\..\XmlData\temp.xml";
            string backup_file = @"..\..\XmlData\backup.xml";
            try
            {
                WebClient webClient = new WebClient();

                webClient.DownloadFile(link, file);
                File.Copy(file, backup_file, true);
                return file;
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутствует подключение к интернету! Данные не будут обновлены!");
                return "false";
            }
            
        }
    }
}
