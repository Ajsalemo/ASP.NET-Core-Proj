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
        private string[] cityNames = new[]
        {
            "New York City", "London", "Tokyo", "Paris", "Hong Kong", "Los Angeles", "Sydney", "Rome"
        };

        public string[] CityNames { get => cityNames; set => cityNames = value; }

        [HttpGet]
        public string[] CityName() => CityNames;
    }
}