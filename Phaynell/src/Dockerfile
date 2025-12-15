FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app
COPY ./WebAPI /WebAPI
COPY ./Application.Phaynell/ /Application.Phaynell
COPY ./Domain.Phaynell/ /Domain.Phaynell
COPY ./Infrastructure.Phaynell/ /Infrastructure.Phaynell
WORKDIR /WebAPI
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /runtime-app
COPY --from=build-env /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "WebAPI.dll"]