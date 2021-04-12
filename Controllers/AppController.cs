using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ASP.NET_Core_Proj.Controllers
{
    [ApiController]
    // Map the request to the root path - ex. "/"
    [Route("")]
    public class AppController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public string runtime = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
        public string buildId;

        public AppController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }


        [HttpGet]
        public String Index()
        {
            // If running locally then show the below message instead of the not-yet-replaced token value in appsettings.json
            // If running in production then display the actual DevOps buildId
            if (_env.IsDevelopment())
            {
                buildId = "Local Development - v1.0";
            }
            else
            {
                buildId = _configuration["CodeVersion:Number"];
            }
            var message = "ASP.NET-Core-Proj " + "| Runtime: " + runtime + " | Build Version: " + buildId;
            return message;
        }
    }
}