Imports System
Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient


Public Class CDConexion

    Dim conexion As MySqlConnection

    Public Function conectarBD() As MySqlConnection
        conexion = New MySqlConnection(ConfigurationManager.ConnectionStrings("MYSQLConnectionString").ConnectionString)
        Return conexion
    End Function

End Class
