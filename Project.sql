CREATE DATABASE FitnessManagement
USE FitnessManagement

CREATE TABLE Trainers(
TrainerId int Identity(1,1) PRIMARY KEY,
FirstName nvarchar(50) NOT NULL, 
LastName nvarchar(50) NOT NULL
)

CREATE TABLE Clients(
ClientId int PRIMARY KEY, 
FirstName nvarchar(50) NOT NULL, 
LastName nvarchar(50) NOT NULL, 
Email varchar(50) UNIQUE NOT NULL,
PhoneNumber varchar(15) CHECK ((PhoneNumber) LIKE '+359%'),
StartDate date DEFAULT GETDATE(), 
)

CREATE TABLE Classes(
ClassesId int PRIMARY KEY, 
ClassesType nvarchar(50) NOT NULL, 
Price decimal NOT NULL CHECK (Price>0),
Date date NOT NULL, 
TrainerId int NOT NULL,
CONSTRAINT FK_Classes_Trainers FOREIGN KEY (TrainerId) REFERENCES Trainers(TrainerId)
)

CREATE TABLE Attendance(
AttendanceId int IDENTITY(1,1) PRIMARY KEY,
ClientId int NOT NULL,
ClassId int NOT NULL,
AttendanceDate date NOT NULL,
CONSTRAINT FK_Attendance_Clients FOREIGN KEY (ClientId) REFERENCES Clients(ClientId),
CONSTRAINT FK_Attendance_Classes FOREIGN KEY (ClassId) REFERENCES Classes(ClassesId)
)


INSERT INTO Trainers (FirstName, LastName)
VALUES 
('Emily', 'Ivanova'),
('Daniel', 'Dimitrov'),
('Sophia', 'Johnson'),
('James', 'Brown'),
('Olivia', 'Martinez'),
('Liam', 'Wilson'),
('Emma', 'Taylor'),
('Ethan', 'Moore'),
('Isabella', 'Harris'),
('Noah', 'Anderson')

INSERT INTO Clients (ClientId, FirstName, LastName, Email, PhoneNumber, StartDate)
VALUES 
(1, 'Georgi', 'Georgiev', 'georgi.georgiev@gmail.com', '+359123456789', '2024-01-01'),
(2, 'Mariya', 'Slavcheva', 'mariya.slavcheva@gmail.com', '+359987654321', '2024-01-02'),
(3, 'Ivan', 'Petrov', 'ivan.petrov@gmail.com', '+359555123456', '2024-01-03'),
(4, 'Stoyan', 'Dimitrov', 'stoyan.dimitrov@gmail.com', '+359444987654', '2024-01-04'),
(5, 'Raya', 'Kostova', 'raya.kostova@gmail.com', '+359333876543', '2024-01-05'),
(6, 'Elena', 'Ilieva', 'elena.ilieva@gmail.com', '+359222765432', '2024-01-06'),
(7, 'Martin', 'Nikolov', 'martin.nikolov@gmail.com', '+359111654321', '2024-01-07'),
(8, 'Desislava', 'Hristova', 'desislava.hristova@gmail.com', '+359777987654', '2024-01-08'),
(9, 'Nikola', 'Stanev', 'nikola.stanev@gmail.com', '+359888876543', '2024-01-09'),
(10, 'Petya', 'Ivanova', 'petya.ivanova@gmail.com', '+359999765432', '2024-01-10')

INSERT INTO Classes (ClassesId, ClassesType, Price, Date, TrainerId)
VALUES
(1,'Yoga', 50.00, '2024-01-10', 5),     
(2,'Cardio', 40.00, '2024-01-15', 3),   
(3,'Strength Training', 60.00, '2024-01-20', 10), 
(4,'Pilates', 55.00, '2024-01-25', 7),  
(5,'CrossFit', 70.00, '2024-01-30', 1), 
(6,'HIIT', 45.00, '2024-02-05', 2),     
(7,'Zumba', 35.00, '2024-02-10', 8),    
(8,'Boxing', 65.00, '2024-02-15', 9),   
(9,'Spinning', 50.00, '2024-02-20', 4), 
(10,'Aqua Aerobics', 60.00, '2024-02-25', 6)

INSERT INTO Attendance (ClientId, ClassId, AttendanceDate)
VALUES 
(1, 6, '2024-02-05'),   
(2, 8, '2024-02-15'),   
(3, 4, '2024-01-25'),   
(4, 7, '2024-02-10'),   
(5, 1, '2024-01-10'),   
(6, 9, '2024-02-20'),  
(7, 5, '2024-01-30'),   
(8, 2, '2024-01-15'),  
(9, 3, '2024-01-20'), 
(10, 10, '2024-02-25')


--2
SELECT FirstName, LastName, Email
FROM Clients

SELECT ClassesType, Price
FROM Classes

--3
SELECT ClassesType, Price, Date, TrainerId
FROM Classes
WHERE Price BETWEEN 40 AND 60 AND TrainerId > 3

SELECT ClientId
FROM Attendance
WHERE ClassId IN (2,3,4) AND  AttendanceDate> '2024-01-01'

--4
CREATE VIEW AverageClassPrice AS 
SELECT AVG(Price) AS AveragePrice
FROM Classes

SELECT * FROM AverageClassPrice

CREATE VIEW TrainerClassCount AS
SELECT TrainerId, COUNT(ClassesId) AS TotalClasses
FROM Classes
GROUP BY TrainerId

SELECT * FROM TrainerClassCount

--5
UPDATE Clients
SET PhoneNumber = '+359111223344'
WHERE ClientId = 1

UPDATE Classes
SET Price = 75.00
WHERE ClassesId = 5
 
--6
DELETE FROM Attendance
WHERE ClassId = 1

DELETE FROM Clients
WHERE ClientId NOT IN (SELECT DISTINCT ClientId FROM Attendance)

--7
SELECT FirstName, LastName, (SELECT ClassesType FROM Classes c WHERE t.TrainerId= c.TrainerId ) AS TypeClass
FROM Trainers t
WHERE EXISTS (SELECT TrainerId FROM Classes c WHERE t.TrainerId=c.TrainerId)
           
SELECT FirstName, LastName, Email, PhoneNumber
FROM Clients
WHERE  ClientId IN (SELECT ClientId FROM Attendance WHERE AttendanceDate > '2024-01-02' ) AND FirstName LIKE 'M%'