using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Bizonyitek
	{
		private string azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosag;

		public Bizonyitek(string azonosito, string tipus, string leiras, int megbizhatosag)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosag = megbizhatosag;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }


		public override string ToString()
		{
			return $"Bizonyíték azonosítója: {this.azonosito}, Típusa: {this.tipus}, Leírása: {this.leiras}, Megbizhatósága (1-5): {megbizhatosag}";
		}
	
	
	
	}
}
