Imports MySql.Data.MySqlClient
Public Class Proveedor
    Private name As String
    Private contac As Contacto
    Private id As Integer

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, name As String)
        Me.id = id
        Me.name = name
    End Sub
    Public Sub New(name As String)
        Me.name = name
    End Sub

    Public Property IDProveedor As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Proveedor As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Contacto As Contacto
        Get
            Return contac
        End Get
        Set(value As Contacto)
            contac = value
        End Set
    End Property

    Public Function GuardarProveedor()
        Dim operacion_proveedor As New Operacion("proveedor")
        Dim operacion_contacto As New Operacion("contacto")
        Dim result As Boolean = False

        Try
            operacion_contacto.AgregarCampo("telefono", Me.Contacto.Telefono)
            operacion_contacto.AgregarCampo("correo", Me.Contacto.Correo)
            operacion_contacto.AgregarCampo("direccion", Me.Contacto.Direccion)
            operacion_contacto.Guardar()

            Me.Contacto.IDContacto = CInt(operacion_contacto.UltimoID("idcontacto"))

            operacion_proveedor.AgregarCampo("proveedor", Me.Proveedor)
            operacion_proveedor.AgregarCampo("idcontacto", Me.Contacto.IDContacto)
            operacion_proveedor.Guardar()

            result = True
        Catch ex As Exception
            MsgBox("Error en la clase operario, guardaroperario() " & vbCrLf & ex.Message)
        End Try
        Return result
    End Function

    Public Function Validar()
        Dim result As Boolean = True

        If Me.Proveedor = "" Then
            result = False
        End If
        If Me.Contacto.Telefono = "" Then
            result = False
        End If
        If Me.Contacto.Direccion = "" Then
            result = False
        End If
        If Me.Contacto.Correo = "" Then
            result = False
        End If

        Return result
    End Function
End Class
