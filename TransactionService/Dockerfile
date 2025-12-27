FROM mcr.microsoft.com/dotnet/sdk:10.0 AS base
WORKDIR /src/
COPY ["*.csproj", "./"]
RUN dotnet restore
COPY . .
RUN dotnet publish -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app/
COPY --from=base /publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "TransactionService.dll"]