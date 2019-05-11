Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlServerCe


Public Class CDConexion

    Dim conexion As SqlCeConnection

    Public Function conectarBD() As SqlCeConnection
        conexion = New SqlCeConnection(ConfigurationManager.ConnectionStrings("InventarioRepuestosConnectionString").ConnectionString)
        Return conexion
    End Function

End Class
