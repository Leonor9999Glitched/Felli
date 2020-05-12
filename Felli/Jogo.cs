using System;

namespace Felli
{
    public class Jogo
    {

        private Tabuleiro tabuleiro;

        private Interface ui;

        public Jogo()
        {
            tabuleiro = new Tabuleiro();
            ui = new Interface();
        }

        public void Jogar()
        {
            do
            {
                int nextMove;
                
                ui.Rendertabuleiro(tabuleiro);

                nextMove = ui.GetJogada(tabuleiro.Next_turn);

                tabuleiro.Jogada(Move);

            } while(!tabuleiro.isover);
        }
    }
}