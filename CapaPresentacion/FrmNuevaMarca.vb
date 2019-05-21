Imports System.Text.RegularExpressions
Imports CapaEntidad
Imports CapaNegocio

Public Class FrmNuevaMarca

    Private Sub BtnNuevaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaMarca.Click
        CrearMarca()
    End Sub

    Sub CrearMarca()
        Dim Nombre As String
        Dim Valido As Boolean

        Valido = False

        Nombre = TextBoxDescripcionMarca.Text.ToUpper

        'Validaciones de campos
        Dim ExpRegNombre = New Regex("^[a-zA-Z][a-zA-Z]*")

        'Formato Campos Texto
        Dim MatchCampoNombre As Match = ExpRegNombre.Match(Nombre)

        If String.IsNullOrEmpty(Nombre) Then
            MsgBox("El campo nombre es obligatorio", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchCampoNombre.Success Then
            MsgBox("El formato del campo nombre no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        Else
            Valido = True
        End If

        If Valido Then
            Dim Marca As New CNMarcas
            Dim EntidadMarca As New CEMarca

            EntidadMarca.Descripcion = Nombre
            Marca.RegistrarMarca(EntidadMarca)

            TextBoxDescripcionMarca.Text = ""
            Me.Close()
        End If
    End Sub
End Class