namespace ListaPOO2.Exercicios.Exercicio3_Pagamentos.Domain
{
    public interface IPagamento
    {
        void ProcessarPagamento(decimal valor);
    }

    public class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado no cartão de crédito.");
        }
    }

    public class PagamentoBoleto : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado via boleto bancário.");
        }
    }

    public class PagamentoPIX : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado via PIX.");
        }
    }
}
