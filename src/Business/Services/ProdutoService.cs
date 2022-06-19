using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProdutoService
    {
        private readonly IRepositorio<Produto> _repositorio;

        public ProdutoService(IRepositorio<Produto> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Produto>> ObterTodos()
        {
            return await _repositorio.ObterTodos();
        }

        public async Task Adicionar(Produto produto)
        {
            await _repositorio.Adicionar(produto);
        }
    }
}
