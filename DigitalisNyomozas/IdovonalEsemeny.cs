using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class IdovonalEsemeny
	{
		private DateOnly datum;
		private string leiras;

		public IdovonalEsemeny(DateOnly datum, string leiras)
		{
			this.datum = datum;
			this.leiras = leiras;
		}

		public DateOnly Datum { get => datum; set => datum = value; }
		public string Leiras { get => leiras; set => leiras = value; }
	}
}
