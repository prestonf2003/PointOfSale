
using System;

namespace PointOfSale
{
    public class Program
    {
        
        public static void Main()
        {
            Product bagOfOranges = new Product("Bag Of Oranges", "Produce", "8 pound bag of oranges", 6.99);
            Product bagOfLimes = new Product("Bag of Limes", "Produce", "1 pound bag of key limes", 3.99);
            Product bagOfSpinach = new Product("Bag of Spinach", "Produce", "10 ounce bag of spinach", 2.18);
            
            Product PopcornBag = new Product("Microwave Popcorn", "Snacks", "Cousin WIllies Butter Explosion 3 pack microwave popcorn", 2.29);
            Product BagOfPretzels = new Product("Bag of Pretzels", "Snacks", "Bag of dots original seasonzed pretzels 16 ounces", 5.99);
            Product Cheezits = new Product("Box of Cheez-Its", "Snacks", "21 0unce family size box of original cheez its", 4.54);

            Product WhiteBread = new Product("Loaf of white bread", "Bread", "1 loaf of sunbeam white bread", 2.08);
            Product SourDough = new Product("Loaf of sourdough bread", "Bread", "1 loaf of Brownberry Sourdough bread", 3.18);
            Product HotDogBuns = new Product("Pack of Hot Dog buns", "Bread", "8 count ball park white hot dog buns", 2.58);

            Product GallonOfMilk = new Product("Gallon of 2% Milk", "dairy", "Gallon of fairlife 2% milk", 3.98);
            Product PackOfYogurt = new Product("Yoplait Yogurt", "dairy", "8 pack of Yoplait Strawberry and Banana Yogurt", 4.36);
            Product CoffeeCreamer = new Product("Carmel Macchiato Creamer", "dairy", "32 ounce container of Internation delight coffee creamer", 3.24);

            List<Product> Products = new List<Product>();
          
            Products.Add(WhiteBread);
            Products.Add(SourDough);
            Products.Add(HotDogBuns);
         

            List<Product> dairy = new List<Product>();
            dairy.Add(CoffeeCreamer);
                dairy.Add(GallonOfMilk);
                dairy.Add(PackOfYogurt);

            List<Product> produce = new List<Product>();
            produce.Add(bagOfLimes);
            produce.Add(bagOfOranges);
            produce.Add(bagOfSpinach);
            string input = GetUserInput("Choose a category").ToLower().Trim();
            if(input == "produce")
            {
                for(int i = 0; i < produce.Count; i++)
                {
                    Product p = produce[i];
                    Console.WriteLine(i + " " + p.name);
                }

            }
            if (input == "dairy")
            {
                for (int i = 0; i < dairy.Count; i++)
                {
                    Product p = dairy[i];
                    Console.WriteLine(i + " " + p.name);
                }

            }
            if (input == "bread")
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    Product p = Products[i];
                    Console.WriteLine(i + " " + p.name);
                }

            }

        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }  
        
  
    }
}