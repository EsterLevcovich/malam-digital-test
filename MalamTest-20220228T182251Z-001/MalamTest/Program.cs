
using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MalamTest
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Receiver email address \t ");
            string emailAddress = Console.ReadLine();
            while(!MailService.EmailAddressValidTest(emailAddress))
            {
                Console.WriteLine("The email address is not valid!");
                Console.Write("Receiver email address \t ");
                emailAddress = Console.ReadLine();
            }

            Console.Write("email subject \t ");
            string emailSubject = Console.ReadLine();
            while (!MailService.EmailSubjectValidTest(emailSubject))
            {
                Console.WriteLine("The email subject is not valid!");
                Console.Write("email subject \t ");
                emailSubject = Console.ReadLine();
            }

            Console.Write("email body \t ");
            string emailBody = Console.ReadLine();
            while (!MailService.EmailBodyValidTest(emailBody))
            {
                Console.WriteLine("The email body is not valid!");
                Console.Write("email body \t ");
                emailBody = Console.ReadLine();
            }

            bool b=MailService.SendEmail(emailAddress, emailSubject, emailBody);
            if (!b)
            {
                Console.WriteLine("Sending filed to \t {emailAddress}  \t ");
            }
            else
            {
                Console.WriteLine("\n An email was successfully sent to "+ emailAddress + ", with subject "+emailSubject+" AssemblyLoadEventHandler body "+emailBody+" \n");
                Console.WriteLine("process finished by exit code 0");
            }
            Console.ReadLine();


        }
    }
}
