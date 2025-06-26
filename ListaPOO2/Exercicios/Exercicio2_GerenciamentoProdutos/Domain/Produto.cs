namespace ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Domain
{
    public class Produto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Produto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
