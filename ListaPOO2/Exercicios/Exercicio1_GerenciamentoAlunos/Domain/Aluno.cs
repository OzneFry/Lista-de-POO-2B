namespace ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Domain
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string ra, string nome, int idade)
        {
            RA = ra;
            Nome = nome;
            Idade = idade;
        }
    }
}
