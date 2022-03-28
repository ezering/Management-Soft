using Management.Api.Registrars.Interfaces;
using Management.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Management.Api.Registrars;

public class DbRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var cs = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseNpgsql(cs);
        });
    }
}