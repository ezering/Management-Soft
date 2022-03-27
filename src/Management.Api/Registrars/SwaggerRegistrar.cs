using Management.Api.Options;
using Management.Api.Registrars.Interfaces;

namespace Management.Api.Registrars;

public class SwaggerRegistrar: IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {


        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}