using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Services;
using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.UI;

namespace ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos
{
    public class Exercicio2App
    {
        public static void Run()
        {
            var service = new ProdutoService();
            var menu = new MenuProdutos(service);
            menu.ExibirMenu();
        }
    }
}
