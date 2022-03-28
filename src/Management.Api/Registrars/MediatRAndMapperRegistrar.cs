using Management.Api.Registrars.Interfaces;
using Management.Application.UserProfiles.Queries;
using MediatR;

namespace Management.Api.Registrars;

public class MediatRAndMapperRegistrar: IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
        builder.Services.AddMediatR(typeof(GetAllUserProfiles));
    }
}