using Control.Data.Interfaces;
using Control.Data.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Repository
{
    public class CompaniesRepository : ICompany
    {

        private readonly AppDBContent appDBContent;

        public CompaniesRepository(AppDBContent appDBContent)
        {   
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Company> AllCompanies => appDBContent.Companies;

        public IEnumerable<Company> AllActiveCompanies => appDBContent.Companies.Where(o => o.Status == true);

        public IEnumerable<Company> SearchForCompanies(string search)
        {
            return appDBContent.Companies.AsEnumerable().Where(o => o.Country.ToString().Contains(search) || o.Name.ToString().Contains(search));
                
        }
    }
}
