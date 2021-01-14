using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Simple_Factory.Email
{
    public static class EmailFactory
    {
        public static ISendEmail GetSendEmail(string senderName, string senderEmail)
        {
            return new SendEmailByDepartment(senderName, senderEmail);
        }
    }
}
