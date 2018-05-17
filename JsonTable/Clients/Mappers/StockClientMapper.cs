using JsonTable.Clients.DTO;
using JsonTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Clients.Mappers
{
    public class StockClientMapper : IStockClientMapper
    {
        public StockListClientDto Map(StockList stockList)
        {
            return new StockListClientDto { Stock = stockList.Stocks, AsOf = stockList.AsOf };
        }

        public StockClientDto Map(Stock stock)
        {
            return new StockClientDto { Name = stock.Name, Price = Map(stock.Price), Symbol = stock.Symbol, PercentChange = stock.PercentChange, Volume = stock.Volume };
        }

        public PriceClientDto Map(Price price)
        {
            return new PriceClientDto { Amount = price.Amount, Currency = price.Currency };
        }
    }
}