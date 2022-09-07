using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Control.Data.Models;

namespace Control.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Company> allActiveCompanies { get; set; }
    }
}
