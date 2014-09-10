Imports MySql.Data.MySqlClient

Public Class Operacion

    Private campos As New Hashtable()
    Private table As String

    Public Sub New()

    End Sub

    Sub New(tabla As String)
        Me.table = tabla
    End Sub

    Public Property Tabla As String
        Get
            Return table
        End Get
        Set(value As String)
            table = value
        End Set
    End Property

    Public Sub Limpiar()
        campos.Clear()
    End Sub

    Public Function Guardar() As Boolean
        Dim vars As String = ""
        Dim vals As String = ""
        Dim sqlString As String = 0
        Dim i As Integer = 0
        Dim result As Boolean = False

        For i = 0 To campos.Count - 1
            vars = vars & campos.Keys(i)
            vals = vals & campos.Item(campos.Keys(i))
            If i < campos.Count - 1 Then
                vars = vars & ","
                vals = vals & "','"
            End If
        Next
        sqlString = "insert into " & table & "(" & vars & ") values ('" & vals & "');"
        MsgBox(sqlString)
        Dim command As New MySqlCommand(sqlString, Conexion)

        Try
            Conexion.Open()
            command.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            MsgBox("Error en la Funcion Guardar() en la clase Operacion " & vbCrLf & ex.Message)
            result = False
        Finally
            Conexion.Close()
        End Try

        Return False
    End Function

    Public Function GuardarComoProcedimiento(procedimiento As String) As Boolean
        Dim command As New MySqlCommand
        Dim result As Boolean = False

        command.CommandType = CommandType.StoredProcedure
        command.CommandText = procedimiento
        command.Connection = Conexion

        For i As Integer = 0 To campos.Count - 1
            command.Parameters.AddWithValue("?" & campos.Keys(i), campos.Item(campos.Keys(i)))
            command.Parameters("?" & campos.Keys(i)).direction = ParameterDirection.Input
        Next

        Try
            Conexion.Open()
            command.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            MsgBox("Error en la funcion GuardarComoProcedimiento(args())" & vbCrLf & ex.Message)
        Finally
            Conexion.Close()
            command.Dispose()
        End Try

        Return result
    End Function

    Public Sub AgregarCampo(ByRef campo As String, ByRef valor As Object)
        campos.Add(campo, valor)
    End Sub

    Public Function Consultar(sqlString As String) As Integer
        Dim command As New MySqlCommand(sqlString, Conexion)
        Dim result As Integer

        Try
            Conexion.Open()
            result = command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
            command.Dispose()
        End Try
        Return result
    End Function

    Public Shared Sub CargarDatos(sqlstring As String, objeto As Object)
        Dim adapter As New MySqlDataAdapter(sqlstring, Conexion)

        If (TypeOf objeto Is DataTable Or TypeOf objeto Is DataSet) And (Not IsNothing(objeto)) Then

            Try
                adapter.Fill(objeto)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                adapter.Dispose()
            End Try

        End If
    End Sub

    Public Function UltimoID(campo_id As String) As String
        Dim adapter As New MySqlDataAdapter("select max(" & campo_id & ") from " & table, Conexion)
        Dim tabla As New DataTable

        adapter.Fill(tabla)
        adapter.Dispose()

        Return tabla.Rows(0).Item(0).ToString
    End Function
End Class
