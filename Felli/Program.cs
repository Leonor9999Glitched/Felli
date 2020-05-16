using System;

namespace Felli
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Declaração das variáveis
            string escolha;

            //Dar as boas vindas aos jogadores e pedir o que eles desejam fazer
            Console.WriteLine("Bem-vindos ao jogo Felli");
            Console.WriteLine("Este jogo requer dois jogadores");
            Console.WriteLine("O computador não irá jogar com ninguém.");
            Console.WriteLine("O que o jogador deseja fazer?");
            Console.WriteLine("1 - Jogar");
            Console.WriteLine("2 - Regras");
            Console.WriteLine("3 - Sair");
            escolha = Console.ReadLine();
            
            if(escolha == "1")
            {   
                //Chama a Classe Jogo e é apartir daí que o jogo começa
                Jogo Jogo = new Jogo();
                Jogo.Jogar();
            }    

            if(escolha == "2")
            {
                //Regras do jogo
                Console.WriteLine("Escolheste ver as regras.");
                Console.WriteLine("1 - Este jogo é para dois jogadores. O computador não irá jogar com ninguém");
                Console.WriteLine("2 - Há um total de doze peças. Seis pretas e seis brancas.");
                Console.WriteLine("3 - Um jogador ficará com as peças pretas e o outro ficará com as brancas.");
                Console.WriteLine("4 - Há um total de doze peças. Seis pretas e seis brancas");
                Console.WriteLine("5 - Os jogadores decidem quem é que joga primeiro.");
                Console.WriteLine("6 - As peças brancas são colocadas no lado oposto das peças negras.");
                Console.WriteLine("6 - As peças podem mover-se livremente.");
                Console.WriteLine("7 - Pode se saltar sobre a peça do inimigo, eliminando assim essa peça.");
                Console.WriteLine("8 - Só se pode eliminar uma peça por turno.");
                Console.WriteLine("9 - Ganha quem tiver eliminado as peças todas do inimigo ou tiver conseguido bloquear o inimgo");

                //Despois das regras, o jogo começará
                Console.WriteLine("Agora que os jogadores sabem as regras, vamos jogar");
                Jogo Jogo = new Jogo();
                Jogo.Jogar();

            }

            if(escolha == "3")
            {
                //Foi escolhido sair do jogo e o programa termina
                Console.WriteLine("Escolheste sair.");
                Console.WriteLine("Até para a próxima.");
            }
        }
    }
}
