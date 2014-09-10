Imports MySql.Data.MySqlClient

Module ModuloConexion

    Public Conexion As MySqlConnection

    Public usuario As String
    Public contraseña As String
    Public catalogo As String
    Public servidor As String

    Private Const user As String = "root"
    Private Const password As String = "root"
    Private Const server As String = "localhost"
    Private Const database As String = "inventario"

    Sub New()
        If Not ReanudarConexion() Then
            MsgBox("No se ha podido reanudar la conexion")
        End If
    End Sub

    Public Function ReanudarConexion() As Boolean

        usuario = My.Settings.Usuario
        contraseña = My.Settings.Contraseña
        servidor = My.Settings.Servidor
        catalogo = My.Settings.BaseDatos
        Return Conectar()
    End Function

    Private Sub GuardarConfiguracion()
        My.Settings.Usuario = usuario
        My.Settings.Contraseña = contraseña
        My.Settings.Servidor = servidor
        My.Settings.BaseDatos = catalogo
        My.Settings.Save()
    End Sub

    Public Sub Prederminada()
        usuario = user
        contraseña = password
        servidor = server
        catalogo = database
        Conectar()
    End Sub

    Public Function Conectar() As Boolean

        If IsNothing(Conexion) Then
            Conexion = New MySqlConnection("Data Source=" & servidor & ";Database=" & catalogo & ";User Id=" & usuario & ";Password=" & contraseña)
        Else
            Conexion.ConnectionString = "Data Source=" & servidor & ";Database=" & catalogo & ";User Id=" & usuario & ";Password=" & contraseña
        End If

        Try
            Conexion.Open()
            GuardarConfiguracion()
            Return True
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")

        Finally
            Conexion.Close()
        End Try
        Return False
    End Function

End Module
