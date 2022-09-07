using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Control.ViewModels;
using Control.Data.Interfaces;

namespace Control.Controllers
{
    public class UnitsController : Controller
    {
        private readonly ICompanyUnits _allCompanyUnits;

        public UnitsController(ICompanyUnits iAllCompanyUnits)
        {
            _allCompanyUnits = iAllCompanyUnits;
        }

        public ViewResult List()
        {
            CompanyUnitsViewModel obj = new CompanyUnitsViewModel();
            obj.getCompanyUnits = _allCompanyUnits.getCompanyUnits(1);

            return View(obj);
        }
    }
}