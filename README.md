# Park Lookup API

##### Date: **07/04/2021**

#### By **_Salim Mayan_**

## Description

#### Web API for lookup of State and National parks was made using C#, SQL, and Entity. Swagger documentation was implemented which visually renders  API end point schema as a fully interactive document for live workability.

### Implemented User Stories

-   Full CRUD functionality.
-   Swagger documentation.

## Setup/Installation Requirements  

1. Clone this repository from GitHub using `git clone https://github.com/salimmayan/ParkLookUpAPI.Solution`

  

2. Open directory `https://github.com/salimmayan/ParkLookUpAPI.Solution` in VS Code

  

3. To install packages listed in `.csproj` file, from command line navigate to `ParkLookUpAPI` directory and then run `dotnet restore` (**'obj'** directory would get created in `ParkLookUpAPI` directory)

  

4. To create internal content for build, from command line navigate to `ParkLookUpAPI` directory and then run `dotnet build` (**'bin'** directory would get created in `ParkLookUpAPI` directory)

5. Create `appsettings.json` file (in path `ParkLookUpAPI\appsettings.json`) and add below lines (replace [PASSWORD] with your chosen password)

  

```
{
	"Logging": {
		"LogLevel": {
			"Default": "Warning",
			"System": "Information",
			"Microsoft": "Information"
		}
	},
	"AllowedHosts": "*",
	"ConnectionStrings": {
		"DefaultConnection": "Server=localhost;Port=3306;database=salim_mayan;uid=root;pwd=[PASSWORD];"
	}
}
```

  

6.  **Re-create Database with MySQL Workbench Migration Functionality**: From command line navigate to `ParkLookUpAPI` directory and execute below command

- dotnet ef database update

*Note*: In _MySQL Workbench_ Reopen the _Navigator_ > _Schemas_ tab. Right click and select _Refresh All_ (new database will appear with the name "salim_mayan".

  

7.  **Execute Application:** Navigate to `ParkLookUpAPI` directory and enter `dotnet run`

  

8. In Browser enter URL `http://localhost:5000` to access application

  

⚠️ *Note*: To run project locally you need to have .NET Core (confirm running of .NET Core using command `dotnet --version` in command line)

  
## API End points 

**Path to Swagger documentation**: http://localhost:5000/swagger/index.html
1. **GET Requests**

-   GET all Parks in the database (DB is seeded for 4 parks): `https://localhost:5001/api/parklookup/parks`
-   GET park by State name: `https://localhost:5001/api/parklookup/parks?state=<YOUR STATE HERE>`  (Ex: https://localhost:5001/api/parklookup/parks?state=wyoming) 
-   GET park by IsOpen attribute: `https://localhost:5001/api/parklookup/parks?isopen=<TRUE OR FALSE HERE>`  (Ex: https://localhost:5001/api/parklookup/parks?isopen=true)
-   GET park by State & IsOpen attribute: `https://localhost:5001/api/parklookup/parks?state=<YOUR STATE HERE>&isopen=<TRUE OR FALSE HERE>`  (Ex: https://localhost:5001/api/parklookup/parks?state=wyoming&isopen=true)
-   GET park by Id: `https://localhost:5001/api/parklookup/parks/<yourID here>` (Ex: https://localhost:5001/api/parklookup/parks/1)

2. **POST Request**

-   POST a new State or National Park to the database: `https://localhost:5001/api/parklookup/parks` (Ex: http://localhost:5000/api/parklookup/Parks) 

3. **DELETE Request**

-   DELETE an existing Park by specifying Id: `https://localhost:5001/api/parklookup/parks/{ID}` (Ex: http://localhost:5000/api/parklookup/Parks/1) 

4. **PUT Request**

-   PUT or update an existing Park record by specifying Id: `https://localhost:5001/api/parklookup/parks/{ID}` (Ex: http://localhost:5000/api/parklookup/Parks/1) 

## Known Bugs

* No Known bugs

## Improvement opportunities

* Build UI and link it to API

## Technologies Used

-   C# 9
-   ASP.NET MVC
-   .NET Core v5.0
-   RESTful Routing
-   SQL
-   Git and GitHub
-   Entity Framework Core

## Support and contact details

* For questions, comments, or concerns *[email author](mailto:mailsalim@gmail.com?subject=[GitHub])*


### License

*{This software is licensed under the MIT license}*

Copyright (c) 2021 **_{Salim Mayan}_**