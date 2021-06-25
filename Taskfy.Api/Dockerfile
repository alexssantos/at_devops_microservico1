#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Imaem ASPNET base
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Imagem .NET 5 SDK
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Taskfy.Api/Taskfy.Api.csproj", "Taskfy.Api/"]
RUN dotnet restore "Taskfy.Api/Taskfy.Api.csproj"
COPY . .
WORKDIR "/src/Taskfy.Api"
RUN dotnet build "Taskfy.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Taskfy.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Taskfy.Api.dll"]