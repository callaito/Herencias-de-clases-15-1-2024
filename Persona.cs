using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias_de_clases_15_1_2024
{
    public class Persona
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"nombre: {nombre}");
            Console.WriteLine($"dirección: {direccion}");
            Console.WriteLine($"correo: {correo}");
        }
    }
}




