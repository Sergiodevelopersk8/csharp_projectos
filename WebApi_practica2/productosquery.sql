
create database apiprueba1;
use apiprueba1;





create table Producto(
Id_Producto int identity primary key,
Nombre_Producto varchar (100),
Descripcion_producto varchar (100)
);


insert into Producto values ('Monitor','Lenovo');

insert into Producto values ('Teclado','Microsoft');

select * from Producto;

