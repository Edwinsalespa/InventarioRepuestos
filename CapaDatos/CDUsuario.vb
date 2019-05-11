Imports System
Imports MySql.Data.MySqlClient
Imports CapaDatos

Public Class CDUsuario

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim Sentencia As MySqlCommand
    Dim _DataSet As DataSet
    Dim DatosTabla As DataTable


    Function listarUsuarios() As DataSet

        Conexion = New MySqlConnection
        _DataSet = New DataSet

        Try
            'generar la conexión
            Conexion = ObjConexion.conectarBD

            'configurar adaptador con la sentencia SQL a ejecutar
            Adaptador = New MySqlDataAdapter("CALL SP_ListarUsuarios()", Conexion)

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuarios")

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar usuarios" + ex.ToString)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
        End Try

        Return _DataSet

    End Function

    Function loginUsuarios(ByVal cedula, ByVal contraseña) As ArrayList

        Conexion = New MySqlConnection
        _DataSet = New DataSet
        DatosTabla = New DataTable
        Dim DatosUsuario As New ArrayList
        Dim Consulta As String

        Consulta = String.Format("CALL SP_LoginUsuario({0}, {1})", cedula, contraseña)


        Try

            'generar la conexión
            Conexion = ObjConexion.conectarBD

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
                DatosUsuario.Add(item("id_usuario"))
                DatosUsuario.Add(item("nombre"))
                DatosUsuario.Add(item("apellido"))
                DatosUsuario.Add(item("descripcion"))
            Next


        Catch ex As Exception
            MsgBox("Error al hacer login: " & ex.ToString)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
        End Try

        Return DatosUsuario

    End Function

End Class
