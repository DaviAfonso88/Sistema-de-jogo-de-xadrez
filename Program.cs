using System;
using Tabuleiro;

namespace xadrex_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3,4);

            Console.WriteLine($"Posiçao {p}");


            Console.ReadLine();    

        }
    }
}
