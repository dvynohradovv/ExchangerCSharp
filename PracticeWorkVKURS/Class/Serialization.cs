using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Currency
    {
        public Currency() { }
        public Currency(string name, string buy, string sold)
        {
            Name = name;
            Buy = buy;
            Sold = sold;
        }

        public string Name { get; set; }
        public string Buy { get; set; }
        public string Sold { get; set; }
    }

    [Serializable]
    public class Bank
    {
        public Bank()
        { }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
