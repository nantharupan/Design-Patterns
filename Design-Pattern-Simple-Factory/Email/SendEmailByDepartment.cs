using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Simple_Factory.Email
{
    public class SendEmailByDepartment : ISendEmail
    {
        private string SenderName { get; set; }
        private string SenderEmail { get; set; }

        public SendEmailByDepartment(string senderName, string senderEmail)
        {
            this.SenderEmail = senderEmail;
            this.SenderName = senderName;
        }

        public bool SendEmail()
        {
            Console.WriteLine("Email is send By" + SenderName + "from the email" + SenderEmail);
            return true;
        }
    }
}
