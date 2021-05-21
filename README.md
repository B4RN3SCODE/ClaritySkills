ClaritySkills


  - Restore NuGet packages (requires EntityFramework and Configuration Binder Interface)
  - Update the appsettings.json file with correct data strings
  - Rebuild Solution
  - Deploy

 
 
 To migrate the database run:
 
 dotnet EF migrations add nameofmig
 
 then 

 dotnet EF database update

 Or create database with:
  - Id (PRIMARY KEY IDENTITY AUTO INCR)
  - To (VARCHAR(32))
  - From (VARCHAR(32))
  - Subject (VARCHAR(255))
  - Body (TEXT)
  - Date (DateTime)
  - SendingStatus (VARCHAR(6))


 Check out the web app at https://clarity.projectsbybc.com/