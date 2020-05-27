using System;
using System.Collections.Generic;
using System.Text;
using Utities.NetTools;

namespace deploy_coreTests.Mocks
{
    public class MyRestSharpMock : IRestSharp
    {
        public string Get(string url)
        {
            if (url == "https://data.taipei/opendata/datalist/apiAccess?scope=resourceAquire&rid=9099acc7-9b9e-4a99-8c0f-3c85cd578a97&q=七張站&limit=1&offset=1")
            {
                var sb = new StringBuilder(12766);
                sb.AppendLine(@"{""result"":{""limit"":1,""offset"":1,""count"":90,""sort"":"""",""results"":[{""_full_count"":""90"",""Bus"":""252,648"",""Destination"":""台北車站"",""rank"":0.0573088,""Station"":""七張站"",""Outlet"":""A.捷運七張站"",""_id"":1,""Nearby"":""出口1""}]}}");
                //設定CallAPI回傳結果
                return sb.ToString();
            }
            return string.Empty;
        }
    }
}
