Imports CapaDatos

Public Class CNUsuarios

    Dim usuario As New CDUsuario
    Dim usuario2 As New CDUsuario

    Function loginUsuarios(ByVal usuario, ByVal contraseña) As ArrayList
        Return usuario2.loginUsuarios(usuario, contraseña)
    End Function

    Function listarUsuarios() As DataSet
        Return usuario.listarUsuarios
    End Function
End Class
