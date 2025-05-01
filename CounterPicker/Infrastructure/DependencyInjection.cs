using CounterPicker.Application.Features.Hero.Queries.GetAllHeroes;
using CounterPicker.Domain.Services;

namespace CounterPicker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IHeroService, HeroService>();
            services.AddSingleton<IJsonCacheService, JsonCacheService>();
            services.AddMemoryCache();

            services.AddMediatR(serviceConfiguration => 
            {
                serviceConfiguration.RegisterServicesFromAssembly(typeof(GetAllHeroesQuery).Assembly);
            });

            return services;
        }

    }
}
