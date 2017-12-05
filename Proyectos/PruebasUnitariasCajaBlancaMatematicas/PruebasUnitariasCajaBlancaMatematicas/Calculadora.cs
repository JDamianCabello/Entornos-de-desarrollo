using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitariasCajaBlancaMatematicas
{
    public class FaltaParametroException : Exception { }
    public class DemasiadosParametrosException : Exception { }
    public class NoNumeroException : Exception { }
    public class NumeroNoPositivoException : Exception { }
    public class NumuracoException : Exception { }

    public class Calculadora
    {
        static void Main(string[] args)
        {
        }

        public static bool EsPrimo(String[] args)
        {
            if(args.Length == 0)
                throw new FaltaParametroException();
            else if(args.Length > 1)
                throw new DemasiadosParametrosException();
            else
                try
                {
                    int num = int.Parse(args[0]);
                    if(num < 0)
                        throw new NumeroNoPositivoException();
                    else
                        for(int i = 2; i < num; i++)
                            if(num % i == 0)
                                return false;
                }
                catch(FormatException) { throw new NoNumeroException(); }
                catch(OverflowException) { throw new NumuracoException(); }
            return true;
        }

        public static bool EsPrimo2(String[] args)
        {
            if(args.Length == 0)
                throw new FaltaParametroException();
            else if(args.Length > 1)
                throw new DemasiadosParametrosException();
            else
            {
                int num;
                if(!int.TryParse(args[0], out num))
                    throw new NoNumeroException();
                if(num < 0)
                    throw new NumeroNoPositivoException();
                else
                    for(int i = 2; i < num; i++)
                        if(num % i == 0)
                            return false;
            }
            return true;
        }

        public String CalcularDC(String entrada)
        {
            string resultado;
            int[] multiplicador = { 4, 8, 5, 10, 9, 7, 3, 6, 0, 0, 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            int acumulador1 = 0, acumulador2 = 0, resuParcial = 0;

            for(int i = 0; i < 10; i++)
            {
                acumulador1 += multiplicador[i] * int.Parse(entrada.Substring(i,1));
                acumulador2 += multiplicador[i + 10] + int.Parse(entrada.Substring(1 + 10, 1));
            }

            //Calcular primer DC
            resuParcial = 11 - (acumulador1 % 11);
            if(resuParcial == 10)
                resultado = "1";
            else
                resultado = resuParcial.ToString();

            //Calcular segundo DC
            resuParcial = 11 - (acumulador2 % 11);
            if(resuParcial == 10)
                resultado += "1";
            else
                resultado += resuParcial.ToString();

            return resultado;
        }

    }
}
