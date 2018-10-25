FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 50906
EXPOSE 44301

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CircleCITest/CircleCITest.csproj", "CircleCITest/"]
RUN dotnet restore "CircleCITest/CircleCITest.csproj"
COPY . .
WORKDIR "/src/CircleCITest"
RUN dotnet build "CircleCITest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CircleCITest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CircleCITest.dll"]