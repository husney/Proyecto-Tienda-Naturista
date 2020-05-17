CREATE DATABASE tienda_naturista;
GO

CREATE TABLE clientes(
cliNumero int  primary key identity (1,1),
cliDocumento varchar(10),
cliNombre varchar(50) ,
cliDireccion varchar(100),
cliTelefono varchar(10),
cliCorreo varchar(50) 
);




CREATE TABLE vendedores(
venUsuario varchar(20) primary key,
venContraseña varchar(20) not null
);


CREATE TABLE productos(
proCodigo int primary key,
proDescripcion varchar(50) not null,
proValor decimal(12,2) not null,
proCantidad int not null
);

CREATE TABLE factura_detalle(
facNumero int primary key identity (1,1),
facProducto int not null,
facCantidad int not null,
FOREIGN KEY (facProducto) REFERENCES productos(proCodigo)
);

CREATE TABLE facturas(
facNumero int primary key,
facFecha datetime not null,
facCliente int not null,
facVendedor varchar(20) not null,
facValorTotal decimal(12,2) not null,
FOREIGN KEY (facCliente) REFERENCES clientes(cliNumero),
FOREIGN KEY (facVendedor) REFERENCES vendedores(venUsuario),
FOREIGN KEY (facNumero) REFERENCES factura_detalle(facNumero)
);
