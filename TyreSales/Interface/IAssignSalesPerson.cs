using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface IAssignSalesPerson
    {
        string CheckForSalesPerson(CustomerDetails customerDetails);
    }
}
