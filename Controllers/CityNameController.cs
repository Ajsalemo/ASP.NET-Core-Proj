using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASP.NET_Core_Proj.Controllers
{
    [ApiController]
    // Map the request to the root path - ex. "/"
    [Route("controller")]
    public class CityNameController : ControllerBase
    {
        [HttpGet]
        public String CityName()
        {
            var placeholder = "Temporary placeholder";
            return placeholder;
        }
    }
}