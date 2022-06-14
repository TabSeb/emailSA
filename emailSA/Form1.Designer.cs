
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
            System.Windows.Forms.Label ContenidoApp;
            System.Windows.Forms.Button Ingresar;
            System.Windows.Forms.Button Enviar;
            this.Pantalla1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Enviar0 = new System.Windows.Forms.Label();
            this.cuerpoTexto = new System.Windows.Forms.Label();
            this.asunto = new System.Windows.Forms.Label();
            this.ingresarAsunto = new System.Windows.Forms.TextBox();
            this.ingresarCuerpoText = new System.Windows.Forms.RichTextBox();
            this.textoAyuda = new System.Windows.Forms.Label();
            this.correoReceptor = new System.Windows.Forms.Label();
            this.ingresarCorreoRecep = new System.Windows.Forms.TextBox();
            this.redactar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quees = new System.Windows.Forms.Label();
            this.IngresarContraseña = new System.Windows.Forms.TextBox();
            this.IngresarCorreo = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.CorreoE = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.ColorC = new System.Windows.Forms.PictureBox();
            this.ColorB = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            CerrarBoton = new System.Windows.Forms.Button();
            ContenidoApp = new System.Windows.Forms.Label();
            Ingresar = new System.Windows.Forms.Button();
            Enviar = new System.Windows.Forms.Button();
            this.Pantalla1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
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
            // ContenidoApp
            // 
            ContenidoApp.AutoSize = true;
            ContenidoApp.BackColor = System.Drawing.SystemColors.Highlight;
            ContenidoApp.CausesValidation = false;
            ContenidoApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ContenidoApp.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ContenidoApp.ForeColor = System.Drawing.Color.White;
            ContenidoApp.Location = new System.Drawing.Point(645, 157);
            ContenidoApp.Name = "ContenidoApp";
            ContenidoApp.Size = new System.Drawing.Size(307, 110);
            ContenidoApp.TabIndex = 8;
            ContenidoApp.Text = "ASEmail es una plataforma en la cual \r\nel usuario tendra la posibilidad de \r\nenvi" +
    "ar un correo a otra persona sin \r\nnecesidad de entrar al mismo mediante\r\nla pagi" +
    "na web\r\n";
            // 
            // Ingresar
            // 
            Ingresar.BackColor = System.Drawing.Color.Transparent;
            Ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ingresar.BackgroundImage")));
            Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Ingresar.FlatAppearance.BorderSize = 0;
            Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Ingresar.ForeColor = System.Drawing.Color.Transparent;
            Ingresar.Location = new System.Drawing.Point(210, 441);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new System.Drawing.Size(53, 53);
            Ingresar.TabIndex = 9;
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // Enviar
            // 
            Enviar.BackColor = System.Drawing.Color.Transparent;
            Enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Enviar.BackgroundImage")));
            Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Enviar.FlatAppearance.BorderSize = 0;
            Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Enviar.ForeColor = System.Drawing.Color.Transparent;
            Enviar.Location = new System.Drawing.Point(218, 369);
            Enviar.Name = "Enviar";
            Enviar.Size = new System.Drawing.Size(53, 53);
            Enviar.TabIndex = 24;
            Enviar.UseVisualStyleBackColor = false;
            Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Pantalla1
            // 
            this.Pantalla1.Controls.Add(this.error);
            this.Pantalla1.Controls.Add(this.panel1);
            this.Pantalla1.Controls.Add(this.label1);
            this.Pantalla1.Controls.Add(Ingresar);
            this.Pantalla1.Controls.Add(ContenidoApp);
            this.Pantalla1.Controls.Add(CerrarBoton);
            this.Pantalla1.Controls.Add(this.Quees);
            this.Pantalla1.Controls.Add(this.IngresarContraseña);
            this.Pantalla1.Controls.Add(this.IngresarCorreo);
            this.Pantalla1.Controls.Add(this.Contraseña);
            this.Pantalla1.Controls.Add(this.CorreoE);
            this.Pantalla1.Controls.Add(this.Titulo);
            this.Pantalla1.Controls.Add(this.ColorC);
            this.Pantalla1.Controls.Add(this.ColorB);
            this.Pantalla1.Location = new System.Drawing.Point(0, 0);
            this.Pantalla1.Name = "Pantalla1";
            this.Pantalla1.Size = new System.Drawing.Size(1189, 633);
            this.Pantalla1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Enviar0);
            this.panel1.Controls.Add(Enviar);
            this.panel1.Controls.Add(this.cuerpoTexto);
            this.panel1.Controls.Add(this.asunto);
            this.panel1.Controls.Add(this.ingresarAsunto);
            this.panel1.Controls.Add(this.ingresarCuerpoText);
            this.panel1.Controls.Add(this.textoAyuda);
            this.panel1.Controls.Add(this.correoReceptor);
            this.panel1.Controls.Add(this.ingresarCorreoRecep);
            this.panel1.Controls.Add(this.redactar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 587);
            this.panel1.TabIndex = 11;
            // 
            // Enviar0
            // 
            this.Enviar0.AutoSize = true;
            this.Enviar0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar0.Location = new System.Drawing.Point(44, 385);
            this.Enviar0.Name = "Enviar0";
            this.Enviar0.Size = new System.Drawing.Size(60, 19);
            this.Enviar0.TabIndex = 25;
            this.Enviar0.Text = "ENVIAR";
            // 
            // cuerpoTexto
            // 
            this.cuerpoTexto.AutoSize = true;
            this.cuerpoTexto.BackColor = System.Drawing.SystemColors.Highlight;
            this.cuerpoTexto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuerpoTexto.ForeColor = System.Drawing.Color.White;
            this.cuerpoTexto.Location = new System.Drawing.Point(427, 99);
            this.cuerpoTexto.Name = "cuerpoTexto";
            this.cuerpoTexto.Size = new System.Drawing.Size(128, 23);
            this.cuerpoTexto.TabIndex = 22;
            this.cuerpoTexto.Text = "CUERPO TEXTO";
            // 
            // asunto
            // 
            this.asunto.AutoSize = true;
            this.asunto.BackColor = System.Drawing.SystemColors.Highlight;
            this.asunto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asunto.ForeColor = System.Drawing.Color.White;
            this.asunto.Location = new System.Drawing.Point(427, 12);
            this.asunto.Name = "asunto";
            this.asunto.Size = new System.Drawing.Size(77, 23);
            this.asunto.TabIndex = 21;
            this.asunto.Text = "ASUNTO";
            // 
            // ingresarAsunto
            // 
            this.ingresarAsunto.Location = new System.Drawing.Point(431, 53);
            this.ingresarAsunto.Name = "ingresarAsunto";
            this.ingresarAsunto.Size = new System.Drawing.Size(716, 20);
            this.ingresarAsunto.TabIndex = 20;
            // 
            // ingresarCuerpoText
            // 
            this.ingresarCuerpoText.Location = new System.Drawing.Point(440, 148);
            this.ingresarCuerpoText.Name = "ingresarCuerpoText";
            this.ingresarCuerpoText.Size = new System.Drawing.Size(716, 256);
            this.ingresarCuerpoText.TabIndex = 19;
            this.ingresarCuerpoText.Text = "";
            // 
            // textoAyuda
            // 
            this.textoAyuda.AutoSize = true;
            this.textoAyuda.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Italic);
            this.textoAyuda.Location = new System.Drawing.Point(35, 219);
            this.textoAyuda.Name = "textoAyuda";
            this.textoAyuda.Size = new System.Drawing.Size(302, 34);
            this.textoAyuda.TabIndex = 18;
            this.textoAyuda.Text = "\r\nASEGURESE DE QUE ESTE BIEN ESCRITO EL CORREO*";
            // 
            // correoReceptor
            // 
            this.correoReceptor.AutoSize = true;
            this.correoReceptor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoReceptor.Location = new System.Drawing.Point(35, 135);
            this.correoReceptor.Name = "correoReceptor";
            this.correoReceptor.Size = new System.Drawing.Size(236, 19);
            this.correoReceptor.TabIndex = 17;
            this.correoReceptor.Text = "CORREO ELECTRONICO RECEPTOR\r\n";
            // 
            // ingresarCorreoRecep
            // 
            this.ingresarCorreoRecep.Location = new System.Drawing.Point(38, 176);
            this.ingresarCorreoRecep.Name = "ingresarCorreoRecep";
            this.ingresarCorreoRecep.Size = new System.Drawing.Size(233, 20);
            this.ingresarCorreoRecep.TabIndex = 16;
            // 
            // redactar
            // 
            this.redactar.AutoSize = true;
            this.redactar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redactar.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redactar.Location = new System.Drawing.Point(31, 29);
            this.redactar.Name = "redactar";
            this.redactar.Size = new System.Drawing.Size(315, 44);
            this.redactar.TabIndex = 15;
            this.redactar.Text = "REDACTAR UN MENSAJE\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(362, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 596);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 596);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "INGRESAR";
            // 
            // Quees
            // 
            this.Quees.AutoSize = true;
            this.Quees.BackColor = System.Drawing.SystemColors.Highlight;
            this.Quees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quees.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quees.ForeColor = System.Drawing.Color.White;
            this.Quees.Location = new System.Drawing.Point(702, 83);
            this.Quees.Name = "Quees";
            this.Quees.Size = new System.Drawing.Size(191, 39);
            this.Quees.TabIndex = 6;
            this.Quees.Text = "Que es ASEmail?";
            // 
            // IngresarContraseña
            // 
            this.IngresarContraseña.Location = new System.Drawing.Point(52, 371);
            this.IngresarContraseña.Name = "IngresarContraseña";
            this.IngresarContraseña.Size = new System.Drawing.Size(211, 20);
            this.IngresarContraseña.TabIndex = 5;
            // 
            // IngresarCorreo
            // 
            this.IngresarCorreo.Location = new System.Drawing.Point(52, 265);
            this.IngresarCorreo.Name = "IngresarCorreo";
            this.IngresarCorreo.Size = new System.Drawing.Size(211, 20);
            this.IngresarCorreo.TabIndex = 4;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(49, 322);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(103, 19);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "CONTRASEÑA";
            // 
            // CorreoE
            // 
            this.CorreoE.AutoSize = true;
            this.CorreoE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoE.Location = new System.Drawing.Point(49, 217);
            this.CorreoE.Name = "CorreoE";
            this.CorreoE.Size = new System.Drawing.Size(162, 19);
            this.CorreoE.TabIndex = 2;
            this.CorreoE.Text = "CORREO ELECTRONICO";
            this.CorreoE.UseMnemonic = false;
            this.CorreoE.UseWaitCursor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(101, 63);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(150, 59);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "ASEmail";
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
            // ColorB
            // 
            this.ColorB.BackColor = System.Drawing.Color.White;
            this.ColorB.Location = new System.Drawing.Point(0, 0);
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(369, 630);
            this.ColorB.TabIndex = 0;
            this.ColorB.TabStop = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(24, 408);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(312, 15);
            this.error.TabIndex = 12;
            this.error.Text = "CORREO O CONTRASEÑA NO VALIDOS, VUELVA A INTENTAR*\r\n";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pantalla1;
        private System.Windows.Forms.PictureBox ColorB;
        private System.Windows.Forms.PictureBox ColorC;
        private System.Windows.Forms.Label CorreoE;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox IngresarContraseña;
        private System.Windows.Forms.TextBox IngresarCorreo;
        private System.Windows.Forms.Label Quees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Enviar0;
        private System.Windows.Forms.Label cuerpoTexto;
        private System.Windows.Forms.Label asunto;
        private System.Windows.Forms.TextBox ingresarAsunto;
        private System.Windows.Forms.RichTextBox ingresarCuerpoText;
        private System.Windows.Forms.Label textoAyuda;
        private System.Windows.Forms.Label correoReceptor;
        private System.Windows.Forms.TextBox ingresarCorreoRecep;
        private System.Windows.Forms.Label redactar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label error;
    }

}

