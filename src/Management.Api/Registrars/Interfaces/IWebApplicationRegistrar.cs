﻿namespace Management.Api.Registrars.Interfaces;

public interface IWebApplicationRegistrar:IRegistrar
{
    public void RegisterPipelineComponents(WebApplication app);
}