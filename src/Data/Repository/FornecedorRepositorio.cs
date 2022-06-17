using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class FornecedorRepositorio : IRepositorio<Fornecedor>
    {

        private readonly MeuDbContext _context;

        public FornecedorRepositorio(MeuDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fornecedor>> ObterTodos()
        {
            return await _context.Fornecedores.AsNoTracking().ToListAsync();
        }

        public async Task<Fornecedor> ObterPorId(int id)
        {
            return await _context.Fornecedores.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Fornecedor fornecedor)
        {
            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
        }
    }
}
