
namespace emailSA
{
    partial class ASEmail
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button CerrarBoton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASEmail));
            this.Pantalla1 = new System.Windows.Forms.Panel();
            this.pantalla3 = new System.Windows.Forms.Panel();
            this.finalizarCorreo = new System.Windows.Forms.Button();
            this.conExito = new System.Windows.Forms.Label();
            this.enviarCorreo = new System.Windows.Forms.Button();
            this.ayuda = new System.Windows.Forms.Label();
            this.insertarCorreoReceptor = new System.Windows.Forms.TextBox();
            this.correoReceptor = new System.Windows.Forms.Label();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.errorIngresar = new System.Windows.Forms.Label();
            this.ingresarBoton = new System.Windows.Forms.Button();
            this.ingresar = new System.Windows.Forms.Label();
            this.insertarContraseña = new System.Windows.Forms.TextBox();
            this.insertarCorreoParaSistema = new System.Windows.Forms.TextBox();
            this.tituloSistema = new System.Windows.Forms.Label();
            this.contraseñaSistema = new System.Windows.Forms.Label();
            this.correoSistema = new System.Windows.Forms.Label();
            this.pantalla2 = new System.Windows.Forms.Panel();
            this.metodoPagoOp = new System.Windows.Forms.ListBox();
            this.esMayorOp = new System.Windows.Forms.ListBox();
            this.exitoCompra = new System.Windows.Forms.Label();
            this.finalizarOp = new System.Windows.Forms.Button();
            this.comprarOp = new System.Windows.Forms.Button();
            this.metodoPago = new System.Windows.Forms.Label();
            this.mayorEdad = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.insertarApellido = new System.Windows.Forms.TextBox();
            this.insertarNombre = new System.Windows.Forms.TextBox();
            this.mailMenuOp = new System.Windows.Forms.Button();
            this.salirOp = new System.Windows.Forms.Button();
            this.venderOp = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.ColorC = new System.Windows.Forms.PictureBox();
            CerrarBoton = new System.Windows.Forms.Button();
            this.Pantalla1.SuspendLayout();
            this.pantalla3.SuspendLayout();
            this.panelSistema.SuspendLayout();
            this.pantalla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorC)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBoton
            // 
            CerrarBoton.BackColor = System.Drawing.SystemColors.Highlight;
            CerrarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CerrarBoton.BackgroundImage")));
            CerrarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CerrarBoton.FlatAppearance.BorderSize = 0;
            CerrarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CerrarBoton.ForeColor = System.Drawing.Color.Transparent;
            CerrarBoton.Location = new System.Drawing.Point(1148, 12);
            CerrarBoton.Name = "CerrarBoton";
            CerrarBoton.Size = new System.Drawing.Size(26, 28);
            CerrarBoton.TabIndex = 7;
            CerrarBoton.UseVisualStyleBackColor = false;
            CerrarBoton.Click += new System.EventHandler(this.cerrarBoton_Click);
            // 
            // Pantalla1
            // 
            this.Pantalla1.Controls.Add(this.pantalla3);
            this.Pantalla1.Controls.Add(this.panelSistema);
            this.Pantalla1.Controls.Add(this.pantalla2);
            this.Pantalla1.Controls.Add(this.mailMenuOp);
            this.Pantalla1.Controls.Add(this.salirOp);
            this.Pantalla1.Controls.Add(this.venderOp);
            this.Pantalla1.Controls.Add(CerrarBoton);
            this.Pantalla1.Controls.Add(this.Titulo);
            this.Pantalla1.Controls.Add(this.ColorC);
            this.Pantalla1.Location = new System.Drawing.Point(0, 0);
            this.Pantalla1.Name = "Pantalla1";
            this.Pantalla1.Size = new System.Drawing.Size(1189, 633);
            this.Pantalla1.TabIndex = 0;
            // 
            // pantalla3
            // 
            this.pantalla3.BackColor = System.Drawing.SystemColors.Highlight;
            this.pantalla3.Controls.Add(this.finalizarCorreo);
            this.pantalla3.Controls.Add(this.conExito);
            this.pantalla3.Controls.Add(this.enviarCorreo);
            this.pantalla3.Controls.Add(this.ayuda);
            this.pantalla3.Controls.Add(this.insertarCorreoReceptor);
            this.pantalla3.Controls.Add(this.correoReceptor);
            this.pantalla3.Location = new System.Drawing.Point(424, 71);
            this.pantalla3.Name = "pantalla3";
            this.pantalla3.Size = new System.Drawing.Size(692, 424);
            this.pantalla3.TabIndex = 10;
            this.pantalla3.Paint += new System.Windows.Forms.PaintEventHandler(this.pantalla3_Paint);
            // 
            // finalizarCorreo
            // 
            this.finalizarCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.finalizarCorreo.Location = new System.Drawing.Point(277, 216);
            this.finalizarCorreo.Name = "finalizarCorreo";
            this.finalizarCorreo.Size = new System.Drawing.Size(211, 39);
            this.finalizarCorreo.TabIndex = 7;
            this.finalizarCorreo.Text = "FINALIZAR";
            this.finalizarCorreo.UseVisualStyleBackColor = true;
            this.finalizarCorreo.Click += new System.EventHandler(this.finalizarCorreo_Click);
            // 
            // conExito
            // 
            this.conExito.AutoSize = true;
            this.conExito.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conExito.ForeColor = System.Drawing.Color.White;
            this.conExito.Location = new System.Drawing.Point(35, 281);
            this.conExito.Name = "conExito";
            this.conExito.Size = new System.Drawing.Size(142, 13);
            this.conExito.TabIndex = 6;
            this.conExito.Text = "CORREO ENVIADO CON EXITO*";
            // 
            // enviarCorreo
            // 
            this.enviarCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.enviarCorreo.Location = new System.Drawing.Point(36, 216);
            this.enviarCorreo.Name = "enviarCorreo";
            this.enviarCorreo.Size = new System.Drawing.Size(211, 39);
            this.enviarCorreo.TabIndex = 5;
            this.enviarCorreo.Text = "ENVIAR CORREO";
            this.enviarCorreo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enviarCorreo.UseVisualStyleBackColor = true;
            this.enviarCorreo.Click += new System.EventHandler(this.enviarCorreo_Click_1);
            // 
            // ayuda
            // 
            this.ayuda.AutoSize = true;
            this.ayuda.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayuda.ForeColor = System.Drawing.Color.White;
            this.ayuda.Location = new System.Drawing.Point(32, 175);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(589, 19);
            this.ayuda.TabIndex = 2;
            this.ayuda.Text = "SE ENVIARA EL LISTADO COMPLETO DE LAS ENTRADAS VENDIDAS AL CORREO INDICADO*\r\n";
            // 
            // insertarCorreoReceptor
            // 
            this.insertarCorreoReceptor.Location = new System.Drawing.Point(36, 117);
            this.insertarCorreoReceptor.Name = "insertarCorreoReceptor";
            this.insertarCorreoReceptor.Size = new System.Drawing.Size(232, 20);
            this.insertarCorreoReceptor.TabIndex = 1;
            // 
            // correoReceptor
            // 
            this.correoReceptor.AutoSize = true;
            this.correoReceptor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoReceptor.ForeColor = System.Drawing.Color.White;
            this.correoReceptor.Location = new System.Drawing.Point(32, 64);
            this.correoReceptor.Name = "correoReceptor";
            this.correoReceptor.Size = new System.Drawing.Size(236, 19);
            this.correoReceptor.TabIndex = 0;
            this.correoReceptor.Text = "CORREO ELECTRONICO RECEPTOR";
            // 
            // panelSistema
            // 
            this.panelSistema.Controls.Add(this.errorIngresar);
            this.panelSistema.Controls.Add(this.ingresarBoton);
            this.panelSistema.Controls.Add(this.ingresar);
            this.panelSistema.Controls.Add(this.insertarContraseña);
            this.panelSistema.Controls.Add(this.insertarCorreoParaSistema);
            this.panelSistema.Controls.Add(this.tituloSistema);
            this.panelSistema.Controls.Add(this.contraseñaSistema);
            this.panelSistema.Controls.Add(this.correoSistema);
            this.panelSistema.Location = new System.Drawing.Point(41, 206);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(273, 364);
            this.panelSistema.TabIndex = 13;
            // 
            // errorIngresar
            // 
            this.errorIngresar.AutoSize = true;
            this.errorIngresar.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorIngresar.ForeColor = System.Drawing.Color.Red;
            this.errorIngresar.Location = new System.Drawing.Point(5, 334);
            this.errorIngresar.Name = "errorIngresar";
            this.errorIngresar.Size = new System.Drawing.Size(170, 13);
            this.errorIngresar.TabIndex = 12;
            this.errorIngresar.Text = "CORREO O CONTRASEÑA INVALIDOS*";
            // 
            // ingresarBoton
            // 
            this.ingresarBoton.AutoSize = true;
            this.ingresarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresarBoton.BackgroundImage")));
            this.ingresarBoton.FlatAppearance.BorderSize = 0;
            this.ingresarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarBoton.Location = new System.Drawing.Point(217, 268);
            this.ingresarBoton.Name = "ingresarBoton";
            this.ingresarBoton.Size = new System.Drawing.Size(53, 53);
            this.ingresarBoton.TabIndex = 11;
            this.ingresarBoton.UseVisualStyleBackColor = true;
            this.ingresarBoton.Click += new System.EventHandler(this.ingresarBoton_Click);
            // 
            // ingresar
            // 
            this.ingresar.AutoSize = true;
            this.ingresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.Black;
            this.ingresar.Location = new System.Drawing.Point(4, 287);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(78, 19);
            this.ingresar.TabIndex = 10;
            this.ingresar.Text = "INGRESAR";
            // 
            // insertarContraseña
            // 
            this.insertarContraseña.Location = new System.Drawing.Point(8, 227);
            this.insertarContraseña.Name = "insertarContraseña";
            this.insertarContraseña.Size = new System.Drawing.Size(182, 20);
            this.insertarContraseña.TabIndex = 9;
            this.insertarContraseña.TextChanged += new System.EventHandler(this.insertarContraseña_TextChanged);
            // 
            // insertarCorreoParaSistema
            // 
            this.insertarCorreoParaSistema.Location = new System.Drawing.Point(8, 143);
            this.insertarCorreoParaSistema.Name = "insertarCorreoParaSistema";
            this.insertarCorreoParaSistema.Size = new System.Drawing.Size(182, 20);
            this.insertarCorreoParaSistema.TabIndex = 8;
            // 
            // tituloSistema
            // 
            this.tituloSistema.AutoSize = true;
            this.tituloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSistema.ForeColor = System.Drawing.Color.Black;
            this.tituloSistema.Location = new System.Drawing.Point(2, 20);
            this.tituloSistema.Name = "tituloSistema";
            this.tituloSistema.Size = new System.Drawing.Size(362, 33);
            this.tituloSistema.TabIndex = 7;
            this.tituloSistema.Text = "INGRESAR AL SISTEMA";
            // 
            // contraseñaSistema
            // 
            this.contraseñaSistema.AutoSize = true;
            this.contraseñaSistema.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaSistema.ForeColor = System.Drawing.Color.Black;
            this.contraseñaSistema.Location = new System.Drawing.Point(4, 189);
            this.contraseñaSistema.Name = "contraseñaSistema";
            this.contraseñaSistema.Size = new System.Drawing.Size(103, 19);
            this.contraseñaSistema.TabIndex = 6;
            this.contraseñaSistema.Text = "CONTRASEÑA";
            this.contraseñaSistema.Click += new System.EventHandler(this.label2_Click);
            // 
            // correoSistema
            // 
            this.correoSistema.AutoSize = true;
            this.correoSistema.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoSistema.ForeColor = System.Drawing.Color.Black;
            this.correoSistema.Location = new System.Drawing.Point(3, 106);
            this.correoSistema.Name = "correoSistema";
            this.correoSistema.Size = new System.Drawing.Size(162, 19);
            this.correoSistema.TabIndex = 5;
            this.correoSistema.Text = "CORREO ELECTRONICO";
            // 
            // pantalla2
            // 
            this.pantalla2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pantalla2.Controls.Add(this.metodoPagoOp);
            this.pantalla2.Controls.Add(this.esMayorOp);
            this.pantalla2.Controls.Add(this.exitoCompra);
            this.pantalla2.Controls.Add(this.finalizarOp);
            this.pantalla2.Controls.Add(this.comprarOp);
            this.pantalla2.Controls.Add(this.metodoPago);
            this.pantalla2.Controls.Add(this.mayorEdad);
            this.pantalla2.Controls.Add(this.apellido);
            this.pantalla2.Controls.Add(this.nombre);
            this.pantalla2.Controls.Add(this.insertarApellido);
            this.pantalla2.Controls.Add(this.insertarNombre);
            this.pantalla2.Location = new System.Drawing.Point(424, 103);
            this.pantalla2.Name = "pantalla2";
            this.pantalla2.Size = new System.Drawing.Size(683, 427);
            this.pantalla2.TabIndex = 11;
            // 
            // metodoPagoOp
            // 
            this.metodoPagoOp.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoPagoOp.FormattingEnabled = true;
            this.metodoPagoOp.Items.AddRange(new object[] {
            "Efectivo",
            "MercadoPago",
            "TarjetaCredito"});
            this.metodoPagoOp.Location = new System.Drawing.Point(69, 327);
            this.metodoPagoOp.Name = "metodoPagoOp";
            this.metodoPagoOp.Size = new System.Drawing.Size(102, 43);
            this.metodoPagoOp.TabIndex = 12;
            // 
            // esMayorOp
            // 
            this.esMayorOp.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esMayorOp.FormattingEnabled = true;
            this.esMayorOp.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.esMayorOp.Location = new System.Drawing.Point(69, 246);
            this.esMayorOp.Name = "esMayorOp";
            this.esMayorOp.Size = new System.Drawing.Size(28, 30);
            this.esMayorOp.TabIndex = 11;
            // 
            // exitoCompra
            // 
            this.exitoCompra.AutoSize = true;
            this.exitoCompra.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic);
            this.exitoCompra.ForeColor = System.Drawing.Color.White;
            this.exitoCompra.Location = new System.Drawing.Point(439, 152);
            this.exitoCompra.Name = "exitoCompra";
            this.exitoCompra.Size = new System.Drawing.Size(115, 17);
            this.exitoCompra.TabIndex = 10;
            this.exitoCompra.Text = "COMPRA EXITOSA*";
            // 
            // finalizarOp
            // 
            this.finalizarOp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarOp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.finalizarOp.Location = new System.Drawing.Point(432, 184);
            this.finalizarOp.Name = "finalizarOp";
            this.finalizarOp.Size = new System.Drawing.Size(211, 39);
            this.finalizarOp.TabIndex = 9;
            this.finalizarOp.Text = "FINALIZAR COMPRA";
            this.finalizarOp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.finalizarOp.UseVisualStyleBackColor = true;
            this.finalizarOp.Click += new System.EventHandler(this.finalizarOp_Click);
            // 
            // comprarOp
            // 
            this.comprarOp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarOp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comprarOp.Location = new System.Drawing.Point(432, 95);
            this.comprarOp.Name = "comprarOp";
            this.comprarOp.Size = new System.Drawing.Size(211, 39);
            this.comprarOp.TabIndex = 8;
            this.comprarOp.Text = "COMPRAR ENTRADA";
            this.comprarOp.UseVisualStyleBackColor = true;
            this.comprarOp.Click += new System.EventHandler(this.comprarOp_Click);
            // 
            // metodoPago
            // 
            this.metodoPago.AutoSize = true;
            this.metodoPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoPago.ForeColor = System.Drawing.Color.White;
            this.metodoPago.Location = new System.Drawing.Point(62, 292);
            this.metodoPago.Name = "metodoPago";
            this.metodoPago.Size = new System.Drawing.Size(136, 19);
            this.metodoPago.TabIndex = 7;
            this.metodoPago.Text = "METODO DE PAGO";
            // 
            // mayorEdad
            // 
            this.mayorEdad.AutoSize = true;
            this.mayorEdad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mayorEdad.ForeColor = System.Drawing.Color.White;
            this.mayorEdad.Location = new System.Drawing.Point(61, 206);
            this.mayorEdad.Name = "mayorEdad";
            this.mayorEdad.Size = new System.Drawing.Size(123, 19);
            this.mayorEdad.TabIndex = 6;
            this.mayorEdad.Text = "MAYOR DE EDAD";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.ForeColor = System.Drawing.Color.White;
            this.apellido.Location = new System.Drawing.Point(62, 129);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(75, 19);
            this.apellido.TabIndex = 5;
            this.apellido.Text = "APELLIDO";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(65, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(71, 19);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "NOMBRE";
            // 
            // insertarApellido
            // 
            this.insertarApellido.Location = new System.Drawing.Point(65, 156);
            this.insertarApellido.Name = "insertarApellido";
            this.insertarApellido.Size = new System.Drawing.Size(219, 20);
            this.insertarApellido.TabIndex = 1;
            // 
            // insertarNombre
            // 
            this.insertarNombre.Location = new System.Drawing.Point(65, 95);
            this.insertarNombre.Name = "insertarNombre";
            this.insertarNombre.Size = new System.Drawing.Size(219, 20);
            this.insertarNombre.TabIndex = 0;
            // 
            // mailMenuOp
            // 
            this.mailMenuOp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mailMenuOp.BackgroundImage")));
            this.mailMenuOp.FlatAppearance.BorderSize = 0;
            this.mailMenuOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailMenuOp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailMenuOp.ForeColor = System.Drawing.Color.White;
            this.mailMenuOp.Location = new System.Drawing.Point(56, 334);
            this.mailMenuOp.Name = "mailMenuOp";
            this.mailMenuOp.Size = new System.Drawing.Size(211, 39);
            this.mailMenuOp.TabIndex = 12;
            this.mailMenuOp.Text = "ENVIAR MAIL";
            this.mailMenuOp.UseVisualStyleBackColor = true;
            this.mailMenuOp.Click += new System.EventHandler(this.mailMenuOp_Click);
            // 
            // salirOp
            // 
            this.salirOp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salirOp.BackgroundImage")));
            this.salirOp.FlatAppearance.BorderSize = 0;
            this.salirOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirOp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirOp.ForeColor = System.Drawing.Color.White;
            this.salirOp.Location = new System.Drawing.Point(56, 414);
            this.salirOp.Name = "salirOp";
            this.salirOp.Size = new System.Drawing.Size(211, 39);
            this.salirOp.TabIndex = 10;
            this.salirOp.Text = "SALIR DEL PROGRAMA";
            this.salirOp.UseVisualStyleBackColor = true;
            this.salirOp.Click += new System.EventHandler(this.salirOp_Click);
            // 
            // venderOp
            // 
            this.venderOp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("venderOp.BackgroundImage")));
            this.venderOp.FlatAppearance.BorderSize = 0;
            this.venderOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venderOp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderOp.ForeColor = System.Drawing.Color.White;
            this.venderOp.Location = new System.Drawing.Point(56, 255);
            this.venderOp.Name = "venderOp";
            this.venderOp.Size = new System.Drawing.Size(211, 39);
            this.venderOp.TabIndex = 8;
            this.venderOp.Text = "VENDER ENTRADAS";
            this.venderOp.UseVisualStyleBackColor = true;
            this.venderOp.Click += new System.EventHandler(this.venderMenuOp_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(46, 46);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(397, 110);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "ASEmail\r\nALEMANIA-CUP";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColorC
            // 
            this.ColorC.BackColor = System.Drawing.SystemColors.Highlight;
            this.ColorC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorC.Location = new System.Drawing.Point(362, -19);
            this.ColorC.Name = "ColorC";
            this.ColorC.Size = new System.Drawing.Size(824, 649);
            this.ColorC.TabIndex = 1;
            this.ColorC.TabStop = false;
            // 
            // ASEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 628);
            this.Controls.Add(this.Pantalla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAEmail";
            this.Pantalla1.ResumeLayout(false);
            this.Pantalla1.PerformLayout();
            this.pantalla3.ResumeLayout(false);
            this.pantalla3.PerformLayout();
            this.panelSistema.ResumeLayout(false);
            this.panelSistema.PerformLayout();
            this.pantalla2.ResumeLayout(false);
            this.pantalla2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pantalla1;
        private System.Windows.Forms.PictureBox ColorC;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button salirOp;
        private System.Windows.Forms.Button venderOp;
        private System.Windows.Forms.Panel pantalla2;
        private System.Windows.Forms.Button finalizarOp;
        private System.Windows.Forms.Button comprarOp;
        private System.Windows.Forms.Label metodoPago;
        private System.Windows.Forms.Label mayorEdad;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox insertarApellido;
        private System.Windows.Forms.TextBox insertarNombre;
        private System.Windows.Forms.Panel pantalla3;
        private System.Windows.Forms.Button enviarCorreo;
        private System.Windows.Forms.Label ayuda;
        private System.Windows.Forms.TextBox insertarCorreoReceptor;
        private System.Windows.Forms.Label correoReceptor;
        private System.Windows.Forms.Label conExito;
        private System.Windows.Forms.Button finalizarCorreo;
        private System.Windows.Forms.Label exitoCompra;
        private System.Windows.Forms.Button mailMenuOp;
        private System.Windows.Forms.ListBox metodoPagoOp;
        private System.Windows.Forms.ListBox esMayorOp;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.Label tituloSistema;
        private System.Windows.Forms.Label contraseñaSistema;
        private System.Windows.Forms.Label correoSistema;
        private System.Windows.Forms.TextBox insertarContraseña;
        private System.Windows.Forms.TextBox insertarCorreoParaSistema;
        private System.Windows.Forms.Label errorIngresar;
        private System.Windows.Forms.Button ingresarBoton;
        private System.Windows.Forms.Label ingresar;
    }

}

