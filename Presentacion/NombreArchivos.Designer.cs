
namespace Presentacion
{
    partial class NombreArchivos
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
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(36, 56);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(140, 17);
            this.lblNombreArchivo.TabIndex = 0;
            this.lblNombreArchivo.Text = "Nombre del Archivo: ";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(182, 53);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(274, 22);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(182, 98);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(75, 29);
            this.btnCrearArchivo.TabIndex = 2;
            this.btnCrearArchivo.Text = "Crear";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(381, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // NombreArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 148);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.lblNombreArchivo);
            this.Name = "NombreArchivos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.NombreArchivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Button btnSalir;
    }
}