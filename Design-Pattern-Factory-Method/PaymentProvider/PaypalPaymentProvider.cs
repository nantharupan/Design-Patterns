using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Factory_Method.PaymentProvider
{
    public class PaypalPaymentProvider : IPaymentProvider
    {
        public void DoPayment()
        {
            Console.WriteLine("Payment Through Paypal");
        }
    }
}
