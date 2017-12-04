using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetedoPrimosRaiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(esPrimo2(987654321));
            Console.ReadKey();
        }

        private static Boolean esPrimo(Int32 numero)
        {
            if(numero < 2)
                return false;
            if(numero < 4)
                return true;

            int i = 2;
            while(i <= Math.Sqrt(numero) && numero % i != 0)
                i++;

            return (i>= Math.Sqrt(numero));
        }

        private static Boolean esPrimo2(Int32 numero)
        {
            Boolean factorEncontrado = false;

            if(numero < 2)
                return false;
            if(numero < 4)
                return true;

            Int32 i = 2;
            while(i <= Math.Sqrt(numero) && !factorEncontrado)
            {
                factorEncontrado = (numero % i == 0);
                i++;
            }

            return (i >= Math.Sqrt(numero));
        }
    }
}
