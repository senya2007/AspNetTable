using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Models
{
    public class Stock
    {
        public string Name { get; set; }
        public Price Price { get; set; }
        public double PercentChange { get; set; }
        public int Volume { get; set; }
        public string Symbol { get; set; }
    }
}