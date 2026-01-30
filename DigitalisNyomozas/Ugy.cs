using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Ugy
	{
		private string azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		List<Gyanusitott> gyanusitottak;
		List<Tanu> tanuk;
		List<Bizonyitek> bizonyitekok;

		public Ugy(string azonosito, string cim, string leiras, string allapot)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.gyanusitottak = new List<Gyanusitott>();
			this.tanuk = new List<Tanu>();
			this.bizonyitekok = new List<Bizonyitek>();
		}


		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Gyanusitott> Gyanusitottak { get => gyanusitottak; set => gyanusitottak = value; }
		internal List<Tanu> Tanuk { get => tanuk; set => tanuk = value; }
		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	
	
	
		public void AllapotValtoztatas(string ujAllapot)
		{
			this.allapot = ujAllapot;
		}
	
		public void Donteshozo()
		{
			foreach(var i in bizonyitekok)
			{
				foreach (var j in gyanusitottak)
				{
					j.Gyanusitottsag += i.Megbizhatosag * 3;
					if (j.Gyanusitottsag > 50)
					{
						Console.WriteLine($"Ez a {j.Szemely.Nev} ember elég gyanús!");
					}
					if(j.Gyanusitottsag >= 100)
					{
						Console.WriteLine($"100% Biztos hogy {j.Szemely.Nev} a tettes!!!");
						j.Gyanusitottsag = 100;
					} 
				}
			}
		}
	
	
	
	
	}
}
