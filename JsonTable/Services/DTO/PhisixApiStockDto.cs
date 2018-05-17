using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services.DTO
{
    public class PhisixApiStockDto
    {
        public string Name { get; set; }
        public PhisixApiPriceDto Price { get; set; }
        public double Percent_Change { get; set; }
        public int Volume { get; set; }
        public string Symbol { get; set; }
    }
}