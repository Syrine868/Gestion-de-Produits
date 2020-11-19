using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructures
{
   public class UnitOfWork : IunitOfWork
    {
        IDatabaseFactory Factory;
        public UnitOfWork(IDatabaseFactory Factory)
        {
            this.Factory = Factory;
        }
        public void Commit()
        {
            Factory.MyContext.SaveChanges();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Factory);
        }
        public void Dispose()
        {
            Factory.Dispose();
        }
    }
}
