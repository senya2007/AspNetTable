using JsonTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Clients.DTO
{
    public class StockListClientDto
    {
        public List<Stock> Stock { get; set; }
        public DateTime AsOf { get; set; }
    }
}