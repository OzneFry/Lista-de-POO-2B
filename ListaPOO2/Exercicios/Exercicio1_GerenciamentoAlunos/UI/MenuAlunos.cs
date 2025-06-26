using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Domain;
using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Services;
using System;

namespace ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.UI
{
    public class MenuAlunos
    {
        private readonly AlunoService _service;
        public MenuAlunos(AlunoService service)
        {
            _service = service;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu Alunos ---");
                Console.WriteLine("1. Cadastrar aluno");
                Console.WriteLine("2. Listar alunos");
                Console.WriteLine("3. Alterar aluno");
                Console.WriteLine("4. Remover aluno");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha: ");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": Cadastrar(); break;
                    case "2": Listar(); break;
                    case "3": Alterar(); break;
                    case "4": Remover(); break;
                    case "5": return;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            }
        }

        private void Cadastrar()
        {
            Console.Write("RA: ");
            var ra = Console.ReadLine();
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida!");
                return;
            }
            var aluno = new Aluno(ra, nome, idade);
            if (_service.CadastrarAluno(aluno))
                Console.WriteLine("Aluno cadastrado!");
            else
                Console.WriteLine("RA já cadastrado!");
        }

        private void Listar()
        {
            var alunos = _service.ListarAlunos();
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }
            foreach (var a in alunos)
                Console.WriteLine($"RA: {a.RA} | Nome: {a.Nome} | Idade: {a.Idade}");
        }

        private void Alterar()
        {
            Console.Write("RA do aluno a alterar: ");
            var ra = Console.ReadLine();
            var aluno = _service.BuscarPorRA(ra);
            if (aluno == null)
            {
                Console.WriteLine("Aluno não encontrado!");
                return;
            }
            Console.Write("Novo nome: ");
            var nome = Console.ReadLine();
            Console.Write("Nova idade: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida!");
                return;
            }
            if (_service.AlterarAluno(ra, nome, idade))
                Console.WriteLine("Aluno alterado!");
            else
                Console.WriteLine("Erro ao alterar!");
        }

        private void Remover()
        {
            Console.Write("RA do aluno a remover: ");
            var ra = Console.ReadLine();
            if (_service.RemoverAluno(ra))
                Console.WriteLine("Aluno removido!");
            else
                Console.WriteLine("Aluno não encontrado!");
        }
    }
}
