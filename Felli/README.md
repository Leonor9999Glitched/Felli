# Felli

# Nome dos alunos:
- Leonor Figueiredo: 21902968
- João Pedro: 21906096

Os dois colegas trabalharam no código. Apesar de que a Leonor Figueiredo se ocupou mais do código enquanto, João Pedro ajudava com o diagrama.

# Repositório no Git

https://github.com/Leonor9999Glitched/Felli

# Arquitetura da solução

O programa foi dividido em várias classes, sendo de que algumas dessas classes têm metódos lá dentros para recolher valores de outras zonas do código.

O programa começa com a classe Main. É através desta classe o programa irá iniciar as suas acções e terminar, consuante a decisão do jogador. Se o jogador escolher a terceira opção (Sair), o programa terminará com uma mensagem de despedida. Se o jogador escolher ver as regras (Segunda opção), o programa mostrará as regras e depois, iniciará o jogo. O programa acabou de chamar a Classe Jogo. Se o jogador decidir escolher a primeira opção (Jogar), o programa entrará, de imediato, na Clasee Jogo.


- A Classe Estado guarda o estado das posições (mais propriamente, é a classe das peças do jogo). 


- A Classe Interface é responsavel por mostrar o tabuleiro criado na Classe Tabuleiro, obter as jogadas feitas e mandar mensagens aos jogadores. Esta classe serve de ponte entre os jogadores e o programa.


- A Classe Jogo recebe as informações de todas as outras classes, que decide que classe irá agir, que método chamar para resolver os problemas. Tirando a Classe Main à parte, esta é classe mais importante do programa.


- O Program (Classe Main) é a classe que chama a Classe Jogo.


- A Classe Tabuleiro é responsável pela criação do tabuleiro do jogo. Também é através desta classe que o programa sabe se houve empate no jogo, se há vencedor e se o jogo já acabou.

- A Classe Posicao é a classe que indica as variaveis que vão ser usadas para indicar a posição onde o jogador irá jogar.

![Diagrama em UML das Classes do Felli](https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/2fb39435-99ff-49ad-9246-42032eeea416/ddxbu2q-99f89cd1-82d1-4369-bdda-6e8c9c95db70.png/v1/fill/w_1122,h_712,strp/felli__1__by_glitchydemonfairy_ddxbu2q-pre.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOiIsImlzcyI6InVybjphcHA6Iiwib2JqIjpbW3siaGVpZ2h0IjoiPD04MTMiLCJwYXRoIjoiXC9mXC8yZmIzOTQzNS05OWZmLTQ5YWQtOTI0Ni00MjAzMmVlZWE0MTZcL2RkeGJ1MnEtOTlmODljZDEtODJkMS00MzY5LWJkZGEtNmU4YzljOTVkYjcwLnBuZyIsIndpZHRoIjoiPD0xMjgwIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.GYf_-j8G7TXgJ6PMd0B0kgkvDt_SAvE81CYp5h4xGn0)

# Referências

https://www.youtube.com/watch?v=h7ofkKpV4kw&feature=youtu.be