<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtvalor1 = New System.Windows.Forms.TextBox()
        Me.txtvalor2 = New System.Windows.Forms.TextBox()
        Me.btlimpiar = New System.Windows.Forms.Button()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtresta = New System.Windows.Forms.TextBox()
        Me.txtmulti = New System.Windows.Forms.TextBox()
        Me.txtdivi = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valor 2"
        '
        'txtvalor1
        '
        Me.txtvalor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalor1.Location = New System.Drawing.Point(13, 86)
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor1.TabIndex = 11
        '
        'txtvalor2
        '
        Me.txtvalor2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtvalor2.Location = New System.Drawing.Point(145, 86)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor2.TabIndex = 12
        '
        'btlimpiar
        '
        Me.btlimpiar.Location = New System.Drawing.Point(114, 230)
        Me.btlimpiar.Name = "btlimpiar"
        Me.btlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btlimpiar.TabIndex = 13
        Me.btlimpiar.Text = "Limpiar"
        Me.btlimpiar.UseVisualStyleBackColor = True
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(12, 139)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(100, 20)
        Me.txtsuma.TabIndex = 18
        '
        'txtresta
        '
        Me.txtresta.Location = New System.Drawing.Point(145, 139)
        Me.txtresta.Name = "txtresta"
        Me.txtresta.Size = New System.Drawing.Size(100, 20)
        Me.txtresta.TabIndex = 19
        '
        'txtmulti
        '
        Me.txtmulti.Location = New System.Drawing.Point(12, 182)
        Me.txtmulti.Name = "txtmulti"
        Me.txtmulti.Size = New System.Drawing.Size(100, 20)
        Me.txtmulti.TabIndex = 20
        '
        'txtdivi
        '
        Me.txtdivi.Location = New System.Drawing.Point(145, 182)
        Me.txtdivi.Name = "txtdivi"
        Me.txtdivi.Size = New System.Drawing.Size(100, 20)
        Me.txtdivi.TabIndex = 21
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(13, 230)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 22
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 282)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtdivi)
        Me.Controls.Add(Me.txtmulti)
        Me.Controls.Add(Me.txtresta)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.btlimpiar)
        Me.Controls.Add(Me.txtvalor2)
        Me.Controls.Add(Me.txtvalor1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.Text = "Validacion de Numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtvalor1 As TextBox
    Friend WithEvents txtvalor2 As TextBox
    Friend WithEvents btlimpiar As Button
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtresta As TextBox
    Friend WithEvents txtmulti As TextBox
    Friend WithEvents txtdivi As TextBox
    Friend WithEvents btncalcular As Button
End Class
