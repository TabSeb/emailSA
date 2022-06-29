﻿using System;
using System.Collections;
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

        /// <summarys>
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
    static class sistema 
    {
        static SmtpClient smtp = new SmtpClient();
        static public string emailDestino;
        public static string cuerpo;

        static public string nombreEmisor;

        static public string emailEmisor;

        static public string contra;
        static public bool fueIngresado = false;
        static public ArrayList DatoSocios = new ArrayList();

        public static void ingresar()
        {
            if (fueIngresado == true)
            {
                smtp.Authenticate(emailEmisor, contra);

            }
            else
            {
                fueIngresado = true;
                smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(emailEmisor, contra);
            }

        }
        public static void enviar()
        {

            
            MimeMessage email = new MimeMessage();
            email.From.Add(new MailboxAddress(sistema.nombreEmisor , sistema.emailEmisor));
            email.To.Add(new MailboxAddress("destino", sistema.emailDestino));
            email.Subject = "entradas vendidas";

            foreach (string c in DatoSocios)
            {
                cuerpo = $"{cuerpo}<p> {c} <br>";
            }

            
            
            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = string.Format(@cuerpo);

            email.Body = builder.ToMessageBody();
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }

    static class socio
    {
        static public string nombre;
        static public string apellido;
        static public bool esMayorDeEdad;
        static public FormasPagoDescuento pagoDescuento;
        static public float costeEntrada;
        static public string datoSocio;

        public enum FormasPagoDescuento
        {
            Efectivo = 50,
            MercadoPago = 25,
            TarjetaCredito = 0,
        }


    }
}