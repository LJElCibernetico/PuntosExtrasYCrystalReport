Create DataBase estudiantesDB
go 

CREATE TABLE Estudiantes 
(
    estudianteID  INT primary key IDENTITY (1, 1) NOT NULL,
    nombre        VARCHAR (30)  NULL,
    montoDescuento DECIMAL (18)  NULL,
    observaciones VARCHAR (100) NULL,
    fecha  DATE          NULL
);
