using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen");
            Console.WriteLine("Gissa talet, lycka till");

            int nr;
            string strNr;
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101);
            strNr = Console.ReadLine();
            nr = Convert.ToInt32(strNr);
            int guess = 1;


            do
            {


                guess++;


                if (nr > slump_tal)
                {
                    Console.WriteLine("Tyvärr fel nummer");
                    Console.WriteLine("Talet är mindre, gissa igen");
                    strNr = Console.ReadLine();
                    nr = Convert.ToInt32(strNr);
                }
                else if (nr < slump_tal)
                {
                    Console.WriteLine("Tyvärr fel nummer");
                    Console.WriteLine("Talet är större, gissa igen");
                    strNr = Console.ReadLine();
                    nr = Convert.ToInt32(strNr);
                }

                if (nr == slump_tal)
                {
                    Console.WriteLine("Grattis du gissade nummret efter " + guess + " gissningar");
                    Console.ReadLine();


                }

            } while (nr != slump_tal);
        }
    }
}
