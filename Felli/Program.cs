using System;

namespace Felli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindos ao jogo Felli");
            Console.WriteLine("Este jogo requer dois jogadores");
            Console.WriteLine("O computador não irá jogar com ninguém.");

            Jogo Jogo = new Jogo();
            Jogo.Jogar();
        }
    }
}
