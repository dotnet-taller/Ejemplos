using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo06
{
    public abstract class Enemigo:Personaje
    {
        public abstract void Atacar(Jugador objetivo);
    }
}
