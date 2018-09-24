use master
go
create database Rubinstein_DB
go
use Rubinstein_DB
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

--DATOS PRODUCTOS
insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (1,'Kasenkuchen','Chica',300,3,'11/09/2018')
insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (2,'Lemon Pie','Chica',200,2,'10/09/2018')
insert into Producto(IdProducto,Descripcion,Tamanio,PrecioUnitario,Stock,FechaVenc) values (3,'Dinner Kuchen','Mediana',450,1,'11/11/2018')

--Test
select P.IdProducto,P.Descripcion,P.Tamanio,P.PrecioUnitario,P.Stock,P.FechaVenc from Producto as P
