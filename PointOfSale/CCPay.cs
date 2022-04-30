using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class CCPay : PaymentMethod
    {
        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }

        public int CVV { get; set; }


        public override double GetTotal()
        {
            base.GetTotal();

<<<<<<< Updated upstream
            if (HowtoPay == "credit card") ;
            {
=======
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




>>>>>>> Stashed changes

               return CCNumbers();
                
            }
        }

<<<<<<< Updated upstream
           public static string GetUserInput(string prompt)
            {
                Console.WriteLine(prompt);
                string output = Console.ReadLine();
                return output;
            }


            static double CCNumbers()
            {
                Console.WriteLine("Please enter your credit card number.");
                string CCNums = Console.ReadLine();
                if (CCNums.Length == 16)
                {
                    double CCNumber = double.Parse(CCNums);
                return CCNumber;
                }
=======
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
>>>>>>> Stashed changes

                return true;
            }

            else
            {
                Console.WriteLine("Sorry that isn't a valid credit card number. Please input your card again.");
                return CCNumbers();
            }
        }

<<<<<<< Updated upstream
            static int JustCVV()
            {
                Console.WriteLine("And what is the CVV number?");
                string CVVNumber = Console.ReadLine();
                if (CVVNumber.Length == 3)
                {
                    int CVV2 = int.Parse(CVVNumber);
                    return CVV2;
                }
                else
                {
                    Console.WriteLine("I'm sorry. That CVV number doesn't seem to be accurate.");
                   string option = GetUserInput("Please enter yes to re-enter the CVV or no to start over with a new card. ").ToLower();
                if (option == "yes" || option == "y") ;
                    {
                        return JustCVV();
                    }
                    else if (option == "n" || option == "no")
                    {
                        return CCNumbers();
                    }
                }
                else
=======
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
                string repeat = GetUserInput("Please enter yes to re-enter the CVV or no to start over with a new form of payment. ").ToLower();
                if (repeat.Contains("y"))
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
>>>>>>> Stashed changes
            {
                Console.WriteLine("I'm sorry I didn't understand that");
            }
<<<<<<< Updated upstream
=======
            else if (expy == y && expm >= m)
            {
                return true;
>>>>>>> Stashed changes
            }
            public bool DateTimeVeri()
            {
<<<<<<< Updated upstream
                GetUserInput("What is the expiration date");
                Expiration = DateTime.Parse(Console.ReadLine());
                if(Expiration >= DateTime.Today)
                {
                    return true;
                }
                else
                {
                Console.WriteLine("Sorry that is not a valid date.");
                    return false;
                }

            }
=======
                Console.WriteLine("That seems to be expired. Please find another card or form of payment. ");
                return false;
            }
            exp = expm + "-" + expy;
>>>>>>> Stashed changes
        }

    }


}