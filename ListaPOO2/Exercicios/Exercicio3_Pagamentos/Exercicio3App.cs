using ListaPOO2.Exercicios.Exercicio3_Pagamentos.Services;
using ListaPOO2.Exercicios.Exercicio3_Pagamentos.UI;

namespace ListaPOO2.Exercicios.Exercicio3_Pagamentos
{
    public class Exercicio3App
    {
        public static void Run()
        {
            var loja = new LojaVirtual();
            var menu = new MenuPagamentos(loja);
            menu.ExibirMenu();
        }
    }
}
