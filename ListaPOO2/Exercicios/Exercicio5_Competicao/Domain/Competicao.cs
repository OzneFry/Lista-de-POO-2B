using System.Collections.Generic;

namespace ListaPOO2.Exercicios.Exercicio5_Competicao.Domain
{
    public class Competicao
    {
        public string Nome { get; set; }
        public List<Competidor> Competidores { get; } = new();

        public Competicao(string nome)
        {
            Nome = nome;
        }

        public void AdicionarCompetidor(Competidor competidor)
        {
            Competidores.Add(competidor);
        }
    }
}
