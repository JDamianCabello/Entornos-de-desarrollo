using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitariasCajaBlancaMatematicas;

namespace PruebaUnitariaCajaBlancaMatematicasTEST
{
    [TestClass]
    public class CalculadoraTEST
    {
        [TestMethod]
        [ExpectedException(typeof(FaltaParametroException))]
        public void C1_EsPrimo_NULL_ExceptionE1()
        {
            string[] valores = { };
            Calculadora.EsPrimo(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(DemasiadosParametrosException))]
        public void C2_EsPrimo_ArrayDosParametros_ExceptionE2()
        {
            string[] valores = {"a","b"};
            Calculadora.EsPrimo(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(NoNumeroException))]
        public void C3_EsPrimo_Caracter_ExceptionE3()
        {
            string[] valores = {"a"};
            Calculadora.EsPrimo(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroNoPositivoException))]
        public void C4_EsPrimo_NumValorNegativo_ExceptionE4()
        {
            string[] valores = {"-1"};
            Calculadora.EsPrimo(valores);
        }

        [TestMethod]
        public void C5_EsPrimo_EsPrimo_DOS_TRUE()
        {
            string[] valores = { "2" };
            Assert.IsTrue(Calculadora.EsPrimo(valores));
        }

        [TestMethod]
        public void C6_EsPrimo_EsPrimo_CUATRO_FALSE()
        {
            string[] valores = { "4" };
            Assert.IsFalse(Calculadora.EsPrimo(valores));
        }

        [TestMethod]
        public void C7_EsPrimo_EsPrimo_TRES_TRUE()
        {
            string[] valores = { "3" };
            Assert.IsTrue(Calculadora.EsPrimo(valores));
        }



        [TestMethod]
        [ExpectedException(typeof(FaltaParametroException))]
        public void C1_EsPrimo2_NULL_ExceptionE1()
        {
            string[] valores = { };
            Calculadora.EsPrimo2(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(DemasiadosParametrosException))]
        public void C2_EsPrimo2_ArrayDosParametros_ExceptionE2()
        {
            string[] valores = { "a", "b" };
            Calculadora.EsPrimo2(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(NoNumeroException))]
        public void C3_EsPrimo2_Caracter_ExceptionE3()
        {
            string[] valores = { "a" };
            Calculadora.EsPrimo2(valores);
        }

        [TestMethod]
        [ExpectedException(typeof(NumeroNoPositivoException))]
        public void C4_EsPrimo2_NumValorNegativo_ExceptionE4()
        {
            string[] valores = { "-1" };
            Calculadora.EsPrimo2(valores);
        }

        [TestMethod]
        public void C5_EsPrimo2_DOS_TRUE()
        {
            string[] valores = { "2" };
            Assert.IsTrue(Calculadora.EsPrimo2(valores));
        }

        [TestMethod]
        public void C6_EsPrimo2_CUATRO_FALSE()
        {
            string[] valores = { "4" };
            Assert.IsFalse(Calculadora.EsPrimo2(valores));
        }

        [TestMethod]
        public void C7_EsPrimo2_TRES_TRUE()
        {
            string[] valores = { "3" };
            Assert.IsTrue(Calculadora.EsPrimo2(valores));
        }

        [TestMethod]
        [ExpectedException(typeof(NumuracoException))]
        public void EsPrimo_ValorOverflow_NumeracoException()
        {
            Int64 valor = int.MaxValue;
            valor++;
            string[] valores = {valor.ToString()};
            Calculadora.EsPrimo(valores);
        }

        //Pruebas unitarias del método de cálculo del dígito de control.
        [TestMethod]
        public void C1_CalcularDC_12335678000012335678()
        {
            string valor = "12335678000012335678";
            string resultado = Calculadora.CalcularDC(valor);

            Assert.AreEqual("11", resultado);
        }

        [TestMethod]
        public void C2_CalcularDC_12345678001234567890()
        {
            string valor = "12345678001234567890";
            string resultado = Calculadora.CalcularDC(valor);

            Assert.AreEqual("11", resultado);
        }
    }
}
