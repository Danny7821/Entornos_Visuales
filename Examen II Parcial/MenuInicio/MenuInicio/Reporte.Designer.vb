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
        Me.dtclientes = New System.Windows.Forms.DataGridView()
        Me.group = New System.Windows.Forms.GroupBox()
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtclientes
        '
        Me.dtclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtclientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtclientes.Location = New System.Drawing.Point(6, 31)
        Me.dtclientes.Name = "dtclientes"
        Me.dtclientes.Size = New System.Drawing.Size(650, 366)
        Me.dtclientes.TabIndex = 1
        '
        'group
        '
        Me.group.Controls.Add(Me.dtclientes)
        Me.group.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group.Location = New System.Drawing.Point(117, 51)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(662, 403)
        Me.group.TabIndex = 2
        Me.group.TabStop = False
        Me.group.Text = "Reporte Clientes "
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 466)
        Me.Controls.Add(Me.group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtclientes As DataGridView
    Friend WithEvents group As GroupBox
End Class
