using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasInformaticas
{
    public class Factura
    {
        List<LineaFactura> _cesta;
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public Factura(string numero)
        {
            this._numero = numero;
            _cesta = new List<LineaFactura>();
        }

        public void AgregarLinea(LineaFactura Linea)
        {
            _cesta.Add(Linea);
        }

        public String Facturar()
        {
            double totalFactura = 0;

            IEnumerator<LineaFactura> it = _cesta.GetEnumerator();

            LineaFactura unaLinea = it.Current;
            while(it.MoveNext())
            {

            }

            return null;
        }
    }
}
