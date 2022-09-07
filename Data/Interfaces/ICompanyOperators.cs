using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Data.Models;

namespace Control.Data.Interfaces
{
    public interface ICompanyOperators
    {
        IEnumerable<Operators> getCompanyOperators(int id);
  
    }
}
