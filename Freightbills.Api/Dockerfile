FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY Freightbills.Api/*.csproj ./Freightbills.Api/
COPY Freightbills.Application/*.csproj ./Freightbills.Application/
COPY Freightbills.Domain/*.csproj ./Freightbills.Domain/
COPY Freightbills.Repository/*.csproj ./Freightbills.Repository/

RUN dotnet restore

# Copy everything else and build
COPY Freightbills.Api/. ./Freightbills.Api/
COPY Freightbills.Application/. ./Freightbills.Application/
COPY Freightbills.Domain/. ./Freightbills.Domain/
COPY Freightbills.Repository/. ./Freightbills.Repository/

WORKDIR /app/Freightbills.Api

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/Freightbills.Api/out .
ENTRYPOINT ["dotnet", "Freightbills.Api.dll"]