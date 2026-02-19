namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] xargs)
        {
            Adattar a = new Adattar();
            string valasz;
            do
            {
                Console.WriteLine("Ügykezelő: 1 \t  Bizonyítékkezelő: 2 Kilépés: k");
                valasz = Console.ReadLine();
                switch(valasz)
                {
                    case "1":
                        a.Ugykezelo();
                        break;
                    case "2":
                        a.BizonyitekKezelo();
                        break;
                }
                
            } while (valasz != "k");
		}
	}
}
