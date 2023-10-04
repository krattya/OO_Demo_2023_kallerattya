using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Demo_2023_kallerattya
{
    class Kanala
    {
        public Omistaja omistaja;
        public Kana[] kanat = new Kana[3];

        public Kanala(Omistaja omistaja)
        {
            this.omistaja = omistaja;

            kanat[0] = new Kana { rotu = "Ameraucana" };
            kanat[1] = new Kana { rotu = "Silkkikana" };
            kanat[2] = new Kana { rotu = "Suomalainen maatiaiskana" };
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Kanalan omistaja: " + omistaja.Nimi + ", " + omistaja.Postinumero);
            Console.WriteLine("Kanat:");
            foreach (Kana kana in kanat)
            {
                Console.WriteLine("- Rotu: " + kana.rotu);
                kana.Muniva();
                Console.WriteLine("  Munia viikossa: " + kana.munienMaara);
            }
        }

        public void MuokkaaRotuja()
        {
            Console.WriteLine("Valitse kana, jonka rotua haluat muokata (1-3):");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta < 1 || valinta > 3)
            {
                Console.WriteLine("Virheellinen valinta.");
                return;
            }

            Console.WriteLine("Anna uusi rotu:");
            string uusiRotu = Console.ReadLine();
            if (uusiRotu.Length < 10)
            {
                uusiRotu = "Tuntematon rotu";
            }

            kanat[valinta - 1].rotu = uusiRotu;
            Console.WriteLine("Rotu muutettu onnistuneesti.");
        }
    }
}

