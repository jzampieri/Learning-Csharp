﻿// Screen Sound

using System.Globalization;

string mensagemDeBoasVindas = "Boas vindas ao meu programa!";
//List<string> listaDasBandas = new List<string>{"U2", "The Beatles", "Calipso", "Iron Maiden"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

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
        case 3: AvaliarUmaBanda();
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
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); // .Add adiciona um item na lista
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); //cifrão para interpolação de string
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçoesDoMenu();
}

void MostraBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas\n");

    //for (int i = 0; i < listaDasBandas.Count; i++) //loop for, parecido com python
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) // ContainsKey verifica se existe a chave pedida dentro do dicionario
       Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
       int nota = int.Parse( Console.ReadLine()!);
       bandasRegistradas[nomeDaBanda].Add(nota);
    {

    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
    }
}


ExibirOpçoesDoMenu();