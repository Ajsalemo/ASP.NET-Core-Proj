using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace ASP.NET_Core_Proj.Controllers
{
    [ApiController]
    // Map the request to the root path - ex. "/"
    [Route("")]
    public class AppController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public string runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

        public AppController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [HttpGet]
        public String Index()
        {
            var buildId = _configuration["CodeVersion:Number"];
            var message = "ASP.NET-Core-Proj " + "| Runtime: " + runtime + " | Build Version: " + buildId;
            return message;
        }
    }
}