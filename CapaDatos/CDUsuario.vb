Imports System
Imports System.Text
Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports CapaEntidad

Public Class CDUsuario

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim Sentencia As MySqlCommand
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable


    Function ListarUsuarios() As DataSet

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()

        Try
            'generar la conexión
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            'configurar adaptador con la consulta preparada a ejecutar a ejecutar
            Adaptador = New MySqlDataAdapter("SP_ListarUsuarios", Conexion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Adaptador.SelectCommand.Prepare()

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuarios")

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar usuarios" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return _DataSet

    End Function


    Sub RegistroUsuario(ByVal Usuario As CEUsuario)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SP_CrearUsuario", Conexion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With Adaptador.SelectCommand.Parameters
                .Add("_nombre", MySqlDbType.VarChar).Value = Usuario.Nombre
                .Add("_apellido", MySqlDbType.VarChar).Value = Usuario.Apellido
                .Add("_cedula", MySqlDbType.Int32).Value = Usuario.Cedula
                .Add("_contrasena", MySqlDbType.VarChar).Value = Usuario.Contraseña
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario registrado", MsgBoxStyle.Information, "¡Operación éxitosa!")
            
        Catch ex As Exception
            If ex.Message.Contains("Duplicate entry") Then
                MsgBox("El número de cédula ya se encuentra registrado", MsgBoxStyle.Critical, "¡Error!")
            Else
                MsgBox("Error al crear usuario: " & ex.Message)
            End If

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub ActualizarUsuario()

    End Sub

    Sub EliminarUsuario()

    End Sub


    Function LoginUsuarios(ByVal cedula, ByVal contraseña) As ArrayList

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()
        DatosTabla = New DataTable
        Dim DatosUsuario As New ArrayList

        Try

            'generar la conexión
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            'configurar adaptador con la sentencia SQL a ejecutar            
            Adaptador = New MySqlDataAdapter()
            Sentencia = New MySqlCommand("CALL SP_LoginUsuario(@cedula, @contrasena)", Conexion)
            Sentencia.Parameters.AddWithValue("@cedula", cedula)
            Sentencia.Parameters.AddWithValue("@contrasena", contraseña)
            Adaptador.SelectCommand = Sentencia


            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuario")

            DatosTabla = _DataSet.Tables("Usuario")

            For Each item As DataRow In DatosTabla.Rows
                DatosUsuario.Add(item("id"))
                DatosUsuario.Add(item("nombre"))
                DatosUsuario.Add(item("apellido"))
                DatosUsuario.Add(item("rol"))
            Next


        Catch ex As Exception
            MsgBox("Error al hacer login: " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return DatosUsuario

    End Function

End Class
