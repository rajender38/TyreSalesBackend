using System.Collections.Generic;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface IMatchGroups
    {
        SalesPerson MatchForAllGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups);
        SalesPerson MatchForCarTypGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups);
        SalesPerson MatchForLanguageGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups);
    }
}
