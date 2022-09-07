using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Control.Data.Interfaces;
using System.Runtime.InteropServices;
using Control.ViewModels;
using Korzh.EasyQuery.Linq;

namespace Control.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompany _allActiveCompanies;
        private readonly ICompany _allCompanies;

        public HomeController(ICompany allActiveCompanies, ICompany allCompanies)
        {
            _allActiveCompanies = allActiveCompanies;
            _allCompanies = allCompanies;
        }
        /*public ViewResult Index()
        {
            var homePage = new HomeViewModel
            {
                allActiveCompanies = _allActiveCompanies.AllActiveCompanies
            };
            return View(homePage);
        }*/
        public ViewResult IndexAlt()
        {
            var homePage = new HomeViewModel
            {
                allActiveCompanies = _allActiveCompanies.AllActiveCompanies
            };
            return View(homePage);
        }

        public async Task<IActionResult> Index(string search)
        {
            var homePage = new HomeViewModel
            {
                allActiveCompanies = _allActiveCompanies.AllActiveCompanies
            };
            if (!String.IsNullOrEmpty(search))
            {
                homePage = new HomeViewModel
                {
                    allActiveCompanies = _allActiveCompanies.SearchForCompanies(search)
                };
            }
            
            return View(homePage);
        }

    }
}