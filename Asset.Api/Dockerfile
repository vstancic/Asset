FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY "*.sln" .
COPY ["Asset.Api/Asset.Api.csproj", "Asset.Api/"]
COPY ["Asset.Domain/Asset.Domain.csproj", "Asset.Domain/"]
COPY ["Asset.Infrastructure/Asset.Infrastructure.csproj", "Asset.Infrastructure/"]
COPY ["Asset.Test/Asset.Test.csproj", "Asset.Test/"]
RUN dotnet restore "Asset.Api/Asset.Api.csproj"
COPY . .
WORKDIR "/src/Asset.Api"
RUN dotnet build "Asset.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Asset.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Asset.Api.dll"]
