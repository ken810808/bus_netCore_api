using RestSharp;
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
            /// 取得巴士路線資料
            /// </summary>
            /// <param name="city">縣市名稱</param>
            /// <param name="routeName">巴士路線名稱</param>
            /// <returns></returns>
        public BusRouteDTO Get(string city, string routeName)
        {
            BusRouteDTO Result = null;

            //Use RestSharp Call API
            var client = new RestClient($"http://ptx.transportdata.tw/MOTC/v2/Bus/StopOfRoute/City/{city}/{routeName}?%24top=1&%24format=JSON");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var APIResult = JsonSerializer.Deserialize<List<PTXBusRouteResult>>(response.Content);

                if (APIResult != null && APIResult.Count > 0)
                {
                    var Route = APIResult.First();
                    Result = new BusRouteDTO
                    {
                        Name = Route.RouteName.Zh_tw,
                        BusStops = new List<BusRouteDTO.BusStop>()
                    };

                    foreach (var stop in Route.Stops)
                    {
                        Result.BusStops.Add(new BusRouteDTO.BusStop
                        {
                            ID = stop.StopUID,
                            Name = stop.StopName.Zh_tw
                        });
                    }
                }
            }

            return Result;
        }
    }
}
