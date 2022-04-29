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


        public override void GetTotal()
        {
            base.GetTotal();

            if (HowtoPay == "credit card") ;
            {

                CCNumbers();
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






            //else

            //    Console.WriteLine("Sorry that isn't a valid credit card number. Please input your card again.");
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
                string CCNums = Console.ReadLine();
                if (CCNums.Length == 16)
                {
                    int CCNumber = int.Parse(CCNums);
                    return true;
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

            static bool JustCVV()
            {
                Console.WriteLine("And what is the CVV number?");
                string CVVNumber = Console.ReadLine();
                if (CVVNumber.Length == 3)
                {
                    int CVV2 = int.Parse(CVVNumber);
                    return true;
                }
                else
                {
                    Console.WriteLine("I'm sorry. That CVV number doesn't seem to be accurate.");
                    GetUserInput("Please enter yes to re-enter the CVV or no to start over with a new card. ").ToLower();
                    if (true)
                    {
                        return JustCVV();
                    }
                    else
                    {
                        return CCNumbers();
                    }
                }
            }
             bool DateTimeVeri()
            {
                GetUserInput("What is the expiration date");
                Expiration = DateTime.Parse(Console.ReadLine());
                if(Expiration >= DateTime.Today)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


    }
