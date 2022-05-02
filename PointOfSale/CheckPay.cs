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

        public static string CheckNum { get; set; }

        public override void GetTotal()
        {
            base.GetTotal();

            
            
                Console.WriteLine("Please enter the check number.");
                
                CheckNum = (Console.ReadLine());
                if(CheckNum.Length == 4 )
                {
                    Console.WriteLine("Alright Thank you");
                }
                else
                {
                    Console.WriteLine("Sorry we cannot accept this check please input another form of payment");
                     Program.GetPayment();
                }

            }
        public void PrintInfo()
        {
            Console.WriteLine(CheckNum);
        }
        }
    }

