using Application.Phaynell.Handlers.Commands;
using Application.Phaynell.Interfaces.Handlers.Commands;
using Application.Phaynell.Interfaces.Services;
using Application.Phaynell.Services;
using Domain.Phaynell.Interfaces.Connections;
using Domain.Phaynell.Interfaces.Repository;
using Domain.Phaynell.Interfaces.Repositorys;
using Infrastructure.Phaynell.Connections;
using Infrastructure.Phaynell.Repository;
using Infrastructure.Phaynell.Repositorys;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Phaynell
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IPostgreSQLConnection, PostgreSQLConnection>();
            services.AddScoped<IProducaoRepository, ProducaoRepository>();
            services.AddScoped<IPhaynellService, PhaynellService>();
            services.AddScoped<IPhaynellRepository, PhaynellRepository>();
            services.AddScoped<IPhaynellCommandHandler, PhaynellCommandHandler>();

            return services;
        }
    }
}
