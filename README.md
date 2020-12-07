# Jobs Application

## Introduction
- Simple client server app for querying relevant jobs according to specific query key.
- Server: built with C# and .NET Core 3.1
- Client: built with React.JS

## Installation

- Manual SQL Server:
    - Manualy install SQL server on your computer
    - Create user with password Password! and username sa
    - Create database with the name tempdb
- SQL Server with Docker:
    - Run the command `docker run -d -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Password!' -e 'MSSQL_PID_Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest`
- Run the /JobsApplication/CreateTestJobTitles.sql file to create table with Data
- Run the /JobsApplication/CreateTestJobs.sql file to create table with Data
- Run the command `git clone https://github.com/Omrisha/JobsApplication.git`
- Open the SLN file in Visual Studio/Rider/Visual Studio Code
- Run the project (or  `dotnet run` if in VSCode).  
    

