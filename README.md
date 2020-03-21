# Eau Claire's Hair Salon

#### C# Database Basics Independent Project, 20 March 2020
 
#### By **_Jieun Kang_**

---

## Description
An MVC application which lets a user manage stylists and clients for a hair salon.

---
## Behavior Driven Development Specifications
|| Behavior(Spec)  | Input   | Output  |
|---| :---------------- | :----- | :----- |
|1| Upon launching the application, user sees homepage | http://localhost:5000 | Splash Page |
|2| User can view all stylists that currently exist | Click `Stylists` | Display a list of all stylists |

---

## Setup/Installation 
### :large_blue_diamond: Installing C# and .NET

* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

### :large_blue_diamond: Installing and Configuring MySQL
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

### :large_blue_diamond: Re-create the database
#### Using MySQL:
```
$ `$ mysql -uroot -pYOURPASSWORD`
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
1. Launch MySQL Workbench and open the _Navigator_ window.
2. In the _Navigator > Administration_ window, select _Data Import/Restore_.
3. In _Import Options_ select _Import from Self-Contained File_.
4. Under _Default Schema to be Imported To_, select the _New_ button.
    * Enter the name of database `jieun_kang`
5. Click _Start Import_.    
```
### # Run this project

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
* C#
* .NET
* ASP.NET Core MVC
* [MySQL](https://www.mysql.com/)
* MySQL Workbench
* Entity Framework 
* [Bootstrap v4.4](https://getbootstrap.com/docs/4.4/getting-started/introduction/)

---

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

:+1: Copyright (c) 2020 **_Jieun Kang_**