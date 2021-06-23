CREATE TABLE Marca

(

	idMarca			int				primary key identity,
	nombre			varchar(100)	not null,
	activo			int				not null,
	unique(nombre)

)

CREATE TABLE Categoria

(

	idCategoria		int				primary key identity,
	nombre			varchar(100)	not null,
	activo			int				not null,
	unique(nombre)

)



CREATE TABLE Producto

(

	idProducto		int				primary key identity,
	codigoBarra		int				not null,
	descripcion		varchar(100)	not null,
	precioCosto		int				not null,
	precioVenta		int				not null,
	stock			int				not null,

	unique(codigoBarra)

)