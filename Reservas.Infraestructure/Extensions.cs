using Microsoft.Extensions.DependencyInjection;
using Reservas.Domain.Repositories;
using Reservas.Infraestructure.EF;
using Reservas.Infraestructure.MemoryRepository;

namespace Reservas.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TODO: Eliminar despues. Solo para proposito de pruebas
            services.AddSingleton<MemoryDatabase>();

            services.AddScoped<IReservaRepository, MemoryReservaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }

    }
}
