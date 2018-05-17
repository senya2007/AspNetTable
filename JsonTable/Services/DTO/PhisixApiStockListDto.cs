using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services.DTO
{
    public class PhisixApiStockListDto
    {
        public List<PhisixApiStockDto> Stock { get; set; }
        public DateTime AsOf { get; set; }
    }
}