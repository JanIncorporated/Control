using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using Control.Data.Interfaces;
using Control.Data.Models;

namespace Control.Data.Repository
{
    public class ConnectionRepository
    {
        private readonly AppDBContent appDBContent;

        public ConnectionRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        /*public IEnumerable<Unit> getCompanyConnections(int name)
        {
            return appDBContent.Connection.AsEnumerable().Where(o => o.Country.ToString().Contains(id) || o.Name.ToString().Contains(id));
        }*/
    }
}
