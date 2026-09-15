


using System.Diagnostics;
using System.Xml.XPath;

// Toda a introdução do jogo é feita aqui, respeitando a idade mínima e pedido de nome do usuário 
Console.WriteLine("Digite seu nome, domador de fer222as: ");
string nome = Console.ReadLine()!;

Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (idade < 15)
{

    Console.WriteLine("Você é muito jovem para jogar, " + nome + ". Volte quando tiver mais idade.");
}
else
{
    // Intro simples que introduz o jogador a este mundo
    Console.WriteLine("Bem vindo ao GLYPHBORN" + nome + " !!");
    Console.WriteLine("Um rei de um reino distante estava organizando um grande torneio de luta, GLYPHBORN");
    Console.WriteLine("que ocorria anualmente para determinar o campeão e saciar a grande fome");
    Console.WriteLine("por luta das criaturas.");

    Console.WriteLine();

    Console.WriteLine("Para isso, ele chamou seus melhores heróis,");
    Console.WriteLine("que conseguiam interagir com os animais mágicos daquele reino.");

    Console.WriteLine();

    Console.WriteLine("Assim, os heróis foram encarregados de controlar as feras");
    Console.WriteLine("e colocá-las para duelar entre si no grande torneio.");

    Console.WriteLine();

    Console.WriteLine("Agora, chegou a sua vez de entrar na arena...");
    Console.WriteLine("Você será capaz de se tornar o campeão?");

    Console.WriteLine();

    Console.WriteLine("Aperte qualquer tecla para prosseguir");
    Console.ReadKey();
    Console.Clear();
    // Tutorial que ensina as mecânicas básicas de como o jogo funciona ao jogador
    Console.WriteLine("======== TUTORIAl ========");
    Console.WriteLine();
    Console.WriteLine("O jogador escolhe qual criatura mágica vai atacar");
    Console.WriteLine("O computador decide a jogada dele");
    Console.WriteLine("Após compará-las, o resultado da rodada é decidido, e a partida acaba quando um dos jogadores chegar a 0 de vida.");
    Console.WriteLine("Depois de derrotar seus adversários e chegar na final do torneio, o grande rei te espera para o combate!");

    Console.WriteLine();

    Console.WriteLine("Unicórnio - Vence o Pegasus");
    Console.WriteLine("Pegasus - Vence o Grifo");
    Console.WriteLine("Grifo - Vence o Unicórnio");

    Console.WriteLine();

    Console.WriteLine("Pressione qualquer tecla para prosseguir");
    Console.ReadKey();
    Console.Clear();

    int hpjogador = 10;
    int hpcomputador = 10;
    int rodada = 1;
    int Xp = 0;
    int partida = 1;
    int dano = Convert.ToInt32(dano = 3);
    int cura = Convert.ToInt32(cura = 0);
    bool zerou = false;
    bool boss = false;
    string[] jogadas = { "Unicórnio", "Pegasus", "Grifo" };

    // Local onde sao feitas as funções que definem as habilidades de cada criatura
    static int habilidadeUnicornio(int dano)
    {

        return dano * 2;
    }

    static int habilidadePegasus(int cura)
    {

        return cura = 2;
    }

    static int habilidadeGrifo(int dano)
    {

        return dano = 0;
    }

    // While que define o sistema de partidas por fora do de derrotas
    while (partida <= 3 && !zerou)
    {
        if (Xp == 3)
        {
            Console.WriteLine("Prepare-se, agora é a batalha final!");
        }
        else
        {
            Console.WriteLine("Agora é hora de descansar antes do próximo combate...");
        }

        Console.WriteLine("Aperte qualquer tecla para ir para a próxima batalha");
        Console.ReadKey();
        Console.Clear();

        rodada = 1;

        if (boss)
        {
            hpcomputador = 15;
        }

        bool habilidadePegasusUsada = false;
        bool jogadaUnicornioUsada = false;
        bool HabilidadeGrifoUsada = false;
        Console.WriteLine("Vitórias conquistadas: " + Xp);

        // Sistema de progressão bem simples
        // Ganhou -> Xp aumenta -> subiu de nível - > modificação é feita


        if (Xp >= 1)
        {
            hpjogador = 12;

        }

        else if (Xp <= 0)
        {
            hpcomputador = 1;
            hpjogador = 10;
        }

        if (partida >= 3)
        {
            hpcomputador = 15;
        }


        if (Xp >= 3)
        {
            dano = 4;
        }


        if (Xp == 1)
        {
            Console.WriteLine("Você subiu de nível!!");
            Console.WriteLine("Agora, você está no nível 1");
            Console.WriteLine("HP UP - Você ganhou mais 2 de hp!");
            Console.Clear();
        }
        else if (Xp == 2)
        {
            Console.WriteLine("Você subiu de nível!!");
            Console.WriteLine("Agora, você está no nível 2");
            Console.WriteLine("Com tanta experiência, você agora aprendeu a habilidade: 'Corram, equinos!'");
            Console.WriteLine("1x por partida, você pode correr contra o tempo e reiniciar o hp de ambos os jogadores!");
            Console.Clear();
        }
        else if (Xp == 3)
        {
            Console.WriteLine("Você subiu de nível!!");
            Console.WriteLine("Agora, você está no nível 3");
            Console.WriteLine("Suas criaturas apreciaram os combates feitos e se sentem mais fortes!!");
            Console.WriteLine("Todas as suas criaturas ganham mais 1 de dano permanente!");
            Console.Clear();
        }



        // Estrutura básica de combate, onde o jogador e a máquina vão se enfrentando até que um deles tenha o hp == 0  
        while (hpjogador > 0 && hpcomputador > 0)
        {

            if (Xp >= 2)
            {
                Console.WriteLine("Você deseja usar a habilidade: 'corram, equinos' e resetar a rodada?");
                Console.WriteLine("Sim | Não");
                Console.Write("Sua escolha -> "); string decisaopoder = Console.ReadLine()!;
                if (decisaopoder == "sim")
                {
                    Console.WriteLine("Você usou a habilidade: 'corram, equinos'!");
                    Console.WriteLine("O hp de ambos os jogadores foi resetado!");
                    hpjogador = 10;
                    hpcomputador = 10;

                }
                Console.Clear();
            }


            if (Xp == 3)
            {
                Console.WriteLine("========== BATALHA FINAL ==========");
            }
            else
            {
                Console.WriteLine("========== RODADA " + rodada + "  ==========");

            }

            // Aqui é definido a jogada do computador, que é aleatória, e a jogada do jogador, que é escolhida por ele
            Random AtqComp = new Random();
            int ataqueComp = AtqComp.Next(0, jogadas.Length);
            string jogadaComp = jogadas[ataqueComp];


            Console.WriteLine("Escolha sua criatura e ataque mágico: ");
            Console.WriteLine("Unicórnio | Pegasus | Grifo");
            Console.WriteLine();
            Console.Write("Sua jogada: "); string ataque = Console.ReadLine()!;
            Console.WriteLine("A máquina escolheu: " + jogadaComp);
            Console.WriteLine();


            // Switch case serve para as jogadas do jogador e dentro dele, o if else compara com a jogada do computador, e assim define quem vence a rodada.
            switch (ataque)
            {
                case "Unicórnio":

                    if (jogadaComp == "Pegasus")
                    {
                        dano = 3;
                        if (!jogadaUnicornioUsada)
                        {
                            Console.WriteLine("Sua habilidade: Chifre Que Rasga Os Céus foi ativada!");

                            jogadaUnicornioUsada = true;

                            dano = habilidadeUnicornio(dano);
                        }

                        hpcomputador -= dano;

                        Console.WriteLine(
                            "O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio(jogador) vence a rodada."
                        );

                        Console.WriteLine("Dano causado: " + dano);

                        break;

                    }

                    else if (jogadaComp == "Grifo")
                    {
                        dano = 3;
                        hpjogador -= 3;

                        Console.WriteLine(
                            "O Grifo repele o ataque. Grifo(computador) vence a rodada."
                        );

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
                        dano = 3;

                        if (!habilidadePegasusUsada)
                        {
                            Console.WriteLine("A habilidade: Determinação de Bellerophon é ativada, o jogador recupera 2 de hp!");
                            habilidadePegasusUsada = true;
                            cura = habilidadePegasus(cura);

                        }
                        hpjogador += cura;
                        hpcomputador -= dano;
                        Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus(jogador) vence a rodada.");
                        Console.WriteLine("Dano causado: " + dano);

                        break;

                    }
                    else if (jogadaComp == "Unicórnio")

                    {
                        dano = 3;
                        Console.WriteLine("O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio(Computador) vence a rodada.");
                        hpjogador -= dano;
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
                        dano = 3;
                        Console.WriteLine("O Grifo repele o ataque com suas garras, refletindo-o na direção do Unicórnio. Grifo(jogador) vence a rodada.");
                        Console.WriteLine("Dano causado: " + dano);
                        hpcomputador -= dano;
                        break;
                    }


                    else if (jogadaComp == "Pegasus")
                    {
                        dano = 3;
                        if (!HabilidadeGrifoUsada)
                        {
                            Console.WriteLine("O pegasus estava prestes a cortar o grifo, porém, a habilidade: Honra do Velocino Dourado é ativada");
                            Console.WriteLine("Anulando qualquer dano sofrido pelo usuário!!");
                            HabilidadeGrifoUsada = true;
                            dano = habilidadeGrifo(dano);
                        }
                        hpjogador -= dano;
                        Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus(Computador) vence a rodada.");
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

            // Aqui é feito uma tela que mostra o HP do jogador e do adversário, usando uma pequena matriz

            string[,] hp =

              {

                 {"HP do Jogador -> ", hpjogador.ToString() },
                 {"HP do Computador -> ", hpcomputador.ToString() },

              };

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("Status da batalha: ");
            for (int i = 0; i < hp.GetLength(0); i++)

            {
                Console.WriteLine(hp[i, 0] + hp[i, 1]);
            }

            Console.WriteLine("==================================");

            // Decisão de quem venceu a batalha, e uma mensagem de vitória ou derrota é mostrada ao jogador.
            if (hpjogador <= 0)
            {
                Console.WriteLine("O computador venceu a batalha! Mais sorte na próxima vez, " + nome + ".");
            }
            else if (hpcomputador <= 0)
            {
                if (partida == 3)
                {
                    Console.WriteLine("Parabéns! Você derrotou o rei!");
                    Console.WriteLine("Você se tornou o campeão de GLYPHBORN!");

                    zerou = true;
                }
                else
                {
                    Console.WriteLine("Parabéns, " + nome + "! Você venceu a batalha!");

                    partida++;
                    Xp++;
                }


                if (partida == 4)
                {
                    zerou = true;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }

            rodada++;
            // Serve para o jogador ver o resultado da batalha antes de limpar a tela e iniciar uma nova rodada


        }





    }



}
