using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo07
{
    class Program
    {
        static void Main(string[] args)
        {
            var factura = new Factura() { Total = 100 };
            var lista = new List<FacturaLinea>() { new FacturaLinea() { Numero=1, Cantidad = 5, Precio = 15 }, new FacturaLinea() { Numero = 2, Cantidad = 1, Precio=25 } };
            var lista2 = new List<FacturaLinea>() { new FacturaLinea() { Numero = 1, Cantidad = 5, Precio = 15 }, new FacturaLinea() { Numero = 2, Cantidad = 6, Precio=25 } };


            factura.ControlarTotal(lista);
            factura.ControlarTotal(lista2);

            Console.WriteLine($"control de la lista 1 {factura.ControlarTotal(lista)} control para la lista 2 {factura.ControlarTotal(lista2)}");


            Func<decimal, FacturaLinea, decimal> Descuento = (p, item) => (item.Cantidad * item.Precio) * p / 100;

            foreach (var item in lista)
            {
                Console.WriteLine(Descuento(20,item));
            }


            Action<FacturaLinea> bonificacion = x => x.Precio -= 5;
            Console.WriteLine($"Precio antes de la bonificacio {lista[0].Precio}");
            bonificacion(lista[0]);
            Console.WriteLine($"Precio despues de la bonificacio {lista[0].Precio}");


            var mayor_a_1_query = from l in lista where l.Cantidad > 1 select l;
            var mayor_a_1_lamb = lista.Where(x=>x.Cantidad>1).ToList();

            Console.ReadLine();

        }
    }
}
