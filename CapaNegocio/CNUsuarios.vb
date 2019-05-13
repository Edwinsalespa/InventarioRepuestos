Imports CapaDatos
Imports CapaEntidad

Public Class CNUsuarios

    Dim Usuario As CDUsuario

    'Petición y envio de Datos a la Capa Datos    

    'CRUD------
    'Listar Usuarios
    Function ListarUsuarios() As DataSet
        Usuario = New CDUsuario
        Return Usuario.ListarUsuarios
    End Function

    'Crear usuarios
    Sub RegistroUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.RegistroUsuario(EntidadUsuario)
    End Sub

    'Editar Usuario
    Sub ActualizarUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.ActualizarUsuario(EntidadUsuario)
    End Sub


    'Eliminar Usuario
    Sub EliminarUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.EliminarUsuario(EntidadUsuario)
    End Sub

    'Login
    Function LoginUsuarios(ByVal EntidadUsuario As CEUsuario) As ArrayList
        Usuario = New CDUsuario
        Return Usuario.LoginUsuarios(EntidadUsuario)
    End Function

    'Peticiones para cargar vistas
    Sub CerrarSesion(ByVal FormularioCerrar, ByVal FormularioCargar)
        If MsgBox("¿Desea cerrar sesión?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
            CargarVistaRequerida(FormularioCerrar, FormularioCargar)
        End If
    End Sub

    'Encriptacion de Contraseñas
    Function CodificarContraseña(ByVal Opcion As String, ByVal Contraseña As String) As String
        Usuario = New CDUsuario
        Return Usuario.CodificarContraseña(Opcion, Contraseña)
    End Function


    Sub CargarVistaRequerida(ByVal FormularioCerrar, ByVal FormularioCargar)
        FormularioCargar.Show()
        FormularioCerrar.Close()
    End Sub

    Sub CargarUsuarioEnSesion(ByVal Elemento, ByVal Nombre, ByVal Apellido, ByVal Rol)
        Elemento.DropDownItems.Add(String.Format("Nombre : {0} {1}", Nombre, Apellido))
        Elemento.DropDownItems.Add(String.Format("Tipo usuario: {0}", Rol))
    End Sub
End Class
