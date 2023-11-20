/*GUARDAR USUARIO*/
create PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end

GO

/*EDITAR USUARIO*/
create PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update  usuario set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		where IdUsuario = @IdUsuario

		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end

go

/*eliminar usuario*/
create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM COMPRA C 
	INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n' 
	END

	IF EXISTS (SELECT * FROM VENTA V
	INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1 
	end

end

go

/*-----------PROCEDIMIENTOS PARA CATEGORIA----------*/
--PROCEDIMIENTO PAR GUARDAR CATEGORIA
Create PROC SP_RegistrarCategoria(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	IF NOT EXISTS(SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin
	    insert into CATEGORIA(Descripcion,Estado) values(@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	Else
	   set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end

	go

--PROCEDIMIENTO PARA MODIFICAR CATEGORIA 
Create procedure sp_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 1
	IF NOT EXISTS(SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion and IdCategoria != @IdCategoria)

		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado 
		where IdCategoria = @IdCategoria
  Else
  begin
    SET @Resultado = 0
	set  @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end
end
go

--PROCEDIMIENTO PARA ELIMINAR CATEGORIA 
create procedure sp_EliminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500)output
)
as
begin
    SET @Resultado = 1
	IF NOT EXISTS (
	select * from CATEGORIA c
	inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	where c.IdCategoria = @IdCategoria
	)begin
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	Else
	begin
		SET @Resultado = 0
		set @Mensaje = ' La categoria se encuentra relacionada a un producto'
	end
end

go


Select *from CATEGORIA

Insert into CATEGORIA(Descripcion,Estado)VALUES('Platos',1)
Insert into CATEGORIA(Descripcion,Estado)VALUES('Vasos',1)
Insert into CATEGORIA(Descripcion,Estado)VALUES('Utensilios de cocina',1)
update CATEGORIA set Estado = 1
go

/*---------- PROCEDIMIENTO PARA PRODUCTO -------------*/
--PROCEDIMIENTO PARA GUARDAR PRODUCTO

create PROC sp_RegistrarProducto(
@Codigo varchar(20),
@Nombre varchar(30),
@Descripcion varchar(30),
@IdCategoria int,
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
    SET @Resultado = 0
	IF NOT EXISTS(SELECT * FROM producto WHERE Codigo = @Codigo)
	begin
	    insert into producto(Codigo,Nombre,Descripcion,IdCategoria,Estado) values(@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
		set @Resultado = SCOPE_IDENTITY()
    end
	ELSE
     SET @Mensaje = 'Ya existe un producto con el mismo codigo'

end

GO

/*----------- PROCEDIMIENTO PARA ACTUALIZAR PRODUCTO ------------*/
alter procedure sp_ModificarProducto(
@IdProducto int,
@Codigo varchar(20),
@Nombre varchar(30),
@Descripcion varchar(30),
@IdCategoria int,
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE codigo = @Codigo and IdProducto != @IdProducto)
		
		update PRODUCTO set
		codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo' 
	end
end


go

/*---------- PROCEDIMIENTO PARA ELIMINAR PRODUCTO ------------*/

alter PROC SP_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLE_COMPRA dc 
	INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n' 
	END

	IF EXISTS (SELECT * FROM DETALLE_VENTA dv
	INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n' 
	END

	if(@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1 
	end

end

select p.IdProducto,p.Codigo,p.Nombre,p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioCompra,PrecioVenta,p.Estado from PRODUCTO p
inner join CATEGORIA c on c.IdCategoria = p.IdCategoria


Select *from PRODUCTO

Insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria)VALUES('101010','gaseosa','1litro',1)

update PRODUCTO set Estado = 1

DROP PROCEDURE SP_EliminarProducto;


/* ---------------- PROCEDIMIENTOS PARA CLIENTE---------------------*/

/* ---------------- PROCEDIMIENTOS PARA REGISTRAR CLIENTE---------------------*/
create PROC sp_RegistrarCliente(
@Documento varchar (50),
@NombreCompleto varchar (50),
@Correo varchar (50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar (500) output
)
as
begin
    SET @Resultado = 0
    DECLARE @IDPERSONA INT
    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
    BEGIN
        insert into CLIENTE(Documento,NombreCompleto,Correo,Telefono,Estado) values (
        @Documento,@NombreCompleto,@Correo,@Telefono,@Estado)

        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'El numero de documento ya existe'
end

go

/*---------------- PROCEDIMIENTOS PARA MODIFICAR CLIENTE*/

create PROC sp_ModificarCliente(
@IdCliente int,
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar (50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar (500) output
)as
begin
    SET @Resultado =1
    DECLARE @IDPERSONA INT
    IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento and IdCliente != @IdCliente)
    begin
        update CLIENTE set
        Documento = @Documento,
        NombreCompleto = @NombreCompleto,
        Correo = @Correo,
        Telefono = @Telefono,
        Estado = @Estado
        where IdCliente = @IdCliente
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El numero de documento ya existe'
    end
end

go

/*-----------------PROCEDIMIENTOS PARA PROVEEDOR -----------------------*/
/*------- REGISTROS PROVEEDOR ---------------*/

create PROC sp_RegistrarProveedor(
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar (50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    SET @Resultado = 0
	DECLARE @IDPERSONA INT
	if not exists(SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
	    insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) values(
		@Documento,@RazonSocial,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
		 end
    else
        set @Mensaje = 'El numero de documento ya existe'
end

go

/*----------- MODIFICAR PROVEEDOR ----------*/

create PROC sp_ModificarProveedor(
@IdProveedor int,
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar (50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
 SET @Resultado =1
    DECLARE @IDPERSONA INT
    IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
    begin
        update PROVEEDOR set
        Documento = @Documento,
        RazonSocial = @RazonSocial,
        Correo = @Correo,
        Telefono = @Telefono,
        Estado = @Estado
        where IdProveedor = @IdProveedor
    end
    else
    begin
        SET @Resultado = 0
        set @Mensaje = 'El numero de documento ya existe'
    end
end

go

/*--------- ELIMINAR PROVEEDOR------------------*/

create PROC SP_EliminarProveedor(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PROVEEDOR p
	INNER JOIN COMPRA c ON p.IdProveedor = c.IdProveedor
	WHERE p.IdProveedor = @IdProveedor
	)
    begin
	delete top (1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	ELSE
	begin
	SET @Resultado = 0
        set @Mensaje = 'El proveedor se encuentra relacionado a una compra'
	end

end


/*-------------INSERTAR DATOS NEGOCIO-----------------*/

insert into NEGOCIO(IdNegocio,Nombre,RUC,Direccion) values(1,'Plasticos Tonita','101010','av.Codigo 123')
go