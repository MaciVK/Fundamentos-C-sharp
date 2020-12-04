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
using System.Xml.Serialization;
using ProyectoClases;
namespace Fundamentos
{
    public partial class Form30SerializacionCoches : Form
    {
        XmlSerializer serializer;
        Coches coches;
        public Form30SerializacionCoches()
        {
            InitializeComponent();
            this.coches = new Coches();
            this.serializer = new XmlSerializer(typeof(Coches));
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (this.txtMarca.Text != "" && this.txtModelo.Text != "" && this.ptbImagen.Image != null)
            {
                Coche coche = new Coche();
                coche.Marca = this.txtMarca.Text;
                coche.Modelo = this.txtModelo.Text;
                coche.Image = this.ConvertirImagenToByteArray(this.ptbImagen.Image);
                this.lstCoches.Items.Add(coche.Marca);
                this.coches.Add(coche);
                this.txtMarca.Text = "";
                this.txtModelo.Text = "";
                this.ptbImagen.Image = null;
                this.txtMarca.Focus();
            }
        }

        private byte[] ConvertirImagenToByteArray(Image img)
        {
            ImageConverter conversor = new ImageConverter();
            byte[] ImagenByteArray = (byte[])conversor.ConvertTo(img, typeof(byte[]));
            return ImagenByteArray;
        }
        private Image ConvertirByteArrayToImagen(byte[] arrayBytes)
        {
            ImageConverter conversor = new ImageConverter();
            Image imagen = (Image)conversor.ConvertFrom(arrayBytes);
            return imagen;
        }
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult resultado = open.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string path = open.FileName;
                this.ptbImagen.Image = Image.FromFile(open.FileName);
            }
         
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter escritor = new StreamWriter("Coches.xml");
            this.serializer.Serialize(escritor, this.coches);
            await escritor.FlushAsync();
            escritor.Close(); this.lstCoches.Items.Clear();
            this.coches.Clear();
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.ptbImagen.Image = null;

        }

        private void btnCargarCoches_Click(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader("Coches.xml");
            this.coches.Clear();
            this.coches = (Coches)serializer.Deserialize(lector);
            lector.Close();
            this.PintarCoches();
        }
        private void PintarCoches()
        {
            this.lstCoches.Items.Clear();
            foreach (Coche coche in this.coches)
            {
                this.lstCoches.Items.Add(coche.Marca);
            }
        }

        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstCoches.SelectedIndex;
            this.txtMarca.Text = this.coches[index].Marca;
            this.txtModelo.Text = this.coches[index].Modelo;
            this.ptbImagen.Image = this.ConvertirByteArrayToImagen(this.coches[index].Image);
        }
    }
}
