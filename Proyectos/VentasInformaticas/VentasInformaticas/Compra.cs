using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasInformaticas
{
    public class LineaFactura
    {
        private int _cantidad;
        private Producto _producto;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public LineaFactura(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this._cantidad = cantidad;
        }

        public Producto Producto
        {
            get { return _producto; }
            set
            {
                if(value != Producto)
                    _producto = value;
            }
        }
    }
}
