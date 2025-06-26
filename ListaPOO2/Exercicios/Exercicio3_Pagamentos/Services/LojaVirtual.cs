using ListaPOO2.Exercicios.Exercicio3_Pagamentos.Domain;

namespace ListaPOO2.Exercicios.Exercicio3_Pagamentos.Services
{
    public class LojaVirtual
    {
        public void RealizarPagamento(IPagamento metodo, decimal valor)
        {
            metodo.ProcessarPagamento(valor);
        }
    }
}
