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
        Me.Checksuma = New System.Windows.Forms.CheckBox()
        Me.checkresta = New System.Windows.Forms.CheckBox()
        Me.Checkdiv = New System.Windows.Forms.CheckBox()
        Me.Checkmulti = New System.Windows.Forms.CheckBox()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.txtraiz = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpotencia = New System.Windows.Forms.TextBox()
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
        Me.btlimpiar.Location = New System.Drawing.Point(16, 228)
        Me.btlimpiar.Name = "btlimpiar"
        Me.btlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btlimpiar.TabIndex = 13
        Me.btlimpiar.Text = "Limpiar"
        Me.btlimpiar.UseVisualStyleBackColor = True
        '
        'Checksuma
        '
        Me.Checksuma.AutoSize = True
        Me.Checksuma.Location = New System.Drawing.Point(37, 125)
        Me.Checksuma.Name = "Checksuma"
        Me.Checksuma.Size = New System.Drawing.Size(53, 17)
        Me.Checksuma.TabIndex = 14
        Me.Checksuma.Text = "Suma"
        Me.Checksuma.UseVisualStyleBackColor = True
        '
        'checkresta
        '
        Me.checkresta.AutoSize = True
        Me.checkresta.Location = New System.Drawing.Point(37, 149)
        Me.checkresta.Name = "checkresta"
        Me.checkresta.Size = New System.Drawing.Size(54, 17)
        Me.checkresta.TabIndex = 15
        Me.checkresta.Text = "Resta"
        Me.checkresta.UseVisualStyleBackColor = True
        '
        'Checkdiv
        '
        Me.Checkdiv.AutoSize = True
        Me.Checkdiv.Location = New System.Drawing.Point(37, 173)
        Me.Checkdiv.Name = "Checkdiv"
        Me.Checkdiv.Size = New System.Drawing.Size(42, 17)
        Me.Checkdiv.TabIndex = 16
        Me.Checkdiv.Text = "Div"
        Me.Checkdiv.UseVisualStyleBackColor = True
        '
        'Checkmulti
        '
        Me.Checkmulti.AutoSize = True
        Me.Checkmulti.Location = New System.Drawing.Point(37, 197)
        Me.Checkmulti.Name = "Checkmulti"
        Me.Checkmulti.Size = New System.Drawing.Size(47, 17)
        Me.Checkmulti.TabIndex = 17
        Me.Checkmulti.Text = "multi"
        Me.Checkmulti.UseVisualStyleBackColor = True
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(145, 138)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(100, 20)
        Me.txtresultado.TabIndex = 18
        '
        'txtraiz
        '
        Me.txtraiz.Location = New System.Drawing.Point(142, 187)
        Me.txtraiz.Name = "txtraiz"
        Me.txtraiz.Size = New System.Drawing.Size(100, 20)
        Me.txtraiz.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Resultado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Raiz"
        '
        'txtpotencia
        '
        Me.txtpotencia.Location = New System.Drawing.Point(142, 231)
        Me.txtpotencia.Name = "txtpotencia"
        Me.txtpotencia.Size = New System.Drawing.Size(100, 20)
        Me.txtpotencia.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 282)
        Me.Controls.Add(Me.txtpotencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtraiz)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Checkmulti)
        Me.Controls.Add(Me.Checkdiv)
        Me.Controls.Add(Me.checkresta)
        Me.Controls.Add(Me.Checksuma)
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
    Friend WithEvents Checksuma As CheckBox
    Friend WithEvents checkresta As CheckBox
    Friend WithEvents Checkdiv As CheckBox
    Friend WithEvents Checkmulti As CheckBox
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents txtraiz As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpotencia As TextBox
End Class
