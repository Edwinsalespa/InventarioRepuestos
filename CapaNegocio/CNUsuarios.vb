Imports CapaDatos

Public Class CNUsuarios

    Dim usuario As New CDUsuario

    Sub loginUsuarios(ByVal usuario, ByVal contraseña)

    End Sub

    Function listarUsuarios() As DataSet
        Return usuario.listarUsuarios
    End Function
End Class
