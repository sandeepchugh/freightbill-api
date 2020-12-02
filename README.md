### What is this?
This is a demo project for a .NET Core Api using domain driven design and hexagonal architecture:
- Api 
- Database and data setup using DbUp
- SQL Server running in a container

The Api is used to retrieve a list of freight bills

### How does this work?
#### Get Freight Bills

GET /freightbills

### How is this setup for development?
The project uses docker and docker compose to launch the database (SQL Server) in a container and DbUp to create the database, tables and test data

#### Database Setup
Install docker from https://www.docker.com/products/docker-desktop

SQL Server is run using docker and the database is currently not confugured to use a volume to persist the data. The DB will be destroyed when the container is shut down

Run the following command to launch SQL Server (docker-compose with docker-compose-sql.yml)
```
docker-compose -f docker-compose-sql.yml up
```
OR to run the container in the backgroupnd use the -d flag
```
docker-compose -f docker-compose-sql.yml -d up
```

Install the tables and test data
```
cd Freightbills.Database
dotnet run
```

Install Sql Client 

https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-setup-tools?view=sql-server-ver15#macos
OR
https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15


#### Configuring Logging

https://serilog.net

#### Running the application
```
cd Freightbills.Api
dotnet run
```
Launch the api in the browser or postman using the following url
```
https://localhost:5001/freightbills
```
