using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorizar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pablo0 = new Persona(0, "Pablo #0");
            Persona jm = new Persona(1, "Er Jozemi");
            Persona em = new Persona(2, "Er Mario");

            Proyecto alambrarCortijo = new Proyecto("Alambrar el cortijo del Tío Antonio", 2300);

            if(!alambrarCortijo.AgregarParticipante(jm))
                Console.WriteLine("No se puede añadir participante");

            if(!alambrarCortijo.AgregarParticipante(em))
                Console.WriteLine("No se puede añadir participante");

            Console.WriteLine("Datos del proyecto:");
            Console.WriteLine(alambrarCortijo.ToString());

            Console.ReadLine();
        }
    }
}
