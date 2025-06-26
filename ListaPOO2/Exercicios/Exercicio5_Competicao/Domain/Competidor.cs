namespace ListaPOO2.Exercicios.Exercicio5_Competicao.Domain
{
    public class Competidor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }

        public Competidor(string nome, int idade, string modalidade)
        {
            Nome = nome;
            Idade = idade;
            Modalidade = modalidade;
        }
    }
}
