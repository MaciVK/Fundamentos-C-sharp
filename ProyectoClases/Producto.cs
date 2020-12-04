﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Producto
    {
        public Producto()
        {

        }
        public Producto(string name, int price)
        {
            this.Nombre = name;
            this.Precio = price;
        }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public string GetProducto()
        {
            return (this.Nombre+", "+this.Precio+"€");
        }
        public string GetSaveProducto()
        {
            return (this.Nombre + "," + this.Precio);
        }
        public string GetNombre()
        {
            return this.Nombre;
        }
        public int GetPrecio()
        {
            return this.Precio;
        }
    }
}
