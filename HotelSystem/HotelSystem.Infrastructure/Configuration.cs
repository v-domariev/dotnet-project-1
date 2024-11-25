using HotelSystem.API.Interfaces;
using HotelSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelSystem.Infrastructure
{
    public static class Configuration
    {
        public static IServiceCollection AddInfrastractureLayer(this IServiceCollection services)
        {
            //services.AddScoped<Service1>
            //services.AddScoped<Service2>
            services.AddScoped<IDbContext, HotelContext>();
            services.AddDbContext<HotelContext>(opt => opt.UseSqlServer("Server=DESKTOP-QBPEBIC\\DEVELOPERDB;Database=HotelSystem1;IntegratedSecurity=true;"));
            return services;
        }
    }
}
