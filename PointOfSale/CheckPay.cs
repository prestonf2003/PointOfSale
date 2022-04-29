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

            if(HowtoPay == "check")
            {
                Console.WriteLine("Please enter the check number.");
                
                CheckNum = int.Parse(Console.ReadLine());
            }
        }
    }
}
