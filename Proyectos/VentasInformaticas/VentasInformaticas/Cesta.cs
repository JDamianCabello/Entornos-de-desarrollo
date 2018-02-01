using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasInformaticas
{
    public class LineaFactura
    {
        private int _cantidad;

        public LineaFactura(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this._cantidad = cantidad;
        }

        public Producto Producto
        {
            get { return Producto; }
            set
            {
                if(value != Producto)
                    Producto = value;
            }
        }
    }
}
