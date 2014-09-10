<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbMedicion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregarClasificacion = New System.Windows.Forms.Label()
        Me.BtnAgregarMedicion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtTelefono.Location = New System.Drawing.Point(12, 36)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(223, 23)
        Me.TxtTelefono.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Medicion"
        '
        'CmbMedicion
        '
        Me.CmbMedicion.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbMedicion.FormattingEnabled = True
        Me.CmbMedicion.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbMedicion.Location = New System.Drawing.Point(12, 155)
        Me.CmbMedicion.Name = "CmbMedicion"
        Me.CmbMedicion.Size = New System.Drawing.Size(223, 24)
        Me.CmbMedicion.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Clasificacion"
        '
        'CmbClasificacion
        '
        Me.CmbClasificacion.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbClasificacion.FormattingEnabled = True
        Me.CmbClasificacion.Location = New System.Drawing.Point(12, 95)
        Me.CmbClasificacion.Name = "CmbClasificacion"
        Me.CmbClasificacion.Size = New System.Drawing.Size(223, 24)
        Me.CmbClasificacion.TabIndex = 20
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(397, 185)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 31)
        Me.BtnCancelar.TabIndex = 25
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(316, 185)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 31)
        Me.BtnGuardar.TabIndex = 24
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(300, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregarClasificacion
        '
        Me.BtnAgregarClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnAgregarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarClasificacion.Image = CType(resources.GetObject("BtnAgregarClasificacion.Image"), System.Drawing.Image)
        Me.BtnAgregarClasificacion.Location = New System.Drawing.Point(241, 96)
        Me.BtnAgregarClasificacion.Name = "BtnAgregarClasificacion"
        Me.BtnAgregarClasificacion.Size = New System.Drawing.Size(23, 23)
        Me.BtnAgregarClasificacion.TabIndex = 27
        '
        'BtnAgregarMedicion
        '
        Me.BtnAgregarMedicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnAgregarMedicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarMedicion.Image = CType(resources.GetObject("BtnAgregarMedicion.Image"), System.Drawing.Image)
        Me.BtnAgregarMedicion.Location = New System.Drawing.Point(241, 156)
        Me.BtnAgregarMedicion.Name = "BtnAgregarMedicion"
        Me.BtnAgregarMedicion.Size = New System.Drawing.Size(23, 23)
        Me.BtnAgregarMedicion.TabIndex = 28
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 220)
        Me.Controls.Add(Me.BtnAgregarMedicion)
        Me.Controls.Add(Me.BtnAgregarClasificacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbMedicion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbClasificacion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label7)
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbMedicion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAgregarClasificacion As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarMedicion As System.Windows.Forms.Label
End Class
