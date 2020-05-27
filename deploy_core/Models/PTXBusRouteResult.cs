using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deploy_core.Models
{
    /// <summary>
    /// 取PTX BusRoute的結果
    /// </summary>
    public class PTXBusRouteResult
    {
        public NameDTO RouteName { get; set; }

        public List<StopDTO> Stops { get; set; }

        /// <summary>
        /// 巴士路線名稱
        /// </summary>
        public class NameDTO
        {
            public string Zh_tw { get; set; }
            public string En { get; set; }
        }

        /// <summary>
        /// 站點
        /// </summary>
        public class StopDTO
        {
            /// <summary>
            /// 站點ID
            /// </summary>
            public string StopUID { get; set; }

            /// <summary>
            /// 站點名稱
            /// </summary>
            public NameDTO StopName { get; set; }

            public class NameDTO
            {
                public string Zh_tw { get; set; }
                public string En { get; set; }
            }
        }
    }

}
