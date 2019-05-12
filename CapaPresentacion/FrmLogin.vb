Imports CapaNegocio

Public Class FrmLogin

    Dim Usuario As New CNUsuarios
    Dim DatosUsuario As New ArrayList
    Friend Nombre, Apellido, Rol As String


    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Sub Login()
        Dim Cedula As Integer
        Dim Contraseña As String

        Cedula = Val(TxtUsuario.Text)
        Contraseña = TxtContraseña.Text

        DatosUsuario = Usuario.loginUsuarios(Cedula, Contraseña)

        Nombre = DatosUsuario.Item(1)
        Apellido = DatosUsuario.Item(2)
        Rol = DatosUsuario.Item(3)

        If DatosUsuario.Count <> 0 Then
            'Limpiar Campos del formulario
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            Me.Hide()
            MsgBox("¡Hola" & " " & " " & DatosUsuario.Item(1) & " " & DatosUsuario.Item(2) & "!")

            'Mostrar el formulario correspondiente al Rol de usuario que inicia sesión
            If Rol = "ADMIN" Then
                FrmIndexAdmin.Show()
            Else
                FrmIndexBasico.Show()
            End If

        Else
            MsgBox("Credenciales incorrectas")
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
        End If

    End Sub
    
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nombre = ""
        Apellido = ""
        Rol = ""
    End Sub
End Class