namespace Business.Interfaces
{
    public interface IRepositorio<TEntity>
    {
        public Task<List<TEntity>> ObterTodos();
        public Task<TEntity> ObterPorId(int id);
        public Task Adicionar(TEntity entity);
        public Task Atualizar(TEntity entity);
        public Task Remover(TEntity entity);
    }
}
