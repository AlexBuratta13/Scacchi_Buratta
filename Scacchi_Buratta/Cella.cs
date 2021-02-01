using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi_Buratta
{
    public sealed class Cella
    {
        public char Lettera { get; private set; }
        public int Numero { get; private set; }
        public Pezzo Pezzo { get; set; }

        internal Cella(char lettera, int numero)
        {
            Lettera = lettera;
            Numero = numero;
        }
        public Colore Colore
        {
            get
            {
                bool numeroPari = Numero % 2 == 0;
                bool letteraPari = (Lettera - 'A') % 2 == 0;
                if (numeroPari == letteraPari)
                    return Colore.Nero;
                return Colore.Bianco;
            }
        }
        public override string ToString()
        {
            return $"{Lettera}{Numero}";
        }
    }
}
