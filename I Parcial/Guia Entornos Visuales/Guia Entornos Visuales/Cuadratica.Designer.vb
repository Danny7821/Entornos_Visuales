<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuadratica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuadratica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtvalorA = New System.Windows.Forms.TextBox()
        Me.txtvalorB = New System.Windows.Forms.TextBox()
        Me.txtvalorC = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtx1 = New System.Windows.Forms.TextBox()
        Me.txtx2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor C"
        '
        'txtvalorA
        '
        Me.txtvalorA.Location = New System.Drawing.Point(5, 32)
        Me.txtvalorA.Name = "txtvalorA"
        Me.txtvalorA.Size = New System.Drawing.Size(100, 20)
        Me.txtvalorA.TabIndex = 3
        Me.txtvalorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvalorB
        '
        Me.txtvalorB.Location = New System.Drawing.Point(5, 116)
        Me.txtvalorB.Name = "txtvalorB"
        Me.txtvalorB.Size = New System.Drawing.Size(100, 20)
        Me.txtvalorB.TabIndex = 4
        Me.txtvalorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtvalorC
        '
        Me.txtvalorC.Location = New System.Drawing.Point(5, 211)
        Me.txtvalorC.Name = "txtvalorC"
        Me.txtvalorC.Size = New System.Drawing.Size(100, 20)
        Me.txtvalorC.TabIndex = 5
        Me.txtvalorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(134, 76)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 6
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "X2"
        '
        'txtx1
        '
        Me.txtx1.Enabled = False
        Me.txtx1.Location = New System.Drawing.Point(25, 32)
        Me.txtx1.Name = "txtx1"
        Me.txtx1.Size = New System.Drawing.Size(100, 20)
        Me.txtx1.TabIndex = 9
        Me.txtx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtx2
        '
        Me.txtx2.Enabled = False
        Me.txtx2.Location = New System.Drawing.Point(25, 120)
        Me.txtx2.Name = "txtx2"
        Me.txtx2.Size = New System.Drawing.Size(100, 20)
        Me.txtx2.TabIndex = 10
        Me.txtx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtx2)
        Me.GroupBox1.Controls.Add(Me.txtx1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 176)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Respuestas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtvalorC)
        Me.GroupBox2.Controls.Add(Me.txtvalorB)
        Me.GroupBox2.Controls.Add(Me.txtvalorA)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 251)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(335, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 29)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 276)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncalcular)
        Me.Name = "Cuadratica"
        Me.Text = "Formula Cuadratica Cuadratica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtvalorA As TextBox
    Friend WithEvents txtvalorB As TextBox
    Friend WithEvents txtvalorC As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtx1 As TextBox
    Friend WithEvents txtx2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
