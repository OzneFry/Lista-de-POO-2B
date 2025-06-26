using ListaPOO2.Exercicios.Exercicio5_Competicao.Domain;
using ListaPOO2.Exercicios.Exercicio5_Competicao.Services;
using System;

namespace ListaPOO2.Exercicios.Exercicio5_Competicao.UI
{
    public class MenuCompeticao
    {
        private readonly CompeticaoService _service;
        public MenuCompeticao(CompeticaoService service)
        {
            _service = service;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu Competição ---");
                Console.WriteLine("1. Cadastrar nova competição");
                Console.WriteLine("2. Adicionar competidor");
                Console.WriteLine("3. Listar competidores");
                Console.WriteLine("4. Editar competidor");
                Console.WriteLine("5. Remover competidor");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha: ");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": CadastrarCompeticao(); break;
                    case "2": AdicionarCompetidor(); break;
                    case "3": ListarCompetidores(); break;
                    case "4": EditarCompetidor(); break;
                    case "5": RemoverCompetidor(); break;
                    case "6": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        private void CadastrarCompeticao()
        {
            Console.Write("Nome da competição: ");
            var nome = Console.ReadLine();
            _service.CadastrarCompeticao(nome);
            Console.WriteLine("Competição cadastrada!");
        }

        private void AdicionarCompetidor()
        {
            var comp = SelecionarCompeticao();
            if (comp == null) return;
            Console.Write("Nome do competidor: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida!");
                return;
            }
            Console.Write("Modalidade: ");
            var modalidade = Console.ReadLine();
            _service.AdicionarCompetidor(comp.Nome, new Competidor(nome, idade, modalidade));
            Console.WriteLine("Competidor adicionado!");
        }

        private void ListarCompetidores()
        {
            var comp = SelecionarCompeticao();
            if (comp == null) return;
            if (comp.Competidores.Count == 0)
            {
                Console.WriteLine("Nenhum competidor cadastrado.");
                return;
            }
            foreach (var c in comp.Competidores)
                Console.WriteLine($"Nome: {c.Nome} | Idade: {c.Idade} | Modalidade: {c.Modalidade}");
        }

        private void EditarCompetidor()
        {
            var comp = SelecionarCompeticao();
            if (comp == null) return;
            Console.Write("Nome do competidor a editar: ");
            var nome = Console.ReadLine();
            Console.Write("Novo nome: ");
            var novoNome = Console.ReadLine();
            Console.Write("Nova idade: ");
            if (!int.TryParse(Console.ReadLine(), out int novaIdade))
            {
                Console.WriteLine("Idade inválida!");
                return;
            }
            Console.Write("Nova modalidade: ");
            var novaModalidade = Console.ReadLine();
            if (_service.EditarCompetidor(comp.Nome, nome, novoNome, novaIdade, novaModalidade))
                Console.WriteLine("Competidor editado!");
            else
                Console.WriteLine("Competidor não encontrado!");
        }

        private void RemoverCompetidor()
        {
            var comp = SelecionarCompeticao();
            if (comp == null) return;
            Console.Write("Nome do competidor a remover: ");
            var nome = Console.ReadLine();
            if (_service.RemoverCompetidor(comp.Nome, nome))
                Console.WriteLine("Competidor removido!");
            else
                Console.WriteLine("Competidor não encontrado!");
        }

        private Competicao SelecionarCompeticao()
        {
            var comps = _service.ListarCompeticoes();
            if (comps.Count == 0)
            {
                Console.WriteLine("Nenhuma competição cadastrada.");
                return null;
            }
            Console.WriteLine("Competições disponíveis:");
            foreach (var c in comps)
                Console.WriteLine($"- {c.Nome}");
            Console.Write("Digite o nome da competição: ");
            var nome = Console.ReadLine();
            var comp = _service.BuscarCompeticao(nome);
            if (comp == null)
                Console.WriteLine("Competição não encontrada!");
            return comp;
        }
    }
}
