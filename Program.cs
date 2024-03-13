// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao meu programa!";


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("SCREEN SOUND");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpçoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibit a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // "!" usado para obrigatoriedade de input
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpçoesDoMenu();