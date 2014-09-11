Public Class Inventario
    Private id As Integer
    Private exist As Integer
    Private min As Integer

    Sub New()

    End Sub

    Public Property IDInventario As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Existencia As Integer
        Get
            Return exist
        End Get
        Set(value As Integer)
            exist = value
        End Set
    End Property

    Public Property Minimo As Integer
        Get
            Return min
        End Get
        Set(value As Integer)
            min = value
        End Set
    End Property



End Class
