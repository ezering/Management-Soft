FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Management.Api/Management.Api.csproj", "Management.Api/"]
RUN dotnet restore "src/Management.Api/Management.Api.csproj"
COPY . .
WORKDIR "/src/Management.Api"
RUN dotnet build "Management.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Management.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Management.Api.dll"]
