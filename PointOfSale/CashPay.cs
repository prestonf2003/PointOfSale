using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class CashPay : PaymentMethod
    {
        public CashPay(double subTotal, double salesTax, double grandTotal, string Payment) : base(subTotal, salesTax, grandTotal, Payment)
        {

        }

        public static double Cash { get; set; }
        public static double Change { get; set; }



    
        public override void GetTotal()
        {


            Console.WriteLine($"Your total was {Grandtotal}. How much cash will you be paying with?");
            Cash = double.Parse(Console.ReadLine());
            if (Cash > Grandtotal)
            {
                Change = Math.Round(Cash - Grandtotal, 2);
                Console.WriteLine($"Your change is {Change}");

            }

            else if (Cash == Grandtotal)
            {
                Console.WriteLine("Thanks for shopping with us! Have a great day!");
            }
            else
            {
                Console.WriteLine("I'm sorry that's not the correct amount. Please pay the full amount or select a different form of payment.");
                Program.GetPayment();

            }


            }

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Cash Recieved{Cash}");
            Console.WriteLine($"Cash Returned {Change}");
        }
    }

}

    }


