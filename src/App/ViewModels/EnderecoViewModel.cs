using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int Id { get; set; }
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        [RegularExpression(@"([0-9]{8})", ErrorMessage = "Campo inválido")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo {0} é requerido")]
        public string Estado { get; set; }
        public FornecedorViewModel Fornecedor { get; set; }

        public EnderecoViewModel()
        {
        }

        public EnderecoViewModel(int id, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
