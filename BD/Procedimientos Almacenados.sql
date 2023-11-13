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
