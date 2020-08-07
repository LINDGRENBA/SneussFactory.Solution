# _Sneuss's Factory_

#### _C# ASP.NET Core MVC and EF Core, MySQL databases and Code First with Migration practice for Epicodus, 08.07.2020_

#### By _**Brittany Lindgren**_


## Description

_Welcome Dr. Sneuss! This application is here to help simplify your life and keep track of all your engineers and machines!_ 

## Specifications

| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|
|  |  |  |  |


## Stretch Goals
| Behavior   |   Input   |  Output |  Met? (Y/N)  |
|----------|:-------------:|------:|-----------:|


## User Stories  
* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.


## Setup/Installation Requirements

  1. Follow this [link to the project repository](https://github.com/LINDGRENBA/SneussFactory.Solution) on GitHub.  
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose **open with...** and open using a text editor such as VS Code or Atom, etc.
  8. Once you are inside of your text editor, open the terminal. If you are in VS Code for example, this can be done by clicking on `Terminal` at the top of the editor and then selecting `New Terminal`. **You can navigate to different directories in the project by typing `cd DirectoryName` to go down into specific directories or `cd ..` to go back up one directory. 
  9. Navigate to the Factory directory by typing `cd Factory` in your terminal and hitting `enter`. Then type the command `dotnet restore`,`dotnet build`, then `dotnet run` into your terminal and hit enter. You should see files appear inside of your bin folder. The bin folder should appear greyed out. 
  

#### Additional Setup/Installation Notes:

* You will need to configure the MySQL Workbench database in order to run this project. See directions below.   
* Do not alter the bin/ or obj/ directories or any of the files in them.

#### Configure the MySQL Workbench Database:
* Install MySQL and MySQL Workbench first. During installation of MySQL you will be asked to create a password. This is important! Take note of your password. Once you have installed MySQL and MySQL Workbenck, start MySQL by entering `mysql -uroot -p+_yourpassword_` in the terminal. Example: password is `tomato`, enter `mysql -uroot ptomato`. If this doesn't work in your terminal, try using your computer's command line interface application. If you are successful, you will see a message in the terminal, ending with the line `mysql>`. Once you have succesfully completed these steps, follow the instructions below.
*  Open MySQL Workbench and double click on the grey box under the line `MySQL Connections` (this box should say `mamp` and have some text and numbers ending in `:3306`). This will launch the MySQL Workbench. You may be prompted to enter the same password that you used in the previous step (ex: `tomato`).  


#### Import Database to MySQL Workbench

To set up the database for this project, you can follow the steps below to import it into MySQL Workbench.

  * Open the Navigator, click on the `Administration` tab
  * Select `Data Import/Restore`
  * Select the option to `Import from Self-Contained File`
  * To the right, click on the `...` box to select the database file from this project (the file in the root directory ending in .sql)
  * Below the items from the last step, you'll see `Default Schema to be Imported To`, select  `New...` 
  * Enter the name of the database, in this case `brittany_lindgren`
  * Select the `Import Progress` tab and click on the `Start Import` button.
  * Return to the Navigator window. Anywhere in that area, right click and select `refresh`
  * Your database should appear in the navigator window.    


#### Create a New Schema Query:
* You should see an icon in the upper left that looks like a little piece of paper with the letters `SQL` and a + sign. Hover over the icon and confirm that this is the 'create a new SQL tab for executing queries' icon. Once confirmed, double click the icon.
* Copy paste the code below into the Query tab.
* Then click 'execute' (this may appear as a lightening bolt icon).

##### SQL SCHEMA QUERY
```
CREATE DATABASE IF NOT EXISTS brittany_lindgren; USE brittany_lindgren;

```

#### Code First with Migrations
You can also populate the Database from the VS Code terminal using Migrations.
*  Enter the following into the VS Code terminal `dotnet ef migrations add Initial` and hit Enter
* Now enter `dotnet ef dtabase update` and hit Enter


#### Run the Application
* After you have completed setup and installation and configured the database, you can type the command `dotnet run` into your terminal.
* Once you see the message `now listening on: ... ` appear in your terminal, open your browser and type `localhost:5000` as the url. This should direct you to the main page of this project.


## Known Bugs

| Bug : Message |  Situation  | Resolved (Y/N) |  How was the issue resolved?  |
| ------- | ----- | ------ | ------- |
| MySqlException: Table 'brittany_lindgren_factory.engineermachine' doesn't exist | Add new Machine | N |  |
| DbUpdateException: An error occurred while updating the entries. See the inner exception for details | Add new Machine | N |  |


## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA) with any feedback, questions or concerns._


## Technologies Used

* C#
* .NET Core 2.2
* ASP.NET Core MVC
* Entity Framework Core
* Razor
* MySQL & MySQL Workbench
* Visual Studio Code
* Git Version Control
* GitHub


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Brittany Lindgren}_**