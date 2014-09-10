Public Class FrmOperario
    Private Actualizar As Boolean = False
    Private Operario As New Operario
    Private operacion As New Operacion

    Sub New()
        InitializeComponent()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Operario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CmbSexo.SelectedIndex = 0
        CargarTaller()
    End Sub

    Sub CargarTaller()
        Dim operacion As New Operacion("taller")
        Dim tabla As New DataTable
        operacion.CargarDatos("select * from taller;", tabla)
        Me.CmbTaller.DataSource = tabla
        CmbTaller.DisplayMember = "taller"
        CmbTaller.ValueMember = "idtaller"

    End Sub

    Sub guardar()
        Operario.Nombre = TxtNombre.Text
        Operario.Apellido = TxtApellido.Text

        If CmbSexo.SelectedIndex = 0 Then
            Operario.Sexo = "M"
        Else
            Operario.Sexo = "F"
        End If

        Operario.Contacto = New Contacto(Me.TxtCorreo.Text, Me.TxtTelefono.Text, Me.TxtDireccion.Text)
        MsgBox(Operario.Contacto.Correo)
        Operario.Taller = New Taller(Me.CmbTaller.SelectedValue)

        If Operario.GuardarOperario() Then
            MsgBox("Operario guardado correctamente")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub
End Class