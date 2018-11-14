
use master
go
create database Rubinstein_DB
go
use Rubinstein_DB
go


--go
--create table Provincia(
--IdProvincia int not null primary key,
--NombreProvincia varchar (50) not null,
--)

--go
--create table Localidad(
--CP int not null primary key,
--NombreLocalidad varchar (50) not null,
--IdProvincia int not null foreign key references Provincia(IdProvincia)
--)

--go
--create table Direccion(
--IdDireccion int not null primary key,
--Calle varchar (30)not null,
--NroCalle int not null,
--Dpto varchar(5) null,
--CP int not null foreign key references Localidad (CP),
----IdProvincia int not null foreign key references Provincia(IdProvincia)
--)

go
create table Proveedor(
IdProveedor int not null primary key,
RazonSocial varchar (50)not null,
CUIT varchar(30)not null, 
Mail varchar(30) not null,
Telefono varchar(40) not null,
Celular varchar(50) not null,
Direccion varchar(60) not null,
Estado int not null
)



go
create table Cliente(
IdCliente int not null primary key identity(1,1),
Dni varchar(30) null, 
Nombre varchar (50) not null,
Apellido varchar (50) not null,
Mail varchar(30) not null,
Telefono varchar(40) not null,
Celular varchar(50) not null,
Direccion varchar(60) not null,
Estado int not null
)

go
create table Producto(
IdProducto int not null primary key,
Descripcion varchar(60) not null,
Tamanio varchar(20) not null,
PrecioUnitario money not null,
Stock bigint null,
FechaVenc date null,
)
go
create table Medida(
IdMedida int not null primary key,
Descripcion varchar(10) not null,
)
go
create table Categoria(
Idcategoria int not null primary key,
Descripcion varchar(30) not null,
)

go
create table Ingrediente(
IdBien int not null primary key,
Descripcion varchar (30) not null,
IdMedida int not null foreign key references Medida(Idmedida),
IdCategoria int not null foreign key references Categoria(Idcategoria),
Tamanio float null,
Precio float not null,
Cantidad float null,
FechaVencimiento date null, --check fecha mayor a hoy
IdProveedor int null foreign key references Proveedor(IdProveedor),
)


--DATOS PRODUCTOS
--insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (1,'Kasenkuchen','Chica',300,3,'11/09/2018')
--insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (2,'Lemon Pie','Chica',200,2,'10/09/2018')
--insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (3,'Dinner Kuchen','Mediana',450,1,'11/11/2018')

--Test
--select P.IdProducto,P.Descripcion,P.Tamanio,P.PrecioUnitario,P.Stock,P.FechaVenc from Producto as P



--DATOS PROVINCIAS
--insert into Provincia(IdProvincia,NombreProvincia) values (1,'Buenos Aires')
--insert into Provincia(IdProvincia,NombreProvincia) values (2,'Rio Negro')
--insert into Provincia(IdProvincia,NombreProvincia) values (3,'Misiones')
--insert into Provincia(IdProvincia,NombreProvincia) values (4,'Jujuy')

----DATOS LOCALIDADES
--insert into Localidad(CP,NombreLocalidad,IdProvincia) values (1611,'Don Torcuato',1)
--insert into Localidad(CP,NombreLocalidad,IdProvincia) values (2,'Vicente Lopez',1)
--insert into Localidad(CP,NombreLocalidad,IdProvincia) values (3,'Bariloche',2)
--insert into Localidad(CP,NombreLocalidad,IdProvincia) values (4,'Iguazu',3)
--insert into Localidad(CP,NombreLocalidad,IdProvincia) values (5,'Tilcara',4)

----DATOS DIRECCIONES
--insert into Direccion(IdDireccion,Calle,NroCalle,Dpto,CP) values (1,'Ecuador',1642,'PB',1611)
--insert into Direccion(IdDireccion,Calle,NroCalle,Dpto,CP) values (2,'Av. Mitre',1644,'PB',2)
--insert into Direccion(IdDireccion,Calle,NroCalle,Dpto,CP) values (3,'Pucara',1699,'PB',5)

--DATOS PROVEEDORES
insert into Proveedor(IdProveedor,RazonSocial,CUIT,Mail,Telefono,Celular,Direccion) values(1,'Osle','27-33446789-0','osle@gmail.com','4741-1777','15-66-889-079','Ecuador 1899')
insert into Proveedor(IdProveedor,RazonSocial,CUIT,Mail,Telefono,Celular,Direccion) values(2,'Materia Prima','27-33446888-0','materiaprima@gmail.com','4389-9008','15-61-988-909','Av. Mitre')

--DATOS CLIENTES
insert into Cliente ( Dni, Nombre, Apellido, Mail, Telefono, Celular, Direccion, Estado)
values ('35392038', 'daniela','rubinstein','drubinstein@gmail.com','47422829','12345','Brasil 345', '1')

IdCliente int not null primary key,
Dni varchar(30) null, 
Nombre varchar (50) not null,
Apellido varchar (50) not null,
Mail varchar(30) not null,
Telefono varchar(40) not null,
Celular varchar(50) not null,
Direccion varchar(60) not null,
Estado int not null

--select IdProveedor, RazonSocial, CUIT, Mail, Telefono, Celular, L.NombreLocalidad as Localidad from Proveedor 
--inner join Direccion as D on Proveedor.IdDireccion=D.IdDireccion
--inner join Localidad as L on D.CP=L.CP
