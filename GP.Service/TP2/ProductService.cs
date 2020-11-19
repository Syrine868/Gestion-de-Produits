using GP.Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service.TP2
{
    public class ProductService : Service<Product>, IProductService
    {

        ManageProduct m = new ManageProduct();
        public IEnumerable<Product> FindMost5ExpensiveProds()
        {

            /* var myquery = from p in GetMany()
                           orderby p.Price
                           descending
                           select p;
             return myquery.Take(5);*/
            return GetMany().OrderByDescending(p => p.Price).Take(5);

        }

        public IEnumerable<Product> GetProdsByClient(Client c)
        {
            FactureService fs = new FactureService();
            /* var q = from p in GetMany()
                     where p.Factures == fs.GetProdsByClient(c)
                     select p;*/
            var q = fs.GetMany(f => f.ClientFk == c.id)
                        .Select(f => f.Produit);
            return q;

        }

        public int UnavailableProductsPercentage()
        {
            /*var q = from p in GetMany() select p;
            var myquery = from p in GetMany()
                          where p.Quantity == 0
                          select p;
            return myquery.Count() /q.Count()* 100 ;
            */
            int q_t = GetMany().Count();
            int q_p=GetMany(p=>p.Quantity ==0).Count();
            return q_p / q_t * 100;

        }
        public void DeleteOldProducts()
        {
            var q = GetMany(p => (DateTime.Now - p.DateProd).TotalDays > 365);
            foreach (Product p in q)
            {
                Delete(p);
            }
        }
    }
}
