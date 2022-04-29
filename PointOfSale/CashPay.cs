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
        }
        }
    }

