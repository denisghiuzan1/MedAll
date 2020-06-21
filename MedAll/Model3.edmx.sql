
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/20/2020 22:30:05
-- Generated from EDMX file: C:\Users\dghiuzan\source\repos\MedAll\MedAll\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MedAll];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [PhoneNumer] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Doctors'
CREATE TABLE [dbo].[Doctors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Specialization] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Admins'
CREATE TABLE [dbo].[Admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [RoleId] int  NOT NULL
);
GO

-- Creating table 'Appointments'
CREATE TABLE [dbo].[Appointments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Patient_Id] int  NOT NULL,
    [Doctor_Id] int  NOT NULL,
    [Room_Id] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PatientDoctor'
CREATE TABLE [dbo].[PatientDoctor] (
    [Patients_Id] int  NOT NULL,
    [Doctors_Id] int  NOT NULL
);
GO

-- Creating table 'DoctorRoom'
CREATE TABLE [dbo].[DoctorRoom] (
    [Doctors_Id] int  NOT NULL,
    [Rooms_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [PK_Doctors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Admins'
ALTER TABLE [dbo].[Admins]
ADD CONSTRAINT [PK_Admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [PK_Appointments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Patients_Id], [Doctors_Id] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [PK_PatientDoctor]
    PRIMARY KEY CLUSTERED ([Patients_Id], [Doctors_Id] ASC);
GO

-- Creating primary key on [Doctors_Id], [Rooms_Id] in table 'DoctorRoom'
ALTER TABLE [dbo].[DoctorRoom]
ADD CONSTRAINT [PK_DoctorRoom]
    PRIMARY KEY CLUSTERED ([Doctors_Id], [Rooms_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patients_Id] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [FK_PatientDoctor_Patient]
    FOREIGN KEY ([Patients_Id])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Doctors_Id] in table 'PatientDoctor'
ALTER TABLE [dbo].[PatientDoctor]
ADD CONSTRAINT [FK_PatientDoctor_Doctor]
    FOREIGN KEY ([Doctors_Id])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientDoctor_Doctor'
CREATE INDEX [IX_FK_PatientDoctor_Doctor]
ON [dbo].[PatientDoctor]
    ([Doctors_Id]);
GO

-- Creating foreign key on [Patient_Id] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_AppointmentPatient]
    FOREIGN KEY ([Patient_Id])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentPatient'
CREATE INDEX [IX_FK_AppointmentPatient]
ON [dbo].[Appointments]
    ([Patient_Id]);
GO

-- Creating foreign key on [RoleId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_RoleUser]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUser'
CREATE INDEX [IX_FK_RoleUser]
ON [dbo].[Users]
    ([RoleId]);
GO

-- Creating foreign key on [Doctor_Id] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_AppointmentDoctor]
    FOREIGN KEY ([Doctor_Id])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentDoctor'
CREATE INDEX [IX_FK_AppointmentDoctor]
ON [dbo].[Appointments]
    ([Doctor_Id]);
GO

-- Creating foreign key on [Doctors_Id] in table 'DoctorRoom'
ALTER TABLE [dbo].[DoctorRoom]
ADD CONSTRAINT [FK_DoctorRoom_Doctor]
    FOREIGN KEY ([Doctors_Id])
    REFERENCES [dbo].[Doctors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Rooms_Id] in table 'DoctorRoom'
ALTER TABLE [dbo].[DoctorRoom]
ADD CONSTRAINT [FK_DoctorRoom_Room]
    FOREIGN KEY ([Rooms_Id])
    REFERENCES [dbo].[Rooms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorRoom_Room'
CREATE INDEX [IX_FK_DoctorRoom_Room]
ON [dbo].[DoctorRoom]
    ([Rooms_Id]);
GO

-- Creating foreign key on [Room_Id] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_AppointmentRoom]
    FOREIGN KEY ([Room_Id])
    REFERENCES [dbo].[Rooms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentRoom'
CREATE INDEX [IX_FK_AppointmentRoom]
ON [dbo].[Appointments]
    ([Room_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------