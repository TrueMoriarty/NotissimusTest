using DAL.EfCode;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public static class DI
{
    public static void AddDAL(this IServiceCollection services)
    {
        services.AddDbContext<NotissimusContext>(
            opt => opt.UseNpgsql("Host=localhost;Port=5432;Database=Notissimusdb;Username=pgadmin;Password=pgadmin")
        );
        services.AddScoped<IStoragesRepository, StoragesRepository>();
    }
}
