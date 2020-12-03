using GP.Data.Configurations;
using GP.Data.Conventions;
using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data
{
   public class GPContext : DbContext
    {
        public GPContext() : base("name =GPConnection")
        {
            Database.SetInitializer<GPContext>(null);//Disable initializer

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Facture> Factures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductConfiguration());

            modelBuilder.Configurations.Add(new CategoryConfiguration());

            modelBuilder.Configurations.Add(new AdressConfiguration());

            modelBuilder.Configurations.Add(new FactureConfiguration());

            //TPT
            //    modelBuilder.Entity<Biological>().ToTable("Biologicals");

            //   modelBuilder.Entity<Chemical>().ToTable("Chemicals");

            //TPC : Stratégie Heritage
             /* modelBuilder.Entity<Biological>().Map(b =>
                {
                    b.ToTable("Biologicals");
                    b.MapInheritedProperties();
                });

                // Abstract Strategy Configuration (Chemical)
                modelBuilder.Entity<Chemical>().Map(ch =>
                {
                    ch.ToTable("Chemicals");
                    ch.MapInheritedProperties();
                });*/
           

            //TPH ( default )
           // modelBuilder.Entity <Chemical> ().Map(m => m.Requires("IsBiological").HasValue("0"));
           // modelBuilder.Entity<Biological>().Map(m => m.Requires("IsBiological").HasValue("1"));

       
            // ADD CONVENTION
            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Conventions.Add(new IdConvention());

        }

    }
}
