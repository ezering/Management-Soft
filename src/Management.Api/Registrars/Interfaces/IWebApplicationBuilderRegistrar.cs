namespace Management.Api.Registrars.Interfaces;

public interface IWebApplicationBuilderRegistrar:IRegistrar
{
    void RegisterServices(WebApplicationBuilder builder);
}