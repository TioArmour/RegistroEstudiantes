using System;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class RegistroEstudiantes : Form
    {
        Logica.Funcionalidades funcion = new Funcionalidades();
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form Nombrar = new NombreArchivos();
            Nombrar.ShowDialog();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            cbDocumento.Items.Clear();
            funcion.Directorios(cbDocumento);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                if (nombre != "" && apellido != "" && direccion != "" && (telefono.Length >= 7 && telefono.Length <= 8))
                {
                    nombre = $"Nombre: {nombre}, ";
                    apellido = $"Apellido: {apellido}, ";
                    direccion = $"Direccion: {direccion}, ";
                    telefono = $"Telefono: {telefono}, ";
                    string[] datos = {nombre, apellido, direccion, telefono};
                    funcion.Grabar(cbDocumento.Text, datos);
                }
                else
                {
                    MessageBox.Show("No ha sido posible guardar la información en el documento");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al guardar la información en el documento");
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtInformacion.Clear();
            funcion.MostrarInformacion(txtInformacion, cbDocumento.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
    }
}
