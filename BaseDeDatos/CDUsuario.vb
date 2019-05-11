Imports System.Data.SqlServerCe
Imports CapaDatos

Public Class CDUsuario

    Dim objConexion As New CDConexion
    Dim conexion As SqlCeConnection
    Dim adaptador As SqlCeDataAdapter
    Dim dataset As DataSet

    Function listarUsuarios() As DataSet

        conexion = New SqlCeConnection
        dataset = New DataSet


        Try

            'generar la conexión
            conexion = objConexion.conectarBD

            'Configurar el adaptador con la sentencia SQL a ejecutar
            adaptador = New SqlCeDataAdapter("SELECT * FROM USUARIO", conexion)

            'Llenar adaptador con los datos que trae la consulta
            adaptador.Fill(dataset, "Usuarios")
            
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar usuarios : " + ex.ToString)
        Finally
            'Liberar recursos
            conexion.Dispose()
            adaptador.Dispose()
        End Try

        Return dataset

    End Function
End Class
