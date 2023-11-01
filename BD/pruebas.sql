select * from USUARIO

select * from ROL

select * from PERMISO

select p.IdRol,p.NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO u on u.IdRol = r.IdRol
where u.IdUsuario = 1

/*Mostrar en el DGV Form Usuarios*/
select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from USUARIO u
join ROL r on r.IdRol = u.IdRol



