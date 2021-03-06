using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using TyreSales.Interface;
using TyreSales.Models;

namespace TyreSales.Repository
{
    public class AssignSalesPerson : IAssignSalesPerson
    {
        ISalesPerson iSalesPerson;
        IGroups iGroups;
        ICustomerSalesPerson iCustomerSalesPerson;
        private readonly ILogger<AssignSalesPerson> logger;
        IMatchGroups iMatchGroups;
        public AssignSalesPerson(ISalesPerson iSalesPerson, IGroups iGroups, ICustomerSalesPerson iCustomerSalesPerson, IMatchGroups iMatchGroups, ILogger<AssignSalesPerson> logger)
        {
            this.iSalesPerson = iSalesPerson;
            this.iGroups = iGroups;
            this.iCustomerSalesPerson = iCustomerSalesPerson;
            this.iMatchGroups = iMatchGroups;
            this.logger = logger;
        }
        public string CheckForSalesPerson(CustomerDetails customerDetails)
        {
            try
            {
                var reqiredGroups = iGroups.GetGroupByName(new[] {customerDetails.Language, customerDetails.CarType});
                var assignedSalesPerson = iCustomerSalesPerson.GetCustomerSalesPerson().Select(s => s.SalesPerson).ToList();
                var listOfSalesPerson = iSalesPerson.LoadSalesPerson().Where(s => !assignedSalesPerson.Contains(s.Name)).ToList();

                var salesPersonName = iMatchGroups.MatchForAllGroups(listOfSalesPerson, reqiredGroups);
                if (salesPersonName == null)
                    salesPersonName = iMatchGroups.MatchForCarTypGroups(listOfSalesPerson, reqiredGroups);
                if (salesPersonName == null)
                    salesPersonName = iMatchGroups.MatchForLanguageGroups(listOfSalesPerson, reqiredGroups);
                if (salesPersonName == null)
                    salesPersonName = listOfSalesPerson.FirstOrDefault();

                if (salesPersonName != null && !string.IsNullOrEmpty(salesPersonName.Name))
                {
                    iCustomerSalesPerson.AssignSalesPerson(customerDetails, salesPersonName.Name);
                    return $"{salesPersonName.Name} will be contacting you shortly.";
                }
                else
                    return "All salespeople are busy. Please wait.";
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred in CheckForSalesPerson method");
                throw;
            }
        }


    }
}
