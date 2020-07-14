using PracticeWorkVKURS.Class;
using Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWorkVKURS
{
    class ExchangeRates
    {
        private SourceData _sourceData;
        public ExchangeRates()
        {
            onlyWithThatCity = "Все города";
            onlyWithThatCurrency = "Все валюты";
            currencyValueFrom = 0.0;
            currencyValueTo = 10000.0;
        }
        public string onlyWithThatCity { get; set; }
        public string onlyWithThatCurrency { get; set; }

        public double currencyValueFrom { get; set; }
        public double currencyValueTo { get; set; }

        public bool buyCheckBoxIsActive { get; set; }
        public bool sellCheckBoxIsActive { get; set; }

        //public List<string[]> BanksData()
        //{
        //    List<string[]> returnData = new List<string[]>();
        //    foreach (var it in _sourceData.Organizations)
        //    {
        //        returnData.Add(new string[] { it.Id, it.Name, it.Region, it.City, it.Address });
        //    }
        //    return returnData;
        //}
        public List<string[]> BanksData()
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in _sourceData.Organizations)
            {
                if(onlyWithThatCity == "Все города" || it.City == onlyWithThatCity)
                {
                    if(onlyWithThatCurrency == "Все валюты" || it.HaveThatCurrency(onlyWithThatCurrency))
                    {
                        if(buyCheckBoxIsActive == false || it.HaveThatBuyCurrency(currencyValueFrom, currencyValueTo))
                        {
                            if (sellCheckBoxIsActive == false || it.HaveThatSellCurrency(currencyValueFrom, currencyValueTo))
                            {
                                returnData.Add(new string[] { it.Id, it.Name, it.Region, it.City, it.Address });
                            }
                        }
                    }
                }
            }
            return returnData;
        }
        //public List<string[]> BuySell(int index)
        //{
        //    List<string[]> returnData = new List<string[]>();
        //    foreach (var it in _sourceData.Organizations[index].Currencies)
        //    {

        //        returnData.Add(new string[] { it.Id, it.Buy, it.Sold });
        //    } 
        //    return returnData;
        //}
        public List<string[]> BuySell(int index)
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in _sourceData.Organizations[index].Currencies)
            {
                if (onlyWithThatCurrency == "Все валюты" || it.Name == onlyWithThatCurrency)
                {
                    double tmp_buy = Convert.ToDouble(it.Buy);
                    if (buyCheckBoxIsActive == false || tmp_buy >= currencyValueFrom && tmp_buy <= currencyValueTo)
                    {
                        double tmp_sell = Convert.ToDouble(it.Sell);
                        if (sellCheckBoxIsActive == false || tmp_sell >= currencyValueFrom && tmp_sell <= currencyValueTo)
                        {
                            returnData.Add(new string[] { it.Id, it.Name, it.Buy, it.Sell });
                        }
                    }
                }
            }
            return returnData;
        }
        public List<string> Currencies()
        {
            List<string> currencies = new List<string>();
            foreach (var item in _sourceData.Currencies)
            {
                currencies.Add(item.Name);
            }
            return currencies;
        }
        public List<string> Cities()
        {
            List<string> cities = new List<string>();
            foreach (var item in _sourceData.Cities)
            {
                cities.Add(item.Name);
            }
            return cities;
        }
        public string DateData()
        {
            return _sourceData.Date;
        }
        public bool RefreshData()
        {
            bool internetConnection;
            _sourceData = DataParseXml.GetBanksAndCurrenciesData(out internetConnection);
            return internetConnection;
        }
    }
}
