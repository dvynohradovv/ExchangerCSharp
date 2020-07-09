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

namespace PracticeWorkVKURS.Class
{
    static class DataParseXml
    {
        public static (List<Bank> ls_banks, SortedDictionary<int, List<Currency>> dic_currency) GetBanksAndCurrenciesData()
        {
            string source = DonwloadXmlPage("http://resources.finance.ua/ru/public/currency-cash.xml");

            List<Bank> ls_banksData = new List<Bank>();// 0 - id, 1 - name, 2 - region, 3 - city, 4 - address 
            SortedDictionary<int, List<Currency>> dic_currencyData = new SortedDictionary<int, List<Currency>>();

            Dictionary<string, string> dic_currenciesAssociation = new Dictionary<string, string>();
            Dictionary<string, string> dic_regionsAssociation = new Dictionary<string, string>();
            Dictionary<string, string> dic_citiesAssociation = new Dictionary<string, string>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(source);//загрузили эллемент
            XmlElement xSource = xDoc.DocumentElement;//корневой эллемент
            foreach (XmlNode xnodes in xSource)
            {
                foreach (XmlNode xnode in xnodes)
                {
                    switch (xnode.Name)
                    {
                        case "organization":
                            {
                                Bank new_bank = new Bank();
                                List<Currency> new_currenciesList = new List<Currency>();

                                new_bank.Id = ls_banksData.Count.ToString();
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
                                                    Currency new_currency = new Currency
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
                                dic_currencyData.Add(Convert.ToInt32(new_bank.Id), new_currenciesList);
                                ls_banksData.Add(new_bank);
                                break;
                            }
                        case "org_type":
                            {
                                break;
                            }
                        case "c":
                            {
                                dic_currenciesAssociation.Add(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value);
                                break;
                            }
                        case "region":
                            {
                                dic_regionsAssociation.Add(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value);
                                break;
                            }
                        case "city":
                            {
                                dic_citiesAssociation.Add(xnode.Attributes.GetNamedItem("id").Value, xnode.Attributes.GetNamedItem("title").Value);
                                break;
                            }
                        default: break;
                    }
                }
            }
            foreach (var it in ls_banksData)
            {
                it.Region = dic_regionsAssociation[it.Region];
                it.City = dic_citiesAssociation[it.City];
            }
            return (ls_banksData, dic_currencyData);
        }
        public static void SerializeClass()
        {

        }
        public static void DeserializeXml()
        {

        }
        private static string DonwloadXmlPage(string link)
        {
            string file = @"..\..\XmlData\temp.xml";
            string backup_file = @"..\..\XmlData\backup.xml";
            try
            {
                WebClient webClient = new WebClient();

                webClient.DownloadFile(link, file);
                webClient.DownloadFile(link, backup_file);

                return file;
            }
            catch (Exception)
            {
                return backup_file;
            }
            
        }
    }
}
