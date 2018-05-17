using JsonTable.Models;
using JsonTable.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace JsonTable.Services.Business
{
    public class StockService : IStockService
    {
        private IPhisixApiService phisixApiService = new PhisixApiService();
        private IPhisixMapper phisixMapper = new PhisixMapper();

        public async Task<StockList> GetStocks()
        {
            var data = await phisixApiService.GetData();
            return phisixMapper.Map(data);
        }
    }
}