using System.Reflection;
using WillsStore.Catalogo.Application.AutoMapper;

namespace WillsStore.WebApp.MVC.Setup
{
    public static class MVCConfig
    {
        public static IServiceCollection AddMvcConfig(IServiceCollection services)
        {

            services.AddHttpContextAccessor();
            return services;
        }
    }
}
