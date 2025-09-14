create database ProjectsMVCApplication
CREATE TABLE LoginTbl
(
    Id INT PRIMARY KEY IDENTITY(1,1),   -- auto increment
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    User_Role VARCHAR(50),
    PhoneNumber VARCHAR(50),
	Created_at DateTime
);

SELECT * FROM LoginTbl
INSERT INTO LoginTbl (Username, Password, Email, User_Role, PhoneNumber, created_at)
VALUES ('nehakumari', 'nehak@1234', 'nehak25@gmail.com', 'admin', '9098563256', GETDATE());