FROM microsoft/dotnet:3.1-sdk
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 5000/tcp
EXPOSE 5001/tcp
RUN ["dotnet", "run"]