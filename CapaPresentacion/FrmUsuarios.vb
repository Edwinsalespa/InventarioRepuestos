Imports CapaNegocio

Public Class FrmUsuarios

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub

    Sub listarUsuarios()
        Dim usuario As New CNUsuarios
        DataGridView1.DataSource = usuario.listarUsuarios.Tables("Usuarios")
    End Sub

End Class
