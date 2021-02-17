using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scacchi_Buratta;
using System.IO;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer;
            Scacchiera s = Scacchiera.Istanza;
            Pedone p = new Pedone(Colore.Bianco)
            {
                Posizione = s.GetCella('B', 2)
            };
            Torre t = new Torre(Colore.Bianco)
            {
                Posizione = s.GetCella('C', 1)
            };
            Alfiere a = new Alfiere(Colore.Bianco)
            {
                Posizione = s.GetCella('E', 2)
            };
            Re re = new Re(Colore.Bianco)
            {
                Posizione = s.GetCella('E', 1)
            };
            Regina r = new Regina(Colore.Bianco)
            {
                Posizione = s.GetCella('G', 3)
            };
            Cavallo c = new Cavallo(Colore.Bianco)
            {
                Posizione = s.GetCella('F', 2)
            };
            s.Print();

            Console.WriteLine();
            Console.WriteLine("".PadRight(40, '-'));
            Console.WriteLine();
            try
            {
                p.Muovi(s.GetCella('B', 3));
                t.Muovi(s.GetCella('C', 4));
                a.Muovi(s.GetCella('B', 5));
                re.Muovi(s.GetCella('F', 1));
                r.Muovi(s.GetCella('G', 5));
                c.Muovi(s.GetCella('E', 5));
                s.Stampa();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
