using Design_Pattern_Builder.Email;
using System;

namespace Design_Pattern_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailBuilder("to@emai.com")
                .AddFromEmail("from@email.com")
                .AddMessage("Test Messag")
                .AddSubject("Test Subject");
            email.SendEmail();

            email = new EmailBuilder("to@emai.com")
            .AddFromEmail("from@email.com")
            
            .AddSubject("Test Subject");
            email.SendEmail();

        }
    }
}
