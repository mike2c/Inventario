Imports MySql.Data.MySqlClient

Module ModuloSesion
    Private user As String
    Private password As String
    Private id As String
    Private enc As New Encriptacion("mike2c")

    Public bloqueada As Boolean = False

    Public Property Usuario As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Function IniciarSesion() As Boolean
        Dim adapter As New MySqlDataAdapter("select * from usuario where usuario='" & Usuario & "' and contraseña='" & Contraseña & "';", Conexion)
        Dim tabla As New DataTable
        adapter.Fill(tabla)
        'MsgBox("select * from usuario where usuario='" & Usuario & "' and contraseña='" & Contraseña & "';")
        If tabla.Rows.Count > 0 Then

            Return True
        End If
        Return False
    End Function

End Module
