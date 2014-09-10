Imports System.Windows.Forms

Public Class MDI

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BloquearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloquearToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Dim operario As New FrmOperario()
        operario.MdiParent = Me
        operario.Show()

    End Sub

    Private Sub AgregarArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarArticuloToolStripMenuItem.Click
        Dim a As New FrmArticulo
        a.MdiParent = Me
        a.Show()
    End Sub
End Class
