using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTable.Services
{
    public interface IPhisixApiService
    {
        Task<PhisixApiStockListDto> GetData();
    }
}