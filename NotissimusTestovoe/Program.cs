
using DAL;
using Services;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDAL();
        builder.Services.AddServices();

        string clientLocation = builder.Configuration.GetValue<string>("ClientUrl")!;
        string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins,
                o =>
                {
                    o.WithOrigins(clientLocation)
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
        });

        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseCors(MyAllowSpecificOrigins);

        app.MapControllers();

        app.Run();
    }
}
