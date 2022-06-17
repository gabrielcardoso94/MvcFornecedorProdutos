using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
        //public TipoProduto TipoProduto { get; set; }
        public FornecedorViewModel Fornecedor { get; set; }

        public ProdutoViewModel()
        {
        }

        public ProdutoViewModel(int id, string nome, int quantidade, double valor)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
