using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Domain;
using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Services;
using System;

namespace ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.UI
{
    public class MenuProdutos
    {
        private readonly ProdutoService _service;
        public MenuProdutos(ProdutoService service)
        {
            _service = service;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu Produtos ---");
                Console.WriteLine("1. Cadastrar produto");
                Console.WriteLine("2. Remover produto");
                Console.WriteLine("3. Pesquisar produto");
                Console.WriteLine("4. Mostrar produto com menor valor");
                Console.WriteLine("5. Listar todos os produtos");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha: ");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": Cadastrar(); break;
                    case "2": Remover(); break;
                    case "3": Pesquisar(); break;
                    case "4": MenorValor(); break;
                    case "5": Listar(); break;
                    case "6": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        private void Cadastrar()
        {
            Console.Write("Descrição: ");
            var desc = Console.ReadLine();
            Console.Write("Valor: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido!");
                return;
            }
            _service.CadastrarProduto(new Produto(desc, valor));
            Console.WriteLine("Produto cadastrado!");
        }

        private void Remover()
        {
            Console.Write("Descrição do produto a remover: ");
            var desc = Console.ReadLine();
            if (_service.RemoverProduto(desc))
                Console.WriteLine("Produto removido!");
            else
                Console.WriteLine("Produto não encontrado!");
        }

        private void Pesquisar()
        {
            Console.Write("Descrição do produto: ");
            var desc = Console.ReadLine();
            var prod = _service.PesquisarProduto(desc);
            if (prod == null)
                Console.WriteLine("Produto não encontrado!");
            else
                Console.WriteLine($"Descrição: {prod.Descricao} | Valor: {prod.Valor:C}");
        }

        private void MenorValor()
        {
            var prod = _service.ProdutoMenorValor();
            if (prod == null)
                Console.WriteLine("Nenhum produto cadastrado.");
            else
                Console.WriteLine($"Menor valor: {prod.Descricao} | Valor: {prod.Valor:C}");
        }

        private void Listar()
        {
            var produtos = _service.ListarProdutos();
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            foreach (var p in produtos)
                Console.WriteLine($"Descrição: {p.Descricao} | Valor: {p.Valor:C}");
        }
    }
}
