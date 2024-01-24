using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace red
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši riječ:");
            string input = Console.ReadLine();

            Dictionary<char, int> brojslova = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (brojslova.ContainsKey(c))
                {
                    brojslova[c]++;
                }
                else
                {
                    brojslova[c] = 1;
                }
            }

            char najviseslova = brojslova.OrderByDescending(x => x.Value).First().Key;
            int povezanost = brojslova[najviseslova];

            Console.WriteLine($"Najcesce slov u riječi je  '{najviseslova}' ima ga oko {povezanost}.");
            Console.ReadLine();
        }
    }
}
