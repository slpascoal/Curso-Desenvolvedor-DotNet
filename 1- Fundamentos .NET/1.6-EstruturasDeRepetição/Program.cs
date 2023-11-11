using System.Diagnostics;
using System.Numerics;
using códigos.Models;

//variável para controlar encerramento do While do Menu
bool menu = true;

// variável para controlar a opção escolhida no menu
String opcao;

// variável do número que será feita a taboada e inserção de valor
Console.WriteLine("Insira o número que deseja vizualizar a taboada");
int numero = int.Parse(Console.ReadLine());

//criação de objeto para acesso a Classe das Estruturas de Repetição - Tema dessa aula
EstruturasDeRepeticao taboada = new EstruturasDeRepeticao();

while (menu)
{
    Console.WriteLine($"1- Taboada com FOR:");
    Console.WriteLine($"2- Taboada com WHILE:");
    Console.WriteLine($"3- Taboada com DO WHILE:");
    Console.WriteLine($"4- Sair do Programa");
    Console.WriteLine("Opção: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            taboada.LacoFor(numero);
            Console.WriteLine("----");
            break;

        case "2":
            taboada.LacoWhile(numero);
            Console.WriteLine("----");
            break;

        case "3":
            taboada.LacoDoWhile(numero);
            Console.WriteLine("----");
            break;

        case "4":
            Console.WriteLine("Programa encerrado");
            Console.WriteLine("----");
            menu = false;
            break;
    }


}