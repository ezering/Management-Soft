﻿using Management.Api.Registrars.Interfaces;

namespace Management.Api.Registrars;

public class SwaggerWebAppRegistrar: IWebApplicationRegistrar
{
    public void RegisterPipelineComponents(WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
            }
        });
    }
}