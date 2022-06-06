
namespace WindowsForms
{
    partial class FrmBuenaVidaSeguros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnClientesActivos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistorialDeActividades = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnAltaCliente.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnAltaCliente.Location = new System.Drawing.Point(12, 85);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(126, 65);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnBajaCliente.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBajaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBajaCliente.Location = new System.Drawing.Point(12, 258);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(126, 65);
            this.btnBajaCliente.TabIndex = 2;
            this.btnBajaCliente.Text = "Baja Cliente";
            this.btnBajaCliente.UseVisualStyleBackColor = false;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnModificarCliente.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(12, 172);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(126, 65);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnClientesActivos
            // 
            this.btnClientesActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnClientesActivos.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClientesActivos.ForeColor = System.Drawing.Color.White;
            this.btnClientesActivos.Location = new System.Drawing.Point(12, 347);
            this.btnClientesActivos.Name = "btnClientesActivos";
            this.btnClientesActivos.Size = new System.Drawing.Size(126, 65);
            this.btnClientesActivos.TabIndex = 3;
            this.btnClientesActivos.Text = "Clientes Activos";
            this.btnClientesActivos.UseVisualStyleBackColor = false;
            this.btnClientesActivos.Click += new System.EventHandler(this.btnClientesActivos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnSalir.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 601);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 65);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsForms.Properties.Resources.logo;
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnHistorialDeActividades
            // 
            this.btnHistorialDeActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnHistorialDeActividades.Font = new System.Drawing.Font("Sitka Display Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialDeActividades.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistorialDeActividades.Location = new System.Drawing.Point(12, 516);
            this.btnHistorialDeActividades.Name = "btnHistorialDeActividades";
            this.btnHistorialDeActividades.Size = new System.Drawing.Size(126, 65);
            this.btnHistorialDeActividades.TabIndex = 5;
            this.btnHistorialDeActividades.Text = "Historial de actividades";
            this.btnHistorialDeActividades.UseVisualStyleBackColor = false;
            this.btnHistorialDeActividades.Click += new System.EventHandler(this.btnHistorialDeActividades_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(135)))), ((int)(((byte)(207)))));
            this.btnSucursales.Font = new System.Drawing.Font("Sitka Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSucursales.ForeColor = System.Drawing.Color.Transparent;
            this.btnSucursales.Location = new System.Drawing.Point(12, 430);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(126, 65);
            this.btnSucursales.TabIndex = 4;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // FrmBuenaVidaSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.Sin_título;
            this.ClientSize = new System.Drawing.Size(1024, 667);
            this.Controls.Add(this.btnSucursales);
            this.Controls.Add(this.btnHistorialDeActividades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClientesActivos);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnBajaCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuenaVidaSeguros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Buena Vida Seguros";
            this.Load += new System.EventHandler(this.FrmBuenaVidaSeguros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnClientesActivos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistorialDeActividades;
        private System.Windows.Forms.Button btnSucursales;
    }
}

