using OO_Demo_2023_kallerattya;

class Program
{
 
        static void Main()
    {
        Omistaja omistaja = new Omistaja { Nimi = "Kalle Rättyä", Postinumero = "67800" };
        Kanala kanala = new Kanala(omistaja);

        while (true)
        {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Tulosta kanalan tiedot");
            Console.WriteLine("2. Muokkaa kanan rotua");
            Console.WriteLine("3. Lopeta ohjelma");

            int valinta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (valinta)
            {
                case 1:
                    kanala.TulostaTiedot();
                    break;

                case 2:
                    kanala.MuokkaaRotuja();
                    break;

                case 3:
                    Console.WriteLine("Ohjelma lopetetaan.");
                    return;

                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
