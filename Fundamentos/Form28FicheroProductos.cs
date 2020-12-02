using ProyectoClases;
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
    public partial class Form28FicheroProductos : Form
    {
        List<Producto> productos;
        public Form28FicheroProductos()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.TextLength != 0 && this.txtPrecio.TextLength != 0)
            {
                string nombreProducto = this.txtNombre.Text;
                int precio = int.Parse(this.txtPrecio.Text);
                Producto prod = new Producto(nombreProducto, precio);
                this.productos.Add(prod);
                this.lstProductos.Items.Add(prod.GetProducto());
                this.txtNombre.Clear();
                this.txtPrecio.Clear();
                this.txtNombre.Focus();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                string path = save.FileName;
                FileInfo fichero = new FileInfo(path);
                using (TextWriter escritor = fichero.CreateText())
                {
                    await escritor.WriteAsync(this.GetStringProductos());
                    escritor.Flush();
                    escritor.Close();
                }
            }
            this.lstProductos.Items.Clear();
            this.productos.Clear();
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";

        }
        public string GetStringProductos()
        {
            string datos = "";
            foreach (Producto prod in this.productos)
            {
                datos += prod.GetSaveProducto() + ";";
            }
            datos = datos.Trim(';');
            Debug.WriteLine(datos);

            this.lstProductos.Items.Clear();

            return datos;
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            this.lstProductos.Items.Clear();
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                string path = open.FileName;
                FileInfo fichero = new FileInfo(path);
                using (TextReader lector = fichero.OpenText())
                {
                    string contenido = await lector.ReadToEndAsync();
                    this.CargarProductos(contenido);
                    lector.Close();

                }
                this.lblProducto.Text = "Producto 0 de " + (this.productos.Count);
            }
        }
        public void CargarProductos(string datos)
        {
            this.productos.Clear();
            this.lstProductos.Items.Clear();
            string[] prods = datos.Split(';');
            foreach (String producto in prods)
            {
                string[] precioNombre = producto.Split(',');
                string nombre = precioNombre[0];
                int precio = int.Parse(precioNombre[1]);
                Producto prod = new Producto(nombre, precio);
                this.productos.Add(prod);
                this.lstProductos.Items.Add(prod.GetProducto());
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstProductos.SelectedIndex;
            this.lblProducto.Text = "Producto " + (indice + 1) + " de " + (this.productos.Count);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.productos[0].GetNombre();
            this.txtPrecio.Text = this.productos[0].GetPrecio().ToString();
            this.lstProductos.SetSelected(0, true);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.productos[this.productos.Count - 1].GetNombre();
            this.txtPrecio.Text = this.productos[this.productos.Count - 1].GetPrecio().ToString();
            this.lstProductos.SetSelected(this.lstProductos.Items.Count - 1, true);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != 0&& this.lstProductos.SelectedIndex != -1)
            {
                int index = this.lstProductos.SelectedIndex - 1;
                this.lstProductos.SelectedIndex = index;
                this.txtNombre.Text = this.productos[index].GetNombre();
                this.txtPrecio.Text = this.productos[index].GetPrecio().ToString();
            }
            if(this.lstProductos.SelectedIndex == -1)
            {
                this.txtNombre.Text = this.productos[0].GetNombre();
                this.txtPrecio.Text = this.productos[0].GetPrecio().ToString();
                this.lstProductos.SetSelected(0, true);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != this.lstProductos.Items.Count-1)
            {
                int index = this.lstProductos.SelectedIndex + 1;
                this.lstProductos.SelectedIndex = index;
                this.txtNombre.Text = this.productos[index].GetNombre();
                this.txtPrecio.Text = this.productos[index].GetPrecio().ToString();

            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }
    }
}
