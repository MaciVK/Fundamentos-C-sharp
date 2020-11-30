using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Persona
    {
        #region Propiedades
        //Todo lo que pongamos aqui, lo podremos desplegar/colapsar
        /*
         * Campos de la clase:
             Un campo suele ser privado, y una herramienta de clase (es una variable)
            Modificadores de acceso Tiene que ver con la encapsulacion:
                -Public y Private
         */
        // public string Nombre;
        //public int Edad;
        //En Visual Studio no se crean campos accesibles, se crean siempre propiedades
        //Una propiedad es un campo con un codigo, donde nos permite controlar elementos de codigo
        //(GETTER & SETTER)
        //Sintaxis:
        //Las propiedades son SIEMPRE publicas si quiero dejar que se acceda a ellas
        ////public TipoDato NombrePropiedad
        ////{
        ////    get { return valor; }
        ////    set { /*Tenemos VALUE para recuperar el dato*/ }
        ////}
        //Las propiedades tienen siempre un campo de control: _Propiedad
        //Este es el campo de la propiedad
        //Cuando cambias la propiedad, no se cambia de por si, sino el campo de control
        private String _Nombre;

        public string Nombre
        {
            get
            {
                //Devolvemos un valor
                return this._Nombre;
            }
            set
            {
                //Establecemos un valor
                this._Nombre = value;
            }
        }
        //Campo de la propiedad
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //Tenemos un codigo para controlar los valores asignaos a la propiedad
                if (value < 0)
                {
                    //Valor por defecto si no cumple nuestros requisitos
                    //Error silencioso
                    //this._Edad = 0;
                    //Si queremos una excepcion en concreto:
                    //throw new TipoDeExcepcion
                    throw new Exception("Edad Negativa: " + value);
                }
                else
                {
                    this._Edad = value;
                }

            }
        }

        #endregion
    }
}
