using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static double Calc(double a1, double a2)
		{
			Console.WriteLine("Введите операцию");
			while (true)
			{
				string res = Console.ReadLine();
				if (res == "+")
					return a1 + a2;
				else if (res == "-")
					return a1 - a2;
				else if (res == "*")
					return a1 * a2;
				else if (res == "/")
					return a1 / a2;
				else
				{
					Console.WriteLine("Неизвестная операция. Введите заново");
				}
			}
		}

		static void Main(string[] args)
		{
			while (true)
			{
				double a1, a2;
				Console.WriteLine("Введите первое число");
				while (true)
				{
					if (double.TryParse(Console.ReadLine(), out a1))
						break;
					Console.WriteLine("Введено не число, введите число");
				}
				Console.WriteLine("Введите второе число");
				while (true)
				{
					if (double.TryParse(Console.ReadLine(), out a2))
						break;
					Console.WriteLine("Введено не число, введите число");
				}
				Console.WriteLine(Calc(a1, a2));
				while (true)
				{
					Console.WriteLine("Введите r, чтобы продолжить, q - чтобы выйти");
					string res = Console.ReadLine();
					if (res == "q")
						goto Finish;
					if (res == "r")
						break;
				}
			}
		Finish:
			Console.WriteLine("Завершение работы");
		}
	}
}
