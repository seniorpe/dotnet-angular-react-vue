FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/Senior.Boilerplate.Web.Host/Senior.Boilerplate.Web.Host.csproj", "src/Senior.Boilerplate.Web.Host/"]
COPY ["src/Senior.Boilerplate.Web.Core/Senior.Boilerplate.Web.Core.csproj", "src/Senior.Boilerplate.Web.Core/"]
COPY ["src/Senior.Boilerplate.Application/Senior.Boilerplate.Application.csproj", "src/Senior.Boilerplate.Application/"]
COPY ["src/Senior.Boilerplate.Core/Senior.Boilerplate.Core.csproj", "src/Senior.Boilerplate.Core/"]
COPY ["src/Senior.Boilerplate.EntityFrameworkCore/Senior.Boilerplate.EntityFrameworkCore.csproj", "src/Senior.Boilerplate.EntityFrameworkCore/"]
WORKDIR "/src/src/Senior.Boilerplate.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Senior.Boilerplate.Web.Host", "src/Senior.Boilerplate.Web.Host"]
COPY ["src/Senior.Boilerplate.Web.Core", "src/Senior.Boilerplate.Web.Core"]
COPY ["src/Senior.Boilerplate.Application", "src/Senior.Boilerplate.Application"]
COPY ["src/Senior.Boilerplate.Core", "src/Senior.Boilerplate.Core"]
COPY ["src/Senior.Boilerplate.EntityFrameworkCore", "src/Senior.Boilerplate.EntityFrameworkCore"]
WORKDIR "/src/src/Senior.Boilerplate.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Senior.Boilerplate.Web.Host.dll"]
