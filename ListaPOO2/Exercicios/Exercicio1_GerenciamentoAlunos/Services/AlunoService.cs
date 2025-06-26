using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Services
{
    public class AlunoService
    {
        private readonly List<Aluno> _alunos = new();

        public bool CadastrarAluno(Aluno aluno)
        {
            if (_alunos.Any(a => a.RA == aluno.RA))
                return false;
            _alunos.Add(aluno);
            return true;
        }

        public List<Aluno> ListarAlunos() => new(_alunos);

        public Aluno BuscarPorRA(string ra) => _alunos.FirstOrDefault(a => a.RA == ra);

        public bool AlterarAluno(string ra, string novoNome, int novaIdade)
        {
            var aluno = BuscarPorRA(ra);
            if (aluno == null) return false;
            aluno.Nome = novoNome;
            aluno.Idade = novaIdade;
            return true;
        }

        public bool RemoverAluno(string ra)
        {
            var aluno = BuscarPorRA(ra);
            if (aluno == null) return false;
            _alunos.Remove(aluno);
            return true;
        }
    }
}
