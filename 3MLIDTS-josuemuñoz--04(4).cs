namespace _3NLIDTS_Josuemuñoz_04
{
    partial class Form1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(91, 32);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(184, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(184, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(184, 77);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(184, 22);
            this.tbapellido.TabIndex = 2;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(184, 124);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(184, 22);
            this.tbtelefono.TabIndex = 3;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(184, 231);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(184, 22);
            this.tbedad.TabIndex = 4;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(114, 332);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(77, 20);
            this.rbHombre.TabIndex = 5;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(83, 83);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(64, 16);
            this.lbApellidos.TabIndex = 8;
            this.lbApellidos.Text = "Apellidos";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(86, 141);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(61, 16);
            this.lbTelefono.TabIndex = 9;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(91, 237);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 16);
            this.lbEdad.TabIndex = 10;
            this.lbEdad.Text = "Edad";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(262, 332);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(61, 20);
            this.rbMujer.TabIndex = 11;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(91, 297);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(52, 16);
            this.lbGenero.TabIndex = 12;
            this.lbGenero.Text = "Genero";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(82, 377);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(128, 46);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(262, 377);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(128, 46);
            this.btLimpiar.TabIndex = 14;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estatura";
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(184, 180);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(184, 22);
            this.tbestatura.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Cuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbestatura;
    }
}

