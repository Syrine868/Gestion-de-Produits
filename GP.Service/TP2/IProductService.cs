using GP.Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service.TP2
{
   public interface IProductService :  IService<Product>
    {
        IEnumerable<Product> FindMost5ExpensiveProds();

        float UnavailableProductsPercentage();

        IEnumerable<Product> GetProdsByClient(Client c);

        void DeleteOldProducts();
    }
}
