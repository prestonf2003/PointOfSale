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
            return Change;
        }
    }
}
