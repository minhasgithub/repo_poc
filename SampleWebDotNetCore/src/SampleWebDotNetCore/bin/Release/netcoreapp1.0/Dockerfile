FROM microsoft/dotnet:1.0.1-runtime
WORKDIR /app
COPY . .
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT [“dotnet”, “SampleWebDotNetCore.dll”]

