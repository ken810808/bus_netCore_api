using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace deploy_core.Models
{
    public class PTX
    {
        /// <summary>
        /// 取得捷運車站設施資料
        /// </summary>
        /// <param name="query">關鍵字查詢</param>
        /// <param name="limit">筆數</param>
        /// <param name="offset">位移筆數</param>
        /// <returns></returns>
        public List<Infrastructure> Get(string query, int limit, int offset)
        
        {
            List<Infrastructure> Result = null;

            //Use RestSharp Call API
            var client = new RestClient($"https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=9099acc7-9b9e-4a99-8c0f-3c85cd578a97&q={query}&limit={limit}&offset={offset}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
                        
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var APIResult = JsonSerializer.Deserialize<MRTResult>(response.Content);
                if (APIResult != null && APIResult.result.count > 0)
                {
                    return APIResult.result.results;
                }
            }

            return Result;
        }
    }
}
