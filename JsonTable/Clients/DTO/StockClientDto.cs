using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Clients.DTO
{
    public class StockClientDto
    {
        public string Name { get; set; }
        public PriceClientDto Price { get; set; }
        public double PercentChange { get; set; }
        public int Volume { get; set; }
        public string Symbol { get; set; }
    }
}