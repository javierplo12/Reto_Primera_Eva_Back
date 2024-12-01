FROM mcr.microsoft/dotnet/sdk:8.0 AS build-env

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft/dotnet/sdk:8.0 AS runtime-env 
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Back.dll"]