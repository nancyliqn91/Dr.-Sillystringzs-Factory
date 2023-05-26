# Dr. Sillystringz's Factory

#### By _Qian Li_  😊

#### This is my c# and .NET independent project which uses Many-To-Many Relationships to build an MVC web application.

## Technologies Used

* C#
* .NET
* HTML
* MVC
* Entity Framework
* MySQL Workbench
* VS code

## Description

* The factory manager should be able to keep track of the factory's machine repairs, manage their engineers and the machines they are licensed to fix. 
* The factory manager should be able to see engineers' status, like whether idle or not; and the status of the machine, like is operational or not.
* The factory manager should be able to track inspection dates to the machines and license renewal to the engineers.
* The factory manager should be able to see a table for incidents, showing which engineer repaired which machine.


## Setup/Installation Requirements

* _Clone “Dr.-Sillystringzs-Factory
“ from the repository to your desktop_.
* _Navigate to "Dr.-Sillystringzs-Factory
" directory via your local terminal command line_.
* Run the app, first navigate to this project's production directory called "Factory". 
* Add appsettings.json file, please see the "Database Connection String Setup" instruction below.
* Create the database using the migrations in the "Factory" project. Open your shell (e.g., Terminal or GitBash) to the production directory "Factory", and `run dotnet ef database update`.
* To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where MigrationName is your custom name for the migration in UpperCamelCase.
* Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
* Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Database Connection String Setup 

* Create an appsetting.json file in the "Factory" directory of the project. The example is below.
* Within appsettings.json, put in the following code, replacing the uid and pwd values with your own database name, username and password for MySQL Workbench.
* Please add this appsettings.json file to the .gitignore file before push this cloned project to a public-facing repository.

```
Dr.-Sillystringzs-Factory/Factory/appsettings.json

 {
    "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;
      database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USER-HERE];
      pwd=[YOUR-PASSWORD-HERE];"
    }
 }
```

## Known Bugs

No bugs 

## License
[MIT](license.txt)
Copyright (c) 2023 Qian Li
