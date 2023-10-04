using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Demo_2023_kallerattya
{
    class Kana
    {
        public string? rotu;
        public int munienMaara;
        public void Muniva()
        {
            Random rnd = new Random();
            munienMaara = rnd.Next(1, 6);
        }
    }
}