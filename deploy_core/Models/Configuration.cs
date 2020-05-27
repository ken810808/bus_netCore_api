using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deploy_core.Models
{
    public class MyConfiguration
    {
        private readonly IConfiguration _config;

        public MyConfiguration(IConfiguration configuration)
        {
            _config = configuration;
        }

        /// <summary>
        /// Log設定
        /// </summary>
        public string LogLevel 
        {
            get
            {
                return _config["Logging:LogLevel:Default"].ToString();
            }
        }

        /// <summary>
        /// 數據庫連線字串
        /// </summary>
        public string ConnectionString 
        {
            get
            {
                return _config.GetConnectionString("DB");
            }
        }

    }
}
