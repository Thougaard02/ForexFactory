using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ForexFactory
{
    class MailSender
    {
        JSONReader reader = new JSONReader();
        public void Sendmail()
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("YourEmail", "YourPassword");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add("RecipientEmail");
                msgobj.From = new MailAddress("YourEmail");
                msgobj.Subject = "Forexfactory";
                msgobj.Body = reader.Output();
                client.Send(msgobj);
            }
        }
    }
}
