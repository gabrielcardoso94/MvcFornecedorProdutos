using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class EnderecoRepositorio : IRepositorio<Endereco>
    {

        private readonly MeuDbContext _context;

        public EnderecoRepositorio(MeuDbContext context)
        {
            _context = context;
        }

        public async Task<List<Endereco>> ObterTodos()
        {
            return await _context.Enderecos.AsNoTracking().ToListAsync();
        }

        public async Task<Endereco> ObterPorId(int id)
        {
            return await _context.Enderecos.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task Adicionar(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Endereco endereco)
        {
            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();
        }
    }
}
