using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Tanu
	{
		private Szemely szemely;
		private string vallomas_szoveg;
		private DateTime vallomas_datum;

		public Tanu(Szemely szemely, string vallomas_szoveg, DateTime vallomas_datum)
		{
			this.szemely = szemely;
			this.vallomas_szoveg = vallomas_szoveg;
			this.vallomas_datum = vallomas_datum;
		}

		public string Vallomas_szoveg { get => vallomas_szoveg; set => vallomas_szoveg = value; }
		public DateTime Vallomas_datum { get => vallomas_datum; set => vallomas_datum = value; }
		internal Szemely Szemely { get => szemely; set => szemely = value; }
	}
}
