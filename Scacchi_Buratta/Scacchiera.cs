using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi_Buratta
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        public IDictionary<string, Cella> Celle { get; } = new Dictionary<string, Cella>();
        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    Celle.Add($"{c}{n}", new Cella(n, c));
                }
            }
        }
        public Cella GetCella(char lettera, int numero)
        {
            string key = $"{lettera}{numero}";
            if (Celle.ContainsKey(key))
                return Celle[key];
            throw new Exception($"Cella {key} non trovata");
        }
        public void Stampa()
        {
            string s = "";
            int cellSize = 3;
            StampaLettera(ref s, cellSize);
            StampaLinea(ref s, cellSize);
            for (int n = 8; n >= 1; n--)
            {
                s += $"{n}|";
                for (char c = 'A'; c <= 'H'; c++)
                {
                    Cella cella = GetCella(c, n);
                    if (cella.Pezzo != null)
                        s += cella.Pezzo.ShortName.PadRight(cellSize);
                    else
                        s += $"".PadRight(cellSize);
                    s += "|";
                }
                s += "\n";
                StampaLinea(ref s, cellSize);
            }
            StampaLettera(ref s, cellSize);
            Console.Write(s);
        }
        private static void StampaLettera(ref string s, int cellSize)
        {
            s += "";
            for (char c = 'A'; c <= 'H'; c++)
            {
                s += $"| {c} ".PadRight(cellSize + 1);
            }
            s += "|\n";
        }
        private static void StampaLinea(ref string s, int cellSize)
        {
            s += " |".PadRight(cellSize * 11, '-') + "-\n";
        }
    }
}
