Public Class Taller

    Private id As Integer
    Private tall As String

    Sub New()

    End Sub

    Sub New(id As String)
        Me.id = CInt(id)
    End Sub

    Public Property Taller As String
        Get
            Return tall
        End Get
        Set(value As String)
            tall = value
        End Set
    End Property

    Public Property IDTaller As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Function GuardarTaller()


    End Function

End Class
