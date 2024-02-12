using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias_de_clases_15_1_2024

{
    class Profesor : Persona
    {
        public string asignatura { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"asignatura: {asignatura}");
        }
    }
}