using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Mail;

namespace ForexFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONReader reader = new JSONReader();
            Console.WriteLine(reader.Output());
            MailSender mail = new MailSender();
            mail.Sendmail();
        }
    }
}
