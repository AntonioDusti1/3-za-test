using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši prvi broj:");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši drugi broj:");
            int broj2 = int.Parse(Console.ReadLine());

            int najvećidijeljivibroj = Math.Min(broj1, broj2);

            while (broj1 % najvećidijeljivibroj != 0 || broj2 % najvećidijeljivibroj != 0)
            {
               najvećidijeljivibroj--;
            }

            Console.WriteLine($"Najveći broj dijeljiv {broj1} i {broj2} je {najvećidijeljivibroj}.");
            Console.ReadLine();
        }
    }
}
