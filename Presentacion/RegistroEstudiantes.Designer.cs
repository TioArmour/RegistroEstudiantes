
namespace Presentacion
{
    partial class RegistroEstudiantes
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
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.lblRegistroEstudiantes = new System.Windows.Forms.Label();
            this.gbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.BackColor = System.Drawing.Color.Beige;
            this.gbDatosPersonales.Controls.Add(this.btnSalir);
            this.gbDatosPersonales.Controls.Add(this.btnLimpiar);
            this.gbDatosPersonales.Controls.Add(this.btnMostrar);
            this.gbDatosPersonales.Controls.Add(this.btnCrear);
            this.gbDatosPersonales.Controls.Add(this.btnGuardar);
            this.gbDatosPersonales.Controls.Add(this.btnExaminar);
            this.gbDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.txtApellido);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.cbDocumento);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.lblDireccion);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.lblDocumento);
            this.gbDatosPersonales.Location = new System.Drawing.Point(34, 60);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(617, 403);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(493, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 29);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(493, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 31);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(493, 217);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 31);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(493, 113);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(105, 31);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear Archivo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(493, 169);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 31);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(493, 60);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(105, 31);
            this.btnExaminar.TabIndex = 13;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 292);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(316, 22);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 241);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(316, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 180);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(316, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(155, 64);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(316, 24);
            this.cbDocumento.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(46, 295);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefóno :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(46, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(46, 244);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 17);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(46, 67);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(88, 17);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento :";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(666, 60);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(273, 403);
            this.txtInformacion.TabIndex = 1;
            // 
            // lblRegistroEstudiantes
            // 
            this.lblRegistroEstudiantes.AutoSize = true;
            this.lblRegistroEstudiantes.Location = new System.Drawing.Point(399, 9);
            this.lblRegistroEstudiantes.Name = "lblRegistroEstudiantes";
            this.lblRegistroEstudiantes.Size = new System.Drawing.Size(203, 17);
            this.lblRegistroEstudiantes.TabIndex = 2;
            this.lblRegistroEstudiantes.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 485);
            this.Controls.Add(this.lblRegistroEstudiantes);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.gbDatosPersonales);
            this.Name = "RegistroEstudiantes";
            this.Text = "Form1";
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblRegistroEstudiantes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnSalir;
    }
}

