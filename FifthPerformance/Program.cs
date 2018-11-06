using System;
using System.Globalization;

namespace FifthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int LagX, AltY, FotoX, FotoY;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            LagX = int.Parse(vet[0]);
            AltY = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            FotoX = int.Parse(vet[0]);
            FotoY = int.Parse(vet[1]);

            if ((FotoX <= LagX && FotoY <= AltY) || (FotoX <= LagX && FotoY <= AltY))
            {
                Console.WriteLine("A Foto cabe.");
            }
            else
            {
                Console.WriteLine("Vai ter que comprar uma moldura nova, parceiro.");
            }

            Console.ReadLine();
        }
    }
}
