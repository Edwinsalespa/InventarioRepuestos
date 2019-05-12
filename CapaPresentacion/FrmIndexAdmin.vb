Imports CapaNegocio

Public Class FrmIndexAdmin

    Dim UsuarioEventos As New CNUsuarios

    'Gestión Usuarios

    Private Sub BtnMenuUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuUsuario.Click
        UsuarioEventos.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    Private Sub TBtnGestionUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnGestionUs.Click
        UsuarioEventos.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    'Gestión Repuestos

    Private Sub BtnMenuRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuRep.Click
        Me.Hide()
    End Sub

    'Gestión Stock

    Private Sub BtnMenuStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuStock.Click
        Me.Hide()
    End Sub

    'Otros eventos

    'Bóton de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        Me.Show()
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        UsuarioEventos.CerrarSesion(Me, FrmLogin)
    End Sub

    'Carga de datos de usuario en sesión
    Private Sub FrmIndexAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsuarioEventos.CargarUsuarioEnSesion(TBTSesion, FrmLogin.Nombre, FrmLogin.Apellido, FrmLogin.Rol)
    End Sub
End Class