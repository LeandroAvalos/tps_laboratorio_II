
namespace WindowsForms
{
    partial class FrmMenuSucursales
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
            this.btnVerSucursales = new System.Windows.Forms.Button();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerSucursales
            // 
            this.btnVerSucursales.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnVerSucursales.Location = new System.Drawing.Point(38, 35);
            this.btnVerSucursales.Name = "btnVerSucursales";
            this.btnVerSucursales.Size = new System.Drawing.Size(172, 55);
            this.btnVerSucursales.TabIndex = 0;
            this.btnVerSucursales.Text = "Ver sucursales";
            this.btnVerSucursales.UseVisualStyleBackColor = true;
            this.btnVerSucursales.Click += new System.EventHandler(this.btnVerSucursales_Click);
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAgregarSucursal.Location = new System.Drawing.Point(38, 122);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(172, 55);
            this.btnAgregarSucursal.TabIndex = 1;
            this.btnAgregarSucursal.Text = "Agregar sucursal";
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Sitka Display Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(38, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenuSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarSucursal);
            this.Controls.Add(this.btnVerSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMenuSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Sucursales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerSucursales;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.Button btnSalir;
    }
}