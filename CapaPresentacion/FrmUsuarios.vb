Imports System.Text.RegularExpressions
Imports CapaNegocio
Imports CapaEntidad

Public Class FrmUsuarios

    Dim UsuarioEventos As New CNUsuarios
    Dim Usuario As New CNUsuarios
    Dim DatosUsuario As New CEUsuario

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListarUsuarios()
    End Sub

    'Listar Usuarios
    Sub ListarUsuarios()
        DataGridViewUsuarios.DataSource = Usuario.ListarUsuarios.Tables("Usuarios")
    End Sub

    'Crear
    Sub EnviarUsuario()
        Dim Usr As New CNUsuarios
        Dim Nombre, Apellido, Cedula, Contraseña, RepetirContraseña As String
        Dim Valido As Boolean
        Dim ExpRegNom, ExpRegCed, ExpRegContra As Regex

        Valido = False

        Nombre = TextBoxNombre.Text
        Apellido = TextBoxApellido.Text
        Cedula = TextBoxCedula.Text
        Contraseña = TextBoxContraseña.Text
        RepetirContraseña = TextBoxReContraseña.Text

        'Validaciones de campos

        'Formato Campos Nombre y Apellido
        ExpRegNom = New Regex("^[a-zA-Z][a-zA-Z]*")
        Dim MatchNom As Match = ExpRegNom.Match(Nombre)
        Dim MatchApe As Match = ExpRegNom.Match(Apellido)

        'Formato Campo Cédula
        ExpRegCed = New Regex("\d+")
        Dim MatchCed As Match = ExpRegCed.Match(Cedula)

        'Formato Campo Contraseña
        ExpRegContra = New Regex("^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$")
        Dim MatchContra As Match = ExpRegContra.Match(Contraseña)

        If String.IsNullOrEmpty(Nombre) Or String.IsNullOrEmpty(Apellido) Or String.IsNullOrEmpty(Cedula) Or String.IsNullOrEmpty(Contraseña) Or String.IsNullOrEmpty(RepetirContraseña) Then
            MsgBox("Todos los campos son obligatorios", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchNom.Success Then
            MsgBox("El formato del campo nombre no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchApe.Success Then
            MsgBox("El formato del campo apellido no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchCed.Success Then
            MsgBox("El formato del campo cédula no es válido, debe ser númerico", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not Cedula.Length >= 6 Or Not Cedula.Length <= 12 Then
            MsgBox("El campo cédula, debe tener entre 6 y 12 dígitos", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchContra.Success Then
            MsgBox("La contraseña debe tener entre 8 y 16 caracteres, al menos un número, al menos una minúscula y al menos una mayúscula. " +
            "Puede tener otros símbolos.", MsgBoxStyle.Exclamation, "!Advertencia!")
            Valido = False
        ElseIf Not RepetirContraseña.Equals(Contraseña) Then
            MsgBox("El campo repetir contraseña de coincidir con el campo contraseña", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        Else
            Valido = True
        End If

        'Envio de datos

        If Valido Then
            DatosUsuario.Nombre = Nombre
            DatosUsuario.Apellido = Apellido
            DatosUsuario.Cedula = Integer.Parse(Cedula)
            DatosUsuario.Contraseña = Contraseña
            Usr.RegistroUsuario(DatosUsuario)

            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxContraseña.Text = ""
            TextBoxReContraseña.Text = ""

            ListarUsuarios()

        End If

    End Sub

    'Botón de registrar
    Private Sub BtnRegUsuario_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegUsuario.Click
        EnviarUsuario()
    End Sub

    'Botón de editar
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

    End Sub

    'Botón de eliminar
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

    End Sub

    'Otros eventos

    'Botón de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        UsuarioEventos.CargarVistaRequerida(Me, FrmIndexAdmin)
    End Sub

    'Carga de datos de usuario en sesión
    Private Sub FrmIndexAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsuarioEventos.CargarUsuarioEnSesion(TBTSesion, FrmLogin.Nombre, FrmLogin.Apellido, FrmLogin.Rol)
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        UsuarioEventos.CerrarSesion(Me, FrmLogin)
    End Sub

    
End Class
