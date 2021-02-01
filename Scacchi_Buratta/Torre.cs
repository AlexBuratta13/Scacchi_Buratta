using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi_Buratta
{
    class Torre : Pezzo
    {
        public Torre(Colore schieramento) : base(5, schieramento) { }
        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (nuovaPosizione.Lettera == Posizione.Lettera ||
                nuovaPosizione.Numero == Posizione.Numero)
            {

                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
