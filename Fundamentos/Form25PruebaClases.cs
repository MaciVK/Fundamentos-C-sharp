using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;


namespace Fundamentos
{
    public partial class Form25PruebaClases : Form
    {
        public Form25PruebaClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            //TODA CLASE SE DEBE INSTANCIAR
            Persona person=new Persona();
            person.Nombre = "Gabri";
            person.Edad = -23;
            this.lstDatos.Items.Add("Nombre: " + person.Nombre);
            this.lstDatos.Items.Add("Edad: " + person.Edad);

        }
    }
}
