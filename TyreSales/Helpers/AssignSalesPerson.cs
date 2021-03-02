using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TyreSales.Interface;
using TyreSales.Models;

namespace TyreSales.Repository
{
    public class AssignSalesPerson : IAssignSalesPerson
    {
        ISalesPerson iSalesPerson;
        IGroups iGroups;
        public AssignSalesPerson(ISalesPerson iSalesPerson, IGroups iGroups)
        {
            this.iSalesPerson = iSalesPerson;
            this.iGroups = iGroups;
        }
        public void CheckForSalesPerson(CustomerDetails customerDetails)
        {

            var languageGroup = iGroups.GetGroupByName(customerDetails.language);
            var carTypeGroup = iGroups.GetGroupByName(customerDetails.carType);

            List<SalesPerson> sp = iSalesPerson.LoadSalesPerson();
            string name = sp.Where(s => s.Groups.Where(r => (r == languageGroup && r == carTypeGroup)
           || (r == carTypeGroup) || true).Count() > 0).Select(s => s.Name).FirstOrDefault();

            CustomerAssignedSP spf = new CustomerAssignedSP(customerDetails, name);



        }
    }
}
