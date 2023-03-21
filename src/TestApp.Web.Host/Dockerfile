FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/TestApp.Web.Host/TestApp.Web.Host.csproj", "src/TestApp.Web.Host/"]
COPY ["src/TestApp.Web.Core/TestApp.Web.Core.csproj", "src/TestApp.Web.Core/"]
COPY ["src/TestApp.Application/TestApp.Application.csproj", "src/TestApp.Application/"]
COPY ["src/TestApp.Core/TestApp.Core.csproj", "src/TestApp.Core/"]
COPY ["src/TestApp.EntityFrameworkCore/TestApp.EntityFrameworkCore.csproj", "src/TestApp.EntityFrameworkCore/"]
WORKDIR "/src/src/TestApp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TestApp.Web.Host", "src/TestApp.Web.Host"]
COPY ["src/TestApp.Web.Core", "src/TestApp.Web.Core"]
COPY ["src/TestApp.Application", "src/TestApp.Application"]
COPY ["src/TestApp.Core", "src/TestApp.Core"]
COPY ["src/TestApp.EntityFrameworkCore", "src/TestApp.EntityFrameworkCore"]
WORKDIR "/src/src/TestApp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TestApp.Web.Host.dll"]
