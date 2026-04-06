IF DB_ID('Student') IS NULL
BEGIN
    CREATE DATABASE Student;
END;
GO

USE Student;
GO

IF OBJECT_ID('dbo.Logins', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Logins
    (
        username NVARCHAR(50) NOT NULL PRIMARY KEY,
        password NVARCHAR(50) NOT NULL
    );
END;
GO

IF OBJECT_ID('dbo.Registration', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Registration
    (
        regNo INT NOT NULL PRIMARY KEY,
        firstName NVARCHAR(50) NULL,
        lastName NVARCHAR(50) NULL,
        dateOfBirth DATE NULL,
        gender NVARCHAR(50) NULL,
        address NVARCHAR(100) NULL,
        email NVARCHAR(100) NULL,
        mobilePhone INT NULL,
        homePhone INT NULL,
        parentName NVARCHAR(100) NULL,
        nic NVARCHAR(50) NULL,
        contactNo INT NULL
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Logins WHERE username = 'Admin')
BEGIN
    INSERT INTO dbo.Logins (username, password)
    VALUES ('Admin', 'Skills@123');
END;
GO