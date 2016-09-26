using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02T
{
	public interface ITransaccion
	{
		bool Iniciar(string referencia);
		bool Terminar(double valor);
	}
}
