using Business.Interfaces;
using Business.Notificacoes;
using Business.Services;
using Data.Data;
using Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ApplicationContext>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
