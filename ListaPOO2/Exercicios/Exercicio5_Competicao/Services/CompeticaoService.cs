using ListaPOO2.Exercicios.Exercicio5_Competicao.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ListaPOO2.Exercicios.Exercicio5_Competicao.Services
{
    public class CompeticaoService
    {
        private readonly List<Competicao> _competicoes = new();

        public void CadastrarCompeticao(string nome)
        {
            _competicoes.Add(new Competicao(nome));
        }

        public List<Competicao> ListarCompeticoes() => new(_competicoes);

        public Competicao BuscarCompeticao(string nome)
        {
            return _competicoes.FirstOrDefault(c => c.Nome == nome);
        }

        public bool AdicionarCompetidor(string nomeCompeticao, Competidor competidor)
        {
            var comp = BuscarCompeticao(nomeCompeticao);
            if (comp == null) return false;
            comp.AdicionarCompetidor(competidor);
            return true;
        }

        public bool RemoverCompetidor(string nomeCompeticao, string nomeCompetidor)
        {
            var comp = BuscarCompeticao(nomeCompeticao);
            if (comp == null) return false;
            var competidor = comp.Competidores.FirstOrDefault(c => c.Nome == nomeCompetidor);
            if (competidor == null) return false;
            comp.Competidores.Remove(competidor);
            return true;
        }

        public bool EditarCompetidor(string nomeCompeticao, string nomeCompetidor, string novoNome, int novaIdade, string novaModalidade)
        {
            var comp = BuscarCompeticao(nomeCompeticao);
            if (comp == null) return false;
            var competidor = comp.Competidores.FirstOrDefault(c => c.Nome == nomeCompetidor);
            if (competidor == null) return false;
            competidor.Nome = novoNome;
            competidor.Idade = novaIdade;
            competidor.Modalidade = novaModalidade;
            return true;
        }
    }
}
