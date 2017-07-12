FROM microsoft/dotnet:1.0.1-runtime 
WORKDIR /app
COPY . .
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "SampleWebDotNetCore.dll"]
