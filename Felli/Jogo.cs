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
                Posicao MovePos;
                
                ui.Rendertabuleiro(tabuleiro);

                nextMove = ui.GetJogada(tabuleiro.Next_turn);

                MovePos = MovetoPosition(nextMove);

                if(!tabuleiro.Jogada(MovePos))
                {
                    ui.RenderMensagem("Não podes fazer esta jogada");
                }

            } while(!tabuleiro.isover);

            ui.Rendertabuleiro(tabuleiro);

            ui.Render_resultado(tabuleiro);
        }

        private Posicao MovetoPosition (int move)
        {
            switch(move)
            {
                case 1:
                    return new Posicao(0, 0);
                case 2:
                    return new Posicao(0, 2);
                case 3:
                    return new Posicao(0, 4);
                case 4:
                    return new Posicao(1, 1);
                case 5:
                    return new Posicao(1, 3);
                case 6:
                    return new Posicao(2, 2);
                case 7:
                    return new Posicao(3, 1);
                case 8:
                    return new Posicao(3, 3);
                case 9:
                    return new Posicao(4, 0);
                case 10:
                    return new Posicao(4, 2);
                case 11:
                    return new Posicao(4, 4);
                default:
                    return null;
            }
        }
    }
}