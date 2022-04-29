

using System.Collections.Generic;


namespace PointOfSale
{
    public class Program
    {


        public static List<double> subtotal = new List<double>();

       

        public static List<string> Cart = new List<string>();
        public static List<double> Sale = new List<double>();
        public static List<double> Quantities = new List<double>();
        public static double grandTotal;
        public static double salesTax;
        
        


        public static void Main()
        {


            Product bagOfOranges = new Product("Bag Of Oranges", "produce", "8 pound bag of oranges", 6.99);

            Product bagOfLimes = new Product("Bag of Limes", "produce", "1 pound bag of key limes", 3.99);
            Product bagOfSpinach = new Product("Bag of Spinach", "produce", "10 ounce bag of spinach", 2.18);

            Product PopcornBag = new Product("Microwave Popcorn", "snacks", "Cousin WIllies Butter Explosion 3 pack microwave popcorn", 2.29);
            Product BagOfPretzels = new Product("Bag of Pretzels", "snacks", "Bag of dots original seasonzed pretzels 16 ounces", 5.99);
            Product Cheezits = new Product("Box of Cheez-Its", "snacks", "21 0unce family size box of original cheez its", 4.54);

            Product WhiteBread = new Product("Loaf of white bread", "bread", "1 loaf of sunbeam white bread", 2.08);
            Product SourDough = new Product("Loaf of sourdough bread", "bread", "1 loaf of Brownberry Sourdough bread", 3.18);
            Product HotDogBuns = new Product("Pack of Hot Dog buns", "bread", "8 count ball park white hot dog buns", 2.58);

            Product GallonOfMilk = new Product("Gallon of 2% Milk", "dairy", "Gallon of fairlife 2% milk", 3.98);
            Product PackOfYogurt = new Product("Yoplait Yogurt", "dairy", "8 pack of Yoplait Strawberry and Banana Yogurt", 4.36);
            Product CoffeeCreamer = new Product("Carmel Macchiato Creamer", "dairy", "32 ounce container of Internation delight coffee creamer", 3.24);


            List<Product> bread = new List<Product>();
            bread.Add(WhiteBread);
            bread.Add(SourDough);
            bread.Add(HotDogBuns);

            List<Product> dairy = new List<Product>();
            dairy.Add(CoffeeCreamer);
            dairy.Add(GallonOfMilk);
            dairy.Add(PackOfYogurt);

            List<Product> produce = new List<Product>();
            produce.Add(bagOfLimes);
            produce.Add(bagOfOranges);
            produce.Add(bagOfSpinach);

            List<Product> snacks = new List<Product>();
            snacks.Add(PopcornBag);
            snacks.Add(BagOfPretzels);
            snacks.Add(Cheezits);



            bool goAgain = true;
            Menu:
            while (goAgain)
            {

                string input = GetUserInput("Which aisle would you like to shop in? Bread, Dairy, Produce, or Snacks?").ToLower().Trim();
                switch (input)
                {
                    case "bread":
                        {
                           SelectProduct(bread);
                        }
                        break;
                    case "dairy":
                        {
                            SelectProduct(dairy);
                        }
                        break;
                    case "produce":
                        {
                            SelectProduct(produce);
                        }
                        break;
                    case "snacks":
                        {
                            SelectProduct(snacks);
                        }
                        break;
                     default:
                        Console.WriteLine("That is not an acceptable Product please select again");
                        goto Menu;
                        break;

                }
 
                goAgain = AddMore();

            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }


        static bool AddMore()
        {

            double sum = subtotal.Sum();

            Console.WriteLine();
            Console.WriteLine($"Your subtotal is: ${sum}");


            string answer = GetUserInput("Would you like to add more items to your cart? Please enter y/n").ToLower();

            if (answer == "y" || answer == "yes")
                return true;
            else if (answer == "n" || answer == "no")
            {
                PrintCart();
                GetPayment();
                Console.WriteLine("Thank you for shopping at Prethanials please come again");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that response. Please enter y or n");
                return AddMore();


            }

        }

        public static void PrintRecipt()
        {
            for (int i = 0; i < Cart.Count; i++)
            {
                
                double round = Math.Round(Sale[i], 2);
                 salesTax = Math.Round(subtotal.Sum() * .06, 2);
                 grandTotal = Math.Round(salesTax + subtotal.Sum(), 2);
                Console.WriteLine();
                foreach (string product in Cart)
                {
                    Console.WriteLine($"{Cart[i]} x{Quantities[i]}  ${Math.Round(Sale[i], 2)}");
                    i++;
                }
                Console.WriteLine($"SubTotal ${subtotal.Sum()}");
               
                Console.WriteLine($"Grand Total${grandTotal}");
                Console.WriteLine();
                

            }
        }
        public static void GetPayment()
        {
            string payment = GetUserInput("How would you like to pay").Trim().ToLower();

            switch (payment)
            {
                case "check":
                    {
                        CheckPay check = new CheckPay(subtotal.Sum(), 0.06, grandTotal, payment);
                        check.GetTotal();
                        check.PrintInfo();
                        PrintRecipt();
                    }
                    break;
                case "credit":
                    {
                        CCPay Card = new CCPay(subtotal.Sum(), 0.06, grandTotal, payment);

                        Card.GetTotal();
                        Card.PrintInfo();
                        PrintRecipt();
                    }
                    break;
                case "cash":
                    {
                        CashPay cash = new CashPay(subtotal.Sum(), 0.06, grandTotal, payment);
                        cash.GetTotal();

                        cash.PrintInfo();
                        PrintRecipt();
                    }
                    break;
                default:
                    {

                        Console.WriteLine("You didnt enter a payment Method");
                        GetPayment();
                    }
                    break;
            }

        }
       static void SelectProduct(List<Product> productList)
        {
            start:
            for (int i = 0; i < productList.Count; i++)
            {
                Product p = productList[i];
                Console.WriteLine((i + 1) + " " + p.name + " " + "$" + p.price);
            }
            Console.WriteLine();
            int ChooseItem = int.Parse(GetUserInput("Which Item would you like"));
            if(ChooseItem < 0 || ChooseItem > productList.Count)
            {
                Console.WriteLine("That was not a valid number please try again");
                goto start;
            }
                Product Chosen = productList[ChooseItem - 1];
            
                
              
            int QuantityWanted = int.Parse(GetUserInput("How Many"));
            double price = Chosen.price * QuantityWanted;
            subtotal.Add(price);
            Quantities.Add(QuantityWanted);
            Cart.Add(Chosen.name);
            Sale.Add(price);

        }
        static void PrintCart()
        {
            salesTax = Math.Round(subtotal.Sum() * .06, 2);
            grandTotal = Math.Round(salesTax +subtotal.Sum(), 2);
            Console.WriteLine();
            Console.WriteLine($"SubTotal ${subtotal.Sum()}");

            Console.WriteLine($"Sales tax ${salesTax}");
            Console.WriteLine($"Grand Total${grandTotal}");
            Console.WriteLine();
            
        }

    }
}
