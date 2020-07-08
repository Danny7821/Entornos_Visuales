<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.dtclientes = New System.Windows.Forms.DataGridView()
        Me.group = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.PictureBox()
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group.SuspendLayout()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtclientes
        '
        Me.dtclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtclientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtclientes.Location = New System.Drawing.Point(6, 19)
        Me.dtclientes.Name = "dtclientes"
        Me.dtclientes.Size = New System.Drawing.Size(665, 263)
        Me.dtclientes.TabIndex = 1
        '
        'group
        '
        Me.group.Controls.Add(Me.dtclientes)
        Me.group.Location = New System.Drawing.Point(86, 157)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(681, 297)
        Me.group.TabIndex = 2
        Me.group.TabStop = False
        Me.group.Text = "Reporte Clientes "
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.Location = New System.Drawing.Point(18, 11)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(69, 50)
        Me.btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnbuscar.TabIndex = 22
        Me.btnbuscar.TabStop = False
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 466)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group.ResumeLayout(False)
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtclientes As DataGridView
    Friend WithEvents group As GroupBox
    Friend WithEvents btnbuscar As PictureBox
End Class
