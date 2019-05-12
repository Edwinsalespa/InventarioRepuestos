Imports CapaNegocio

Public Class FrmUsuarios

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub

    Sub listarUsuarios()
        Dim Usuario As New CNUsuarios
        DataGridViewUsuarios.DataSource = Usuario.listarUsuarios.Tables("Usuarios")
    End Sub

End Class
