using Design_Pattern_Simple_Factory.Email;
using System;

namespace Design_Pattern_Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var sendEmail = EmailFactory.GetSendEmail("IT Department", "it@nantharupan.com");
            sendEmail.SendEmail();
            Console.ReadLine();
        }
    }
}
