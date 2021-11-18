# Elections
Elections WebApi

Elections API

The aim of this project is to demostrate the use of Create, Read, Update, Delete operation in ASP.NET Core WebApi.

Endpoints of this API as it can be seen are consumed using ASP.NET Core MVC that is deployed under the Repository _______________________________
The whole excercise of demostration was simplified with the help of dependency injection whenever necessary in the code.

Tools used

I've written this webApi using Visual Studio Code editor.

   Below are VS code commands I've used for :-
      Creating project --------------------------> dotnet new webapi -n Elections
	  Building solution--------------------------> dotnet build
	  Running solution --------------------------> dotnet run	  
	  Installing EntityFramework in VS code -----> dotnet tool install --global dotnet-ef
	  Running migration -------------------------> dotnet ef migrations add ElectionsMigration
      For saving migration changes on DB--------->dotnet ef database update
    
Resources and Packages installed.

For securing my WebApi for authorisation i've decided to use JavaScript Object Notation Web Token (JWT).

Below are the packages that I've installed to achieve the simple task as outlined in the introduction,

For EntityFrameworkCore I've installed 
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
and 
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0

To enable EntityFrameworkCore to communication with the SQL Server Database I've installed 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0

I've also added Automapper for handling Data Transfer Objects (DTOs), below is the version I've installed
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 8.1.1

For testing this WebApi I've used SwaggerUI for basic tests
And PostMan was used mainly for testing more advanced tests like Authorization


