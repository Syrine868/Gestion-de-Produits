using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class FactureConfiguration : EntityTypeConfiguration<Facture>
    {
        public FactureConfiguration()
        {

            HasKey(c => new
            {

                c.ClientFk,
                c.ProductFk,
            });
            HasRequired(f => f.Client)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ClientFk)
                .WillCascadeOnDelete(false);

            HasRequired(f => f.Produit)
                .WithMany(p => p.Factures)
                .HasForeignKey(f => f.ProductFk)
                .WillCascadeOnDelete(false);


        }
    }
}
