using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
	class Nelinurk
	{
		// Поля
		double A;
		double B;
		int nurk;
		string tuup;
		
		// Конструкторы
		public Nelinurk() { }
		public Nelinurk(int korgus, int laius)
		{
			A = korgus;
			B = laius;
		}

		//Свойства
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

				return tuup;
			}
		}


	}
}
