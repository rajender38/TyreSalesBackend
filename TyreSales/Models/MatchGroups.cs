using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TyreSales.Constants;
using TyreSales.Interface;

namespace TyreSales.Models
{
    public class MatchGroups : IMatchGroups
    {

        public SalesPerson MatchForAllGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups)
        {
            return salesPersons.Where(s =>
                s.Groups.Where(r => reqiredGroups.Select(s => s.Key).Contains(r)).Count() == reqiredGroups.Count())
                    .FirstOrDefault();
        }

        public SalesPerson MatchForCarTypGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups)
        {
            var key = reqiredGroups.Where(s => s.Value.Type == GroupTypes.CarType).Select(s => s.Key).FirstOrDefault();
            return salesPersons.Where(s => s.Groups.Contains(key)).FirstOrDefault();
        }

        public SalesPerson MatchForLanguageGroups(List<SalesPerson> salesPersons, IDictionary<string, GroupDetails> reqiredGroups)
        {
            var key = reqiredGroups.Where(s => s.Value.Type == GroupTypes.Language).Select(s => s.Key).FirstOrDefault();
            return salesPersons.Where(s => s.Groups.Contains(key)).FirstOrDefault();
        }
    }
}
