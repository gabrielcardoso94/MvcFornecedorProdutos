using App.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public double Valor { get; set; }
        public string Imagem { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Campo {0} é requerido")]
        public TipoProdutoViewModel TipoProduto { get; set; }
        
        public FornecedorViewModel Fornecedor { get; set; }
        
        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }

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
