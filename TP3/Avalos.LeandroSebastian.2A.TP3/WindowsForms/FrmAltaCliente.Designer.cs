
namespace WindowsForms
{
    partial class FrmAltaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAltaEmpleado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroDeTelefono = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNumeroDeTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gpbSeguros = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdbSeguroContraTodo = new System.Windows.Forms.RadioButton();
            this.rdbSeguroIntermedio = new System.Windows.Forms.RadioButton();
            this.rdbSeguroBasico = new System.Windows.Forms.RadioButton();
            this.txtAnioDelVehiculo = new System.Windows.Forms.TextBox();
            this.txtMarcaDelVehiculo = new System.Windows.Forms.TextBox();
            this.txtModeloDelVehiculo = new System.Windows.Forms.TextBox();
            this.lblAnioDelVehiculo = new System.Windows.Forms.Label();
            this.lblMarcaDelVehiculo = new System.Windows.Forms.Label();
            this.lblModeloDelVehiculo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epDatoDeLetrasIncorrecto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.gpbSeguros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaEmpleado
            // 
            this.lblAltaEmpleado.AutoSize = true;
            this.lblAltaEmpleado.Font = new System.Drawing.Font("Sitka Display Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAltaEmpleado.Location = new System.Drawing.Point(295, 9);
            this.lblAltaEmpleado.Name = "lblAltaEmpleado";
            this.lblAltaEmpleado.Size = new System.Drawing.Size(229, 50);
            this.lblAltaEmpleado.TabIndex = 0;
            this.lblAltaEmpleado.Text = "Alta de Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(20, 96);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 31);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(20, 206);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(228, 31);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterNumerico_KeyPress);
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxDni);
            this.txtDni.Validated += new System.EventHandler(this.validados_TextBoxesDeNumeros);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDomicilio.Location = new System.Drawing.Point(20, 321);
            this.txtDomicilio.MaxLength = 20;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(228, 31);
            this.txtDomicilio.TabIndex = 6;
            this.txtDomicilio.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxesDeNumerosYTexto);
            this.txtDomicilio.Validated += new System.EventHandler(this.validados_TextBoxesDeNumerosYTexto);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(295, 96);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(228, 31);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtNumeroDeTelefono
            // 
            this.txtNumeroDeTelefono.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroDeTelefono.Location = new System.Drawing.Point(295, 206);
            this.txtNumeroDeTelefono.MaxLength = 10;
            this.txtNumeroDeTelefono.Name = "txtNumeroDeTelefono";
            this.txtNumeroDeTelefono.Size = new System.Drawing.Size(228, 31);
            this.txtNumeroDeTelefono.TabIndex = 4;
            this.txtNumeroDeTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterNumerico_KeyPress);
            this.txtNumeroDeTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxTelefono);
            this.txtNumeroDeTelefono.Validated += new System.EventHandler(this.validados_TextBoxesDeNumeros);
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(340, 321);
            this.numericUpDownEdad.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownEdad.TabIndex = 7;
            this.numericUpDownEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(295, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(20, 178);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI";
            // 
            // lblNumeroDeTelefono
            // 
            this.lblNumeroDeTelefono.AutoSize = true;
            this.lblNumeroDeTelefono.Location = new System.Drawing.Point(295, 178);
            this.lblNumeroDeTelefono.Name = "lblNumeroDeTelefono";
            this.lblNumeroDeTelefono.Size = new System.Drawing.Size(114, 15);
            this.lblNumeroDeTelefono.TabIndex = 10;
            this.lblNumeroDeTelefono.Text = "Numero de telefono";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(20, 293);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(58, 15);
            this.lblDomicilio.TabIndex = 11;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(340, 293);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // gpbSeguros
            // 
            this.gpbSeguros.Controls.Add(this.richTextBox1);
            this.gpbSeguros.Controls.Add(this.rdbSeguroContraTodo);
            this.gpbSeguros.Controls.Add(this.rdbSeguroIntermedio);
            this.gpbSeguros.Controls.Add(this.rdbSeguroBasico);
            this.gpbSeguros.Location = new System.Drawing.Point(20, 369);
            this.gpbSeguros.Name = "gpbSeguros";
            this.gpbSeguros.Size = new System.Drawing.Size(784, 270);
            this.gpbSeguros.TabIndex = 13;
            this.gpbSeguros.TabStop = false;
            this.gpbSeguros.Text = "Coberturas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(763, 217);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // rdbSeguroContraTodo
            // 
            this.rdbSeguroContraTodo.AutoSize = true;
            this.rdbSeguroContraTodo.Location = new System.Drawing.Point(612, 22);
            this.rdbSeguroContraTodo.Name = "rdbSeguroContraTodo";
            this.rdbSeguroContraTodo.Size = new System.Drawing.Size(130, 19);
            this.rdbSeguroContraTodo.TabIndex = 11;
            this.rdbSeguroContraTodo.TabStop = true;
            this.rdbSeguroContraTodo.Text = "Seguro Contra Todo";
            this.rdbSeguroContraTodo.UseVisualStyleBackColor = true;
            this.rdbSeguroContraTodo.CheckedChanged += new System.EventHandler(this.rdbSeguroContraTodo_CheckedChanged);
            // 
            // rdbSeguroIntermedio
            // 
            this.rdbSeguroIntermedio.AutoSize = true;
            this.rdbSeguroIntermedio.Location = new System.Drawing.Point(317, 22);
            this.rdbSeguroIntermedio.Name = "rdbSeguroIntermedio";
            this.rdbSeguroIntermedio.Size = new System.Drawing.Size(123, 19);
            this.rdbSeguroIntermedio.TabIndex = 10;
            this.rdbSeguroIntermedio.TabStop = true;
            this.rdbSeguroIntermedio.Text = "Seguro Intermedio";
            this.rdbSeguroIntermedio.UseVisualStyleBackColor = true;
            this.rdbSeguroIntermedio.CheckedChanged += new System.EventHandler(this.rdbSeguroIntermedio_CheckedChanged);
            // 
            // rdbSeguroBasico
            // 
            this.rdbSeguroBasico.AutoSize = true;
            this.rdbSeguroBasico.Checked = true;
            this.rdbSeguroBasico.Location = new System.Drawing.Point(53, 22);
            this.rdbSeguroBasico.Name = "rdbSeguroBasico";
            this.rdbSeguroBasico.Size = new System.Drawing.Size(99, 19);
            this.rdbSeguroBasico.TabIndex = 9;
            this.rdbSeguroBasico.TabStop = true;
            this.rdbSeguroBasico.Text = "Seguro Basico";
            this.rdbSeguroBasico.UseVisualStyleBackColor = true;
            this.rdbSeguroBasico.CheckedChanged += new System.EventHandler(this.rdbSeguroBasico_CheckedChanged);
            // 
            // txtAnioDelVehiculo
            // 
            this.txtAnioDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAnioDelVehiculo.Location = new System.Drawing.Point(576, 96);
            this.txtAnioDelVehiculo.MaxLength = 4;
            this.txtAnioDelVehiculo.Name = "txtAnioDelVehiculo";
            this.txtAnioDelVehiculo.Size = new System.Drawing.Size(228, 31);
            this.txtAnioDelVehiculo.TabIndex = 2;
            this.txtAnioDelVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterNumerico_KeyPress);
            this.txtAnioDelVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxAnioDelVehiculo);
            this.txtAnioDelVehiculo.Validated += new System.EventHandler(this.validados_TextBoxesDeNumeros);
            // 
            // txtMarcaDelVehiculo
            // 
            this.txtMarcaDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMarcaDelVehiculo.Location = new System.Drawing.Point(576, 206);
            this.txtMarcaDelVehiculo.MaxLength = 20;
            this.txtMarcaDelVehiculo.Name = "txtMarcaDelVehiculo";
            this.txtMarcaDelVehiculo.Size = new System.Drawing.Size(228, 31);
            this.txtMarcaDelVehiculo.TabIndex = 5;
            this.txtMarcaDelVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtModeloDelVehiculo
            // 
            this.txtModeloDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtModeloDelVehiculo.Location = new System.Drawing.Point(576, 321);
            this.txtModeloDelVehiculo.MaxLength = 20;
            this.txtModeloDelVehiculo.Name = "txtModeloDelVehiculo";
            this.txtModeloDelVehiculo.Size = new System.Drawing.Size(228, 31);
            this.txtModeloDelVehiculo.TabIndex = 8;
            this.txtModeloDelVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxesDeNumerosYTexto);
            this.txtModeloDelVehiculo.Validated += new System.EventHandler(this.validados_TextBoxesDeNumerosYTexto);
            // 
            // lblAnioDelVehiculo
            // 
            this.lblAnioDelVehiculo.AutoSize = true;
            this.lblAnioDelVehiculo.Location = new System.Drawing.Point(576, 68);
            this.lblAnioDelVehiculo.Name = "lblAnioDelVehiculo";
            this.lblAnioDelVehiculo.Size = new System.Drawing.Size(96, 15);
            this.lblAnioDelVehiculo.TabIndex = 17;
            this.lblAnioDelVehiculo.Text = "Año del Vehiculo";
            // 
            // lblMarcaDelVehiculo
            // 
            this.lblMarcaDelVehiculo.AutoSize = true;
            this.lblMarcaDelVehiculo.Location = new System.Drawing.Point(576, 178);
            this.lblMarcaDelVehiculo.Name = "lblMarcaDelVehiculo";
            this.lblMarcaDelVehiculo.Size = new System.Drawing.Size(107, 15);
            this.lblMarcaDelVehiculo.TabIndex = 18;
            this.lblMarcaDelVehiculo.Text = "Marca del vehiculo";
            // 
            // lblModeloDelVehiculo
            // 
            this.lblModeloDelVehiculo.AutoSize = true;
            this.lblModeloDelVehiculo.Location = new System.Drawing.Point(576, 293);
            this.lblModeloDelVehiculo.Name = "lblModeloDelVehiculo";
            this.lblModeloDelVehiculo.Size = new System.Drawing.Size(115, 15);
            this.lblModeloDelVehiculo.TabIndex = 19;
            this.lblModeloDelVehiculo.Text = "Modelo del vehiculo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(564, 656);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 39);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(690, 656);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epDatoDeLetrasIncorrecto
            // 
            this.epDatoDeLetrasIncorrecto.ContainerControl = this;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 699);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblModeloDelVehiculo);
            this.Controls.Add(this.lblMarcaDelVehiculo);
            this.Controls.Add(this.lblAnioDelVehiculo);
            this.Controls.Add(this.txtModeloDelVehiculo);
            this.Controls.Add(this.txtMarcaDelVehiculo);
            this.Controls.Add(this.txtAnioDelVehiculo);
            this.Controls.Add(this.gpbSeguros);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNumeroDeTelefono);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.txtNumeroDeTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAltaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.gpbSeguros.ResumeLayout(false);
            this.gpbSeguros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumeroDeTelefono;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNumeroDeTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gpbSeguros;
        private System.Windows.Forms.TextBox txtAnioDelVehiculo;
        private System.Windows.Forms.TextBox txtMarcaDelVehiculo;
        private System.Windows.Forms.TextBox txtModeloDelVehiculo;
        private System.Windows.Forms.Label lblAnioDelVehiculo;
        private System.Windows.Forms.Label lblMarcaDelVehiculo;
        private System.Windows.Forms.Label lblModeloDelVehiculo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdbSeguroContraTodo;
        private System.Windows.Forms.RadioButton rdbSeguroIntermedio;
        private System.Windows.Forms.RadioButton rdbSeguroBasico;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epDatoDeLetrasIncorrecto;
    }
}