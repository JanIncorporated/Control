using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control.Data.Models
{
    public class Connection
    {
        public int Id { set; get; }

        public string Info { set; get; }

        public bool Status { set; get; }

        public virtual Company CompanyOperator { set; get; }

        public virtual Unit Unit { set; get; }
    }
}
