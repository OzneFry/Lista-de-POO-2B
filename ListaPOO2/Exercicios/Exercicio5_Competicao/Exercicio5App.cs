using ListaPOO2.Exercicios.Exercicio5_Competicao.Services;
using ListaPOO2.Exercicios.Exercicio5_Competicao.UI;

namespace ListaPOO2.Exercicios.Exercicio5_Competicao
{
    public class Exercicio5App
    {
        public static void Run()
        {
            var service = new CompeticaoService();
            var menu = new MenuCompeticao(service);
            menu.ExibirMenu();
        }
    }
}
