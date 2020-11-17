using GP.Data;
using GP.Domain;
using GP.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Provider prov1 = new Provider { ConfirmPassword = "123456", Password = "123456", Username="P1" };
            //Provider prov2 = new Provider { ConfirmPassword = "123456", Password = "12345678", Username="P2" };
            //Provider prov3 = new Provider { ConfirmPassword = "123456", Password = "123456", Username="P3" };
            //Provider prov4 = new Provider { ConfirmPassword = "123456", Password = "123456", Username="P4" };
            //Provider prov5 = new Provider { ConfirmPassword = "123456", Password = "123456", Username="P5" };

            //Category cat1 = new Category { Name = "Cat1"};
            //Category cat2 = new Category { Name = "Cat2" };
            //Category cat3 = new Category { Name = "Cat3" };


            //Product prod1 = new Product {   Name= "Prod 1",
            //                                Description ="Description 1",
            //                                Providers= new List<Provider>() {prov1,prov2,prov3 } ,
            //                                Category = cat1 }; 

            //Product prod2 = new Product {   Name= "Prod 2",
            //                                Description ="Description 2",
            //                                Providers= new List<Provider>() { prov1 } ,
            //                                Category = cat3 };

            //Product prod3 = new Product {   Name= "Prod 3",
            //                                Description ="Description 3",
            //                                Providers= new List<Provider>() { prov1 } ,
            //                                Category = cat1 };

            //Product prod4 = new Product {   Name= "Prod 4",
            //                                Description ="Description 4",
            //                                Providers= new List<Provider>() { prov4,prov5 } 
            //                             };    

            //Product prod5 = new Product {   Name= "Prod 5",
            //                                Description ="Description 4",
            //                                Providers= new List<Provider>() { prov1 } ,
            //                                Category = cat1 };

            //cat1.Products = new List<Product>() { prod1 };
            //cat2.Products = new List<Product>() { prod2 };
            //cat3.Products = new List<Product>() { prod3 };

            //System.Console.WriteLine("***************** Details de Provider 1 ****************");

            //prov1.GetDetails();

            //System.Console.WriteLine("Resultat de Prov 1 "+prov1.ToString());
            //System.Console.WriteLine("**** Valeur initial de IsApproved prov 1 ****");
            //System.Console.WriteLine(prov1.IsApproved);
            //System.Console.WriteLine(" ****************** TEST DE ISAPPROVED ******************");
            //Provider.SetIsApproved(prov1);
            //System.Console.WriteLine( "Resultat : "+prov1.IsApproved);

            //System.Console.WriteLine("Test GetMyType prod1 ");
            //prod1.GetMyType();
            //System.Console.WriteLine("***********//// Verification du Mot de Passe Identique ou pas ////***********");

            //Provider.Mdp( prov1.Password, prov1.ConfirmPassword);
            //Provider.Mdp( prov2.Password, prov2.ConfirmPassword);

            //System.Console.ReadKey();


            // Scenario de Test -- Séance 5

            //Categories
            //Category fruit = new Category() { Name = "Fruit" };
            //Category Alimentaire = new Category() { Name = "Alimentaire" };
            ////Products
            //Product acideCitrique = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "ACIDE CITRIQUE",
            //    Description = "Monohydrate - E330 - USP32",
            //    Category = Alimentaire,
            //    Price = 90,
            //    Quantity = 30,
            //    City = "Sousse"
            //};
            //Product cacaoNaturelle = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "POUDRE DE CACAO NATURELLE",
            //    Description = "10% -12%",
            //    Category = Alimentaire,
            //    Price = 419,
            //    Quantity = 80,
            //    City = "Sfax"
            //};
            //Product cacaoAlcalinisee = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "POUDRE DE CACAO ALCALINISÉE",
            //    Description = "10% -12%",
            //    Category = Alimentaire,
            //    Price = 60,
            //    Quantity = 300,
            //    City = "Sfax"
            //};
            //Product dioxyde = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "DIOXYDE DE TITANE",
            //    Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
            //    Category = Alimentaire,
            //    Price = 200,
            //    Quantity = 50,
            //    City = "Tunis"
            //};
            //Product amidon = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "AMIDON DE MAÏS",
            //    Description = "Amidon de maïs natif",
            //    Category = Alimentaire,
            //    Price = 70,
            //    Quantity = 30,
            //    City = "Tunis"
            //};
            //Product blackberry = new Biological()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "Blackberry",
            //    Description = "",
            //    Category = fruit,
            //    Price = 60,
            //    idProduct = 0,
            //    Quantity = 0

            //};

            //Product apple = new Biological()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Description = "",
            //    Category = fruit,
            //    Name = "Apple",
            //    Price = 100.00,
            //    idProduct = 0,
            //    Quantity = 100

            //};


            ////Product List
            //List<Product> products = new List<Product>() 
            //{  
            //    dioxyde, amidon, 
            //    cacaoAlcalinisee, blackberry, 
            //    apple, acideCitrique, 
            //    cacaoNaturelle 
            //};

            ////Instanciation de la classe ManageProduct
            //ManageProduct manageProduct = new ManageProduct(products);

            ////Other Providers
            //Provider sater = new Provider() { Id = 1, Username = "SATER" };
            //Provider sudMedical = new Provider() { Id = 2, Username = "SUDMEDICAL" };
            //Provider palliserSa = new Provider() { Id = 3, Username = "Palliser SA" };
            //Provider prov4 = new Provider() { Id = 4, Username = "PROV4" };
            //Provider prov5 = new Provider() { Id = 5, Username = "PROV5" };

            ////Providers List
            //List<Provider> providers = new List<Provider>() { sater, sudMedical, palliserSa, prov4, prov5 };

            //ManageProvider manageProvider = new ManageProvider(providers);

            ////Test mths

            //List<Chemical> res_prs_chemical = manageProduct.Get5Chemical(50.0);

            //foreach(Chemical c in res_prs_chemical)
            //{
            //    c.GetDetails();
            //}
            //System.Console.WriteLine("------------------------------------");
            //manageProduct.GetChemicalGroupByCity();
            //System.Console.WriteLine("------------------------------------");
            //manageProduct.UpperName(apple);
            //System.Console.WriteLine(apple.Name);
            //System.Console.WriteLine(manageProduct.inCategory(fruit, apple));



            ////Test Méthodes Anonymes
            //List<Product> list_result_products = manageProduct.FindProducts("a");

            //foreach(Product p in list_result_products)
            //{
            //    p.GetDetails();
            //}

            //System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            //manageProduct.ScanProducts(fruit);
            //System.Console.WriteLine(fruit.Name);


            GPContext gpx = new GPContext();
            Provider prov = new Provider() { Id = 4, Username = "PROV", DateCreated = new DateTime(2020, 10, 27) };
            gpx.Providers.Add(prov);
            gpx.SaveChanges();
            System.Console.WriteLine("DB created");

           


            System.Console.ReadKey();












        }
    }
}
