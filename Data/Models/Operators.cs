using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Models
{
    public class Operators
    {
        public int Id { set; get; }

        public string Login { set; get; }

        public string Password { set; get; }

        public string Name { set; get; }

        public string SurName { set; get; }

        public virtual Company Company { set; get; }

    }
}
