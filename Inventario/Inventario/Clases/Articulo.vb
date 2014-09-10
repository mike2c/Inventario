Public Class Articulo
    Private idart As Integer
    Private desc As String
    Private clas As New Clasificar
    Private med As New Medir

    Public Property IDArticulo As Integer
        Get
            Return idart
        End Get
        Set(value As Integer)
            idart = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return desc
        End Get
        Set(value As String)
            desc = value
        End Set
    End Property

    Public Property Clasificacion As Clasificar
        Get
            Return Me.clas
        End Get
        Set(value As Clasificar)
            Me.clas = value
        End Set
    End Property

    Public Property Medicion As Medir
        Get
            Return Me.med
        End Get
        Set(value As Medir)
            med = value
        End Set
    End Property

    Public Class Medir
        Private id As Integer
        Private med As String

        Public Property IDMedicion As Integer
            Get
                Return id
            End Get
            Set(value As Integer)
                id = value
            End Set
        End Property

        Public Property Medicion As Integer
            Get
                Return med
            End Get
            Set(value As Integer)
                med = value
            End Set
        End Property

    End Class

    'Clase que maneja las clasificaciones
    Public Class Clasificar
        Private id As Integer
        Private clas As String

        Sub New()

        End Sub

        Public Property Clasificacion As String
            Get
                Return clas
            End Get
            Set(value As String)
                clas = value
            End Set
        End Property

        Public Property IDClasificacion As Integer
            Get
                Return id
            End Get
            Set(value As Integer)
                id = value
            End Set
        End Property

    End Class

    Public Function GuardarArticulo() As Boolean
        Dim operacion As New Operacion

        operacion.AgregarCampo("pdescripcion", Me.Descripcion)
        operacion.AgregarCampo("medicion_id", Me.Medicion.IDMedicion)
        operacion.AgregarCampo("clasificacion_id", Me.Clasificacion.IDClasificacion)

        If operacion.GuardarComoProcedimiento("GuardarArticulo") Then
            Return True
        End If

        Return False
    End Function

End Class
