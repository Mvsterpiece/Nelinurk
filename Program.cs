using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
	class Program
	{
		static void Main(string[] args)
		{
			Nelinurk figure = new Nelinurk(30,25,150);
			Console.WriteLine("Kujundi tüüp on "+figure.Tuup);
			double P = figure.Pindala();
			Console.WriteLine("Kujundi pindala on "+P);
			double Pr = figure.Perimeetr();
			Console.WriteLine("Kujundi perimeetr on " + Pr);
			Console.WriteLine("");
			
			int korgus;
			int laius;
			int nurk;

			Console.WriteLine("Sisesta Korgus ");
			korgus = int.Parse(Console.ReadLine());
			Console.WriteLine("Sisesta Laius ");
			laius = int.Parse(Console.ReadLine());
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("Sisesta nurk ");
				nurk = int.Parse(Console.ReadLine());
			}
			
			 
			Nelinurk N = new Nelinurk(korgus, laius);
			N.Vastus();
			Console.ReadLine();


		}
	}
}
