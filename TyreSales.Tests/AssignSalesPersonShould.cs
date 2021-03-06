using System;
using Xunit;
using TyreSales.Controllers;
using Microsoft.Extensions.DependencyInjection;
using TyreSales.Interface;
using TyreSales.Repository;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace TyreSales.Tests
{
    public class AssignSalesPersonShould
    {
        readonly IServiceProvider _services =
        Program.CreateHostBuilder(new string[] { }).Build().Services;

        [Fact]
        public void CheckAssignSalesPersonKierraGentry()
        {
            var myService = _services.GetRequiredService<IAssignSalesPerson>();
            var result = myService.CheckForSalesPerson(new Models.CustomerDetails { FristName = "Raj", LastName = "Am", Language = "A" , CarType = "C"});

            Assert.Equal("Kierra Gentry will be contacting you shortly.", result);
        }
        [Fact]
        public void CheckAssignSalesPersonThomasCrane()
        {
            var myService = _services.GetRequiredService<IAssignSalesPerson>();
            var result = myService.CheckForSalesPerson(new Models.CustomerDetails { FristName = "Raj", LastName = "Am", Language = "A" , CarType = "B" });

            Assert.Equal("Thomas Crane will be contacting you shortly.", result);
        }
        [Fact]
        public void CheckAssignSalesPersonAldenCantrell()
        {
            var myService = _services.GetRequiredService<IAssignSalesPerson>();
            var result = myService.CheckForSalesPerson(new Models.CustomerDetails { FristName = "Raj", LastName = "Am", Language = "E" , CarType =  "B" });

            Assert.Equal("Alden Cantrell will be contacting you shortly.", result);
        }
    }
}
