using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TyreSales.Interface;
using TyreSales.Models;

namespace TyreSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignSalespersonController : ControllerBase
    {
        IAssignSalesPerson iAssignSalesperson;
        public AssignSalespersonController(IAssignSalesPerson iAssignSalesperson)
        {
            this.iAssignSalesperson = iAssignSalesperson;
        }
        [HttpPost]
        public IActionResult PostAssignSalesPerson([FromBody] CustomerDetails customerDetails)
        {
            iAssignSalesperson.CheckForSalesPerson(customerDetails);

            return Ok();
        }
    }
}
