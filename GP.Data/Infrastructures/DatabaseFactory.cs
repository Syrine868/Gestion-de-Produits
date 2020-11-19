using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructures
{
    public class DatabaseFactory : Disposable , IDatabaseFactory
    {
        private GPContext dataContext = null;
        public GPContext MyContext { get { return dataContext; } }
        public DatabaseFactory()
        {
            dataContext = new GPContext();
        }
        protected override void DisposeCore()
        {
            if (dataContext != null) dataContext.Dispose();
        }
    }
}
