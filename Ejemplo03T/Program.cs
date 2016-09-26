using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03T
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal gato = new Gato();
			Animal perro = new Perro();

			gato.Comunicarse();
			perro.Comunicarse();
		}
	}
}
