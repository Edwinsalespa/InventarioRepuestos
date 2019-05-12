Imports CapaDatos

Public Class CNUsuarios

    Dim usuario As New CDUsuario
    Dim usuario2 As New CDUsuario

    'Petición y envio de Datos a la Capa Datos
    Function loginUsuarios(ByVal usuario, ByVal contraseña) As ArrayList
        Return usuario2.loginUsuarios(usuario, contraseña)
    End Function

    Function listarUsuarios() As DataSet
        Return usuario.listarUsuarios
    End Function

    'Peticiones para cargar vistas
    Sub CerrarSesion(ByVal FormularioCerrar, ByVal FormularioCargar)
        If MsgBox("¿Desea cerrar sesión?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
            CargarVistaRequerida(FormularioCerrar, FormularioCargar)
        End If
    End Sub

    Sub CargarVistaRequerida(ByVal FormularioCerrar, ByVal FormularioCargar)
        FormularioCerrar.Hide()
        FormularioCargar.Show()
    End Sub

    Sub CargarUsuarioEnSesion(ByVal Elemento, ByVal Nombre, ByVal Apellido, ByVal Rol)
        Elemento.DropDownItems.Add(String.Format("Nombre : {0} {1}", Nombre, Apellido))
        Elemento.DropDownItems.Add(String.Format("Tipo usuario: {0}", Rol))
    End Sub
End Class
