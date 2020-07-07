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

namespace PracticeWorkVKURS.Class
{
    static class DataParseFromXml
    {
        public static (List<string[]> ls_banksData, SortedDictionary<int, List<string[]>> dic_currencyData) GetBanksAndCurrenciesData()
        {
            List<string[]> ls_banksData = new List<string[]>();
            SortedDictionary <int, List<string[]>> dic_currencyData = new SortedDictionary<int, List<string[]>> ();

            XmlDocument xDoc = new XmlDocument();  

            xDoc.Load("http://resources.finance.ua/ru/public/currency-cash.xml");//загрузили эллемент 
            XmlElement xSource = xDoc.DocumentElement;//корневой эллемент
            foreach(XmlNode xnodes in xSource) 
            {
                foreach (XmlNode xnode in xnodes) 
                {
                    switch (xnode.Name)
                    {
                        case "organization": 
                            {
                                string[] bankInfo = new string[5];// 0 - id, 1 - name, 2 - region, 3 - city, 4 - address  
                                List<string[]> currencyList = new List<string[]>();

                                bankInfo[0] = ls_banksData.Count.ToString();
                                foreach (XmlNode childnode in xnode)
                                {
                                    switch (childnode.Name)
                                    {
                                        case "title":
                                            {
                                                bankInfo[1] = childnode.Attributes.GetNamedItem("value").Value;
                                                break;
                                            }
                                        case "region":
                                            {
                                                bankInfo[2] = childnode.Attributes.GetNamedItem("id").Value;
                                                break;
                                            }
                                        case "city":
                                            {
                                                bankInfo[3] = childnode.Attributes.GetNamedItem("id").Value;
                                                break;
                                            }
                                        case "address":
                                            {
                                                bankInfo[4] = childnode.Attributes.GetNamedItem("value").Value;
                                                break;
                                            }
                                        case "currencies":
                                            {
                                                int tmp_id = Convert.ToInt32(bankInfo[0]);
                                                foreach (XmlNode currency in childnode)
                                                {
                                                    string[] currenciesInfo = new string[] // 0 - currency, 1 - buy, 2 - sold
                                                    {
                                                        currency.Attributes.GetNamedItem("id").Value,
                                                        currency.Attributes.GetNamedItem("br").Value,
                                                        currency.Attributes.GetNamedItem("ar").Value
                                                    };
                                                    //currenciesInfo[0] = 
                                                    //currenciesInfo[1] = 
                                                    //currenciesInfo[2] = 
                                                    currencyList.Add(currenciesInfo);
                                                }
                                                break;
                                            }
                                        default: break;
                                    }
                                }
                                dic_currencyData.Add(Convert.ToInt32(bankInfo[0]), currencyList);
                                ls_banksData.Add(bankInfo); 
                                break;
                            }
                        case "org_type":
                            {
                                break;
                            }
                        case "c":
                            {
                                break;
                            }
                        case "region":
                            {
                                break;
                            }
                        case "city":
                            {
                                break;
                            }
                        default: break;
                    }
                }
            }
            return (ls_banksData, dic_currencyData);
        }
    }
}
