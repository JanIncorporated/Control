using Control.Data.Interfaces;
using Control.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Control.Data.Repository
{
    public class OperatorsRepository : ICompanyOperators  
    {
        private readonly AppDBContent appDBContent;

        public OperatorsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Operators> getCompanyOperators(int id) => appDBContent.CompanyOperators.Where(o => o.Company.Id == id);
        
    }
}
