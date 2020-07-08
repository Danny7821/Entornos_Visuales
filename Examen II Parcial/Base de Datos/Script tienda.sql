create database Tienda
go

create schema factura
go

create table factura.cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)


create table factura.producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)

create table factura.Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)
)

select * from factura.Venta;
go

create procedure reportecliente
as begin
	select c.nombre, c.apellido, p.nombreProducto, cantidad, precio, fechaventa
						from factura.Venta v 
						inner join factura.cliente c
						on v.idCliente = c.idCliente
						inner join factura.producto p
						on v.idProducto = p.idProducto
end
Execute reportecliente 
go

create procedure reportecliente2
as begin
	select c.nombre as 'Nombre', c.apellido as 'Apellido', p.nombreProducto as 'Nombre de Producto', cantidad as 'Cantidad', precio as 'Precio', fechaventa as 'Fecha de Venta'
						from factura.Venta v 
						inner join factura.cliente c
						on v.idCliente = c.idCliente
						inner join factura.producto p
						on v.idProducto = p.idProducto
end
Execute reportecliente2 
