using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
     class CashPay : PaymentMethod
    {
        public double Cash { get; set; }
        public double Change { get; set; }

        public double GetTotal()
        {
            base.GetTotal();
            if(HowtoPay == "cash")
            {
                Console.WriteLine($"Your total was {Grandtotal}. How much cash will you be paying with?");
                Cash = double.Parse(Console.ReadLine());
                if (Cash > Grandtotal )
                {
                    Change =  Cash - Grandtotal;
                   
                }
               
            }
<<<<<<< Updated upstream
            return Change;
=======
            else
            {
                Console.WriteLine("I'm sorry that's not the correct amount. Please pay the full amount or select a different form of payment");
                Program.GetPayment();
            }

>>>>>>> Stashed changes
        }
    }
<<<<<<< Updated upstream
}
=======
>>>>>>> Stashed changes
