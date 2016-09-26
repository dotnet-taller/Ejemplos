using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01T
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ingrese el nombre:");
			var nombre = Console.ReadLine();
			Console.WriteLine("Ingrese la apellido:");
			var apellido = Console.ReadLine();

			Console.WriteLine(nombre+ " " + apellido);
			Console.ReadKey();

			Console.WriteLine("Ingrese el nombre:");
			var nombre2 = Console.ReadLine();
			Console.WriteLine("Ingrese la edad:");
			var edad = int.Parse( Console.ReadLine());
			if(edad>=18)
				Console.WriteLine("Mayor de edad");
			else
				Console.WriteLine("Menor de edad");
			Console.ReadKey();
			
			Console.WriteLine("Ingrese el primer numero:");
			var numero1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la segundo numero:");
			var numero2 = int.Parse(Console.ReadLine());
			for (int i = numero1; i >0; i--)
			{
				if (numero1 % i == 0 && numero2 % i == 0)
				{
					Console.WriteLine("El MCD es: {0}",i);
					i = 0;
				}
			}
			Console.ReadKey();


		}
	}
}
