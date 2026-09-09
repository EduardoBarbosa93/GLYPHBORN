
for (int intro = 0; intro < 1; intro++)
{
    Console.WriteLine("Digite seu nome, guerreiro: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 13)
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
        Console.Clear();
        Console.WriteLine("========== NOVO COMBATE ==========");
        int hpjog = 10;
        int hpcomp = 10;
        string[] jogadas = { "Unicónio", "Pegasus", "Grifo" };

        Random AtqComp = new Random();
        int ataqueComp = AtqComp.Next(0, jogadas.Length);
        string jogadaComp = jogadas[ataqueComp];

        while (hpjog > 0 && hpcomp > 0)
        {
           
            Console.WriteLine("Escolha sua criatura e ataque mágico: ");
            Console.WriteLine("Unicórnio | Pegasus | Grifo");
            string ataque = Console.ReadLine()!;

            if (ataque == "Unicórnio" && jogadaComp == "Pegasus")
            {
                Console.WriteLine("O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio vence a rodada.");
                hpcomp = hpcomp - 3;
            }
            else if (ataque == "Unicórnio" && jogadaComp == "Grifo")
            {
                Console.WriteLine("O Grifo repele o ataque com suas garras, refletindo-o na direção do Unicórnio. Grifo vence a rodada.");
                hpjog = hpjog - 4;
            }
            else if (ataque == "Pegasus" && jogadaComp == "Unicórnio")
            {
                Console.WriteLine("O Pegasus é atingido pela luz desferida pelo unicórnio durante o voo. Unicórnio vence a rodada.");
                hpjog = hpjog - 3;
            }
            else if (ataque == "Pegasus" && jogadaComp == "Grifo")
            {
                Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus vence a rodada.");
                hpcomp = hpcomp - 3;
            }
            else if (ataque == "Grifo" && jogadaComp == "Unicórnio")
            {
                Console.WriteLine("O Grifo repele o ataque com suas garras, refletindo-o na direção do Unicórnio. Grifo vence a rodada.");
                hpcomp = hpcomp - 4;
            }
            else if (ataque == "Grifo" && jogadaComp == "Pegasus")
            {
                Console.WriteLine("O Grifo é cortado por uma arrancada do Pegasus vindo dos céus. Pegasus vence a rodada.");
                hpjog = hpjog - 3;
            }
            else if (ataque == jogadaComp)
            {
                Console.WriteLine("Empate! Nenhum dos dois consegue vencer a rodada.");
            }
            else
            {
                Console.WriteLine("Jogada inválida. Tente novamente.");
            }

            string[,] hp =
            {
        {"HP do Jogador - ", hpjog.ToString() },
        {"HP do Computador - ", hpcomp.ToString() },
            };
            Console.WriteLine("Status da batalha: ");
            for (int i = 0; i < hp.GetLength(0); i++)
            {
                Console.WriteLine(hp[i, 0] + hp[i, 1]);

            }
            Console.WriteLine("==================================");


        }
        if (hpjog <= 0)
        {
            Console.WriteLine("O Computador venceu a batalha! Você foi derrotado, " + nome + ". Tente novamente na próxima vez.");
        }
        else if (hpcomp <= 0)
        {
            Console.WriteLine("Parabéns, " + nome + "! Você venceu a batalha e se tornou o maior domador do reino!");
        }
    }
     

}