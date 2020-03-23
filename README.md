# :haircut: Eau Claire's Hair Salon

#### C# Database Basics Independent Project, 20 March 2020
 
#### By **_Jieun Kang_**

---

## Description
A MVC application which lets a user manage stylists and clients for a hair salon.


---
## Behavior Driven Development Specifications
|| Behavior(Spec)  | Input   | Output  |
|---| :---------------- | :----- | :----- |
|1| Upon launching the application, user sees homepage | http://localhost:5000 | Splash Page |
|2| User can view all stylists that currently exist | Click `Stylists` in the navigation bar | Display a list of all stylists |
|3| User can add a new stylist <li>A application returns a form to enter the stylist's information</li> | Click <br>`Add new stylist`<li>Name: Danielle<li>Description: *** | Stylists <li>Danielle</li> |
|4| User can `see` each stylist's details <li> User can `edit` or `delete` selected stylist in Detail View | Click `Danielle` | Stylist Details: <li> Name: Danielle <li> Description: *** <li> Clients list |
|5| User can add a new client to a specific stylist | Click `Add a new client` <li>Name: Lilly <li>Phone Number: 111-222-3333<li>Email Address: j@mail.com <li>Stylist: Danielle | Clients list page will returned <br> Clients <li> Lilly : Danielle |   
|6| User can view all clients that currently exist for a specific stylist | Click `Clients` in the navigation bar | Display a list of all clients name and selected stylists name |
|7| User can see each client's details <li> User can `edit` or `delete` selected client in Detail View| Click `Lilly` | Client Detials:<li>Name: Lilly <li>Phone Number: 111-222-3333<li>Email Address: j@mail.com |

---

## Setup/Installation 
### :small_orange_diamond: Installing C# and .NET

* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

### :small_orange_diamond: Installing and Configuring MySQL
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

### :small_orange_diamond: Re-create the database
#### Using MySQL:
```
$ mysql -uroot -pYOURPASSWORD
mysql> CREATE DATABASE `jieun_kang`;
mysql> USE `jieun_kang`; 
mysql> CREATE TABLE `clients` (
        `ClientId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` varchar(255) DEFAULT NULL,
        `PhoneNumber` varchar(255) DEFAULT NULL,
        `EmailAddress` varchar(255) DEFAULT NULL,
        `StylistId` int(11) DEFAULT '0',
        PRIMARY KEY (`ClientId`));
mysql> CREATE TABLE `stylists` (
        `StylistId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` varchar(255) DEFAULT NULL,
        `Description` varchar(255) DEFAULT NULL,
        PRIMARY KEY (`StylistId`));
```

#### Import from the Cloned Repository
```
1. Launch MySQL Workbench and open the [Navigator] window.
2. In the [Navigator > Administration] window, select [Data Import/Restore].
3. In [Import Options] select [Import from Self-Contained File].
4. Under [Default Schema to be Imported To], select the [New] button. Enter the name of database "jieun_kang"
5. Click [Start Import].    
```

### :small_orange_diamond: Run this project

1. Clone this project
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/ClairesHairSalon`
    * `$ cd ClairesHairSalon`
2. Add Dependencies for **Entity Framework Core**    
    * `$ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`
    * `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
3. Run this MVC application    
    * `$ dotnet restore` 
    * `$ dotnet build` 
    * `$ dotnet run` 
    * Launch localhost http://localhost:5000

---

## Technologies Used
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://www.mysql.com/)
* [MySQL Workbench](https://www.mysql.com/products/workbench/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/#pivot=efcore)
* [Bootstrap v4.4](https://getbootstrap.com/docs/4.4/getting-started/introduction/)

---

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**
