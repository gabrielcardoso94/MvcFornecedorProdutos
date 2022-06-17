using Business.Interfaces;
using Business.Models;
using Business.Services;
using Data.Repository;

namespace App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRepositorio<Fornecedor>, FornecedorRepositorio>();
            services.AddScoped<IRepositorio<Endereco>, EnderecoRepositorio>();
            services.AddScoped<IRepositorio<Produto>, ProdutoRepositorio>();

            services.AddScoped<FornecedorService>();

            return services;
        }
    }
}
