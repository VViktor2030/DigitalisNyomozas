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
		private DateOnly vallomas_datum;

		public Tanu(Szemely szemely, string vallomas_szoveg, DateOnly vallomas_datum)
		{
			this.szemely = szemely;
			this.vallomas_szoveg = vallomas_szoveg;
			this.vallomas_datum = vallomas_datum;
		}

		public string Vallomas_szoveg { get => vallomas_szoveg; set => vallomas_szoveg = value; }
		public DateOnly Vallomas_datum { get => vallomas_datum; set => vallomas_datum = value; }
		internal Szemely Szemely { get => szemely; set => szemely = value; }
	}
}
