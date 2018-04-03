---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- CREACION DE LA BASE DE DATOS --------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------
use master
go
drop database GoLabs

create database GoLabs
go
use GoLabs

---------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------- FIN DE CREACION DE LA BASE DE DATOS ----------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- CREACION DE LAS REGLAS -----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

create rule RCorreo as (@Correo like '%@%.%')
go
exec sp_addtype		'TCorreo', 'varchar(50)', 'not null'
go
exec sp_bindrule	'RCorreo', 'TCorreo'
go

create rule RCedula as (@Cedula like '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'TCedula', 'char(11)', 'not null'
go
exec sp_bindrule	'RCedula', 'TCedula'
go

create rule RTelefono as (@Telefono like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
or (@Telefono like '([0-9][0-9][0-9]) [0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'TTelefono', 'varchar(15)', 'not null'
go
exec sp_bindrule	'RTelefono', 'TTelefono'
go

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- FIN DE CREACION DE LAS REGLAS -------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- CREACION DE LAS TABLAS -----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------
--select * from Proyecto
--Select c.nombre, p.* from Proyecto as p join Cliente as c on p.IDcliente = c.IDcliente
--select cl.*, c.* from Cliente as cl join Contacto as c on cl.IDcliente = c.IDcliente
--delete from Socio
--delete from Persona
--Select p.*, c.* from Persona as p join Colaborador as c on p.cedula = c.cedula
--Select p.*, s.* from Persona as p join Socio as s on p.cedula = s.cedula
--delete from Persona where cedula = '2-0738-0929'
--select * from Persona
--Select * from Persona where cedula = '2-123-0123'
--select * from Socio
--Select p.nombre, p.apellido1, p.apellido2 from Persona as p join Colaborador as c on p.cedula = c.cedula
create table Persona(
	cedula		TCedula not null,
	direccion	varchar(200) not null,
	correo		TCorreo,
	telefono	TTelefono,
	nombre		varchar (30) not null,
	apellido1	varchar (30) not null,
	apellido2	varchar (30) not null

	constraint PK_PERSONA primary key (cedula)
)
go
--select * from Persona
create table Colaborador(
	cedula				TCedula not null,
	nivel				varchar(30) not null,
	salario				money not null,
	cantidadVacaciones	int not null,
	annoLaborados		int not null

	constraint FK_PERSONA_COLABORADOR foreign key (cedula) references Persona (cedula) on delete cascade on update cascade
	constraint PK_COLABORADOR primary key (cedula)
)
go 

create table Vacaciones(
	nombreColaborador		varchar(30) not null,
	IDVacaciones			int not null,
	cantidadTiempoFuera		int not null,
	fecha					varchar(50) not null

	constraint PK_VACACIONES primary key (IDVacaciones)
)
go

create table Socio(
	cedula					Tcedula not null,
	aportacion				money not null,
	porcentajeAccionario	float not null

	constraint PK_SOCIO primary key (cedula)
	constraint FK_PERSONA_SOCIO Foreign KEY (cedula) references Persona (cedula) on delete cascade on update cascade
)
go
 
create table tipoIngreso(
	IDtipoIngreso	int not null,
	nombreIngreso	varchar(30) not null

	constraint PK_TIPOINGRESO primary key (IDTipoIngreso)
)
go
 
create table Ingreso(
	IDingreso		int not null,
	IDtipoIngreso	int not null,
	numeroFactura	int not null,
	observaciones	varchar(200) not null,
	monto			money not null,
	fecha			date not null

	constraint PK_INGRESO PRIMARY KEY (IDingreso)
	constraint FK_TIPOINGRESO_INGREOS foreign key (IDtipoIngreso) references tipoIngreso (IDtipoIngreso) on delete cascade on update cascade
)
go

--Select nombre, IDcliente from Cliente 
create table Cliente( --Informacion de la Empresa Cliente
	IDcliente	int not null,
	nombre		varchar(30) not null,
	pais		varchar(30) not null,
	ocupacion	varchar (30) not null,
	sitioWeb	varchar(30) not null

	constraint PK_CLIENTE primary key (IDcliente)
)
go

create table Contacto( --Almacena el Contacto del Cliente
	nombreCompleto	varchar(50) not null,
	IDcliente		int not null,
	puesto			varchar(30) not null,
	correo			TCorreo not null

	constraint FK_CLIENTE_CONTACTO foreign key (IDcliente) references Cliente (IDCliente) on delete cascade on update cascade
	constraint PK_CONTACTO primary key (IDCliente)
)
go
 
create table Tecnologia(
	IDtecnologia		int not null,
	nombreTecnologia	varchar(30) not null

	constraint PK_TECNOLOGIA primary key (IDtecnologia)
)
go
 
create table Factura(
	IDfactura			int not null,
	IDcliente			int not null,
	montoTotal			money not null,
	fechaEmision		date not null default convert (date, getdate()),
	fechaMaximaCobro	date not null

	constraint PK_FACTURA primary key (IDfactura)
	CONSTRAINT FK_FACTURA_CLIENTE foreign key (IDcliente) references Cliente (IDcliente) on delete cascade on update cascade
)
go

create table detalleFactura(
	IDdetalleFactura	int not null,
	detalle				varchar(200) not null,
	IDfactura			int not null,
	cantidad			int not null,
	costoUnitario		money not null,
	totalLinea			money not null
	
	constraint PK_DETALLEFACTURA primary key (IDdetalleFactura)
	constraint FK_DETALLEFACTURA_FACTURA Foreign key (IDfactura) references Factura (IDfactura) on delete cascade on update cascade
)
go
--select * from Proyecto
---delete from Proyecto
create table Proyecto(
	IDproyecto						int not null,
	cliente							varchar(30) not null,
	nombreProyecto					varchar(30) not null,
	observaciones					varchar(200) not null,
	fechaInicio						varchar(50) not null,
	fechaFinalizacion				varchar(50) not null,
	fechaPrevistaFinalizacion		varchar(50) not null

	constraint PK_PROYECTO primary key (IDproyecto)
)
go
 
create table proyectoTecnologia(
	IDproyecto		int not null,
	IDtecnologia	int not null

	constraint FK_TECNOLOGIA_PROYECTOTECNOLOGIA foreign key (IDtecnologia) references Tecnologia (IDtecnologia) on delete cascade on update cascade,
	constraint FK_PROYECTO_PROYECTOTECNOLOGIA foreign key (IDproyecto) references Proyecto (IDproyecto) on delete cascade on update cascade,
	constraint PK_PROYECTOTECNOLOGIA primary key (IDproyecto, IDtecnologia)
)
go
 
create table proyectoIngreso(
	IDingreso		int not null, 
	IDproyecto		int not null

	constraint FK_INGRESO_PROYECTOINGRESO foreign key (IDingreso) references Ingreso (IDingreso) on delete cascade on update cascade,
	constraint FK_PROYECTO_PROYECTOINGRESO foreign key (IDproyecto) references Proyecto (IDproyecto) on delete cascade on update cascade,
	constraint PK_PROYECTOINGRESO primary key (IDproyecto, IDingreso)
)
go
 
create table tipoGasto(
	IDtipoGasto		int not null,
	nombre			varchar(30) not null

	constraint PK_TIPOGASTO primary key (IDtipoGasto)
)
go
 
create table Gasto(
	IDgasto			int not null,
	IDtipoGasto		int not null,
	monto			money not null,
	fechaEmision	date not null default convert (date, getdate()),
	observacion		varchar(200) not null

	constraint PK_GASTO primary key (IDgasto)
	constraint FK_TIPOGASTO_GASTO foreign key (IDtipoGasto) references tipoGasto (IDtipoGasto) on delete cascade on update cascade
)
go
 
create table colaboradorProyecto(
	IDproyecto			int not null,
	cedulaColaborador	TCedula not null,
	fechaInicio			date not null,
	fechaFinal			date not null,
	participacion		float not null

	constraint FK_PROYECTO_COLABORADORPROYECTO foreign key (IDproyecto) references Proyecto (IDproyecto) on delete cascade on update cascade,
	constraint FK_COLABORADOR_COLABORADORPROYECTO foreign key (cedulaColaborador) references Colaborador (cedula) on delete cascade on update cascade,
	constraint PK_COLABORADORPROYECTO primary key (IDproyecto, cedulaColaborador)
)
go

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------ FIN DE CREACION DE LAS TABLAS --------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- CREACION DE LAS INSERCIONES ---------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

select * from Persona
select * from Colaborador
select * from Socio
select * from Cliente
select * from Contacto
select * from Gasto
select * from colaboradorProyecto
select * from proyectoIngreso
select * from proyectoTecnologia
select * from detalleFactura
select * from Proyecto
select * from Tecnologia
select * from Ingreso
select * from Factura
 
 
--Datos de persona
insert into Persona values('2-0723-0903','Cuidad Quesada','crisly@gmail.com','2460-3131','Crisly','Gonzalez','Sanchez')--Colaborador
 
insert into Persona values('2-0723-0904','Fortuna','rafa@gmail.com','2460-3130','Rafael','Quesada','Jimenez')--Colaborador
 
insert into Persona values('2-0723-0907','San Carlos','marta@gmail.com','2460-2051','Marta','Sanchez','Quiros')--Colaborador
 
insert into Persona values('2-0723-0905','Santa Clara','luis@gmail.com','2460-0102','Crisly','Arce','Rodriguez')--Socio
 
insert into Persona values('2-0723-0906','San Jose','fernando@gmail.com','2460-6963','Crisly','Sanchez','Sanchez')--Socio
 
update Persona set nombre='Luis' where cedula = '2-0723-0905'
update Persona set nombre='Fernando' where cedula = '2-0723-0906'
 
--Datos Colaborador
insert into Colaborador values('2-0723-0903','Middle',3500,12,1)
insert into Colaborador values('2-0723-0904','Junior',300,6,1)
 
--Datos Socio
insert into Socio values ('2-0723-0905',50000,25)
insert into Socio values ('2-0723-0906',50000,25)
 
--Datos Empresa
insert into Cliente values (01,'belc','Ecuador','Finanzas','www.belc.com')
insert into Cliente values (02,'bitback','U.S.A','Ventas','www.bitback.com')
 
--Datos Contactos
insert into Contacto values('Byron Cruz Avila',02,'Gerente de proyecto','bryron@bitback.com')
insert into Contacto values('Carolina Tuz Arce',01,'Administrador','carolTuz@bitback.com')
 
--Datos tipoGasto
 
insert into tipoGasto values (01,'Café y Galletas')
insert into tipoGasto values (02,'Lapiceros,fichas')
insert into tipoGasto values (03,'equipo de oficina')
 
--Datos Gasto
insert into Gasto values(001,01,500,'20140219','Comida')
insert into Gasto values(002,02,500,'20150109','materiales de oficina')
insert into Gasto(IDgasto, IDtipoGasto, monto, observacion) values(003,03,500, 'Nuevo colaborador contratado')
 
--Datos Vacaciones 
insert into Vacaciones values('2-0723-0903',01,3,'20150425')
insert into Vacaciones values('2-0723-0904',02,1,'20150320')

--Datos tipoIngreso
insert into tipoIngreso values(01,'Proyecto bitback')
insert into tipoIngreso values(02,'Aportacion')
insert into tipoIngreso values(03,'Aseguramiento de la Calidad')
insert into tipoIngreso values(04,'Consultoria')

--Datos Ingresos
insert into Ingreso values(001,01,001,'Ingreso del mes de enero bitback',1000500,'20150120')
insert into Ingreso values(002,02,100,'Aportacion de Socio Luis',50000,'20150425')
insert into ingreso values(008,03,200,'venta de servicios de QA',200000, '20150203')
insert into ingreso values(005,04,150,'consultorias',300000,'20150315')
 
--Datos Tecnologia
insert into Tecnologia values(00,'JavaScript')
insert into Tecnologia values(01,'Android')
insert into Tecnologia values(02,'Ruby on Rails')
 
 
--Datos de Facturas
insert into Factura(IDfactura, IDcliente, montoTotal, fechaMaximaCobro) values(100,01,50000,'20150225')
insert into Factura values(101,02,100000,'20150425','20150526')
 
--Datos de Detalle de Factura
insert into detalleFactura values(01,'Pago del proyecto',100,1,1000500,5000000)
insert into detalleFactura values(02,'QA',101,1,100000,300000)
 
--Datos Proyecto
insert into Proyecto(IDproyecto, IDcliente, nombreProyecto, observaciones, fechaFinalizacion, fechaPrevistaFinalizacion) values(001,01,'bit','desarrollo web', '20150425','20150418')
insert into Proyecto values(002,02,'bitback','desarrollo movil y web','20150318','20150919','20150910')
 
 
--Datos Proyecto_Tecnologia
insert into proyectoTecnologia values(001,00)
insert into proyectoTecnologia values(002,01)
 
--Datos Proyecto_Ingreso
insert into proyectoIngreso values(001,001)
insert into proyectoIngreso values(002,002)
 
--Datos colaborador_Proyecto
insert into colaboradorProyecto values(001,'2-0723-0903','20150102','20150425',100)
insert into colaboradorProyecto values(002,'2-0723-0904','20150318','20150901',90)

---------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------- FIN DE CREACION DE LAS INSERCIONES -----------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------- CREACION DE LAS CONSULTAS ----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

--1-- Obtener la informacion de los colaboradores de un proyecto especifico

select c.* from Colaborador as c join colaboradorProyecto as p on c.cedula = p.cedulaColaborador
where p.IDproyecto = 001

--2-- Obtener el detalle de la factura de un cliente especifico

select DF.* from detalleFactura as DF join Factura as f on DF.IDfactura = f.IDfactura
join Cliente as c on f.IDcliente = c.IDcliente where c.IDcliente = 002

--3-- Obtener el monto del Ingreso de un Proyecto especifico

select i.monto from Ingreso as i join proyectoIngreso as prI on i.IDingreso = prI.IDingreso
join Proyecto as p on prI.IDproyecto = p.IDproyecto where p.IDproyecto = 001

--4-- Obtener la tecnologia del proyecto en la que trabaja un colaborador especifico

select p.nombreProyecto, t.* from Tecnologia as t join proyectoTecnologia as pT on t.IDtecnologia = pT.IDtecnologia
join Proyecto as p on pT.IDproyecto = p.IDproyecto join colaboradorProyecto as cP on cP.IDproyecto = p.IDproyecto
where cP.cedulaColaborador = '2-0723-0903'

--5-- Obtener las vacaciones de un colaborador que trabaja en el proyecto de un cliente especifico

select v.* from Vacaciones as v join Colaborador as c on v.cedulaColaborador = c.cedula join colaboradorProyecto
as cP on c.cedula = cP.cedulaColaborador join Proyecto as p on cP.IDproyecto = p.IDproyecto
join Cliente cl on p.IDcliente = cl.IDcliente where cl.IDcliente = 001

---------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------- FIN DE CREACION DE LAS CONSULTAS ------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------- CREACION DE LAS VISTAS -----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

--1--
create view informacionGasto
as
	select tG.nombre, g.monto, g.observacion from tipoGasto as tG join Gasto as g on tG.IDtipoGasto = g.IDtipoGasto
go
select * from informacionGasto

--2--
create view informacionIngresoProyecto
as
	select i.monto, p.nombreProyecto from Ingreso as i join proyectoIngreso as prI on i.IDingreso = prI.IDingreso join Proyecto as p on prI.IDproyecto = p.IDproyecto
go
select * from informacionIngresoProyecto

--3--
create view informacionTecnologiaProyecto
as
	select p.nombreProyecto, t.nombreTecnologia from Tecnologia as t join proyectoTecnologia as pT on t.IDtecnologia = pT.IDtecnologia join Proyecto as p on pT.IDproyecto = p.IDproyecto
go
select * from informacionTecnologiaProyecto

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- FIN DE CREACION DE LAS VISTAS -------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- CREACION DE PROCESOS DE INSERCION ---------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

create procedure insertarPersonas
	@cedula		TCedula,
	@direccion	varchar(200),
	@correo		TCorreo,
	@telefono	TTelefono,
	@nombre		varchar (30),
	@apellido1	varchar (30),
	@apellido2	varchar (30)
as
	Insert Persona (cedula, direccion, correo, telefono, nombre, apellido1, apellido2)
	values (@cedula, @direccion, @correo, @telefono, @nombre, @apellido1, @apellido2)
go

create procedure insertarColaborador
	@cedula				TCedula,
	@nivel				varchar(30),
	@salario			money,
	@cantidadVacaciones	int,
	@annoLaborados		int
as
	Insert Colaborador (cedula, nivel, salario, cantidadVacaciones, annoLaborados)
	Values (@cedula, @nivel, @salario, @cantidadVacaciones, @annoLaborados)
go
--select * from Vacaciones
create procedure insertarVacaciones
	@nombreColaborador		varchar(30),
	@IDVacaciones			int,
	@cantidadTiempoFuera	int,
	@fecha					varchar(50)
as
	Insert Vacaciones (nombreColaborador, IDVacaciones, cantidadTiempoFuera, fecha)
	Values (@nombreColaborador, @IDVacaciones, @cantidadTiempoFuera, @fecha)
go

create procedure insertarSocio
	@cedula					Tcedula,
	@aportacion				money,
	@porcentajeAccionario	float
as
	Insert Socio (cedula, aportacion, porcentajeAccionario)
	Values (@cedula, @aportacion, @porcentajeAccionario)
go

create procedure insertarTipoIngreso
	@IDtipoIngreso	int,
	@nombreIngreso	varchar(30)
as
	Insert tipoIngreso (IDtipoIngreso, nombreIngreso)
	Values (@IDtipoIngreso, @nombreIngreso)
go

create procedure insertarIngreso
	@IDingreso		int,
	@IDtipoIngreso	int,
	@numeroFactura	int,
	@observaciones	varchar(200),
	@monto			money,
	@fecha			date
as
	Insert Ingreso (IDingreso, IDtipoIngreso, numeroFactura, observaciones, monto, fecha)
	Values (@IDingreso, @IDtipoIngreso, @numeroFactura, @observaciones, @monto, @fecha)
go

create procedure insertarCliente
	@IDcliente	int,
	@nombre		varchar(30),
	@pais		varchar(30),
	@ocupacion	varchar (30),
	@sitioWeb	varchar(30)
as
	Insert Cliente (IDcliente, nombre, pais, ocupacion, sitioWeb)
	Values (@IDcliente, @nombre, @pais, @ocupacion, @sitioWeb)
go

create procedure insertarContacto
	@nombreCompleto	varchar(50),
	@IDcliente		int,
	@puesto			varchar(30),
	@correo			TCorreo
as
	Insert Contacto (nombreCompleto, IDcliente, puesto, correo)
	Values (@nombreCompleto, @IDcliente, @puesto, @correo)
go

create procedure insertarTecnologia
	@IDtecnologia		int,
	@nombreTecnologia	varchar(30)
as
	Insert Tecnologia (IDtecnologia, nombreTecnologia)
	Values (@IDtecnologia, @nombreTecnologia)
go

create procedure insertarFactura
	@IDfactura			int,
	@IDcliente			int,
	@montoTotal			money,
	@fechaEmision		date,
	@fechaMaximaCobro	date
as
	Insert Factura (IDfactura, IDcliente, montoTotal, fechaEmision, fechaMaximaCobro)
	Values (@IDfactura, @IDcliente, @montoTotal, @fechaEmision, @fechaMaximaCobro)
go

create procedure insertarDetalleFactura
	@IDdetalleFactura	int,
	@detalle			varchar(200),
	@IDfactura			int,
	@cantidad			int,
	@costoUnitario		money,
	@totalLinea			money
as
	Insert detalleFactura (IDdetalleFactura, detalle, IDfactura, cantidad, costoUnitario, totalLinea)
	Values (@IDdetalleFactura, @detalle, @IDfactura, @cantidad, @costoUnitario, @totalLinea)
go

create procedure insertarProyecto
	@IDproyecto						int,
	@cliente						varchar(30),
	@nombreProyecto					varchar(30),
	@observaciones					varchar(200),
	@fechaInicio					varchar(50),
	@fechaFinalizacion				varchar(50),
	@fechaPrevistaFinalizacion		varchar(50)
as
	Insert Proyecto (IDproyecto, cliente, nombreProyecto, observaciones, fechaInicio, fechaFinalizacion, fechaPrevistaFinalizacion)
	Values (@IDproyecto, @cliente, @nombreProyecto, @observaciones, @fechaInicio, @fechaFinalizacion, @fechaPrevistaFinalizacion)
go

create procedure insertarProyectoTecnologia
	@IDproyecto		int,
	@IDtecnologia	int
as
	Insert proyectoTecnologia (IDproyecto, IDtecnologia)
	Values (@IDproyecto, @IDtecnologia)
go

create procedure insertarProyectoIngreso
	@IDingreso		int, 
	@IDproyecto		int
as
	Insert proyectoIngreso (IDingreso, IDproyecto)
	Values (@IDingreso, @IDproyecto)
go

create procedure insertarTipoGasto
	@IDtipoGasto	int,
	@nombre			varchar(30)
as
	Insert tipoGasto (IDtipoGasto, nombre)
	Values (@IDtipoGasto, @nombre)
go

create procedure insertarGasto
	@IDgasto		int,
	@IDtipoGasto	int,
	@monto			money,
	@fechaEmision	date,
	@observacion	varchar(200)
as
	Insert Gasto (IDgasto, IDtipoGasto, monto, fechaEmision, observacion)
	Values (@IDgasto, @IDtipoGasto, @monto, @fechaEmision, @observacion)
go

create procedure insertarColaboradorProyecto
	@IDproyecto			int,
	@cedulaColaborador	TCedula,
	@fechaInicio		date,
	@fechaFinal			date,
	@participacion		float
as
	Insert colaboradorProyecto (IDproyecto, cedulaColaborador, fechaInicio, fechaFinal, participacion)
	Values (@IDproyecto, @cedulaColaborador, @fechaInicio, @fechaFinal, @participacion)
go

---------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------- FIN DE CREACION DE PROCESOS DE INSERCION ------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------- CREACION DE PROCESOS DE MODIFICACION ------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

create procedure modificarPersona
	@cedula		TCedula,
	@direccion	varchar(200),
	@correo		TCorreo,
	@telefono	TTelefono,
	@nombre		varchar (30),
	@apellido1	varchar (30),
	@apellido2	varchar (30)
as
	if ((select COUNT(cedula) from Persona where cedula = @cedula) <> 0)
	begin
		update Persona
		set direccion = @direccion, correo = @correo, telefono = @telefono, nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2
		where cedula = @cedula
	end
go

create procedure modificarColaborador
	@cedula				TCedula,
	@nivel				varchar(30),
	@salario			money,
	@cantidadVacaciones	int,
	@annoLaborados		int
as
	if ((select COUNT(cedula) from Colaborador where cedula = @cedula) <> 0)
	begin
		update Colaborador
		set nivel = @nivel, salario = @salario, cantidadVacaciones = @cantidadVacaciones, annoLaborados = @annoLaborados
		where cedula = @cedula
	end
go

create procedure modificarVacaciones
	@nombreColaborador		varchar(30),
	@IDVacaciones			int,
	@cantidadTiempoFuera	int,
	@fecha					varchar(50)
as
	if ((select COUNT(IDVacaciones) from Vacaciones where IDVacaciones = @IDVacaciones) <> 0)
	begin
		update Vacaciones
		set nombreColaborador = @nombreColaborador, cantidadTiempoFuera = @cantidadTiempoFuera, fecha = @fecha
		where IDVacaciones = @IDVacaciones
	end
go

create procedure modificarSocio
	@cedula					Tcedula,
	@aportacion				money,
	@porcentajeAccionario	float
as
	if ((select COUNT(cedula) from Socio where cedula = @cedula) <> 0)
	begin
		update Socio
		set aportacion = @aportacion, porcentajeAccionario = @porcentajeAccionario
		where cedula = @cedula
	end
go

create procedure modificarTipoIngreso
	@IDtipoIngreso	int,
	@nombreIngreso	varchar(30)
as
	if ((select COUNT(IDtipoIngreso) from tipoIngreso where IDtipoIngreso = @IDtipoIngreso) <> 0)
	begin
		update tipoIngreso
		set nombreIngreso = @nombreIngreso
	end
go

create procedure modificarIngreso
	@IDingreso		int,
	@IDtipoIngreso	int,
	@numeroFactura	int,
	@observaciones	varchar(200),
	@monto			money,
	@fecha			date
as
	if ((select COUNT(IDingreso) from Ingreso where IDingreso = @IDingreso) <> 0)
	begin
		update Ingreso
		set IDtipoIngreso = @IDtipoIngreso, numeroFactura = @numeroFactura, observaciones = @observaciones, monto = @monto, fecha = @fecha
		where IDingreso = @IDingreso
	end
go

create procedure modificarCliente
	@IDcliente	int,
	@nombre		varchar(30),
	@pais		varchar(30),
	@ocupacion	varchar (30),
	@sitioWeb	varchar(30)
as
	if ((select COUNT(IDcliente) from Cliente where IDcliente = @IDcliente) <> 0)
	begin
		update Cliente
		set nombre = @nombre, pais = @pais, ocupacion = @ocupacion, sitioWeb = @sitioWeb
		where IDcliente = @IDcliente
	end
go

create procedure modificarContacto
	@nombreCompleto	varchar(50),
	@IDcliente		int,
	@puesto			varchar(30),
	@correo			TCorreo
as
	if ((select COUNT(IDcliente) from Contacto where IDcliente = @IDcliente) <> 0)
	begin
		update Contacto
		set nombreCompleto = @nombreCompleto, puesto = @puesto, correo = @correo
		where IDcliente = @IDcliente
	end
go

create procedure modificarTecnologia
	@IDtecnologia		int,
	@nombreTecnologia	varchar(30)
as
	if ((select COUNT(IDtecnologia) from Tecnologia where IDtecnologia = @IDtecnologia) <> 0)
	begin
		update Tecnologia
		set nombreTecnologia = @nombreTecnologia
		where IDtecnologia = @IDtecnologia
	end
go

create procedure modificarFactura
	@IDfactura			int,
	@IDcliente			int,
	@montoTotal			money,
	@fechaEmision		date,
	@fechaMaximaCobro	date
as
	if ((select COUNT(IDfactura) from Factura where IDfactura = @IDfactura) <> 0)
	begin
		update Factura
		set IDcliente = @IDcliente, montoTotal = @montoTotal, fechaEmision = @fechaEmision, fechaMaximaCobro = @fechaMaximaCobro
		where IDfactura = @IDfactura
	end
go

create procedure modificarDetalleFactura
	@IDdetalleFactura	int,
	@detalle			varchar(200),
	@IDfactura			int,
	@cantidad			int,
	@costoUnitario		money,
	@totalLinea			money
as
	if ((select COUNT(IDdetalleFactura) from detalleFactura where IDdetalleFactura = @IDdetalleFactura) <> 0)
	begin
		update detalleFactura
		set detalle = @detalle, IDfactura = @IDfactura, cantidad = @cantidad, costoUnitario = @costoUnitario, totalLinea = @totalLinea
		where IDdetalleFactura = @IDdetalleFactura
	end
go

create procedure modificarProyecto
	@IDproyecto						int,
	@cliente						varchar(30),
	@nombreProyecto					varchar(30),
	@observaciones					varchar(200),
	@fechaInicio					varchar(50),
	@fechaFinalizacion				varchar(50),
	@fechaPrevistaFinalizacion		varchar(50)
as
	if ((select COUNT(IDproyecto) from Proyecto where IDproyecto = @IDproyecto) <> 0)
	begin
		update Proyecto
		set cliente = @cliente, nombreProyecto = @nombreProyecto, observaciones = @observaciones, fechaInicio = @fechaInicio, fechaFinalizacion = @fechaFinalizacion, fechaPrevistaFinalizacion = @fechaPrevistaFinalizacion
		where IDproyecto = @IDproyecto
	end
go

create procedure modificarTipoGasto
	@IDtipoGasto	int,
	@nombre			varchar(30)
as
	if ((select COUNT(IDtipoGasto) from tipoGasto where IDtipoGasto = @IDtipoGasto) <> 0)
	begin
		update tipoGasto
		set nombre = @nombre
		where IDtipoGasto = @IDtipoGasto
	end
go

create procedure modificarGasto
	@IDgasto		int,
	@IDtipoGasto	int,
	@monto			money,
	@fechaEmision	date,
	@observacion	varchar(200)
as
	if ((select COUNT(IDgasto) from Gasto where IDgasto = @IDgasto) <> 0)
	begin
		update Gasto
		set IDtipoGasto = @IDtipoGasto, monto = @monto, fechaEmision = @fechaEmision, observacion = @observacion
		where IDgasto = @IDgasto
	end
go

create procedure modificarColaboradorProyecto
	@IDproyecto			int,
	@cedulaColaborador	TCedula,
	@fechaInicio		date,
	@fechaFinal			date,
	@participacion		float
as
	if ((select COUNT(cedulaColaborador) from colaboradorProyecto where IDproyecto = @IDproyecto and cedulaColaborador = @cedulaColaborador) <> 0)
	begin
		update colaboradorProyecto
		set fechaInicio = @fechaInicio, fechaFinal = @fechaFinal, participacion = @participacion
		where IDproyecto = @IDproyecto and cedulaColaborador = @cedulaColaborador
	end
go

---------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------- FIN DE CREACION DE PROCESOS DE MODIFICACION ----------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------ CREACION DE PROCESOS DE ELIMINACION-- ------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------

create procedure eliminarPersona
	@cedula		TCedula
as
	if ((select COUNT(cedula) from Persona where cedula = @cedula) <> 0)
	begin
		delete from Persona where cedula = @cedula
	end
go

create procedure eliminarColaborador
	@cedula				TCedula
as
	if ((select COUNT(cedula) from Colaborador where cedula = @cedula) <> 0)
	begin
		delete from Colaborador where cedula = @cedula
	end
go

create procedure eliminarVacaciones
	@IDVacaciones			int
as
	if ((select COUNT(IDVacaciones) from Vacaciones where IDVacaciones = @IDVacaciones) <> 0)
	begin
		delete from Vacaciones where IDVacaciones = @IDVacaciones
	end
go

create procedure eliminarSocio
	@cedula					Tcedula
as
	if ((select COUNT(cedula) from Socio where cedula = @cedula) <> 0)
	begin
		delete from Socio where cedula = @cedula
	end
go

create procedure eliminarTipoIngreso
	@IDtipoIngreso	int
as
	if ((select COUNT(IDtipoIngreso) from tipoIngreso where IDtipoIngreso = @IDtipoIngreso) <> 0)
	begin
		delete from tipoIngreso where IDtipoIngreso = @IDtipoIngreso
	end
go

create procedure eliminarIngreso
	@IDingreso		int
as
	if ((select COUNT(IDingreso) from Ingreso where IDingreso = @IDingreso) <> 0)
	begin
		delete from Ingreso where IDingreso = @IDingreso
	end
go

create procedure eliminarCliente
	@IDcliente	int
as
	if ((select COUNT(IDcliente) from Cliente where IDcliente = @IDcliente) <> 0)
	begin
		delete from Cliente where IDcliente = @IDcliente
	end
go

create procedure eliminarContacto
	@IDcliente		int
as
	if ((select COUNT(IDcliente) from Contacto where IDcliente = @IDcliente) <> 0)
	begin
		delete from Contacto where IDcliente = @IDcliente
	end
go

create procedure eliminarTecnologia
	@IDtecnologia		int
as
	if ((select COUNT(IDtecnologia) from Tecnologia where IDtecnologia = @IDtecnologia) <> 0)
	begin
		delete from Tecnologia where IDtecnologia = @IDtecnologia
	end
go

create procedure eliminarFactura
	@IDfactura			int
as
	if ((select COUNT(IDfactura) from Factura where IDfactura = @IDfactura) <> 0)
	begin
		delete from Factura where IDfactura = @IDfactura
	end
go

create procedure eliminarDetalleFactura
	@IDdetalleFactura	int
as
	if ((select COUNT(IDdetalleFactura) from detalleFactura where IDdetalleFactura = @IDdetalleFactura) <> 0)
	begin
		delete from detalleFactura where IDdetalleFactura = @IDdetalleFactura
	end
go

create procedure eliminarProyecto
	@IDproyecto		int
as
	if ((select COUNT(IDproyecto) from Proyecto where IDproyecto = @IDproyecto) <> 0)
	begin
		delete from Proyecto where IDproyecto = @IDproyecto
	end
go

create procedure eliminarTipoGasto
	@IDtipoGasto	int
as
	if ((select COUNT(IDtipoGasto) from tipoGasto where IDtipoGasto = @IDtipoGasto) <> 0)
	begin
		delete from tipoGasto where IDtipoGasto = @IDtipoGasto
	end
go

create procedure eliminarGasto
	@IDgasto		int
as
	if ((select COUNT(IDgasto) from Gasto where IDgasto = @IDgasto) <> 0)
	begin
		delete from Gasto where IDgasto = @IDgasto
	end
go

create procedure eliminarColaboradorProyecto
	@IDproyecto			int,
	@cedulaColaborador	TCedula
as
	if ((select COUNT(cedulaColaborador) from colaboradorProyecto where IDproyecto = @IDproyecto and cedulaColaborador = @cedulaColaborador) <> 0)
	begin
		delete from colaboradorProyecto where IDproyecto = @IDproyecto and cedulaColaborador = @cedulaColaborador
	end
go

---------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------- FIN DE CREACION DE PROCESOS DE ELIMINACION ----------------------------------------
---------------------------------------------------------------------------------------------------------------------------------