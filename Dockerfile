FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Theraputic/*.csproj ./Theraputic/
RUN dotnet restore

# copy everything else and build app
COPY Theraputic/. ./Theraputic/
WORKDIR /source/Theraputic
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Theraputic.dll"]