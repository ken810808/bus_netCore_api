using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Utities.NetTools;

namespace deploy_core.Models
{
    public class PTX
    {
        IRestSharp _myRestSharp;

        /// <summary>
        /// Construct
        /// </summary>
        /// <param name="myRestSharp">外部注入呼叫API的實體</param>
        public PTX(IRestSharp restSharp)
        {
            //改由外部注入呼叫API的實體
            this._myRestSharp = restSharp;
        }

        /// <summary>
        /// 取得捷運車站設施資料
        /// </summary>
        /// <param name="query">關鍵字查詢</param>
        /// <param name="limit">筆數</param>
        /// <param name="offset">位移筆數</param>
        /// <remarks>1.呼叫外部API為外部行為，部府和測試關注邏輯原則 </remarks>
        /// <returns></returns>
        public List<Infrastructure> Get(string query, int limit, int offset)
        {
            List<Infrastructure> Result = null;

            //Use RestSharp Call API
            var url = $"https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=9099acc7-9b9e-4a99-8c0f-3c85cd578a97&q={query}&limit={limit}&offset={offset}";
            var jsonResult = _myRestSharp.Get(url);

            if (!string.IsNullOrWhiteSpace(jsonResult))
            {
                var APIResult = JsonSerializer.Deserialize<MRTResult>(jsonResult);
                if (APIResult != null && APIResult.result.count > 0)
                {
                    return APIResult.result.results;
                }
            }
            return Result;
        }
    }
}
