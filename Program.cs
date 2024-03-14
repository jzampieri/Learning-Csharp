// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao meu programa!";
List<string> listaDasBandas = new List<string>{"U2", "The Beatles", "Calipso", "Iron Maiden"};


void ExibirLogo()
{
    Console.WriteLine("SCREEN SOUND");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpçoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibit a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // "!" usado para obrigatoriedade de input
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //Transformando o input do usuario em INT para leitura do if

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostraBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau Tchau");
            break;
        default: Console.WriteLine("Opção Inválida.");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda); // adiciona um item a uma lista
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); //cifrão para interpolação de string
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçoesDoMenu();
}

void MostraBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas\n");
    for (int i = 0; i < listaDasBandas.Count; i++) //loop for, parecido com python
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}

ExibirOpçoesDoMenu();