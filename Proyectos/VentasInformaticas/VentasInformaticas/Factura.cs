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
            int bonificacion = 0;
            string ticket = string.Empty;

            foreach(LineaFactura linea in _cesta)
            {
                double valorCompra = 0;

                switch(linea.Producto.Tipo)
                {
                    case Producto.HARDWARE:
                        valorCompra = linea.Producto.Precio * linea.Cantidad * 1.05;
                        break;
                    case Producto.SOFTWARE:
                        valorCompra = linea.Producto.Precio * linea.Cantidad * 1.21;
                        break;
                    case Producto.NOAPLICA: //No lleva cargo adicional
                        valorCompra = linea.Producto.Precio * linea.Cantidad;
                        break;
                }

                //Calcular bonificación por puntos
                bonificacion++;
                if(linea.Producto.Tipo == Producto.HARDWARE && linea.Cantidad > 1)
                    bonificacion++;

                totalFactura += valorCompra;

                ticket += "\t" + linea.Producto.Nombre + "\t" + linea.Cantidad + "\t" + valorCompra + "\n";
            }
            ticket += "El total de su compra es: " + totalFactura.ToString() + "\n";
            ticket += "En esta compra ha acumulado : " + bonificacion + "puntos\n";
            return ticket;
        }
    }
}
