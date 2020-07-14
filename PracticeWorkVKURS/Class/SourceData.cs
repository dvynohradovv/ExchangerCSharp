using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public abstract class ItemWithId
    {
        public ItemWithId() { }
        public ItemWithId(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public string Id { get; set; }
    }

    [Serializable]
    public class OrganizationType : ItemWithId
    {
        public OrganizationType() { }
        public OrganizationType(string id, string name) : base (id, name) { }
    }

    [Serializable]
    public class Region : ItemWithId
    {
        public Region() { }
        public Region(string id, string name) : base(id, name) { }
    }

    [Serializable]
    public class City : ItemWithId
    {
        public City() { } 
        public City(string id, string name) : base(id, name) { }

    }

    [Serializable]
    public class Currency : ItemWithId
    {
        public Currency() { }
        public Currency(string id, string name) : base(id, name) { }
    }

    [Serializable]
    public class BuySell
    {
        public BuySell() { }
        public BuySell(string id, string buy, string sold)
        {
            Id = id;
            Buy = buy;
            Sell = sold;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Buy { get; set; }
        public string Sell { get; set; }
    }

    [Serializable]
    public class Organization : ItemWithId
    {
        public Organization() { }
        public string Region { get; set; } 
        public string City { get; set; } 
        public string Address { get; set; } 
        public List<BuySell> Currencies {get;set;}
        public bool HaveThatCurrency(string onlyWithThatCurrency)
        {
            foreach (var it in Currencies)
            {
                if (it.Name == onlyWithThatCurrency) return true;
            }
            return false;
        }
        public bool HaveThatBuyCurrency(double from, double to)
        {
            foreach (var it in Currencies)
            {
                double tmp_buy = Convert.ToDouble(it.Buy);
                if (tmp_buy >= from && tmp_buy <= to) return true;
            }
            return false;
        }
        public bool HaveThatSellCurrency(double from, double to)
        {
            foreach (var it in Currencies)
            {
                double tmp_sell = Convert.ToDouble(it.Sell);
                if (tmp_sell >= from && tmp_sell <= to) return true;
            }
            return false;
        }

    }

    [Serializable]
    public class SourceData
    {
        public SourceData()
        {
            Organizations = new List<Organization>();
            Currencies = new List<Currency>();
            Cities = new List<City>();
            Regions = new List<Region>();
        }

        public void StructSourceData()
        {
            foreach (var org in Organizations)
            {
                foreach (var region in Regions)
                {
                    if (org.Region == region.Id)
                    {
                        org.Region = region.Name;
                        break;
                    }
                }
                foreach (var city in Cities)
                {
                    if (org.City == city.Id)
                    {
                        org.City = city.Name;
                        break;
                    }
                }
                foreach (var buySell in org.Currencies)
                {
                    foreach (var currensiesList in Currencies)
                    {
                        if(buySell.Id == currensiesList.Id)
                        {
                            buySell.Name = currensiesList.Name;
                        }
                    }
                }
            }
        }
        public string Date { get; set; }
        public List<Organization> Organizations { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<City> Cities { get; set; }
        public List<Region> Regions { get; set; }
    }
}
