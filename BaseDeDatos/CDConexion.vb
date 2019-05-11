Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Configuration


Public Class CDConexion

    Dim conexion As SqlCeConnection

    Public Function conectarBD() As SqlCeConnection
        conexion = New SqlCeConnection(ConfigurationManager.ConnectionStrings("InventarioConnectionString").ConnectionString)
        Return conexion
    End Function

End Class
