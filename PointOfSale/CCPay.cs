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

            if (HowtoPay == "credit card") ;
            {

               return CCNumbers();
                
            }
        }

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

                else
                {
                    Console.WriteLine("Sorry that isn't a valid credit card number. Please input your card again.");
                    return CCNumbers();
                }
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
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't catch that. Please enter 'yes' or 'no'.");
                            return StartOver();
                }
            }

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
            {
                Console.WriteLine("I'm sorry I didn't understand that");
            }
            }
            public bool DateTimeVeri()
            {
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
        }


    }
