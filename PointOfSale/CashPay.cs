using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
     class CashPay : PaymentMethod
    {
        public CashPay(double subTotal,  double salesTax, double grandTotal, string Payment) : base( subTotal,   salesTax,  grandTotal,  Payment)
        {
            
        }

        public double Cash { get; set; }
        public double Change { get; set; }



        public override void GetTotal()
        {
            

            Console.WriteLine($"Your total was {Grandtotal}. How much cash will you be paying with?");
            Cash = double.Parse(Console.ReadLine());
            if (Cash > Grandtotal)
            {
                Change = Cash - Grandtotal;
                Console.WriteLine($"Your change is {Math.Round(Change, 2)}");
            }
            else if (Cash == Grandtotal)
            {
                Console.WriteLine("Thanks for shopping with us! Have a great day!");
            }
            else
            {
                Console.WriteLine("I'm sorry that's not the correct amount. Please pay the full amount");
                GetTotal();
            }
        }
        }
    }

