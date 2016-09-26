using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo06
{
    class Program
    {
        static void Main(string[] args)
        {
            var mundo = new Mundo();
            mundo.AgregarPersonaje<Dragon>();
            mundo.AgregarPersonaje<Dragon>();
            mundo.AgregarPersonaje<Dragon>();
            mundo.AgregarPersonaje<Lobo>();
            mundo.AgregarPersonaje<Lobo>();
            mundo.AgregarPersonaje<Lobo>();

            mundo.AgregarPersonaje<Guerrero>();


        }
    }
}
