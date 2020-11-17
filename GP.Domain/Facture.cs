using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
   public class Facture
    {
        [Key, Column(Order = 0)]
        public DateTime DateAchat { get; set; }
        [Key, Column(Order = 1)]
        public int ProductFk { get; set; }
        [Key, Column(Order = 2)]
        public int ClientFk { get; set; }
        public int Prix { get; set; }
        //prop de navigation
        [ForeignKey("ClientFk")]
        public virtual Client Client { get; set; }
        [ForeignKey("ProductFk")]
        public virtual Product Produit { get; set; }
    }
}
