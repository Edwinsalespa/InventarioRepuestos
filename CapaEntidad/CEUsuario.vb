Public Class CEUsuario
    'Atributos'
    Private _idUsuario As Integer
    Private _nombre As String
    Private _apellido As String
    Private _cedula As Integer
    Private _contraseña As String

    'Getters y Setters'

    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property nombre As Integer
        Get
            Return _nombre
        End Get
        Set(ByVal value As Integer)
            _nombre = value
        End Set
    End Property

    Public Property apellido As Integer
        Get
            Return _apellido
        End Get
        Set(ByVal value As Integer)
            _apellido = value
        End Set
    End Property

    Public Property cedula As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Public Property contraseña As Integer
        Get
            Return _contraseña
        End Get
        Set(ByVal value As Integer)
            _contraseña = value
        End Set
    End Property

End Class
