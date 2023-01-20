FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SchoolApp/SchoolApp.csproj", "SchoolApp/"]
RUN dotnet restore "SchoolApp/SchoolApp.csproj"
COPY . .
WORKDIR "/src/SchoolApp"
RUN dotnet build "SchoolApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolApp.dll"]
