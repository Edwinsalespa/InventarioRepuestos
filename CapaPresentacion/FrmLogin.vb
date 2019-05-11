Imports CapaNegocio

Public Class FrmLogin

    Dim Usuario As New CNUsuarios


    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Sub Login()
        Dim Cedula As Integer
        Dim Contraseña As String
        Dim DatosUsuario As New ArrayList

        Cedula = Val(TxtUsuario.Text)
        Contraseña = TxtContraseña.Text

        DatosUsuario = Usuario.loginUsuarios(Cedula, Contraseña)

        If DatosUsuario.Count <> 0 Then
            'Limpiar Campos del formulario
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            Me.Hide()
            MsgBox("¡Hola" & " " & " " & DatosUsuario.Item(1) & " " & DatosUsuario.Item(2) & "!")
            'Mostrar el formulario correspondiente al Rol de usuario que inicia sesión
            If DatosUsuario.Item(3) = "ADMIN" Then
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
    
End Class