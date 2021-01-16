using Design_Pattern_Factory_Method.PaymentManagers;
using Design_Pattern_Factory_Method.PaymentProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Factory_Method.WholeSaleDepartment
{
    class WholeSalePaymentManager : PaymentManager
    {
        protected override IPaymentProvider CreatePaymentProvider()
        {
            return new PaypalPaymentProvider();
        }
    }
}
