using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider: Concept
    {

        public Provider()
        {

        }

        public Provider( string confirmPassword, DateTime dateCreated, string email, int id, bool isApproved, string password,  string username, List<Product> products)
        {
            ConfirmPassword = confirmPassword;
            DateCreated = dateCreated;
            Email = email;
            Id = id;
            IsApproved = isApproved;
            Password = password;
            Username = username;
            Products = products;
        }

        private string confirmpwd;

        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved {get; set;}

        private string password;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Compare("Password")]
        public string Password {
            get { return password;  } 
            set {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else 
                    Console.WriteLine("Erreur");
            }
        }



        public string Username { get; set; }

        public List<Product> Products { get; set; }


        public override void GetDetails()
        {
            Console.WriteLine(" Password: " + ConfirmPassword + " ,Date created: " + DateCreated + " ,Email :" + Email + "Id "+Id+ " ,Is Approved: "+IsApproved+ " ,Username: "+Username);
            if (Products != null)
            {
                foreach (Product p in Products)
                {
                    Console.WriteLine("***************** DETAILS PRODUCTS *******************");
                    p.GetDetails();
                }
            }
        }
      /*  public bool Login (string username, string pwd)
        {
            return string.Compare(username,username) == 0 && string.Compare(Password,pwd) == 0;
        }

        /*  public bool Login(string username, string pwd,string email)
          {
              return string.Compare(username, username) == 0 && string.Compare(Password, pwd) == 0 && string.Compare(Email,email) == 0;
          }

        public bool Login(string username, string pwd, string email)
        {
            if (email != null)
            {
                return string.Compare(Username, username) == 0 && string.Compare(Password, pwd) == 0 && string.Compare(Email, email) == 0;

            }
            else
            {
                return string.Compare(Username, username) == 0 && string.Compare(Password, pwd) == 0;

            }
        }*/

        public bool Login(string username, string pwd, string email=null)
        {
            return string.Compare(Username, username) == 0 
                   && string.Compare(Password, pwd) == 0 
                   && email != null ? string.Compare(Email, email) == 0 : true ;
        }

        public void GetProducts(string filterValue, string filterType)
        {
            if (Products != null)
            {
                switch (filterType)
                {
                    case "DateProd": foreach(Product p in Products)
                        {
                            if (DateTime.Equals(p.DateProd, DateTime.Parse(filterValue)))
                            {
                                Console.WriteLine("Results of filter FOR Date Prod");
                                p.GetDetails();
                            }
                        }
                        break;
                    case "Name":
                        foreach (Product p in Products)
                        {
                            if (string.Equals(p.Name, filterValue))
                            {
                                Console.WriteLine("Results of filter FOR Name");
                                p.GetDetails();
                            }
                        }
                        break;
                        
                    case "Description":
                        foreach (Product p in Products)
                        {
                            if (string.Equals(p.Description,filterValue))
                            {
                                Console.WriteLine("Results of filter FOR Description");
                                p.GetDetails();
                            }
                        }
                        break;
                    case "Price":
                        foreach (Product p in Products)
                        {
                            if (p.Price == double.Parse(filterValue))
                            {
                                Console.WriteLine("Results of filter FOR Price");
                                p.GetDetails();
                            }
                        }
                        break;
                    case "Quantity":
                        foreach (Product p in Products)
                        {
                            if (p.Quantity == int.Parse(filterValue))
                            {
                                Console.WriteLine("Results of filter FOR Quantity");
                                p.GetDetails();
                            }
                        }
                        break;
                    case "idProduct":
                        foreach (Product p in Products)
                        {
                            if (p.idProduct == int.Parse(filterValue))
                            {
                                Console.WriteLine("Results of filter FOR Produit ID");
                                p.GetDetails();
                            }
                        }
                        break;
                }
            }
        }
        public override string ToString()
        {
            return "Username : "+Username + " ,Password : "+Password+ ", Confirm Password : "+confirmpwd;
        }
        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = string.Compare(p.Password, p.ConfirmPassword) == 0;
        }   
        public static void SetIsApproved(string password , string confirmpwd, bool isApproved)
        {
            isApproved = string.Compare(password, confirmpwd) == 0;
        }

        public static void Mdp(string pass, string confirm)
        {
            if (string.Equals(pass, confirm))
            {
                Console.WriteLine("Mdp identique");
            }
            else
            {
                Console.WriteLine("Non Identique");
            }
        }
    }


}
