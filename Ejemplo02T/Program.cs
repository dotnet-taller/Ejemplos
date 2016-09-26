using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02T
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero=0;
			Console.WriteLine(numero);
			string texto = "letras";
			Console.WriteLine(texto);

			IEstado trx01 = new MiTransaccion();
			ITransaccion trx02 = new MiTransaccion();
			TransaccionBase trx03 = new MiTransaccion();
			MiTransaccion trx04 = new MiTransaccion();
			var trx05 = new MiTransaccion();



			Console.WriteLine(trx01);
			Console.WriteLine(trx02);
			Console.WriteLine(trx03);
			Console.WriteLine(trx04);
			Console.WriteLine(trx05);

			Console.WriteLine(trx05.Test01(5));
			Console.WriteLine(trx05.Test01(10));
			Console.WriteLine(trx05.Test01(15));

			numero = 10;
			Console.WriteLine("Valor antes de la funcion: {0}", numero);
			trx05.Test02(ref numero);
			Console.WriteLine("Valor antes de la funcion: {0}", numero);

			numero = 10;
			Console.WriteLine("Valor antes de la funcion: {0}", numero);
			trx05.Test03(numero);
			Console.WriteLine("Valor antes de la funcion: {0}", numero);

			Console.ReadKey();
		}
	}
}
