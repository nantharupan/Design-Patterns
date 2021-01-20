using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Builder.Email
{
    public class EmailBuilder
    {
        private string ToEmailAddress;
        private string Message;
        private string FromEamilAddress;
        private string Subject;
        public EmailBuilder(string ToEmailAddress)
        {
            this.ToEmailAddress = ToEmailAddress;
        }

        public EmailBuilder AddMessage(string message)
        {
            this.Message = message;
            return this;
        }

        public EmailBuilder AddFromEmail(string fromEmailAddress)
        {
            this.FromEamilAddress = fromEmailAddress;
            return this;
        }

        public EmailBuilder AddSubject(string subject)
        {
            this.Subject = subject;
            return this;
        }

        public void SendEmail()
        {
            Console.WriteLine(this.ToEmailAddress);
            Console.WriteLine(this.FromEamilAddress);
            Console.WriteLine(this.Message);
            Console.WriteLine(this.Subject);
        }


    }
}
