Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
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
        DatosTabla = New DataTable

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

            DatosTabla = _DataSet.Tables("Usuarios")

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
                .Add("_contrasena", MySqlDbType.VarChar).Value = CodificarContraseña(1, Usuario.Contraseña)
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

    Sub ActualizarUsuario(ByVal EntidadUsuario As CEUsuario)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SP_ActualizarUsuario", Conexion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With Adaptador.SelectCommand.Parameters
                .Add("_id", MySqlDbType.Int32).Value = EntidadUsuario.IdUsuario
                .Add("_nombre", MySqlDbType.VarChar).Value = EntidadUsuario.Nombre
                .Add("_apellido", MySqlDbType.VarChar).Value = EntidadUsuario.Apellido
                .Add("_cedula", MySqlDbType.Int32).Value = EntidadUsuario.Cedula
                .Add("_contrasena", MySqlDbType.VarChar).Value = CodificarContraseña(1, EntidadUsuario.Contraseña)
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario actualizado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al eliminar usuario: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub EliminarUsuario(ByVal EntidadUsuario As CEUsuario)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SP_EliminarUsuario", Conexion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Adaptador.SelectCommand.Parameters.Add("_id", MySqlDbType.Int32).Value = EntidadUsuario.IdUsuario

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario eliminado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al eliminar usuario: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub


    Function LoginUsuarios(ByVal EntidadUsuario As CEUsuario) As ArrayList

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()
        DatosTabla = New DataTable
        Dim DatosUsuario As New ArrayList

        Try

            'generar la conexión
            Conexion = ObjConexion.conectarBD
            Conexion.Open()
            'configurar adaptador con la sentencia SQL a ejecutar            
            Adaptador = New MySqlDataAdapter("SP_LoginUsuario", Conexion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            With Adaptador.SelectCommand.Parameters
                .Add("_cedula", MySqlDbType.Int32).Value = EntidadUsuario.Cedula
                .Add("_contrasena", MySqlDbType.VarChar).Value = CodificarContraseña(1, EntidadUsuario.Contraseña)
            End With

            Adaptador.SelectCommand.Prepare()

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuario")

            DatosTabla = _DataSet.Tables("Usuario")

            For Each item As DataRow In DatosTabla.Rows
                DatosUsuario.Add(item("id_usuario"))
                DatosUsuario.Add(item("nombre"))
                DatosUsuario.Add(item("apellido"))
                DatosUsuario.Add(item("cedula"))
                DatosUsuario.Add(CodificarContraseña(2, item("contrasena")))
                DatosUsuario.Add(item("descripcion"))
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

    'Encriptar y Desencripttar Contraseñas 
    Function CodificarContraseña(ByVal Opcion As Byte, ByVal Contraseña As String) As String
        Dim TextoPlano() As Byte
        Dim Keys() As Byte = Encoding.ASCII.GetBytes("eeaataxz")
        Dim MemData As New MemoryStream
        Dim Transforma As ICryptoTransform

        Dim Des As New DESCryptoServiceProvider
        Des.Mode = CipherMode.CBC

        If Opcion = 1 Then
            TextoPlano = Encoding.ASCII.GetBytes(Contraseña)
        Else
            TextoPlano = Convert.FromBase64String(Contraseña)
        End If

        If Opcion = 1 Then
            Transforma = Des.CreateEncryptor(Keys, Encoding.ASCII.GetBytes("eeaataxz"))
        Else
            Transforma = Des.CreateDecryptor(Keys, Encoding.ASCII.GetBytes("eeaataxz"))
        End If

        Dim EncStream As New CryptoStream(MemData, Transforma, CryptoStreamMode.Write)
        EncStream.Write(TextoPlano, 0, TextoPlano.Length)
        EncStream.FlushFinalBlock()
        EncStream.Close()

        If Opcion = 1 Then
            Contraseña = Convert.ToBase64String(MemData.ToArray)
        Else
            Contraseña = Encoding.ASCII.GetString(MemData.ToArray)
        End If

        Return Contraseña

    End Function


End Class
