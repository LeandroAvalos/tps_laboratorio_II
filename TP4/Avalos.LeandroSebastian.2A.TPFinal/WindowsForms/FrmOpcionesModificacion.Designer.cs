
namespace WindowsForms
{
    partial class FrmOpcionesModificacion
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
            this.btnModificarNombre = new System.Windows.Forms.Button();
            this.btnModificarApellido = new System.Windows.Forms.Button();
            this.btnModificarTelefono = new System.Windows.Forms.Button();
            this.btnModificarDomicilio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambiarDeVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarNombre
            // 
            this.btnModificarNombre.Location = new System.Drawing.Point(48, 36);
            this.btnModificarNombre.Name = "btnModificarNombre";
            this.btnModificarNombre.Size = new System.Drawing.Size(197, 44);
            this.btnModificarNombre.TabIndex = 0;
            this.btnModificarNombre.Text = "Modificar nombre";
            this.btnModificarNombre.UseVisualStyleBackColor = true;
            this.btnModificarNombre.Click += new System.EventHandler(this.btnModificarNombre_Click);
            // 
            // btnModificarApellido
            // 
            this.btnModificarApellido.Location = new System.Drawing.Point(48, 110);
            this.btnModificarApellido.Name = "btnModificarApellido";
            this.btnModificarApellido.Size = new System.Drawing.Size(197, 44);
            this.btnModificarApellido.TabIndex = 1;
            this.btnModificarApellido.Text = "Modificar Apellido";
            this.btnModificarApellido.UseVisualStyleBackColor = true;
            this.btnModificarApellido.Click += new System.EventHandler(this.btnModificarApellido_Click);
            // 
            // btnModificarTelefono
            // 
            this.btnModificarTelefono.Location = new System.Drawing.Point(48, 187);
            this.btnModificarTelefono.Name = "btnModificarTelefono";
            this.btnModificarTelefono.Size = new System.Drawing.Size(197, 44);
            this.btnModificarTelefono.TabIndex = 2;
            this.btnModificarTelefono.Text = "Modificar telefono";
            this.btnModificarTelefono.UseVisualStyleBackColor = true;
            this.btnModificarTelefono.Click += new System.EventHandler(this.btnModificarTelefono_Click);
            // 
            // btnModificarDomicilio
            // 
            this.btnModificarDomicilio.Location = new System.Drawing.Point(48, 259);
            this.btnModificarDomicilio.Name = "btnModificarDomicilio";
            this.btnModificarDomicilio.Size = new System.Drawing.Size(197, 44);
            this.btnModificarDomicilio.TabIndex = 3;
            this.btnModificarDomicilio.Text = "Modificar domicilio";
            this.btnModificarDomicilio.UseVisualStyleBackColor = true;
            this.btnModificarDomicilio.Click += new System.EventHandler(this.btnModificarDomicilio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarDeVehiculo
            // 
            this.btnCambiarDeVehiculo.Location = new System.Drawing.Point(48, 329);
            this.btnCambiarDeVehiculo.Name = "btnCambiarDeVehiculo";
            this.btnCambiarDeVehiculo.Size = new System.Drawing.Size(197, 44);
            this.btnCambiarDeVehiculo.TabIndex = 4;
            this.btnCambiarDeVehiculo.Text = "Cambio de vehiculo";
            this.btnCambiarDeVehiculo.UseVisualStyleBackColor = true;
            this.btnCambiarDeVehiculo.Click += new System.EventHandler(this.btnCambiarDeVehiculo_Click);
            // 
            // FrmOpcionesModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 473);
            this.Controls.Add(this.btnCambiarDeVehiculo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarDomicilio);
            this.Controls.Add(this.btnModificarTelefono);
            this.Controls.Add(this.btnModificarApellido);
            this.Controls.Add(this.btnModificarNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpcionesModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de modificaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarNombre;
        private System.Windows.Forms.Button btnModificarApellido;
        private System.Windows.Forms.Button btnModificarTelefono;
        private System.Windows.Forms.Button btnModificarDomicilio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambiarDeVehiculo;
    }
}