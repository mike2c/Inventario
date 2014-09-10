Public Class Form1

    Sub New()

        InitializeComponent()
        'If Not ModuloConexion.ReanudarConexion Then
        '    MsgBox("No se ha podido reanudar la conexion")
        'End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Sub iniciarsesion()
        ModuloSesion.Usuario = Me.TxtUser.Text
        ModuloSesion.Contraseña = Me.TxtPass.Text
        If ModuloSesion.IniciarSesion Then
            Dim mdi As New MDI()
            mdi.Show()
            Me.Close()
        Else
            MsgBox("Usuario o contraseña erronea", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        iniciarsesion()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarsesion()
    End Sub
End Class
