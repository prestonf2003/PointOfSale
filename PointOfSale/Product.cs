using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
     class Product
    {
     
      public  string name { get; set; }
      public  string category { get; set; }  
      public  string description { get; set; }
      public  double price {  get; set; }
      


        public Product(string name, string category, string description, double price)
        {
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            

        }
        public  void PrintInfo()
        {
            Console.WriteLine(category);
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine(price);
            Console.WriteLine();


        }


    }
  
}
