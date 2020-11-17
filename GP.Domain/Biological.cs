using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
   public class Biological: Product
    {
        public String Herbs { get; set; }
        public virtual void GetMyType()
        {
            Console.WriteLine("Biological");
        }
    }
}
