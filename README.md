# Contact Management Application
Contact Management Application using ASP.NET Core Web API 3.1, Bootstrap and Visual Studio. 

## Visual Code

### Prerequisite 
.Net Core 3.1<br />
npm 5.6.0 <br />

### Setup Project
git clone https://github.com/hafisali007/Contact-Management.git

### install npm packages and restore dotnet nuget pakages in command promt:
npm install <br />
dotnet restore  

### Update Connectionstring in Appsettings.json file
 "ConnectionStrings": {
    "ContactDb": "Data Source=DESKTOP-IS8B2G6\SQLSERVER2017;Initial Catalog=ContactDB;Integrated Security=True"
	}

### Update Database
dotnet ef database update

### run project
dotnet run
 
## Visual Studio
Create New project on ASP.NET Core Web API 3.1 Framework

### Setup Project
git clone https://github.com/hafisali007/Contact-Management.git

### install dotnet nuget pakages
EntityFrameWorkCore
EntityFrameWorkCore.sql
Microsoft.EntityFrameworkCore.Tools

### Update Connectionstring in Appsettings.json file
 "ConnectionStrings": {
    "ContactDb": "Data Source=DESKTOP-IS8B2G6\SQLSERVER2017;Initial Catalog=ContactDB;Integrated Security=True"
	}
	
### Update Database

### build and run project
	
### Step By Step Methods:

#### Create Contact Application using ASP.NET Core Web API and develop the Web API for contact CRUD operations.

#### Use of Code first Database Approach and migrate Datas to SQL Server and later use of Azure Sql server for deploy process.

#### Create MVC Controller connect with API Controller for implementing and consuming APIs.

#### Create Views from Controller to implement UI.

#### Develop the contact form & list component using Bootstrap Style that will consume Web API which we have created in above

#### Continuoes Integration done to git by commiting changes in codes.

#### Deploy/host a application with Visual Studio to Azure web apps.

### ScreenShots
![ScreenShot](https://contactmanagementevo.file.core.windows.net/contact/ContactList.png)

![ScreenShot](https://contactmanagementevo.file.core.windows.net/contact/ContactActions.png)
