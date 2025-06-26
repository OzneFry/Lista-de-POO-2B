using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.Services;
using ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos.UI;

namespace ListaPOO2.Exercicios.Exercicio1_GerenciamentoAlunos
{
    public class Exercicio1App
    {
        public static void Run()
        {
            var service = new AlunoService();
            var menu = new MenuAlunos(service);
            menu.ExibirMenu();
        }
    }
}
