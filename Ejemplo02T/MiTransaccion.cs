using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02T
{
	public class MiTransaccion:TransaccionBase, IEstado, ITransaccion
	{

		public string Estado
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool Iniciar(string referencia)
		{
			throw new NotImplementedException();
		}

		public bool Terminar(double valor)
		{
			throw new NotImplementedException();
		}

		public string Test01(int valor)
		{
			if (valor > 10)
			{
				return "Correcto";
			}
			else
			{
				return "El valor debe ser mayor a 10";
			}
		}

		public void Test02(ref int valor)
		{
			valor = valor + 20;
			Console.WriteLine("Valor dentro de la funcion: {0}", valor);
		}

		public void Test03(int valor)
		{
			valor = valor + 20;
			Console.WriteLine("Valor dentro de la funcion: {0}", valor);
		}
	}
}
