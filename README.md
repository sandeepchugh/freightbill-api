# .NET Core Api

Demo api using .NET Core 3.1 using a domain driven design

## Development Environment Setup

### Install Sql Client 

https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-setup-tools?view=sql-server-ver15#macos

OR

https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15


### Build Docker Image

Run from root of project (containing the solution)
```
docker build -f Freightbills.Api/Dockerfile -t freightbills:0.1 .
```
### Run Sql Server in Docker
```
 docker-compose -f docker-compose-sql.yml up -d
```
Shut down container
```
 docker-compose -f docker-compose-sql.yml down
```
### Run application in Docker
```
 docker-compose -f docker-compose.yml up -d
```

### Connecting to SQL Server

server: localhost
port: 1433
userid: sa
password : password setup in docker compose