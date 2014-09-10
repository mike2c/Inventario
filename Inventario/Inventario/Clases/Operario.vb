Public Class Operario

    Private name, lastname As String
    Private id As Integer
    Private sex As Char
    Private contact As Contacto
    Private tall As Taller

    Sub New()

    End Sub

    Public Sub New(id As Integer, name As String, lastname As String, sex As Char)
        Me.id = id
        Me.name = name
        Me.lastname = lastname
        Me.sex = sex
    End Sub

    Public Sub New(name As String, lastname As String, sex As Char)
        Me.name = name
        Me.lastname = lastname
        Me.sex = sex
    End Sub

    Public Property Contacto As Contacto
        Get
            Return contact
        End Get
        Set(value As Contacto)
            contact = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return lastname
        End Get
        Set(value As String)
            lastname = value
        End Set
    End Property

    Public Property IDOperario As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Sexo As Char
        Get
            Return sex
        End Get
        Set(value As Char)
            sex = value
        End Set
    End Property

    Public Property Taller As Taller
        Get
            Return tall
        End Get
        Set(value As Taller)
            tall = value
        End Set
    End Property

    Public Function GuardarOperario()
        Dim operacion_operario As New Operacion("operario")
        Dim operacion_contacto As New Operacion("contacto")
        Dim result As Boolean = False

        Try
            operacion_contacto.AgregarCampo("telefono", Me.Contacto.Telefono)
            operacion_contacto.AgregarCampo("correo", Me.Contacto.Correo)
            operacion_contacto.AgregarCampo("direccion", Me.Contacto.Direccion)
            operacion_contacto.Guardar()

            Me.Contacto.IDContacto = CInt(operacion_contacto.UltimoID("idcontacto"))

            operacion_operario.AgregarCampo("nombre", Me.Nombre)
            operacion_operario.AgregarCampo("apellido", Me.Apellido)
            operacion_operario.AgregarCampo("sexo", Me.Sexo)
            operacion_operario.AgregarCampo("idcontacto", Me.Contacto.IDContacto)
            MsgBox(Taller.IDTaller)
            operacion_operario.AgregarCampo("idtaller", CInt(Me.Taller.IDTaller))

            operacion_operario.Guardar()
            result = True
        Catch ex As Exception
            MsgBox("Error en la clase operario, guardaroperario() " & vbCrLf & ex.Message)
        End Try

        Return result
    End Function
End Class

