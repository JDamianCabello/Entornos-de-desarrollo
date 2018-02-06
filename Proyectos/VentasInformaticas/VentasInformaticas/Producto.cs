using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasInformaticas
{
    public class Producto
    {
        private string _nombre;
        private double _precio;
        private TipoProducto _tipo;

        #region Propiedades

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        

        public TipoProducto Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        #endregion

        #region Constructor

        public Producto(string nombre, double precio, TipoProducto tipo)
        {
            this._nombre = nombre;
            this._precio = precio;
            this._tipo = tipo;
        }

        #endregion
    }
}
