using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Conventions
{
    public class DateTimeConvention : Convention
    {
        public DateTimeConvention()
        {
            this.Properties<DateTime>().Configure(dt => dt.HasColumnType("Datetime2") );

        }
    }
}
