using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using deploy_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace deploy_core.Controllers
{
    [Route("[action]")]
    [Produces("application/json")]
    [ApiController]
    public class BusController : Controller
    {
        private readonly MyConfiguration _mySectionConfig;
        private readonly ILogger<BusController> _logger;
        public BusController(ILogger<BusController> logger, MyConfiguration mySectionConfig)
        {
            _logger = logger;
            _mySectionConfig = mySectionConfig;
        }

        [HttpGet]
        public string GetConfig()
        {
            return JsonSerializer.Serialize(_mySectionConfig);
        }
    }
}
