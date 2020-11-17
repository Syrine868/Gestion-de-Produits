namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyCategories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        DateProd = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 25),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Herbs = c.String(),
                        LabName = c.String(),
                        Adresse_StreetAddress = c.String(maxLength: 50),
                        Adresse_City = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idProduct)
                .ForeignKey("dbo.MyCategories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateNaissance = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Mail = c.String(),
                        nom = c.String(),
                        prenom = c.String(),
                        Product_idProduct = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.Product_idProduct)
                .Index(t => t.Product_idProduct);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        DateAchat = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ProductFk = c.Int(nullable: false),
                        ClientFk = c.Int(nullable: false),
                        Prix = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductFk, t.ClientFk })
                .ForeignKey("dbo.Clients", t => t.ClientFk)
                .ForeignKey("dbo.Products", t => t.ProductFk)
                .Index(t => t.ProductFk)
                .Index(t => t.ClientFk);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfirmPassword = c.String(),
                        DateCreated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Email = c.String(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        Password = c.String(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Providings",
                c => new
                    {
                        product_key = c.Int(nullable: false),
                        provider_key = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.product_key, t.provider_key })
                .ForeignKey("dbo.Products", t => t.product_key, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.provider_key, cascadeDelete: true)
                .Index(t => t.product_key)
                .Index(t => t.provider_key);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Providings", "provider_key", "dbo.Providers");
            DropForeignKey("dbo.Providings", "product_key", "dbo.Products");
            DropForeignKey("dbo.Clients", "Product_idProduct", "dbo.Products");
            DropForeignKey("dbo.Factures", "ProductFk", "dbo.Products");
            DropForeignKey("dbo.Factures", "ClientFk", "dbo.Clients");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.MyCategories");
            DropIndex("dbo.Providings", new[] { "provider_key" });
            DropIndex("dbo.Providings", new[] { "product_key" });
            DropIndex("dbo.Factures", new[] { "ClientFk" });
            DropIndex("dbo.Factures", new[] { "ProductFk" });
            DropIndex("dbo.Clients", new[] { "Product_idProduct" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Providings");
            DropTable("dbo.Providers");
            DropTable("dbo.Factures");
            DropTable("dbo.Clients");
            DropTable("dbo.Products");
            DropTable("dbo.MyCategories");
        }
    }
}
