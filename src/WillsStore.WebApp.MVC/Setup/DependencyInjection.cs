using WillsStore.Catalogo.Application.Services;
using WillsStore.Catalogo.Data.Repository;
using WillsStore.Catalogo.Data;
using WillsStore.Catalogo.Domain;
using WillsStore.Core.Bus;

namespace WillsStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //domain bus
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

        }
    }
}
