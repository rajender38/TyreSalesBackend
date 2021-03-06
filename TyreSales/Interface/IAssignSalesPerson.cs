using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface IAssignSalesPerson
    {
        string CheckForSalesPerson(CustomerDetails customerDetails);
    }
}
