using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public FornecedorViewModel Fornecedor { get; set; }

        public EnderecoViewModel()
        {
        }

        public EnderecoViewModel(int id, string logradouro, string numero, string complemento, int cep, string bairro, string cidade, string estado)
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
