SQL & Entity Framework Core Project

How to Run the Project
First, download the SQL-Project.

Open the file creating tables.sql and execute the following line:

CREATE DATABASE ItStepProject

After that, select the ItStepProject database and execute the rest of the script to create all tables.

Next, open inserting data.sql, make sure the correct database is selected, and execute the script to insert the data.

Then open task.sql, select the correct database, and execute one task at a time to verify that it works correctly.

Finally, download the Entity-Framework-Core-Project and connect the database to it. If you don’t know how to do this, follow the instructions in How to Connect the Database to EF Core below.

How to Connect the Database to EF Core
To connect the database to EF Core, you need a connection string.

Run the following command in Package Manager Console:

Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=CinemaBooking;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir Data -DataAnnotations

Replace (localdb)\mssqllocaldb with your SQL Server name, which you can find in SQL Server Management Studio (SSMS).

Used Functions SQL (SSMS) Query Functions
INNER JOIN

LEFT JOIN / RIGHT JOIN

JOIN with 3 or more tables

COUNT + GROUP BY

SUM + GROUP BY

AVG / MIN / MAX

Entity Framework Core Features

Edit branch

Edit brand

Edit city

Edit contact type

Edit customer

Edit customer order

Edit model

Edit person

Edit person contact

Edit product

Edit product category

Edit product title

Edit street

Author

Lasha Maisuradze

Thanks
