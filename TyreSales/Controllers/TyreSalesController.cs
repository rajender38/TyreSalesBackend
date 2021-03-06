using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TyreSales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TyreSalesController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "This is a .net core web API for tyre sales";
        }
    }
}
