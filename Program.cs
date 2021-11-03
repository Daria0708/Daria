using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your name:");
			string name = Console.ReadLine();
			Console.Write("Enter your year of birth:");
			string yearString = Console.ReadLine();
			int year = Int32.Parse(yearString);
			int currentYear = DateTime.Now.Year;
			int age = currentYear - year;
			Console.WriteLine($"{name},your age is {age}");
			if (age >= 18)
			{
				Console.WriteLine($"You are adult ");
			}
			else
				Console.WriteLine($"You are not adult");

			Console.ReadKey();
		}
		
	}
}

