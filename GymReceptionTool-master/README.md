# GymReceptionTool
In order to run the tool:
1) Install SQL Server 2018 & Management Studio
2) Run the CreateTables.sql found in the Databases Folder using SQL Server Management Studio
3) On the Login window Register a User and Login with said User.
4) Add a Default Membership with Name:Registration Amount:15 and Months:0  
5) Add an Instructor
6) Tool is ready for use 
Note: The reason is if you try to Add a member beforehand it will result in 2 exceptions because the first form is trying to find the Registration at ID 1 and atleast 1 Instructor.
