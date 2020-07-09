using PracticeWorkVKURS.Class;
using Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkVKURS
{
    class ExchangeRates
    {
        private (List<Bank> ls_banksData, SortedDictionary<int, List<Currency>> dic_currenciesData) _FullData;
        public List<string[]> BanksData()
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in _FullData.ls_banksData)
            {
                returnData.Add(new string[] { it.Id, it.Name, it.Region, it.City, it.Address });
            }
            return returnData;
        }
        public List<string[]> CurrenciesData(int index)
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in _FullData.dic_currenciesData[index])
            {
                returnData.Add(new string[] { it.Name, it.Buy, it.Sold });
            }
            return returnData;
        }
        public void RefreshData()
        {
            var fullData = DataParseXml.GetBanksAndCurrenciesData();
            _FullData.ls_banksData = fullData.ls_banks;
            _FullData.dic_currenciesData = fullData.dic_currency;
        }
    }
}
