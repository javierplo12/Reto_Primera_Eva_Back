# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copiar el archivo del proyecto y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del proyecto y compilar
COPY . ./
RUN dotnet publish Back.csproj -c Release -o out

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime-env

WORKDIR /app

# Copiar los archivos generados desde la etapa de build
COPY --from=build /app/out .

# Exponer el puerto
EXPOSE 3000

# Configurar el comando de inicio
ENTRYPOINT ["dotnet", "Back.dll"]
