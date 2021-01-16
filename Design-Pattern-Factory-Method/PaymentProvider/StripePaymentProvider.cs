using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Factory_Method.PaymentProvider
{
    public class StripePaymentProvider : IPaymentProvider
    {
        public void DoPayment()
        {
            Console.WriteLine("Payment Through Stripe");
        }
    }
}
