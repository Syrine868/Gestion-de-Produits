using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
   public class Chemical: Product
    {
        //public string City { get; set; }
        public string LabName { get; set; }
        //public string StreetAddress { get; set; }

        public Adresse Adresse { get; set; }
        public virtual void GetMyType()
        {
            Console.WriteLine("Chemical");
        }
    }
}
