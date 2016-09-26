using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo07
{
    public static class Validador
    {
        public static bool ControlarTotal(this Factura factura, List<FacturaLinea> lineas)
        {
            decimal total = 0;
            foreach (var item in lineas)
            {
                total += item.Cantidad * item.Precio;
            }
            return factura.Total == total;
        }
    }
}
