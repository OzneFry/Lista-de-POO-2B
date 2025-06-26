using ListaPOO2.Exercicios.Exercicio3_Pagamentos.Domain;
using ListaPOO2.Exercicios.Exercicio3_Pagamentos.Services;
using System;

namespace ListaPOO2.Exercicios.Exercicio3_Pagamentos.UI
{
    public class MenuPagamentos
    {
        private readonly LojaVirtual _loja;
        public MenuPagamentos(LojaVirtual loja)
        {
            _loja = loja;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu Pagamentos ---");
                Console.WriteLine("1. Cartão de Crédito");
                Console.WriteLine("2. Boleto Bancário");
                Console.WriteLine("3. PIX");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha a forma de pagamento: ");
                var opcao = Console.ReadLine();
                if (opcao == "4") return;
                Console.Write("Valor: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                {
                    Console.WriteLine("Valor inválido!");
                    continue;
                }
                IPagamento pagamento = opcao switch
                {
                    "1" => new PagamentoCartaoCredito(),
                    "2" => new PagamentoBoleto(),
                    "3" => new PagamentoPIX(),
                    _ => null
                };
                if (pagamento == null)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }
                _loja.RealizarPagamento(pagamento, valor);
            }
        }
    }
}
