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
		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	
		public void Ugykezelo()
		{
			int valasz;
			do
			{
				Console.WriteLine("1.Ügy létrehozas  2. Ügyek Listázása  3. Új gyanusitott hozzáadása  4. Új tanu hozzáadása   5. kilépes");
				valasz = Convert.ToInt32(Console.ReadLine());

				switch (valasz)
				{
					case 1:
						Console.WriteLine();
						Console.Write("Azonosítója?    ");
						string azonosito = Console.ReadLine();
						Console.WriteLine();
						Console.Write("címe?    ");
						string cim = Console.ReadLine();
						Console.WriteLine();
						Console.Write("leírása?    ");
						string leiras = Console.ReadLine();
						Console.WriteLine();
						Console.Write("állapota?    ");
						string allapot = Console.ReadLine();
						Console.WriteLine();
						ugyek.Add(new Ugy(azonosito,cim,leiras,allapot));
						break;

					case 2:
						foreach (var i in ugyek)
						{
							Console.WriteLine(i);
							Console.WriteLine();
						}
						break;

					case 3:
						Console.WriteLine();
						Console.Write("neve?    ");
						string nevGY = Console.ReadLine();
						Console.WriteLine();
						Console.Write("eletkora?    ");
						int eletkorGY = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						Console.Write("Megjegyzés?    ");
						string megjegyzesGY = Console.ReadLine();
						Console.WriteLine();
						Console.Write("státusza?    ");
						string statusz = Console.ReadLine();
						Console.WriteLine();
						gyanusitottak.Add(new Gyanusitott(new Szemely(nevGY,eletkorGY,megjegyzesGY),statusz));
						break;
					case 4:
						Console.WriteLine();
						Console.Write("neve?    ");
						string nevT = Console.ReadLine();
						Console.WriteLine();
						Console.Write("eletkora?    ");
						int eletkorT = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						Console.Write("Megjegyzés?    ");
						string megjegyzesT = Console.ReadLine();
						Console.WriteLine();
						Console.Write("vallomas szövege?    ");
						string szoveg = Console.ReadLine();
						Console.Write("vallomas dátuma?    ");
						DateTime datum = Convert.ToDateTime(Console.ReadLine());
						Console.WriteLine();
						tanuk.Add(new Tanu(new Szemely(nevT, eletkorT, megjegyzesT), szoveg,datum));
						break;
				}
			
			
			
			
			} while (valasz != 5);
		}
	
	
	
	
	}
}
