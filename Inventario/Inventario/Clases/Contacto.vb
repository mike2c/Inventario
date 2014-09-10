Public Class Contacto

    Private id As Integer
    Private email, phone, address As String

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, email As String, phone As String, address As String)

        Me.id = id
        Me.email = email
        Me.phone = phone
        Me.address = address
    End Sub

    Public Sub New(email As String, phone As String, address As String)
        Me.email = email
        Me.phone = phone
        Me.address = address

    End Sub

    Public Property IDContacto As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property



End Class
