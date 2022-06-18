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

        public async Task<Fornecedor> ObterPorId(int id)
        {
            return await _repositorio.ObterPorId(id);
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            await _repositorio.Adicionar(fornecedor);
        }

        public async Task Editar(Fornecedor fornecedor)
        {
            await _repositorio.Atualizar(fornecedor);
        }

        public async Task Excluir(Fornecedor fornecedor)
        {
            await _repositorio.Remover(fornecedor);
        }
    }
}
