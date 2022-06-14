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

        static public string nombreEmisor;

        static public string emailEmisor;

        static public string contra;
        static public string emailReceptor;
        static public string asunto, cuerpo;



        public static void ingresar()
        {
            smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(emailEmisor, contra);
        }
        public static void enviar()
        {

            MimeMessage email = new MimeMessage();
            email.From.Add(new MailboxAddress(nombreEmisor, emailEmisor));
            email.To.Add(new MailboxAddress("email", emailReceptor));
            email.Subject = asunto;
            BodyBuilder builder = new BodyBuilder();
            builder.TextBody = @cuerpo;


            email.Body = builder.ToMessageBody();

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}