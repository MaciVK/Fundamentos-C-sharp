﻿using System;
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
        public int GetVacaciones()
        {
            Debug.WriteLine("GetVacaciones() Director");
            return 25;
        }
    }
}
