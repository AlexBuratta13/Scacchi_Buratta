using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi_Buratta
{
    class Regina : Pezzo
    {
        public Regina(Colore schieramento) : base(15, schieramento)
        {
        }
        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (nuovaPosizione.Lettera == Posizione.Lettera ||
                nuovaPosizione.Numero == Posizione.Numero)
            {
                Posizione = nuovaPosizione;
            }
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) ==
                Math.Abs(nuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        } 
    }
}
