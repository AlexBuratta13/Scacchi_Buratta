using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi_Buratta
{
    public abstract class Pezzo
    {
        private Cella posizione;
        public int Valore { get; private set; }
        public Colore Colore { get; private set; }
        public Cella Posizione
        {
            get => posizione; set
            {
                if (posizione != null)
                    posizione.Pezzo = null;
                posizione = value;
                posizione.Pezzo = this;
            }
        }

        public string Name => GetType().Name;
        public virtual string ShortName => Name.Substring(0, 3);

        protected Pezzo(int valore, Colore schieramento)
        {
            Valore = valore;
            Colore = schieramento;
        }

        public override string ToString()
        {
            return $"{Name} {Colore} in {Posizione}";
        }

        protected void Errore()
        {
            throw new Exception($"Mossa per {Name} non valida");
        }
    }
}
