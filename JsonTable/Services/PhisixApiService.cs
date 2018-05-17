using JsonTable.Services.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace JsonTable.Services
{
    public class PhisixApiService : IPhisixApiService
    {
        private static string ApiUrl = "http://phisix-api3.appspot.com/stocks.json";

        public async Task<PhisixApiStockListDto> GetData()
        {
            var content = await new WebClient().DownloadStringTaskAsync(new Uri(ApiUrl));

            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Culture = CultureInfo.GetCultureInfo("en-US"),

            };

            return JsonConvert.DeserializeObject<PhisixApiStockListDto>(content, settings);
        }
    }
}