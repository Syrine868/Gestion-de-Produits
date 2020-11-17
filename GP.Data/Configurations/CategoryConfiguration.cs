using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class CategoryConfiguration : EntityTypeConfiguration <Category>
    {
        public CategoryConfiguration()
        {
            //rename table name
            ToTable("MyCategories");
            //category id primary Key 
            HasKey(e => e.categoryId);
            //Required name + max length
            Property(c => c.Name).IsRequired().HasMaxLength(50);

        }
    }
}
