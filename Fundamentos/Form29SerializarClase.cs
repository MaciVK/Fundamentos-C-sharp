using ProyectoClases;
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
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form29SerializarClase : Form
    {
        XmlSerializer serializador;
        public Form29SerializarClase()
        {
            InitializeComponent();
            //Cuando instanciemos el objeto, indicaremos la clase que almacenaremos
            //Type
            this.serializador = new XmlSerializer(typeof(Producto));
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            Producto product = new Producto();
            product.Nombre = this.txtNombre.Text;
            product.Precio = int.Parse(this.txtPrecio.Text);
            //Para serializar se usa System.IO ya la clase streamreader, ya que lo hacemos con ficheros
            //Si no definimos la ruta, lo guarda donde esté el ensamblado
            StreamWriter writer = new StreamWriter("Producto.xml");
            //Con el metodo SERIALIZE almacenamos un objeto de la clase, y genera un fichero xml con el producto
            //El writer es el vehiculo para escribir el fichero
            this.serializador.Serialize(writer, product);
            await writer.FlushAsync();
            writer.Close();
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.lblInfo.Text = "Datos guardados";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader("Producto.xml");
            //La deserializacion es AUTOMATICA: Le pasamos el reader y nos devuelve el objeto ya instanciado
            //Utilizamos el metodo Deserialize
            Producto producto = (Producto)this.serializador.Deserialize(lector);
            lector.Close();
            this.txtNombre.Text = producto.GetNombre();
            this.txtPrecio.Text = producto.GetPrecio().ToString();
            this.lblInfo.Text = "Producto leido";

        }
    }
}
