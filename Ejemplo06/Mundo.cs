using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo06
{
    public class Mundo
    {
        private List<Personaje> personajes;
        public Mundo()
        {
            personajes = new List<Personaje>();
        }
        public void AgregarPersonaje<T>() where T: Personaje, new()
        {
            personajes.Add(new T());
        }
    }
}
