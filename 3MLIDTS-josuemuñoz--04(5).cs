using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3NLIDTS_Josuemuñoz_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombres=tbNombre.Text;
            string apellidos=tbapellido.Text;
            string edad=tbedad.Text;
            string estatura=tbestatura.Text;
            string telefono=tbtelefono.Text;

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked) {
                genero = "Mujer";
            }

            string datos = $"Nombres:{nombres}\r\nApellidos:{apellidos}\r\n" + $"Telefono:{telefono}\r\n" + $"Estatura:{estatura}\r\nEdad:{edad}años\r\n" + $"Género:{genero}";

            string rutaArchivo = "C:\\Users\\Antonio\\Desktop\\universidad\\TERCER semestre\\programacion avanzada\\Visual\\ARCHIVOS CREADOS\\FormularioBasico.txt";
            bool archivoExiste=File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }

                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbapellido.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            tbedad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
