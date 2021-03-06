using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TyreSales.Interface;
using TyreSales.Models;

namespace TyreSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignSalespersonController : ControllerBase
    {
        private readonly ILogger<AssignSalespersonController> logger;
        IAssignSalesPerson iAssignSalesperson;
        public AssignSalespersonController(IAssignSalesPerson iAssignSalesperson, ILogger<AssignSalespersonController> logger)
        {
            this.iAssignSalesperson = iAssignSalesperson;
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> PostAssignSalesPerson([FromBody] CustomerDetails customerDetails)
        {
            try
            {
                logger.LogInformation("Assigning sales person started");
                string result = iAssignSalesperson.CheckForSalesPerson(customerDetails);
                return Ok(result);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred in PostAssignSalesPerson ");
                return BadRequest("Internal server occured");
            }
        }
    }
}
