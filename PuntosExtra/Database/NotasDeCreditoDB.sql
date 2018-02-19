create database notasdecreditoDB
go

Create table NotasDeCredito
(
    notasID int primary key IDENTITY(1,1) not null,
	estudianteID int null,
	monto decimal null,
	fecha date null,
    pctBeca decimal null,
	montoAsignatura decimal null
);
