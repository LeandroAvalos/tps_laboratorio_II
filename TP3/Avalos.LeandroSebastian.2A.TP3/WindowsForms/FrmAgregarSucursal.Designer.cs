
namespace WindowsForms
{
    partial class FrmAgregarSucursal
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
            this.lblAgregarSucursal = new System.Windows.Forms.Label();
            this.txtBarrioDeLaSucursal = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCodigoDeLaSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCodigoDeSucursal = new System.Windows.Forms.Label();
            this.cmbAbiertoDe = new System.Windows.Forms.ComboBox();
            this.cmbAbiertoHasta = new System.Windows.Forms.ComboBox();
            this.cmbHorarioApertura = new System.Windows.Forms.ComboBox();
            this.lblAbiertoDe = new System.Windows.Forms.Label();
            this.lblAbiertoHasta = new System.Windows.Forms.Label();
            this.lblHorarioDe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHorarioCierre = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.epDatoDeLetrasIncorrecto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarSucursal
            // 
            this.lblAgregarSucursal.AutoSize = true;
            this.lblAgregarSucursal.Font = new System.Drawing.Font("Sitka Display Semibold", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAgregarSucursal.Location = new System.Drawing.Point(176, 51);
            this.lblAgregarSucursal.Name = "lblAgregarSucursal";
            this.lblAgregarSucursal.Size = new System.Drawing.Size(242, 47);
            this.lblAgregarSucursal.TabIndex = 0;
            this.lblAgregarSucursal.Text = "Agregar sucursal";
            // 
            // txtBarrioDeLaSucursal
            // 
            this.txtBarrioDeLaSucursal.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtBarrioDeLaSucursal.Location = new System.Drawing.Point(66, 149);
            this.txtBarrioDeLaSucursal.MaxLength = 20;
            this.txtBarrioDeLaSucursal.Name = "txtBarrioDeLaSucursal";
            this.txtBarrioDeLaSucursal.Size = new System.Drawing.Size(195, 31);
            this.txtBarrioDeLaSucursal.TabIndex = 0;
            this.txtBarrioDeLaSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(351, 149);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 31);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterNumerico_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxTelefono);
            this.txtTelefono.Validated += new System.EventHandler(this.validado_TextBoxTelefono);
            // 
            // txtCodigoDeLaSucursal
            // 
            this.txtCodigoDeLaSucursal.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCodigoDeLaSucursal.Location = new System.Drawing.Point(351, 244);
            this.txtCodigoDeLaSucursal.MaxLength = 5;
            this.txtCodigoDeLaSucursal.Name = "txtCodigoDeLaSucursal";
            this.txtCodigoDeLaSucursal.Size = new System.Drawing.Size(195, 31);
            this.txtCodigoDeLaSucursal.TabIndex = 3;
            this.txtCodigoDeLaSucursal.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxesDeNumerosYTexto);
            this.txtCodigoDeLaSucursal.Validated += new System.EventHandler(this.validados_TextBoxesDeNumerosYTexto);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(66, 244);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(195, 31);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.validar_TextBoxesDeNumerosYTexto);
            this.txtDireccion.Validated += new System.EventHandler(this.validados_TextBoxesDeNumerosYTexto);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(66, 117);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(112, 15);
            this.lblBarrio.TabIndex = 5;
            this.lblBarrio.Text = "Barrio de la sucursal";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(351, 117);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblNumeroTelefono.TabIndex = 6;
            this.lblNumeroTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(66, 216);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCodigoDeSucursal
            // 
            this.lblCodigoDeSucursal.AutoSize = true;
            this.lblCodigoDeSucursal.Location = new System.Drawing.Point(351, 216);
            this.lblCodigoDeSucursal.Name = "lblCodigoDeSucursal";
            this.lblCodigoDeSucursal.Size = new System.Drawing.Size(120, 15);
            this.lblCodigoDeSucursal.TabIndex = 8;
            this.lblCodigoDeSucursal.Text = "Codigo de la sucursal";
            // 
            // cmbAbiertoDe
            // 
            this.cmbAbiertoDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbiertoDe.FormattingEnabled = true;
            this.cmbAbiertoDe.Location = new System.Drawing.Point(66, 354);
            this.cmbAbiertoDe.Name = "cmbAbiertoDe";
            this.cmbAbiertoDe.Size = new System.Drawing.Size(92, 23);
            this.cmbAbiertoDe.TabIndex = 4;
            // 
            // cmbAbiertoHasta
            // 
            this.cmbAbiertoHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbiertoHasta.FormattingEnabled = true;
            this.cmbAbiertoHasta.Location = new System.Drawing.Point(203, 354);
            this.cmbAbiertoHasta.Name = "cmbAbiertoHasta";
            this.cmbAbiertoHasta.Size = new System.Drawing.Size(92, 23);
            this.cmbAbiertoHasta.TabIndex = 5;
            // 
            // cmbHorarioApertura
            // 
            this.cmbHorarioApertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioApertura.FormattingEnabled = true;
            this.cmbHorarioApertura.Location = new System.Drawing.Point(351, 354);
            this.cmbHorarioApertura.Name = "cmbHorarioApertura";
            this.cmbHorarioApertura.Size = new System.Drawing.Size(53, 23);
            this.cmbHorarioApertura.TabIndex = 6;
            // 
            // lblAbiertoDe
            // 
            this.lblAbiertoDe.AutoSize = true;
            this.lblAbiertoDe.Location = new System.Drawing.Point(66, 323);
            this.lblAbiertoDe.Name = "lblAbiertoDe";
            this.lblAbiertoDe.Size = new System.Drawing.Size(68, 15);
            this.lblAbiertoDe.TabIndex = 13;
            this.lblAbiertoDe.Text = "Abierto de..";
            // 
            // lblAbiertoHasta
            // 
            this.lblAbiertoHasta.AutoSize = true;
            this.lblAbiertoHasta.Location = new System.Drawing.Point(203, 323);
            this.lblAbiertoHasta.Name = "lblAbiertoHasta";
            this.lblAbiertoHasta.Size = new System.Drawing.Size(83, 15);
            this.lblAbiertoHasta.TabIndex = 14;
            this.lblAbiertoHasta.Text = "Abierto hasta..";
            // 
            // lblHorarioDe
            // 
            this.lblHorarioDe.AutoSize = true;
            this.lblHorarioDe.Location = new System.Drawing.Point(351, 323);
            this.lblHorarioDe.Name = "lblHorarioDe";
            this.lblHorarioDe.Size = new System.Drawing.Size(53, 15);
            this.lblHorarioDe.TabIndex = 15;
            this.lblHorarioDe.Text = "Apertura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cierre";
            // 
            // cmbHorarioCierre
            // 
            this.cmbHorarioCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioCierre.FormattingEnabled = true;
            this.cmbHorarioCierre.Location = new System.Drawing.Point(465, 354);
            this.cmbHorarioCierre.Name = "cmbHorarioCierre";
            this.cmbHorarioCierre.Size = new System.Drawing.Size(53, 23);
            this.cmbHorarioCierre.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(351, 460);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // brnCancelar
            // 
            this.brnCancelar.Location = new System.Drawing.Point(487, 460);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(110, 33);
            this.brnCancelar.TabIndex = 9;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // epDatoDeLetrasIncorrecto
            // 
            this.epDatoDeLetrasIncorrecto.ContainerControl = this;
            // 
            // FrmAgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 502);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbHorarioCierre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHorarioDe);
            this.Controls.Add(this.lblAbiertoHasta);
            this.Controls.Add(this.lblAbiertoDe);
            this.Controls.Add(this.cmbHorarioApertura);
            this.Controls.Add(this.cmbAbiertoHasta);
            this.Controls.Add(this.cmbAbiertoDe);
            this.Controls.Add(this.lblCodigoDeSucursal);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigoDeLaSucursal);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtBarrioDeLaSucursal);
            this.Controls.Add(this.lblAgregarSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAgregarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Sucursal";
            this.Load += new System.EventHandler(this.FrmAgregarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epDatoDeLetrasIncorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarSucursal;
        private System.Windows.Forms.TextBox txtBarrioDeLaSucursal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodigoDeLaSucursal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCodigoDeSucursal;
        private System.Windows.Forms.ComboBox cmbAbiertoDe;
        private System.Windows.Forms.ComboBox cmbAbiertoHasta;
        private System.Windows.Forms.ComboBox cmbHorarioApertura;
        private System.Windows.Forms.Label lblAbiertoDe;
        private System.Windows.Forms.Label lblAbiertoHasta;
        private System.Windows.Forms.Label lblHorarioDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHorarioCierre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.ErrorProvider epDatoDeLetrasIncorrecto;
    }
}