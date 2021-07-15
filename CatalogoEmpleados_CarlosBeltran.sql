--SQL -> STRUCTURED QUERY LANGUAJE(Lenguaje Estructurado de Consulta)
--       _
--      | DDL -> DATA DEFINITION LANGUAJE 
--      |  (Lenguaje de difinición de datos)  --> CREATE, ALTER, DROP
--SQL -> |
--      | DML -> DATA MANIPULATION LANGUAJE 
--      |  (Lenguaje de manipulación de datos)--> SELECT, INSERT, UPDATE, DELETE
--      |_
USE master;

CREATE DATABASE CatalogoEmpleados_CarlosBeltran;
GO

USE CatalogoEmpleados_CarlosBeltran;

CREATE TABLE Empleado(
	IdEmpleado INT IDENTITY(1,1),
	Nombre VARCHAR(45) NOT NULL,
	Apellido1 VARCHAR(45) NOT NULL,
	Apellido2 VARCHAR(45) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Sueldo FLOAT NOT NULL,
	Departamento VARCHAR(45) NOT NULL,
	CONSTRAINT pk_Empleado PRIMARY KEY (IdEmpleado)
);
GO

-- REGISTROS PARA LA BASE DE DATOS
INSERT INTO Empleado (Nombre, Apellido1, Apellido2, FechaNacimiento, Sueldo, Departamento)
	VALUES ('Carlos Eduardo','Beltrán','Bernal','1997-10-14',16000,'Desarrollo');
INSERT INTO Empleado (Nombre, Apellido1, Apellido2, FechaNacimiento, Sueldo, Departamento)
	VALUES ('Daniela Arian','Beltrán','Bernal','2000-05-10',16000,'Ventas');
INSERT INTO Empleado (Nombre, Apellido1, Apellido2, FechaNacimiento, Sueldo, Departamento)
	VALUES ('Juan Carlos','Beltrán','Aguilar','1975-02-02',16000,'Marketing');

SELECT * FROM Empleado;

