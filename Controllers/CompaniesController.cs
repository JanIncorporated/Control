using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Control.Data.Interfaces;
using System.Runtime.InteropServices;
using Control.ViewModels;

namespace Control.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompany _allCompanies;

        public CompaniesController(ICompany iAllCompanies)
        {
            _allCompanies = iAllCompanies;  
        }

        public ViewResult AllCompaniesList()
        {
            AllCompaniesViewModel obj = new AllCompaniesViewModel();
            obj.allCompanies = _allCompanies.AllCompanies;

            return View(obj);
        }

        public ViewResult AllCompaniesListAlt()
        {
            AllCompaniesViewModel obj = new AllCompaniesViewModel();
            obj.allCompanies = _allCompanies.AllCompanies;

            return View(obj);
        }
 
    }
}
