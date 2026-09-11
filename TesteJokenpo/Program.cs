


internal class TesteJokenpo
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome, guerreiro: ");       /* Toda a introdução do jogo é feita aqui, respeitando a idade mínima e pedido de nome do usuário */
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
         
        if (idade < 15)
        {

            Console.WriteLine("Você é muito jovem para jogar, " + nome + ". Volte quando tiver mais idade.");
        }
        else
        {
            Console.WriteLine("Bem-vindo ao jogo, " + nome + "! Vamos começar a batalha!");                                                  
            Console.WriteLine("Bem vindo ao jokenpo mágico!!");
            Console.WriteLine("Em um reino distante, um grande torneio era realizado todos os anos para decidir quem seria o maior campeão.");
            Console.WriteLine("Três heróis foram escolhidos pelo rei para controlar as poderosas criaturas mágicas do reino e colocá-las para lutar.");
            Console.WriteLine("Agora, chegou a sua vez, " + nome + ". Escolha sua fera, entre na arena e prove que você é o maior domador dessas terras!");
            Console.WriteLine("Aperte qualquer tecla para iniciar a batalha!");
            Console.ReadKey();
            Console.Clear();                                                               // Após uma introdução breve, o combate se iniciaria, e assim a tela se limpa.
            int hpjogador = 10;
            int hpcomputador = 10;
            int rodada = 1;
            string[] jogadas = { "Unicórnio", "Pegasus", "Grifo" };                         // Início do combate, onde as variáveis de vida do player e da máquina são dadas, e as jogadas são definidas

            while (hpjogador > 0 && hpcomputador > 0)                                                // Estrutura básica de combate, onde o jogador e a máquina vão se enfrentando até que um deles tenha o hp == 0            {
            {
                Random AtqComp = new Random();
                int ataqueComp = AtqComp.Next(0, jogadas.Length);                    // Aqui é definido a jogada do computador, que é aleatória, e a jogada do jogador, que é escolhida por ele.
                string jogadaComp = jogadas[ataqueComp];

                Console.WriteLine("========== RODADA " + rodada + "  ==========");
                Console.WriteLine("Escolha sua criatura e ataque mágico: ");
                Console.WriteLine("Unicórnio | Pegasus | Grifo");
                string ataque = Console.ReadLine()!;
                Console.WriteLine("Você escolheu: " + ataque);
                Console.WriteLine("A máquina escolheu: " + jogadaComp);

                switch (ataque)                                          // Switch case serve para as jogadas do jogador e dentro dele, o if else compara com a jogada do computador, e assim define quem vence a rodada.
                {
                    case "Unicórnio":
                        if (jogadaComp == "Pegasus")
                        {
                            Console.WriteLine("O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio(jogador) vence a rodada.");
                            hpcomputador -= 3;
                            break;
                        }
                        else if (jogadaComp == "Grifo")
                        {
                            Console.WriteLine("O Grifo repele o ataque com suas garras, refletindo-o na direção do Unicórnio. Grifo(Computador) vence a rodada.");
                            hpjogador -= 3;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Empate! Nenhum dano ocorre.");
                            break;
                        }

                    case "Pegasus":

                        if (jogadaComp == "Grifo")
                        {
                            Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus(jogador) vence a rodada.");
                            hpcomputador -= 3;
                            break;
                        }
                        else if (jogadaComp == "Unicórnio")
                        {
                            Console.WriteLine("O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio(Computador) vence a rodada.");
                            hpjogador -= 3;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Empate! Nenhum dano ocorre.");
                            break;
                        }

                    case "Grifo":

                        if (jogadaComp == "Unicórnio")
                        {
                            Console.WriteLine("O Grifo repele o ataque com suas garras, refletindo-o na direção do Unicórnio. Grifo(jogador) vence a rodada.");
                            hpcomputador -= 3;
                            break;
                        }
                        else if (jogadaComp == "Pegasus")
                        {
                            Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus(Computador) vence a rodada.");
                            hpjogador -= 3;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Empate! Nenhum dano ocorre.");
                            break;
                        }

                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }


                string[,] hp =

                {

                 {"HP do Jogador -> ", hpjogador.ToString() },                               // Aqui é feito uma tela que mostra o HP do jogador e do adversário, usando uma pequena matriz
                 {"HP do Computador -> ", hpcomputador.ToString() },

                  };

                Console.WriteLine("Status da batalha: ");
                for (int i = 0; i < hp.GetLength(0); i++)

                {
                    Console.WriteLine(hp[i, 0] + hp[i, 1]);
                }

                Console.WriteLine("==================================");

                if (hpjogador <= 0)                                                             // Decisão de quem venceu a batalha, e uma mensagem de vitória ou derrota é mostrada ao jogador.
                {
                    Console.WriteLine("O computador venceu a batalha! Mais sorte na próxima vez, " + nome + ".");
                }
                else if (hpcomputador <= 0)
                {
                    Console.WriteLine("Parabéns, " + nome + "! Você venceu a batalha e se tornou o maior domador do reino!");
                }

                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");       // Serve para o jogador ver o resultado da batalha antes de limpar a tela e iniciar uma nova rodada.
                Console.ReadKey();
                Console.Clear();
                rodada++;
            }


        }
    }
}