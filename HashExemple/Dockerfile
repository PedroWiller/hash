#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY HashExemple/HashExemple.csproj HashExemple/
RUN dotnet restore HashExemple/HashExemple.csproj
COPY . .
WORKDIR /src/HashExemple
RUN dotnet build HashExemple.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish HashExemple.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HashExemple.dll"]
