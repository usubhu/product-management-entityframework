## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
 See deployment for notes on how to deploy the project on a live system.


### Installing

A step by step series of examples that tell you how to get a development env running
if aspnetcore-2.2 is not insalled in your computer you have to install it by this link
#### https://dotnet.microsoft.com/en-us/download/dotnet/2.2
    for SDK dotnet-sdk-2.2.110-win-<x32/x86> please download and install with the help of below link
    https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-2.2.110-windows-x86-installer

    for SDK aspnetcore-runtime-2.2.8-win-<x32/x86> please download and install with the help of below link
    https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-2.2.8-windows-x86-installer



#### Windows

- You need to have .Net Core 2.2 installed on your machine
- MSSQL localdb server

    
## How to Run
In order to run application you need to go SonForYou.Web project, and execute commands in bash/terminal below
This will run application in default mode

    dotnet run

This will run application, and start watch, each time you make changes in c# code, application will restart automatically

    dotnet watch run

## Running the tests

Currently there are no tests to run


## Built With

* [Asp.Net Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2) - The web framework used
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - ORM
* Sql servers 
    * [Microsoft SQL server](https://www.microsoft.com/en-us/sql-server/sql-server-2019) - Used Sql server for windows

