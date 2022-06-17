using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class FornecedorService
    {
        private readonly IRepositorio<Fornecedor> _repositorio;

        public FornecedorService(IRepositorio<Fornecedor> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Fornecedor>> ObterTodos()
        {
            return await _repositorio.ObterTodos();
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            await _repositorio.Adicionar(fornecedor);
        }
    }
}
