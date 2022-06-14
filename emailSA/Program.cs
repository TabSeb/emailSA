using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mime;
using MailKit.Security;

namespace emailSA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ASEmail());
        }

    }

    static class usuario
    {
        static SmtpClient smtp = new SmtpClient();

        static private string _nombreEmisor;
        static public string NombreEmisor { get; set; }

        static private string _emailEmisor;
        static public string EmailEmisor { get; set; }

        static private string _contra;
        static public string Contra { get; set; }

        static string _emailReceptor;
        static string NombreReceptor { get; set; }
        static public string EmailReceptor { get; set; }
        static string _nombreReceptor;




        public static void ingresar()
        {
            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(EmailEmisor, Contra);
        }
        public static void enviar()
        {


            MimeMessage email = new MimeMessage();
            email.From.Add(new MailboxAddress(NombreEmisor, EmailEmisor));
            email.To.Add(new MailboxAddress(NombreReceptor, EmailReceptor));
            email.Subject = "Prueba";
            BodyBuilder builder = new BodyBuilder();
            builder.TextBody = @"A";


            email.Body = builder.ToMessageBody();

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}