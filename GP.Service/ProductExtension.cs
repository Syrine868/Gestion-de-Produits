using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this ManageProduct mp, Product p ) 
        {
            p.Name = p.Name.ToUpper();
        }

        public static bool inCategory(this ManageProduct mp , Category c , Product p)
        {
            return p.Category.Equals(c);
        }
    }
}
