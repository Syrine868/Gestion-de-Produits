using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        GPContext MyContext { get; }
    }
}
