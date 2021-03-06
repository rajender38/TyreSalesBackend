using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
