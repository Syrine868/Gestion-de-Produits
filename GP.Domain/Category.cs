using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
   public class Category: Concept
    {
        public int categoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine("Category ID: " + categoryId + "Category Name " + Name );
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("Category");
        }
    }

}

