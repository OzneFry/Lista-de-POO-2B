using System.Collections.Generic;
using System.Linq;
using ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Domain;

namespace ListaPOO2.Exercicios.Exercicio2_GerenciamentoProdutos.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos = new();

        public void CadastrarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public bool RemoverProduto(string descricao)
        {
            var produto = _produtos.FirstOrDefault(p => p.Descricao == descricao);
            if (produto == null) return false;
            _produtos.Remove(produto);
            return true;
        }

        public Produto PesquisarProduto(string descricao)
        {
            return _produtos.FirstOrDefault(p => p.Descricao == descricao);
        }

        public Produto ProdutoMenorValor()
        {
            return _produtos.OrderBy(p => p.Valor).FirstOrDefault();
        }

        public List<Produto> ListarProdutos() => new(_produtos);
    }
}
