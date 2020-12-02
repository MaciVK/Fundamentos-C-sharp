using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form27LeerFicherosPlanos : Form
    {
        public Form27LeerFicherosPlanos()
        {
            InitializeComponent();
        }

        private async void  btnGuardarFichero_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //Todos devuelven una respuesta: DialogResult, que nos la da el metodo ShowDialog()
            //ShowDialog()-->DialogResult
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                //Devuelve la ruta de acceso al fichero
                String path = save.FileName;
                //La clase FileInfo sirve para manejar CUALQUIER tipo de archivo
                FileInfo fichero = new FileInfo(path);
                //A partir de FileInfo podemos crear OBJETOS para leer bytes o plain text
                //Para usarlo como texto plano tenemos fichero.CreateText, de la clase TextWriter
                //Vamos a usar Using para crear el objeto, utilizarlo, y destruirlo a la vez
                using (TextWriter writer = fichero.CreateText())
                {
                    //ESCRIBIR
                    //writer.Write(this.txtTexto.Text);
                    await writer.WriteAsync(this.GetStringNombres());
                    //Al escribir hay que LIBERAR el flujo de memoria y CERRAR el fichero
                    writer.Flush();
                    writer.Close();
                }
                this.lstNombres.Items.Clear();
                this.txtTexto.Text = "";
            }
        }

        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using(TextReader reader = file.OpenText())
                {
                    string contenido = await reader.ReadToEndAsync();
                    this.SetStringNombre(contenido);
                    reader.Close();
                    this.txtTexto.Text = contenido;

                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.Text = "";
            this.txtNombre.Focus();
        }

        //Guardaremos los items de texto como una sola cadena con separadores ','

        public string GetStringNombres()
        {
            string datos = "";
            foreach(string nombre in this.lstNombres.Items)
            {
                datos += nombre + ',';
            }
            datos = datos.Trim(',');
            return datos;
        }
        public void SetStringNombre(string datos)
        {
            //datos recibe los nombres que hemos guardado en el fichero
            string[] nombres=datos.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }
    }
}
