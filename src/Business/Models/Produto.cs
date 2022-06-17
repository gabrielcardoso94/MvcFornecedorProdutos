using Business.Models.Enums;

namespace Business.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
        public TipoProduto TipoProduto { get; set; }

        //EF relacionamento
        public Fornecedor Fornecedor { get; set; }

        public Produto()
        {            
        }

        public Produto(int id, string nome, int quantidade, double valor)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }
    }
}