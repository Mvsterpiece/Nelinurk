using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
	class Nelinurk
	{

		double A;
		double B;
		int nurk;
		string tuup;
		

		public Nelinurk() { }
		public Nelinurk(double korgus, double laius)
		{
			A = korgus;
			B = laius;
		}
		public Nelinurk(double korgus, double laius, int Nurk)
		{
			A = korgus;
			B = laius;
			nurk = Nurk;
		}

		public int Nurk { set { nurk = value; } get { return nurk; } }


		public double Pindala()
		{
			double pindala;
			pindala = A * B;
			return pindala;
		}
		public double Perimeetr() 
		{
			double perimeetr;
			perimeetr = (A + B) * 2;
			return perimeetr;
		}


		public string Tuup 
		{
			get
			{
				if(A == B && nurk==90)
				{
					tuup = "Ruut";
				}
				else if (A==B && nurk!=90)
				{
					tuup = "Romb";
				}
				else if (A!=B && nurk==90)
				{
					tuup = "Ristkülik";
				}
				else if (A != B && nurk != 90)
				{
					tuup = "Nelinurk";
				}

					return tuup;
			}
		}
		public void Vastus()
		{
			double P = Pindala();
			double Pr = Perimeetr();
			Console.WriteLine("Tüüp on {0}",Tuup);
			Console.WriteLine($"Pindala on {P} ja perimeetr on {Pr}");
		}


	}
}
