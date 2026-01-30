using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Adattar
	{
		List<Felhasznalo> felhasznalok;
		List<Ugy> ugyek;
		List<Gyanusitott> gyanusitottak;
		List<Tanu> tanuk;
		List<Bizonyitek> bizonyitekok;

		public Adattar()
		{
			this.felhasznalok = new List<Felhasznalo>();
			this.ugyek = new List<Ugy>();
			this.gyanusitottak = new List<Gyanusitott>();
			this.tanuk = new List<Tanu>();
			this.bizonyitekok = new List<Bizonyitek>();
		}

		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Gyanusitott> Gyanusitottak { get => gyanusitottak; set => gyanusitottak = value; }
		internal List<Tanu> Tanuk { get => tanuk; set => tanuk = value; }
		internal List<Bizonyitek> Bizonyitekok { get => Bizonyitekok; set => Bizonyitekok = value; }
	}
}
