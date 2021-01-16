using Design_Pattern_Factory_Method.SaleDepartment;
using Design_Pattern_Factory_Method.WholeSaleDepartment;
using System;

namespace Design_Pattern_Factory_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wholeSaleDepartmentPaymentManager = new WholeSalePaymentManager();
            wholeSaleDepartmentPaymentManager.DoPayment();

            var saleDepartmentPaymentManager = new SalePaymentManager();
            saleDepartmentPaymentManager.DoPayment();

        }
    }
}
