using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class CCPay : PaymentMethod
    {
        public CCPay(double subTotal, double salesTax, double grandTotal, string Payment) : base(subTotal, salesTax, grandTotal, Payment)
        {
        }

        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }

        public int CVV { get; set; }
        public static string CCNums { get; set; }
        public static string CVVNums { get; set; }
        public static string exp { get; set; }


        public override void GetTotal()
        {
            base.GetTotal();

            if (CCNumbers() == true && JustCVV() == true && ExpDateCheck() == true)
            {

              
                Console.WriteLine("That Info is correct have a good day");
            }
            else
            {
                Program.GetPayment();
            }


            //if (CCNumber.Length == 16)

            //    int CCNumber2 = int.Parse(CCNumber);


            //Console.WriteLine("And what is the expiration date?");
            //public DateTime Expiration = DateTime.Parse(Console.ReadLine());


            //if (Expiration >= DateTime.Today)

            //    Console.WriteLine("And what is the CVV number?");
            //    string CVVNumber = Console.ReadLine();
            //    if (CVVNumber.Length == 3)

            //        int CVV2 = int.Parse(CVVNumber);

            //    else

            //        Console.WriteLine("I'm sorry. That CVV number doesn't seem to be accurate.");
            //        Console.WriteLine("Would you like to start over with a new card or enter your CVV number again?");
            //        GetUserInput("Please type 1 to start over, or 2 to enter your CVV again");



            //else

            //    Console.WriteLine("It looks like your card is expired. Please use another card.");



                Console.WriteLine("That Info is correct have a good day");
            }
            else
            {
                Program.GetPayment();
            }
                                   
        }
        public void PrintInfo()
        {
            Console.WriteLine(CCNums);
            Console.WriteLine(CVVNums);
            Console.WriteLine(exp);
        }

        static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }


        static bool CCNumbers()
        {
            Console.WriteLine("Please enter your credit card number.");
            CCNums = Console.ReadLine();
            if (CCNums.Length == 16)
            {

                return true;
            }

            else
            {
                Console.WriteLine("Sorry that isn't a valid credit card number. Please input your card again.");
                return CCNumbers();
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(CCNums);
            Console.WriteLine(CVVNums);
            Console.WriteLine(exp);
        }

        static bool StartOver()
        {
            string input = GetUserInput("Would you like to start over?").ToLower();
            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {

                return false;

                Console.WriteLine("Please enter your credit card number.");
                    CCNums = Console.ReadLine();
                if (CCNums.Length == 16)
                {
                    
                    return true;
                }

                else
                {
                    Console.WriteLine("Sorry that isn't a valid credit card number. Please input your card again.");
                    return CCNumbers();
                }

            }
            else
            {
                Console.WriteLine("I'm sorry I didn't catch that. Please enter 'yes' or 'no'.");
                return StartOver();
            }
        }

        static bool JustCVV()
        {
            Console.WriteLine("And what is the CVV number?");
            string CVVNums = Console.ReadLine();
            if (CVVNums.Length == 3)
            {

                int CVV2 = int.Parse(CVVNums);
                return true;
            }
            else
            {
                Console.WriteLine("I'm sorry. That CVV number doesn't seem to be accurate.");
                string repeat = GetUserInput("Please enter yes to re-enter the CVV or no to start over with a new card. ").ToLower();
                if (repeat.Contains("y"))

                Console.WriteLine("And what is the CVV number?");
                string CVVNums = Console.ReadLine();
                if (CVVNums.Length == 3)
                {
                    int CVV2 = int.Parse(CVVNums);
                    return true;
                }
                else

                {
                    return JustCVV();
                }
                else
                {
                    return false;
                    return CCNumbers();
                }
            }
        }
        bool ExpDateCheck()
        {
            int m = DateTime.Today.Month;
            int y = DateTime.Today.Year;
            int expm = int.Parse(GetUserInput("Please enter in you month in single digit or double digit if greater than 9"));
            int expy = int.Parse(GetUserInput("Please enter the year of expiration in 4 digits"));
            if (expy > y)
            {
                return true;
            }
            else if (expy == y && expm >= m)
            {
                return true;
            }
            else
            {
                Console.WriteLine("It looks like this card is expired. Please choose a different card or select a different form of payment.");
                return false;
            }

            exp = expm + "-" + expy;

             exp = expm + "-" + expy;
        }
            

        }

    }


}