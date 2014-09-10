Public Class FrmArticulo

    Private Sub Articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClasificacion()
        CargarMedicion()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Sub CargarClasificacion()
        Dim tabla As New DataTable
        Operacion.CargarDatos("select * from clasificacion;", tabla)
        CmbClasificacion.DataSource = tabla
        CmbClasificacion.DisplayMember = "clasificacion"
        CmbClasificacion.ValueMember = "idclasificacion"

    End Sub

    Sub CargarMedicion()
        Dim tabla As New DataTable
        Operacion.CargarDatos("select * from medicion", tabla)
        CmbMedicion.DataSource = tabla
        CmbMedicion.DisplayMember = "tipomedida"
        CmbMedicion.ValueMember = "idmedicion"

    End Sub
End Class