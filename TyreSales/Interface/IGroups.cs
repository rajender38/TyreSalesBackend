using System.Collections.Generic;
using TyreSales.Models;

namespace TyreSales.Interface
{
    public interface IGroups
    {
        public IDictionary<string, GroupDetails> GetGroupByName(string[] value);
    }
}
