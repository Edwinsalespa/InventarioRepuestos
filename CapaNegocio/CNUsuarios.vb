Imports CapaDatos
Imports CapaEntidad

Public Class CNUsuarios

    Dim UsuarioListado As New CDUsuario
    Dim UsuarioCrear As New CDUsuario
    Dim UsuarioLogin As New CDUsuario

    'Petición y envio de Datos a la Capa Datos    

    'CRUD------
    'Listar Usuarios
    Function ListarUsuarios() As DataSet
        Return UsuarioListado.ListarUsuarios
    End Function

    'Crear usuarios
    Sub RegistroUsuario(ByVal Usuario As CEUsuario)
        UsuarioCrear.RegistroUsuario(Usuario)
    End Sub

    'Login
    Function LoginUsuarios(ByVal usuario, ByVal contraseña) As ArrayList
        Return UsuarioLogin.LoginUsuarios(usuario, contraseña)
    End Function

    'Peticiones para cargar vistas
    Sub CerrarSesion(ByVal FormularioCerrar, ByVal FormularioCargar)
        If MsgBox("¿Desea cerrar sesión?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
            CargarVistaRequerida(FormularioCerrar, FormularioCargar)
        End If
    End Sub

    Sub CargarVistaRequerida(ByVal FormularioCerrar, ByVal FormularioCargar)
        FormularioCargar.Show()
        FormularioCerrar.Close()
    End Sub

    Sub CargarUsuarioEnSesion(ByVal Elemento, ByVal Nombre, ByVal Apellido, ByVal Rol)
        Elemento.DropDownItems.Add(String.Format("Nombre : {0} {1}", Nombre, Apellido))
        Elemento.DropDownItems.Add(String.Format("Tipo usuario: {0}", Rol))
    End Sub
End Class
