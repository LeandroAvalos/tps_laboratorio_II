
namespace WindowsForms
{
    partial class FrmNuevoVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnioDelVehiculo = new System.Windows.Forms.TextBox();
            this.txtModeloDelVehiculo = new System.Windows.Forms.TextBox();
            this.txtMarcaDelVehiculo = new System.Windows.Forms.TextBox();
            this.lblAnioDelVehiculo = new System.Windows.Forms.Label();
            this.gpbPlanes = new System.Windows.Forms.GroupBox();
            this.rtbInformacionSeguros = new System.Windows.Forms.RichTextBox();
            this.rdbSeguroContraTodo = new System.Windows.Forms.RadioButton();
            this.rdbSeguroIntermedio = new System.Windows.Forms.RadioButton();
            this.rdbSeguroBasico = new System.Windows.Forms.RadioButton();
            this.lblMarcaDelVehiculo = new System.Windows.Forms.Label();
            this.lblModeloDelVehiculo = new System.Windows.Forms.Label();
            this.epDatoDeLetrasIncorrecto = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo vehiculo";
            // 
            // txtAnioDelVehiculo
            // 
            this.txtAnioDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtAnioDelVehiculo.Location = new System.Drawing.Point(12, 142);
            this.txtAnioDelVehiculo.MaxLength = 4;
            this.txtAnioDelVehiculo.Name = "txtAnioDelVehiculo";
            this.txtAnioDelVehiculo.Size = new System.Drawing.Size(200, 31);
            this.txtAnioDelVehiculo.TabIndex = 0;
            this.txtAnioDelVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterNumerico_KeyPress);
            this.txtAnioDelVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxAnioDelVehiculo);
            this.txtAnioDelVehiculo.Validated += new System.EventHandler(this.validado_TextBoxAnioDelVehiculo);
            // 
            // txtModeloDelVehiculo
            // 
            this.txtModeloDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtModeloDelVehiculo.Location = new System.Drawing.Point(456, 142);
            this.txtModeloDelVehiculo.MaxLength = 20;
            this.txtModeloDelVehiculo.Name = "txtModeloDelVehiculo";
            this.txtModeloDelVehiculo.Size = new System.Drawing.Size(200, 31);
            this.txtModeloDelVehiculo.TabIndex = 2;
            this.txtModeloDelVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxesDeNumerosYTexto);
            this.txtModeloDelVehiculo.Validated += new System.EventHandler(this.validados_TextBoxesDeNumerosYTexto);
            // 
            // txtMarcaDelVehiculo
            // 
            this.txtMarcaDelVehiculo.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtMarcaDelVehiculo.Location = new System.Drawing.Point(234, 142);
            this.txtMarcaDelVehiculo.MaxLength = 20;
            this.txtMarcaDelVehiculo.Name = "txtMarcaDelVehiculo";
            this.txtMarcaDelVehiculo.Size = new System.Drawing.Size(200, 31);
            this.txtMarcaDelVehiculo.TabIndex = 1;
            this.txtMarcaDelVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // lblAnioDelVehiculo
            // 
            this.lblAnioDelVehiculo.AutoSize = true;
            this.lblAnioDelVehiculo.Location = new System.Drawing.Point(12, 110);
            this.lblAnioDelVehiculo.Name = "lblAnioDelVehiculo";
            this.lblAnioDelVehiculo.Size = new System.Drawing.Size(96, 15);
            this.lblAnioDelVehiculo.TabIndex = 3;
            this.lblAnioDelVehiculo.Text = "Año del vehiculo";
            // 
            // gpbPlanes
            // 
            this.gpbPlanes.Controls.Add(this.rtbInformacionSeguros);
            this.gpbPlanes.Controls.Add(this.rdbSeguroContraTodo);
            this.gpbPlanes.Controls.Add(this.rdbSeguroIntermedio);
            this.gpbPlanes.Controls.Add(this.rdbSeguroBasico);
            this.gpbPlanes.Location = new System.Drawing.Point(12, 207);
            this.gpbPlanes.Name = "gpbPlanes";
            this.gpbPlanes.Size = new System.Drawing.Size(644, 254);
            this.gpbPlanes.TabIndex = 4;
            this.gpbPlanes.TabStop = false;
            this.gpbPlanes.Text = "Coberturas";
            // 
            // rtbInformacionSeguros
            // 
            this.rtbInformacionSeguros.Location = new System.Drawing.Point(0, 47);
            this.rtbInformacionSeguros.Name = "rtbInformacionSeguros";
            this.rtbInformacionSeguros.ReadOnly = true;
            this.rtbInformacionSeguros.Size = new System.Drawing.Size(644, 207);
            this.rtbInformacionSeguros.TabIndex = 3;
            this.rtbInformacionSeguros.Text = "";
            // 
            // rdbSeguroContraTodo
            // 
            this.rdbSeguroContraTodo.AutoSize = true;
            this.rdbSeguroContraTodo.Location = new System.Drawing.Point(469, 22);
            this.rdbSeguroContraTodo.Name = "rdbSeguroContraTodo";
            this.rdbSeguroContraTodo.Size = new System.Drawing.Size(130, 19);
            this.rdbSeguroContraTodo.TabIndex = 5;
            this.rdbSeguroContraTodo.Text = "Seguro Contra Todo";
            this.rdbSeguroContraTodo.UseVisualStyleBackColor = true;
            this.rdbSeguroContraTodo.CheckedChanged += new System.EventHandler(this.rdbSeguroContraTodo_CheckedChanged);
            // 
            // rdbSeguroIntermedio
            // 
            this.rdbSeguroIntermedio.AutoSize = true;
            this.rdbSeguroIntermedio.Location = new System.Drawing.Point(265, 22);
            this.rdbSeguroIntermedio.Name = "rdbSeguroIntermedio";
            this.rdbSeguroIntermedio.Size = new System.Drawing.Size(123, 19);
            this.rdbSeguroIntermedio.TabIndex = 4;
            this.rdbSeguroIntermedio.Text = "Seguro Intermedio";
            this.rdbSeguroIntermedio.UseVisualStyleBackColor = true;
            this.rdbSeguroIntermedio.CheckedChanged += new System.EventHandler(this.rdbSeguroIntermedio_CheckedChanged);
            // 
            // rdbSeguroBasico
            // 
            this.rdbSeguroBasico.AutoSize = true;
            this.rdbSeguroBasico.Checked = true;
            this.rdbSeguroBasico.Location = new System.Drawing.Point(71, 22);
            this.rdbSeguroBasico.Name = "rdbSeguroBasico";
            this.rdbSeguroBasico.Size = new System.Drawing.Size(99, 19);
            this.rdbSeguroBasico.TabIndex = 3;
            this.rdbSeguroBasico.TabStop = true;
            this.rdbSeguroBasico.Text = "Seguro Basico";
            this.rdbSeguroBasico.UseVisualStyleBackColor = true;
            this.rdbSeguroBasico.CheckedChanged += new System.EventHandler(this.rdbSeguroBasico_CheckedChanged);
            // 
            // lblMarcaDelVehiculo
            // 
            this.lblMarcaDelVehiculo.AutoSize = true;
            this.lblMarcaDelVehiculo.Location = new System.Drawing.Point(234, 110);
            this.lblMarcaDelVehiculo.Name = "lblMarcaDelVehiculo";
            this.lblMarcaDelVehiculo.Size = new System.Drawing.Size(107, 15);
            this.lblMarcaDelVehiculo.TabIndex = 5;
            this.lblMarcaDelVehiculo.Text = "Marca del vehiculo";
            // 
            // lblModeloDelVehiculo
            // 
            this.lblModeloDelVehiculo.AutoSize = true;
            this.lblModeloDelVehiculo.Location = new System.Drawing.Point(456, 110);
            this.lblModeloDelVehiculo.Name = "lblModeloDelVehiculo";
            this.lblModeloDelVehiculo.Size = new System.Drawing.Size(115, 15);
            this.lblModeloDelVehiculo.TabIndex = 6;
            this.lblModeloDelVehiculo.Text = "Modelo del vehiculo";
            // 
            // epDatoDeLetrasIncorrecto
            // 
            this.epDatoDeLetrasIncorrecto.ContainerControl = this;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(383, 479);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 30);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 521);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblModeloDelVehiculo);
            this.Controls.Add(this.lblMarcaDelVehiculo);
            this.Controls.Add(this.gpbPlanes);
            this.Controls.Add(this.lblAnioDelVehiculo);
            this.Controls.Add(this.txtMarcaDelVehiculo);
            this.Controls.Add(this.txtModeloDelVehiculo);
            this.Controls.Add(this.txtAnioDelVehiculo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Vehiculo";
            this.Load += new System.EventHandler(this.FrmNuevoVehiculo_Load);
            this.gpbPlanes.ResumeLayout(false);
            this.gpbPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnioDelVehiculo;
        private System.Windows.Forms.TextBox txtModeloDelVehiculo;
        private System.Windows.Forms.TextBox txtMarcaDelVehiculo;
        private System.Windows.Forms.Label lblAnioDelVehiculo;
        private System.Windows.Forms.GroupBox gpbPlanes;
        private System.Windows.Forms.RichTextBox rtbInformacionSeguros;
        private System.Windows.Forms.RadioButton rdbSeguroContraTodo;
        private System.Windows.Forms.RadioButton rdbSeguroIntermedio;
        private System.Windows.Forms.RadioButton rdbSeguroBasico;
        private System.Windows.Forms.Label lblMarcaDelVehiculo;
        private System.Windows.Forms.Label lblModeloDelVehiculo;
        private System.Windows.Forms.ErrorProvider epDatoDeLetrasIncorrecto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}