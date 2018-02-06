using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasInformaticas
{
    public class Producto
    {
        public const int SOFTWARE = 2;
        public const int HARDWARE = 1;
        public const int NOAPLICA = 0;
        private string _nombre;

        #region Propiedades

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private double _precio;

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private int _tipo;

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        #endregion

        #region Constructor

        public Producto(string nombre, double precio, int tipo)
        {
            this._nombre = nombre;
            this._precio = precio;
            this._tipo = tipo;
        }

        #endregion
    }
}
