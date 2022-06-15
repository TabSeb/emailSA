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
            exitoMensaje.Hide();
            errorCorreo.Hide();
        }


        private void ingresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                usuario.emailEmisor = IngresarCorreo.Text;
                usuario.contra = IngresarContraseña.Text;
                usuario.ingresar();

                panel1.Show();
                error.Hide();
            }
            catch (Exception)
            {
                error.Show();
            }
        }

        private void cerrarBoton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.emailReceptor = ingresarCorreoRecep.Text;
                usuario.asunto = ingresarAsunto.Text;
                usuario.cuerpo = ingresarCuerpoText.Text;
                usuario.enviar();
                exitoMensaje.Show();

            }
            catch (Exception)
            {
                errorCorreo.Show();
            }
            
        }
    }
}
