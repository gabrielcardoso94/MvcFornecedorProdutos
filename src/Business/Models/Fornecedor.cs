using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; }
        public Endereco Endereco { get; set; }

        //EF relacionamento
        public IEnumerable<Produto> Produtos { get; set; }

        public Fornecedor()
        {            
        }

        public Fornecedor(int id, string nome, int documento)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
        }
    }
}