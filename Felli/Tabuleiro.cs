namespace Felli
{
    public class Tabuleiro
    {
        private Estado[,] estado;

        //Vez do jogador
        private int turn;

        //Verificar quem é o próximo a jogar
        //Se o turno for par, então são as peças brancas a jogar.
        //Se o turno for ímpar, então são as peças pretas a jogar
        //Se o jogo tiver acabado, nenhuma peça será jogada.
        public Estado Next_turn
        {
            get
            {
                if (isover)
                {
                    return Estado.N;
                }
                if (turn % 2 == 0)
                {
                    return Estado.B;
                }
                else
                {
                    return Estado.P;
                }
            }
        }

        public Tabuleiro()
        {
            estado = new Estado[5, 5];
            turn = 0;
        }

        //Obter posição no tabuleiro
        public Estado GetEstado(Posicao pos)
        {
            return estado[pos.Row, pos.Col];
        }

        //Verificar se o jogo já acabou
        public bool isover
        {
           get
           {
               return Empate || Ha_vencedor(Estado.B) || Ha_vencedor(Estado.P);
           }    
        }

        //Verificar se houve empate
        public bool Empate
        {
            get
            {
                for (int i = 0; i < 5; i++)
               {
                   for (int j = 0; j < 5; j++)
                   {
                      if (estado[i, j] == Estado.N)
                       {
                           return false;
                       }
                   }
               }
               return true;
            }
        }

        //Verificar se o vencedor foram as peças brancas ou as peças pretas
        public Estado Vencedor
        {
            get
            {
                if(Ha_vencedor(Estado.B))
                {
                    return Estado.B;
                }

                if(Ha_vencedor(Estado.P))
                {
                    return Estado.P;
                }
                return Estado.N;
            }
        }

        //Verificar a posição escolhida pelos jogadores
        public bool Jogada(Posicao pos)
        {
            if (pos == null)
                return false;
            if (pos.Row < 0 || pos.Row > 5 || pos.Col < 0 || pos.Col > 5)
                return false;
            if (estado[pos.Row, pos.Col] != Estado.N)
                return false;
            estado[pos.Row, pos.Col] = Next_turn;
            turn++;
            return true;
        }

        //Verificar se há vencedor
        private bool Ha_vencedor(Estado jogador)
        {
            return true;
        }
    }
}