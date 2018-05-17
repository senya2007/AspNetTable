using JsonTable.Clients.DTO;
using JsonTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Clients.Mappers
{
    public interface IStockClientMapper
    {
        StockListClientDto Map(StockList stockList);
        StockClientDto Map(Stock stock);
        PriceClientDto Map(Price price);
    }
}