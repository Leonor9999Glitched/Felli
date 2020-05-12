namespace Felli
{
    public class Tabuleiro
    {
        private Estado[,] estado;

        private int turn;

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

        public Estado GetEstado(int x, int y)
        {
            return estado[x, y];
        }

        public bool isover
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
        public bool Jogada(int x, int y)
        {

        }
    }
}