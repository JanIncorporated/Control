using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Models
{
    public class Unit
    {
        public int Id { set; get; }

        public string CodeName { set; get; }

        public string Info { set; get; }

        public bool Status { set; get; }

        public virtual Company Company { set; get; }
    }
}
