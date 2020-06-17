<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.btnvalidar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(57, 41)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 5
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(67, 135)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 10
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnvalidar
        '
        Me.btnvalidar.Location = New System.Drawing.Point(67, 87)
        Me.btnvalidar.Name = "btnvalidar"
        Me.btnvalidar.Size = New System.Drawing.Size(75, 23)
        Me.btnvalidar.TabIndex = 16
        Me.btnvalidar.Text = "Validar"
        Me.btnvalidar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 202)
        Me.Controls.Add(Me.btnvalidar)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.txtvalor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents btnvalidar As Button
End Class
