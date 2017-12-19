using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
//Usings necesarios para hacer funcionar la clase StopWatch
using System.Diagnostics;


/* Esquema de nuestra clase a analizar con StopWatch     
 *      +--------------------------------------+
 *      +       Program                        +
 *      +--------------------------------------+
 *      +                                      +
 *      +                                      +
 *      +                                      +
 *      +                                      +
 *      +--------------------------------------+
 *      + +Main(string[] args)                 +
 *      + +FactorialRecursivo(uint) : double   +
 *      + +FactorialIterativo(uint) : double   +
 *      +                                      +
 *      +                                      +
 *      +                                      +
 *      +                                      +
 *      +--------------------------------------+
 */

namespace RendimientoStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cronometro = new Stopwatch();
            uint candidato = 100;
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Medición del método recursivo:");
                Console.WriteLine("==============================");
                cronometro.Restart();
                cronometro.Start();
                Console.WriteLine("El factorial de {0} es {1:E1}", candidato, FactorialRecursivo(candidato));
                cronometro.Stop();
                Console.WriteLine("Tiempo y ticks transcurridos: {0} / {1}", cronometro.Elapsed, cronometro.ElapsedTicks);


                Console.WriteLine("\n\n\n");


                Console.WriteLine("Medición del método iterativo:");
                Console.WriteLine("==============================");
                cronometro.Restart();
                cronometro.Start();
                Console.WriteLine("El factorial de {0} es {1:E1}", candidato, FactorialIterativo(candidato));
                cronometro.Stop();
                Console.WriteLine("Tiempo y ticks transcurridos: {0} / {1}", cronometro.Elapsed, cronometro.ElapsedTicks);
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////");
            } while(tecla.Key != ConsoleKey.Escape);


            Console.ReadKey();


        }

        static double FactorialRecursivo(uint numero)
        {
            if(numero == 0)
                return 1;
            else
                return numero * FactorialRecursivo(numero - 1);
        }

        static double FactorialIterativo(uint numero)
        {
            double auxResultado = 1;

            for(int i = 1; i <= numero; i++)
                auxResultado *= i;

            return auxResultado;
        }


    }
}
