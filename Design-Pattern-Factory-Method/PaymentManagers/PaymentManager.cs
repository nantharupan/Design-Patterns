using Design_Pattern_Factory_Method.PaymentProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Factory_Method.PaymentManagers
{
    abstract class PaymentManager
    {
        abstract protected IPaymentProvider CreatePaymentProvider();

        public void DoPayment()
        {
            var paymentProvider = this.CreatePaymentProvider();
            paymentProvider.DoPayment();
        }
    }
}
