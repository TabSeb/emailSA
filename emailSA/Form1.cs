using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailSA
{
    public partial class ASEmail : Form
    {
        public ASEmail()
        {
            InitializeComponent();
            panel1.Hide();
            error.Hide();
        }


        private void ingresar_Click(object sender, EventArgs e)
        {
            
            usuario.contra = IngresarContraseña.Text;
            usuario.emailEmisor = IngresarCorreo.Text;
            try
            {
                usuario.ingresar();

                panel1.Show();
                error.Hide();
            }
            catch (Exception)
            {
                error.Show();
                //MessageBox.Show("Correo ingresado no valido" + auth.StackTrace);

            }



            // hacer la autenticacion gei con tu try catch
            //este se hace si la autenticacion fue valida
            //panel1.Show();
            //error.Hide();



            //si no es valido entonces muestra esto
            //error.Show();

        }

        private void cerrarBoton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            usuario.emailReceptor = ingresarCorreoRecep.Text;
            usuario.asunto = ingresarAsunto.Text;
            usuario.cuerpo = ingresarCuerpoText.Text;
            


            usuario.enviar();


            //insert an action o method , which to send the message TANTO TE GUSTA EL INGLES GEI
        }
    }
}
