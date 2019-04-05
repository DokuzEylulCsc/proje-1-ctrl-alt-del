using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kelimelik
{
    class Sozcuk
    {
        private string kelime;
        public string Kelime
        {
            get { return kelime; }
            set { kelime = value; }
        }
        private char seviye;
        public char Seviye
        {
            get { return seviye; }
            set { seviye = value; }

        }
        public Sozcuk(string kelime)
        {
            this.kelime = kelime;
        }
    }
}
