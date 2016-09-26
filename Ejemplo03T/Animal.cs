using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03T
{
	public abstract class Animal
	{
		protected string Sonido { get; set; }
		public void Comunicarse()
		{
			Console.WriteLine(Sonido);
		}
	}
}
