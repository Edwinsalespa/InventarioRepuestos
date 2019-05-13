Imports System.Text.RegularExpressions
Imports CapaNegocio
Imports CapaEntidad

Public Class FrmUsuarios

    Dim Usuario As CNUsuarios
    Dim EntidadUsuario As New CEUsuario
    Dim UsuarioSeleccionado(5) As String
    Dim Editable As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Editable = False
        ListarUsuarios()
    End Sub

    'Listar Usuarios
    Sub ListarUsuarios()
        Usuario = New CNUsuarios
        DataGridViewUsuarios.DataSource = Usuario.ListarUsuarios.Tables("Usuarios")
    End Sub

    'Crear
    Sub EnviarUsuario()
        Usuario = New CNUsuarios
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
            EntidadUsuario.Nombre = Nombre
            EntidadUsuario.Apellido = Apellido
            EntidadUsuario.Cedula = Integer.Parse(Cedula)
            EntidadUsuario.Contraseña = Contraseña

            If Editable Then
                EntidadUsuario.IdUsuario = Integer.Parse(LabelId.Text)
                Usuario.ActualizarUsuario(EntidadUsuario)
            Else
                Usuario.RegistroUsuario(EntidadUsuario)
            End If

            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxContraseña.Text = ""
            TextBoxReContraseña.Text = ""
            Editable = False
            GroupBox1.Text = "Crear usuarios"
            BtnRegUsuario.Text = "REGISTRAR"
            LabelId.Text = ""
            ListarUsuarios()

        End If

    End Sub

    'Editar Usuario

    Sub EditarUsuario()
        GroupBox1.Text = "Editar usuario"
        BtnRegUsuario.Text = "ACTUALIZAR"
        TextBoxNombre.Text = UsuarioSeleccionado(1)
        TextBoxApellido.Text = UsuarioSeleccionado(2)
        TextBoxCedula.Text = UsuarioSeleccionado(3)
        TextBoxContraseña.Text = UsuarioSeleccionado(4)
        TextBoxReContraseña.Text = UsuarioSeleccionado(4)

        Editable = True
    End Sub


    'Eliminar Usuario
    Sub EliminarUsuario()
        Usuario = New CNUsuarios
        EntidadUsuario.IdUsuario = Integer.Parse(LabelId.Text)
        Usuario.EliminarUsuario(EntidadUsuario)
        LabelId.Text = ""
        ListarUsuarios()
    End Sub

    'Botón de registrar
    Private Sub BtnRegUsuario_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegUsuario.Click
        EnviarUsuario()
    End Sub

    'Botón de editar
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        If Not String.IsNullOrEmpty(UsuarioSeleccionado(0)) Then
            EditarUsuario()
        Else
            MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
        End If
    End Sub

    'Botón de eliminar
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If Not String.IsNullOrEmpty(UsuarioSeleccionado(0)) Then
            If Not UsuarioSeleccionado(5).Equals("ADMIN") Then
                If MsgBox("¿Desea eliminar el usuario " + UsuarioSeleccionado(1) + "?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
                    EliminarUsuario()
                End If
            Else
                MsgBox("No se puede eliminar el administrador", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Else
            MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
        End If
    End Sub

    'Al seleccionar una fila de la tabla
    Private Sub DataGridViewUsuarios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUsuarios.CellClick
        Dim dgv As DataGridViewRow = DataGridViewUsuarios.Rows(e.RowIndex)
        Seleccionado(dgv)

        TextBoxNombre.Text = ""
        TextBoxApellido.Text = ""
        TextBoxCedula.Text = ""
        TextBoxContraseña.Text = ""
        TextBoxReContraseña.Text = ""
        GroupBox1.Text = "Crear usuarios"
        BtnRegUsuario.Text = "REGISTRAR"

    End Sub

    'Guardar Usuario seleccionado
    Sub Seleccionado(ByVal Datos As DataGridViewRow)
        LabelId.Text = Datos.Cells(0).Value.ToString

        For i As Integer = 0 To Datos.Cells.Count - 1
            UsuarioSeleccionado(i) = Datos.Cells(i).Value.ToString
        Next
    End Sub


    'Otros eventos------

    'Botón de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        Usuario = New CNUsuarios
        Usuario.CargarVistaRequerida(Me, FrmIndexAdmin)
    End Sub

    'Carga de datos de usuario en sesión
    Private Sub FrmIndexAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Usuario = New CNUsuarios
        Usuario.CargarUsuarioEnSesion(TBTSesion, FrmLogin.Nombre, FrmLogin.Apellido, FrmLogin.Rol)
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        Usuario = New CNUsuarios
        Usuario.CerrarSesion(Me, FrmLogin)
    End Sub

End Class
