using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Nº4._1er_Año
{
    internal class Usuario
    {
        //Defino mis propiedades para el traslado de la Informacion
        public string nombre { get; set; }
        public int edad { get; set; }

        //Metodo. Es para concatenar los datos del Nombre y la Edad
        public string cadena(string nombre, int edad)
        {
            return nombre + "-" + edad;
        }
          

    }
}
