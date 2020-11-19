using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
   public class ManageProduct
    {
        
        private List<Product> products;
       
        public Func<string, List<Product>> FindProducts;
        public Action<Category> ScanProducts;

        public ManageProduct(List<Product> prod)
        {
            this.products = prod;
            //Méthode Anonyme Find Product
            //FindProducts = delegate (string c)
            //{
            //    List<Product> ProductFoundedList = new List<Product>();
            //    foreach (Product finder in products)
            //    {
            //        if (finder.Name.ToUpper().StartsWith(c.ToUpper()))
            //        {
            //            ProductFoundedList.Add(finder);
            //        }
            //    }
            //    return ProductFoundedList;
            //};

            FindProducts =  (string c) =>
            {
                List<Product> ProductFoundedList = new List<Product>();
                foreach (Product finder in products)
                {
                    if (finder.Name.ToUpper().StartsWith(c.ToUpper()))
                    {
                        ProductFoundedList.Add(finder);
                    }
                }
                return ProductFoundedList;
            };

            //Méthode Anonyme ScanProducts
            //ScanProducts = delegate (Category scanCatg)
            //{
            //    foreach (Product p_scan in products)
            //    {
            //        if(p_scan.Category.Equals(scanCatg))
            //        {
            //            p_scan.GetDetails();
            //        }
            //    }
            //};

            ScanProducts = (Category scanCatg) =>
            {
                foreach (Product p_scan in products)
                {
                    if (p_scan.Category.Equals(scanCatg))
                    {
                        p_scan.GetDetails();
                    }
                }
            };
        }

        public ManageProduct()
        {
        }

        public List<Product> Get5Product(double price)
        {
            var query = from p in products
                        where p.Price > price
                        select p;
            return query.Take(5).ToList<Product>();
        }

        public List<Chemical> Get5Chemical (double price)
        {
            var query = (from p in products
                         where p.Price > price
                         select p).OfType<Chemical>();
            return query.Take(5).ToList<Chemical>();
        }
        public List<Chemical> Get5ChemicalV2(double price)
        {
            var query = (from p in products
                         where p.Price > price
                         && p is Chemical
                         select (Chemical) p );
            return query.Take(5).ToList<Chemical>();
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            
            var query = from p in products
                        where p.Price > price
                        select p;
            return query.Skip(2);
        }
        public double GetAveragePrice()
        {
            var query = from p in products
                        select p.Price;
            return query.Average();
        }

        public Product GetMaxPrice()
        {
            var maxPrice = (from p in products
                       
                        select p.Price).Max();
            var query = from p in products
                        where p.Price == maxPrice
                        select p;
            return query.First();
        }

        public int GetCountProduct(string city)
        {
            var query = from p in products
                        where ((Chemical)p).Adresse.City.Equals(city) && p is Chemical
                        select p;
            return query.Count();
                        
        }

        public IEnumerable<Chemical> GetChemicalCity()
        {
            var query = from p in products
                        where p is Chemical
                        orderby ((Chemical )p).Adresse.City descending
                        select ((Chemical) p)
                        ;
            return query;
        }

        public void GetChemicalGroupByCity()
        {
            var query = from p in products
                        where p is Chemical
                        orderby ((Chemical)p).Adresse.City descending
                        group (Chemical)p by
                        ((Chemical)p).Adresse.City;
            foreach (var i in query)
            {

                Console.WriteLine( i.Key);

                foreach (var j in i)
                {
                    Console.WriteLine(j.Name);
                }

            }    
                        
        }
    }
}
