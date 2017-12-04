using System;

namespace DebugPasoAPaso
{
    class PasoAPaso
    {
        private static string[] colores = { "rojo", "naranja", "amarillo", "verde", "azul", "violeta" };
        static void Main(string[] args)
        {
             Console.WriteLine("El array colores es de longitud {0}", colores.Length); // Ver la longitud del array

            PrintArrayFor();

            Console.WriteLine("Y ahora igual pero con foreach");

            PrintArrayForeach();

            Console.WriteLine("Y ahora igual pero con while");

            PrintArrayWhile();


            Console.ReadLine();
        }

        private static void PrintArrayWhile()
        {
            int j = 0;
            while (j < colores.Length)
                Console.WriteLine(colores[j++]);
        }

        private static void PrintArrayForeach()
        {
            foreach (string item in colores)
                Console.WriteLine(item);
        }

        private static void PrintArrayFor()
        {
            for (int i = 0; i < colores.Length; i++)
                Console.WriteLine(colores[i]);
        }
    }
}
