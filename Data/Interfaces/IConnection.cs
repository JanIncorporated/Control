using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control.Data.Models;

namespace Control.Data.Interfaces
{
    interface IConnection
    {
        IEnumerable<Unit> getCompanyConnections(int name);
    }
}
