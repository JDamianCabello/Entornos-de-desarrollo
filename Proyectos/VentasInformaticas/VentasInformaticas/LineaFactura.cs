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

        public double CalcularTasa()
        {
            double valorLinea = 0;

            switch(this.Producto.Tipo)
            {
                case TipoProducto.HARDWARE:
                    valorLinea = this.Producto.Precio * this.Cantidad * (1 + Constantes.IVAREDUCIDO);
                    break;
                case TipoProducto.SOFTWARE:
                    valorLinea = this.Producto.Precio * this.Cantidad * (1 + Constantes.IVANORMAL);
                    break;
                case TipoProducto.NOAPLICA: //No lleva cargo adicional
                    valorLinea = this.Producto.Precio * this.Cantidad;
                    break;
            }
            return valorLinea;
        }
    }
}
