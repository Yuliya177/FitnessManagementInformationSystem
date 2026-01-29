#  Fitness Management Information System

Desktop application developed in C# with Microsoft SQL Server, designed to manage gym operations including clients, trainers, training sessions, and membership payments through a user-friendly forms interface.

## Features

- Client management (create, edit, delete, search)
- Trainer management
- Training session scheduling
- Client–trainer assignment tracking
- Payment status tracking
- Tracking training dates and attendance
- Input validation and error handling
- Full CRUD operations across core entities
- Forms-based user interface

## Technologies Used

- C# (.NET Framework 4.7.2, WinForms/WPF)
- Microsoft SQL Server
- ADO.NET
- SQL queries & relational database design

## Database

The system uses a relational database named `FitnessManagement` with the following tables:

- Clients
- Trainers
- Attendance
- Classes
- AttendanceClassesRelations
- AttendanceClientsRelations 

Referential integrity and foreign keys are used to ensure consistency.

##  How to Run

1. Download the named file `Project,sql` and the file `Project`
2. Execute the existing tables.
3. Update connection string in `App.config`:

Server=YOUR_SERVER_NAME;Database=FitnessManagement;Integrated Security=True;

6. Open the solution in Visual Studio and run the project
