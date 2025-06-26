using ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao.Services;
using System;

namespace ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao.UI
{
    public class MenuDivisao
    {
        private readonly DivisaoService _service;
        public MenuDivisao(DivisaoService service)
        {
            _service = service;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número (ou 'sair'): ");
                    var inputA = Console.ReadLine();
                    if (inputA?.Trim().ToLower() == "sair") return;
                    if (!int.TryParse(inputA, out int a))
                        throw new FormatException();

                    Console.Write("Digite o segundo número: ");
                    var inputB = Console.ReadLine();
                    if (!int.TryParse(inputB, out int b))
                        throw new FormatException();

                    int resultado = _service.Dividir(a, b);
                    Console.WriteLine($"Resultado: {resultado}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
            }
        }
    }
}
