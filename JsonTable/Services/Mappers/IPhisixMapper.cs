using JsonTable.Models;
using JsonTable.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services.Mappers
{
    public interface IPhisixMapper
    {
        StockList Map(PhisixApiStockListDto dto);
        Stock Map(PhisixApiStockDto dto);
        Price Map(PhisixApiPriceDto dto);
    }
}