# Eau Claire's Hair Salon

#### C# Database Basics Independent Project, 20 March 2020
 
#### By **_Jieun Kang_**

## Description
An MVC application which lets a user manage stylists and clients for a hair salon.

## Setup/Installation 
### # Installing C# and .NET
* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

### # Installing and Configuring MySQL
Follow the installation instructions below to installing **MySQL Community Server** and **MySQL Workbench**
#### MacOS
1. _Download from the [MySQL Community Server Page](https://dev.mysql.com/downloads/file/?id=484914)_ (Use the No thanks, just start my download link.)
2. _Download from the [MySQL Workbench Page](https://dev.mysql.com/downloads/file/?id=484391)_ (Use the No thanks, just start my download link.)
3. Verity MySQL installation by opening terminal and entering the command: <br>`$ mysql -uroot -pYOURPASSWORD`

#### Windows 10
1. _Download the [MySQL Web Installer](https://dev.mysql.com/downloads/file/?id=484919)_ (Use the No thanks, just start my download link.)
2. Add the MySQL environment variable to the System PATH.
    * Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
    * Then select PATH..., click Edit..., then Add.
    * Add the exact location of your MySQL installation, and click OK.
3. Add the exact location of your MySQL installation, and click OK.
4. Verity MySQL installation by opening terminal and entering the command: <br>`$ mysql -uroot -pYOURPASSWORD`

### # Run this project
1. Clone this project
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/HairSalon`
    * `$ cd HairSalon`
2. Add Dependencies for **Entity Framework Core**    
    * `$ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`
    * `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
3. Run this MVC application    
    * `$ dotnet restore` 
    * `$ dotnet build` 
    * `$ dotnet run` 
    * Launch localhost http://localhost:5000

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* dotnet script
* [Bootstrap v4.4](https://getbootstrap.com/docs/4.4/getting-started/introduction/)
* [MySQL](https://www.mysql.com/)
* MySQL Workbench
* Entity Framework Core

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**