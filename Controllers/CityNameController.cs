using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASP.NET_Core_Proj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityNameController : ControllerBase
    {
        public string[] cityNames = new[]
        {
            "New York City"
        };

        [HttpGet]
        public string[] CityName()
        {
            return cityNames;
        }
    }
}