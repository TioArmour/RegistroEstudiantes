using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Funcionalidades
    {
        public void CrearArchivo(string nombreArchivo)
        {
            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\RegistroEstudiantes\Archivos\" + nombreArchivo + ".txt";
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta);
                    MessageBox.Show("El archivo se ha creado con éxito");
                }
                else
                {
                    MessageBox.Show("No se ha podido crear el archivo porque ya existe un archivo con ese nombre");
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido crear el archivo");
            }
        }

        public void Directorios(ComboBox lista)
        {
            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\RegistroEstudiantes\Archivos";
            try
            {
                var files = from retrievedFile in Directory.GetFiles(ruta, "*.txt", SearchOption.AllDirectories)
                            select new
                            {
                                File = retrievedFile
                            };
                foreach(var file in files)
                {
                    lista.Items.Add(file.File);
                }
            }
            catch
            {
                MessageBox.Show("No ha sido posible encontar los archivos.");
            }
        }

        public void Grabar(string ruta, string[] informacion)
        {
            try
            {
                //Abrimos el archivo para escribir informacion
                using(StreamWriter files = new StreamWriter(ruta, true))
                {
                    foreach(string dato in informacion)
                    {
                        files.Write(dato);
                    }
                }
                MessageBox.Show("Se ha guardado la información con éxito.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la información" + $" El error es: {Ex.Message}");
            }
        }

        public void MostrarInformacion(TextBox almacen, string ruta)
        {
            using(StreamReader sr = new StreamReader(ruta, Encoding.Default))
            {
                string texto = sr.ReadToEnd();
                sr.Close();
                almacen.Text = texto;
            }
        }
    }
}
