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
        private List<Bank> ls_BanksData;
        public List<string[]> BanksData()
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in ls_BanksData)
            {
                returnData.Add(new string[] { it.Id, it.Name, it.Region, it.City, it.Address });
            }
            return returnData;
        }
        public List<string[]> CurrenciesData(int index)
        {
            List<string[]> returnData = new List<string[]>();
            foreach (var it in ls_BanksData[index].Currencies)
            {
                returnData.Add(new string[] { it.Name, it.Buy, it.Sold });
            } 
            return returnData;
        }
        public void ExceptThenThatInLine(List<string[]> list, string exc)
        {
            if (exc != "Все")
            {
                foreach (var it in list)
                {
                    if (it.Contains(exc))
                    {
                        list.Remove(it);
                    }
                }
            }

        }
        public void RefreshData()
        {
            ls_BanksData = DataParseXml.GetBanksAndCurrenciesData();
        }
    }
}
