using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [StringLength(14, ErrorMessage = "O campo {0} deve ter {1} caracteres", MinimumLength = 14)]
        public string Documento { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

        public FornecedorViewModel()
        {
        }

        public FornecedorViewModel(int id, string nome, string documento)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
        }
    }
}
