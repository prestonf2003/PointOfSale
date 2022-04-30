using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class CheckPay : PaymentMethod
    {
        public int CheckNum { get; set; }

        public override double GetTotal()
        {
            base.GetTotal();

<<<<<<< Updated upstream
            if(HowtoPay == "check")
            {
                Console.WriteLine("Please enter the check number.");
                
                CheckNum = int.Parse(Console.ReadLine());
            }
=======


            Console.WriteLine("Please enter the check number.");

            CheckNum = (Console.ReadLine());
            if (CheckNum.Length == 4)
            {
                Console.WriteLine("Alright Thank you");
            }
            else
            {
                Console.WriteLine("Sorry we cannot accept this check. Please input another form of payment, or write a new one.");
                Program.GetPayment();
            }

        }
        public void PrintInfo()
        {
            Console.WriteLine(CheckNum);
>>>>>>> Stashed changes
        }
    }
}
