using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace deploy_core.Models
{
    public class MRTResult
    { 
        public MRTInfrastructureResult result { get; set; }
    }

    /// <summary>
    /// 取PTX BusRoute的結果
    /// </summary>
    public class MRTInfrastructureResult
    {
        public int limit { get; set; }

        public int offset { get; set; }

        public int count { get; set; }

        public List<Infrastructure> results { get; set; }


    }

    public class Infrastructure
    {
        public int _id { get; set; }
        [JsonPropertyName("Bus")]
        public string Bus { get; set; }
        [JsonPropertyName("Destination")]
        public string Destination { get; set; }
        [JsonPropertyName("Station")]
        public string Station { get; set; }
        [JsonPropertyName("Outlet")]
        public string Outlet { get; set; }
        [JsonPropertyName("Nearby")]
        public string Nearby { get; set; }
        [JsonPropertyName("_full_count")]
        public string FullCount { get; set; }
        [JsonPropertyName("rank")]
        public decimal Rank { get; set; }


    }
}
