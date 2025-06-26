// See https://aka.ms/new-console-template for more information
using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos;
using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos;
using ListaPOO2.Exercicios.Exercicio3_Pagamentos;
using ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao;
using ListaPOO2.Exercicios.Exercicio5_Competicao;

Console.WriteLine("Escolha o exercício para rodar:");
Console.WriteLine("1 - Gerenciamento de Alunos");
Console.WriteLine("2 - Gerenciamento de Produtos");
Console.WriteLine("3 - Pagamentos");
Console.WriteLine("4 - Divisão com Exceção");
Console.WriteLine("5 - Competição e Competidores");
Console.WriteLine("0 - Sair");

while (true)
{
    Console.Write("Opção: ");
    var opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": Exercicio1App.Run(); break;
        case "2": Exercicio2App.Run(); break;
        case "3": Exercicio3App.Run(); break;
        case "4": Exercicio4App.Run(); break;
        case "5": Exercicio5App.Run(); break;
        case "0": return;
        default: Console.WriteLine("Opção inválida!"); break;
    }
    Console.WriteLine("\nRetornando ao menu principal...\n");
    Console.WriteLine("Escolha o exercício para rodar:");
    Console.WriteLine("1 - Gerenciamento de Alunos");
    Console.WriteLine("2 - Gerenciamento de Produtos");
    Console.WriteLine("3 - Pagamentos");
    Console.WriteLine("4 - Divisão com Exceção");
    Console.WriteLine("5 - Competição e Competidores");
    Console.WriteLine("0 - Sair");
}
