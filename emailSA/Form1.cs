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
            errorIngresar.Hide();
            pantalla2.Hide();
            pantalla3.Hide();
            
        }
        private void ingresarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                sistema.emailEmisor = insertarCorreoParaSistema.Text;
                sistema.contra = insertarContraseña.Text;
                sistema.ingresar();

                panelSistema.Hide();
                
            }
            catch (Exception)
            {
                errorIngresar.Show();

            }
        }
        private void cerrarBoton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        //Inicio de botones menu
        private void salirOp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void venderMenuOp_Click(object sender, EventArgs e)
        {
            pantalla2.Show();
            pantalla3.Hide();
            exitoCompra.Hide();
        }
        private void mailMenuOp_Click(object sender, EventArgs e)
        {
            pantalla2.Hide();
            pantalla3.Show();
            conExito.Hide();
        }

        // aca termina.
        private void comprarOp_Click(object sender, EventArgs e)
        {
            socio.nombre = insertarNombre.Text;
            socio.apellido = insertarApellido.Text;
            socio.esMayorDeEdad = esMayorOp.GetSelected(0);
            
            socio.pagoDescuento = (socio.FormasPagoDescuento)Enum.Parse(typeof(socio.FormasPagoDescuento), metodoPagoOp.Text);
            socio.costeEntrada = ((float)socio.pagoDescuento / 100f) * 2000f;
            //tarjeta de credito anda mal
            socio.datoSocio = $"{socio.nombre}{socio.apellido} - {socio.esMayorDeEdad} - {socio.pagoDescuento} - ${socio.costeEntrada} " ;
            //str.replace
            sistema.DatoSocios.Add(socio.datoSocio);
            exitoCompra.Show();
        }
        private void finalizarOp_Click(object sender, EventArgs e)
        {
            pantalla2.Hide();
        }
        private void enviarCorreo_Click(object sender, EventArgs e)
        {   
        }

        private void finalizarCorreo_Click(object sender, EventArgs e)
        {
            pantalla3.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pantalla3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enviarCorreo_Click_1(object sender, EventArgs e)
        {
            try
            {
                sistema.emailDestino = insertarCorreoReceptor.Text;

                sistema.enviar();
                conExito.Show();
            }
            catch (Exception)
            {
                //TODO: en el caso que salga mal
                
            }
            //INSERTA TU METODO FEO 
            //si sale bien mostra esto
        }
    }
}
