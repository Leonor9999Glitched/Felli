using System;

namespace Felli
{
    public class Interface 
    {
        public void Rendertabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    switch(tabuleiro.GetEstado(new Posicao(i, j)))
                    {
                        case Estado.B:
                            Console.Write(" B ");
                            break;
                        case Estado.P:
                            Console.Write(" P ");
                            break;
                        case Estado.N:
                            Console.Write("  ");
                            break;
                    }
                }
                if(i == 0)
                {
                    Console.WriteLine(".   .   .");
                }    
                if(i == 1)
                {
                    Console.WriteLine(" .  .  . ");
                }
                if(i == 2)
                { 
                    Console.WriteLine("    .    ");
                }
                if(i == 3)
                {
                    Console.WriteLine(" .  .  . ");
                }
                if(i == 4)
                {
                    Console.WriteLine(".   .   .");
                }
            }
        }

        public int GetJogada(Estado nextPlayer)
        {
            string aux;
            int move;
            Console.Write($"O jogador {nextPlayer} pode fazer a sua jogada: ");
            aux = Console.ReadLine();
            move = int.Parse(aux);
            return move;
        }
        public void RenderMensagem(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Render_resultado(Tabuleiro tabuleiro)
        {
            if(tabuleiro.Empate)
            {
                Console.WriteLine("É um empate");
            }
        }
    }
}