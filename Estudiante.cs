using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias_de_clases_15_1_2024

{
    public class Estudiante : Persona

    {

        public string carrera { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"carrera: {carrera}");
        }
    }
}
