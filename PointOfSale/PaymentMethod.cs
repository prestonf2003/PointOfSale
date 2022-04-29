using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public abstract class PaymentMethod
    {
        public double Subtotal { get; set; }
        public double SalesTax { get; set; }
        public double Grandtotal { get; set; }
        public string HowtoPay { get; set; }

        public virtual void GetTotal()
        {
            SalesTax = Subtotal * 0.06;
            Grandtotal = Subtotal + SalesTax;
            
        }
        
    }
}
