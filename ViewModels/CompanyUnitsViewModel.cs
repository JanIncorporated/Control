using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Data.Models;

namespace Control.ViewModels
{
    public class CompanyUnitsViewModel
    {
        public IEnumerable<Unit> getCompanyUnits { get; set; }
    }
}
