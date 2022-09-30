FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IWS.WebApp/IWS.WebApp.csproj", "IWS.WebApp/"]
RUN dotnet restore "IWS.WebApp/IWS.WebApp.csproj"
COPY . .
WORKDIR "/src/IWS.WebApp"
RUN dotnet build "IWS.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IWS.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IWS.WebApp.dll"]
