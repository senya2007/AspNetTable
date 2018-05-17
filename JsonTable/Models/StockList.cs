using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Models
{
    public class StockList
    {
        public List<Stock> Stocks { get; set; }
        public DateTime AsOf { get; set; }
    }
}