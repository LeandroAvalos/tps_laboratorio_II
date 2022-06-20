
namespace WindowsForms
{
    partial class FrmChequeoDeDatos
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
            this.lblDatoAPedir = new System.Windows.Forms.Label();
            this.txtDatoAPedir = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatoAPedir
            // 
            this.lblDatoAPedir.AutoSize = true;
            this.lblDatoAPedir.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatoAPedir.Location = new System.Drawing.Point(23, 27);
            this.lblDatoAPedir.Name = "lblDatoAPedir";
            this.lblDatoAPedir.Size = new System.Drawing.Size(108, 23);
            this.lblDatoAPedir.TabIndex = 0;
            this.lblDatoAPedir.Text = "Dato a pedir";
            // 
            // txtDatoAPedir
            // 
            this.txtDatoAPedir.Location = new System.Drawing.Point(23, 75);
            this.txtDatoAPedir.MaxLength = 20;
            this.txtDatoAPedir.Name = "txtDatoAPedir";
            this.txtDatoAPedir.Size = new System.Drawing.Size(364, 23);
            this.txtDatoAPedir.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 122);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 27);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 27);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmChequeoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDatoAPedir);
            this.Controls.Add(this.lblDatoAPedir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmChequeoDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dato a pedir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatoAPedir;
        private System.Windows.Forms.TextBox txtDatoAPedir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}