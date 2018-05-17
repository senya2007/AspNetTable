using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services.Business
{
    public interface IStockService
    {
        Task<StockList> GetStocks();
    }
}