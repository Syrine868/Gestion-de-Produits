using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public  class Product: Concept
    {

        public List<Client> Clients { get; set; }
        public string Image { get; set; }

        [DisplayName("Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd  {get ; set;}

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        
        [MaxLength(25, ErrorMessage ="max length 25")]
        [StringLength(25, ErrorMessage = "string input length 25")]
        [Required(ErrorMessage ="Required Field")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        [Key]
        public int idProduct { get; set; }

        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public List <Provider> Providers { get; set; } 
            public override void GetDetails()
        {
            Console.WriteLine("Product ID: "+idProduct+"Product Name "+Name+"Product description "+Description+"Price "+Price+ "Quantity "+Quantity);    
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("Unknown");
        }
        public virtual ICollection<Facture> Factures { get; set; }

    }
}
