using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //Many with Many relation
            //update table name
            //update PK product + provider
            HasMany(prod => prod.Providers).WithMany(prov => prov.Products)
                                           .Map(m => 
                                           {
                                               m.ToTable("Providings");
                                               m.MapLeftKey("product_key");
                                               m.MapRightKey("provider_key");
                                           });

            //one to many   ( 0 to many => HasOptional)
            HasRequired(prod1 => prod1.Category)
                .WithMany(c => c.Products).HasForeignKey(p => p.CategoryId)
                .WillCascadeOnDelete(false);

            //Stratégie Hertitage
            //Map<Biological>(b => b.Requires("isBiological").HasValue(1));
           // Map<Chemical>(ch => ch.Requires("isBiological").HasValue(0));



        }
    }
}
