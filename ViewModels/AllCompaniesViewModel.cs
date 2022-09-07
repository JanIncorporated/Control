using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Data.Models;

namespace Control.ViewModels
{
    public class AllCompaniesViewModel
    {
        public IEnumerable<Company> allCompanies { get; set;  }

        public IEnumerable<Company> searchedCompanies { get; set; }

        public string Search { get; set; }
    }
}
