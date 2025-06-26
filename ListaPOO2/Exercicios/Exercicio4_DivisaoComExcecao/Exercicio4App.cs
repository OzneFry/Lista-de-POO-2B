using ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao.Services;
using ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao.UI;

namespace ListaPOO2.Exercicios.Exercicio4_DivisaoComExcecao
{
    public class Exercicio4App
    {
        public static void Run()
        {
            var service = new DivisaoService();
            var menu = new MenuDivisao(service);
            menu.ExibirMenu();
        }
    }
}
