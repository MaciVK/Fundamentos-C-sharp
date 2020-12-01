using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        #region Constructores Empleado
        public Empleado():base()
        {
            Debug.WriteLine("Constructor empleado");
            this.SalarioMinimo = 1000;
        }
        public Empleado(string name, string surname):base(name,surname)
        {
            Debug.WriteLine("Constructor Empleado con params");
            this.Nombre = name;
            this.Apellido = surname;
        }
        #endregion
        #region Propiedades Empleado
        protected int SalarioMinimo { get; set; }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        #endregion

    }
}
