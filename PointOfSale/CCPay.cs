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

            if (HowtoPay == "credit card");
            {
                Console.WriteLine("Please enter your credit card number.");
                CCNumber = int.Parse(Console.ReadLine()); //Need to validate this is 16 digits long

                Console.WriteLine("And what is the expiration date?");
                Expiration = DateTime.Parse(Console.ReadLine()); // Need to validate this is a future date?

                Console.WriteLine("And what is the CVV number?");
                CVV = int.Parse(Console.ReadLine()); //Need to validate that this is 3 digits.
            }
        }

    }
}
