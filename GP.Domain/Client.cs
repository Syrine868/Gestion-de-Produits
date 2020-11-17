using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public DateTime DateNaissance { get; set; }

        public string Mail { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        public ICollection<Facture> Factures { get; set; }

       
    }
}
