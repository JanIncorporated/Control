using Control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Interfaces
{
    public interface ICompany
    {
        IEnumerable<Company> AllCompanies { get; }

        IEnumerable<Company> AllActiveCompanies { get; }

        IEnumerable<Company> SearchForCompanies(string search);
    }
}
