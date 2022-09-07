using Control.Data.Interfaces;
using Control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Repository
{
    public class UnitsRepository : ICompanyUnits
    {
        private readonly AppDBContent appDBContent;

        public UnitsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Unit> getCompanyUnits(int id)
        {
            return (appDBContent.Unit.Where(o => o.Company.Id == id));
        }
    }
}
