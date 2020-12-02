using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }
        //OVERRIDEN
        public new int GetVacaciones()
        {
            Debug.WriteLine("GetVacaciones() new de Director");
            return base.GetVacaciones() + 3;
        }

        //public override int GetVacaciones()
        //{
        //    Debug.WriteLine("GetVacaciones() Overriden de Director");
        //    return base.GetVacaciones()+3;
        //}
        //OVERLOAD
        public int GetVacaciones(int diasExtra)
        {
            Debug.WriteLine("GetVacaciones() Director");
            return GetVacaciones() + diasExtra;
        }
    }
}
