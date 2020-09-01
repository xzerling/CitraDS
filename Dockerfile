#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["CitraDataStore.csproj", ""]
RUN dotnet restore "./CitraDataStore.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "CitraDataStore.csproj" -c Release -o /app/build

RUN dotnet restore "./CitraDataStore.csproj"
COPY . .
WORKDIR "/src/."
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -yq nodejs build-essential
RUN npm install -g npm
RUN npm install
RUN dotnet build "CitraDataStore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CitraDataStore.csproj" -c Release -o /app/publish
RUN cp -R node_modules /app/publish/

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CitraDataStore.dll"]