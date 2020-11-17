using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
 public class ManageProvider
    {
        private List<Provider> providers;
        public ManageProvider(List<Provider> pr)
        {
            this.providers = pr;
        }

        public List<Provider> GetProviderByName(string name)
        {
            var query = from p in providers
                        where p.Username.Contains(name) 
                        select p;
            return query.ToList<Provider>();
        }

        public Provider GetFirstProviderByName(string name)
        {
            var query = from p in providers
                        where p.Username.Contains(name)
                        select p;
            return query.First();
        }
         
        public Provider GetProviderById(int id)
        {
            var query = from p in providers
                        where p.Id == id
                        select p;
            return query.Single();
        }


    }
}
