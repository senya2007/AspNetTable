using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services.Mappers
{
    public class PhisixMapper : IPhisixMapper
    {
        public StockList Map(PhisixApiStockListDto dto)
        {
            return new StockList { Stocks = dto.Stock.Select(Map).ToList(), AsOf = dto.AsOf };
        }

        public Stock Map(PhisixApiStockDto dto)
        {
            return new Stock { Name = dto.Name, Price = Map(dto.Price), Volume = dto.Volume, Symbol = dto.Symbol, PercentChange = dto.Percent_Change };
        }

        public Price Map(PhisixApiPriceDto dto)
        {
            return new Price { Currency = dto.Currency, Amount = dto.Amount };
        }
    }
}