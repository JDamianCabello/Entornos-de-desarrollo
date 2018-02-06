using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasInformaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("Pendrive 64Gb",25.00,1);
            Producto p2 = new Producto("Disco SSD 512Gb", 80.00, 1);
            Producto p3 = new Producto("Lisensia Ofiss profecioná", 20.00, 2);
            Producto p4 = new Producto("Cambio pantalla smartphone", 50.00, 0);


            Factura f1 = new Factura("100");
            f1.AgregarLinea(new LineaFactura(p1, 2));
            f1.AgregarLinea(new LineaFactura(p2, 3));
            f1.AgregarLinea(new LineaFactura(p3, 10));
            f1.AgregarLinea(new LineaFactura(p4, 1));

            Console.WriteLine("Factura de compra");
            Console.WriteLine("-----------------");

            Console.WriteLine(f1.Facturar());

            Console.ReadLine();
        }
    }
}
