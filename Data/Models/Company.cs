using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Models
{
    public class Company
    {
        public int Id { set; get; }

        public string Login { set; get; }

        public string Password { set; get; }
        public string Name { set; get; }

        public string Logo { set; get; }

        public string Link { set; get; }

        public string Country { set; get; }

        public string ShortInfo { set; get; }

        public string FullInfo { set; get; }

        public bool Status { set; get; }

        public List<Operators> Operators { set; get;  }
    }
}
