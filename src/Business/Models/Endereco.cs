using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //EF relacionamento
        public Fornecedor Fornecedor { get; set; }

        public Endereco()
        {            
        }

        public Endereco(int id, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado)
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