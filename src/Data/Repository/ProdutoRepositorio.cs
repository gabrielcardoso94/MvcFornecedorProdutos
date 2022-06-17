using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {

        private readonly MeuDbContext _context;

        public ProdutoRepositorio(MeuDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> ObterTodos()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterPorId(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}
