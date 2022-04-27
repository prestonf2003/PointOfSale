using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
     class Product
    {
        public enum Category
        {
            Produce,
            Dairy, 
            Snacks,
            Bread
        }
        string name { get; set; }
        Category category { get; set; }  
        string description { get; set; }
        double price {  get; set; }
        
        
        public Product(string name, Category category, string description, double price)
        {
            this.name = name; 
            this.category = category;
            this.description = description;
            this.price = price;
            
        }
    }
  
}
