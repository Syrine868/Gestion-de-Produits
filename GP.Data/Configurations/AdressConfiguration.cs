using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class AdressConfiguration : EntityTypeConfiguration <Adresse>
    {
        public AdressConfiguration()
        {
            //Properties Adress 
            Property(a => a.City).IsRequired();
            Property(a1 => a1.StreetAddress).IsOptional().HasMaxLength(50);

        }
    }
}
