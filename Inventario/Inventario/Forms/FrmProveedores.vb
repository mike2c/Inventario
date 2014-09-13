Public Class FrmProveedores
    Private proveedor As New Proveedor
    Private operacion As New Operacion

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Sub guardar()
        proveedor.Proveedor = TxtNombre.Text
        proveedor.Contacto = New Contacto(TxtMail.Text, TxtPhone.Text, TxtAddress.Text)

        If proveedor.Validar Then
            If proveedor.GuardarProveedor() Then
                MsgBox("Operario guardado correctamente")
            End If
        Else
            MsgBox("Asegurese de llenar todos los campos antes de guardar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class