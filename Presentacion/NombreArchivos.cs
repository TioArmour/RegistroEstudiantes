using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class NombreArchivos : Form
    {
        Logica.Funcionalidades funcion = new Logica.Funcionalidades(); //Mediante esta linea de codigo instanciamos un objeto para interactuar con las clases de logica
        public NombreArchivos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NombreArchivos_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            funcion.CrearArchivo(txtNombreArchivo.Text);
        }
    }
}
