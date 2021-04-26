using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sknowed.Application.Contracts.Persistance;
using Sknowed.Persistance.Repositories;

namespace Sknowed.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // @TODO db context for other entities
            services.AddDbContext<SknowedDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"))
            );
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICourseRepository, CourseRepository>();
            return services;
        }
    }
}
