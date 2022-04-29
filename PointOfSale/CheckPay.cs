using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
     class CheckPay : PaymentMethod
    {
        public CheckPay(double subTotal, double salesTax, double grandTotal, string Payment) : base(subTotal, salesTax, grandTotal, Payment)
        {
        }

        public int CheckNum { get; set; }

        public override void GetTotal()
        {
            base.GetTotal();

            
            
                Console.WriteLine("Please enter the check amount.");
                
                CheckNum = int.Parse(Console.ReadLine());
                if(CheckNum == Grandtotal)
                {
                    Console.WriteLine("Alright Thank you");
                }
                else
                {
                    Console.WriteLine("Sorry we cannot accept this check please input another form of payment");
                     Program.GetPayment();
                }
            }
        }
    }

