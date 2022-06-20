
namespace WindowsForms
{
    partial class FrmMostrarDatosDelSistema
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
            this.rtbMostrarDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMostrarDatos
            // 
            this.rtbMostrarDatos.Location = new System.Drawing.Point(13, 13);
            this.rtbMostrarDatos.Name = "rtbMostrarDatos";
            this.rtbMostrarDatos.ReadOnly = true;
            this.rtbMostrarDatos.Size = new System.Drawing.Size(1002, 695);
            this.rtbMostrarDatos.TabIndex = 0;
            this.rtbMostrarDatos.Text = "";
            // 
            // FrmMostrarDatosDelSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 720);
            this.Controls.Add(this.rtbMostrarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarDatosDelSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMostrarDatos;
    }
}