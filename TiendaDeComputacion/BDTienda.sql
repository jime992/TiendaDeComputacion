CREATE TABLE CLIENTES
(
	id_Cliente int primary key,
	Nombre varchar(30),
	DNI varchar(9),
	Direccion varchar(40),
	Telefono varchar(12)
)

CREATE TABLE PRODUCTOS
(
	id_Producto int primary key,
	Tipo varchar(15),
	Marca varchar(15),
	Precio float,
)


CREATE TABLE PRESUPUESTOS
(
	id_Presupuesto int primary key,
	fecha date,
	total float,
	id_Cliente int,
	CONSTRAINT FK_Cliente FOREIGN KEY (id_Cliente) REFERENCES CLIENTES (id_Cliente)
)

CREATE TABLE FACTURAS
(
	id_Factura int primary key,
	id_Cliente int,
	Fecha date,
	Total float,
	Modo_De_Pago varchar(30),
	CONSTRAINT FK_Clientefac FOREIGN KEY (id_Cliente) REFERENCES CLIENTES (id_Cliente)
)

CREATE TABLE PRES_PROD
(
	id_Presupuesto int not null,
	id_Producto int not null,
	PRIMARY KEY (id_Presupuesto, id_Producto),
	Cantidad int not null,
	Precio float,
	CONSTRAINT FK_Presupuesto FOREIGN KEY (id_Presupuesto) REFERENCES PRESUPUESTOS (id_Presupuesto),
	CONSTRAINT FK_Producto FOREIGN KEY (id_Producto) REFERENCES PRODUCTOS (id_Producto)
)

CREATE TABLE FACT_PROD
(
	id_Factura int,
	id_Producto int,
	PRIMARY KEY (id_Factura, id_Producto),
	Cantidad int,
	CONSTRAINT FK_Factura FOREIGN KEY (id_Factura) REFERENCES FACTURAS (id_Factura),
	CONSTRAINT FK_Productofac FOREIGN KEY (id_Producto) REFERENCES PRODUCTOS (id_Producto)
)