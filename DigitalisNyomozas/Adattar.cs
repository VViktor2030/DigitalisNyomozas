using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Adattar
	{
		private List<Felhasznalo> felhasznalok;
		private List<Ugy> ugyek;
		private List<Gyanusitott> gyanusitottak;
		private List<Tanu> tanuk;
		private List<Bizonyitek> bizonyitekok;

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
						bool valid = true;
						Console.WriteLine();
						Console.Write("Azonosítója?    ");
						string azonosito = Console.ReadLine();
						foreach (var i in ugyek)
						{
							if (i.Azonosito == azonosito)
							{
								Console.WriteLine("Ez az azonosító már létezik......");
								valid = false;
								
							}
						}
						if (!valid)
						{
							break;
						}
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


		public void BizonyitekKezelo()
		{
			int valasz;

			do
			{
				Console.WriteLine("1.Bizonyíték hozzáadása 2.Bizonyíték törlése 3. Bizonyítékok Listázása  4. Kilépés");
				valasz = Convert.ToInt32(Console.ReadLine());

				switch (valasz)
				{
					case 1:
						bool valid = true;

						Console.WriteLine();
						Console.Write("Azonosítója?    ");
						string azonosito = Console.ReadLine();
						foreach (var i in bizonyitekok)
						{
							if (i.Azonosito == azonosito)
							{
								Console.WriteLine("Ez az azonosító már létezik......");
								valid = false;
								break;
							}
						}
						if (!valid)
						{
							break;
						}
						Console.WriteLine();
						Console.Write("típusa?    ");
						string tipus = Console.ReadLine();
						Console.WriteLine();
						Console.Write("leírása?    ");
						string leiras = Console.ReadLine();
						Console.WriteLine();
						Console.Write("Megbízhatósága(1-5)?    ");
						int megbizhatosag = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine();
						Console.Write("És melyik ügyhöz adjuk? (azonosítót)        ");
						string melyik = Console.ReadLine();
						Bizonyitek bizi = new Bizonyitek(azonosito, tipus, leiras, megbizhatosag);
						bizonyitekok.Add(bizi);
						foreach (var i in ugyek)
						{
							if (i.Azonosito == melyik)
							{
								i.Bizonyitekok.Add(bizi);
							}
						}
						break;
					case 2:
						Console.WriteLine("Törlendő bizonyíték azonosítója");
						string torolni = Console.ReadLine();
						Bizonyitek torlendo = null;
						foreach (var i in bizonyitekok)
						{
							if (i.Azonosito == torolni)
							{
								torlendo = i;
								Console.WriteLine("törölve");
							}
		
						}
						bizonyitekok.Remove(torlendo);
						torlendo = null;
						foreach (var j in ugyek)
						{
							foreach (var k in j.Bizonyitekok)
							{
								if (k.Azonosito == torolni)
								{
									torlendo = k;
									Console.WriteLine("törölve x2");
								}
								
							}
							j.Bizonyitekok.Remove(torlendo);
						}
						break;
					case 3:
						foreach (var i in bizonyitekok)
						{
							Console.WriteLine(i);
						}
						break;
				}
			} while (valasz != 4);




		}




	
	
	}
}
