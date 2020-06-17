<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sueldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sueldo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprimernombre = New System.Windows.Forms.TextBox()
        Me.txtsegundonombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtsueldomensual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtsegundoapellido = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtisr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcalsueldomensual = New System.Windows.Forms.TextBox()
        Me.txtcalsueldoquincenal = New System.Windows.Forms.TextBox()
        Me.txtnombrecompleto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segundo Nombre"
        '
        'txtprimernombre
        '
        Me.txtprimernombre.Location = New System.Drawing.Point(14, 62)
        Me.txtprimernombre.Name = "txtprimernombre"
        Me.txtprimernombre.Size = New System.Drawing.Size(100, 20)
        Me.txtprimernombre.TabIndex = 2
        '
        'txtsegundonombre
        '
        Me.txtsegundonombre.Location = New System.Drawing.Point(131, 62)
        Me.txtsegundonombre.Name = "txtsegundonombre"
        Me.txtsegundonombre.Size = New System.Drawing.Size(100, 20)
        Me.txtsegundonombre.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btncalcular)
        Me.GroupBox1.Controls.Add(Me.txtsueldomensual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtsegundoapellido)
        Me.GroupBox1.Controls.Add(Me.txtsegundonombre)
        Me.GroupBox1.Controls.Add(Me.txtprimernombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 189)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sueldo Mensual"
        '
        'btncalcular
        '
        Me.btncalcular.Enabled = False
        Me.btncalcular.Location = New System.Drawing.Point(290, 120)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(127, 45)
        Me.btncalcular.TabIndex = 12
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtsueldomensual
        '
        Me.txtsueldomensual.Location = New System.Drawing.Point(18, 145)
        Me.txtsueldomensual.Name = "txtsueldomensual"
        Me.txtsueldomensual.Size = New System.Drawing.Size(100, 20)
        Me.txtsueldomensual.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Segundo Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Primer Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(250, 62)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido.TabIndex = 5
        '
        'txtsegundoapellido
        '
        Me.txtsegundoapellido.Location = New System.Drawing.Point(365, 62)
        Me.txtsegundoapellido.Name = "txtsegundoapellido"
        Me.txtsegundoapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtsegundoapellido.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnlimpiar)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtisr)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtcalsueldomensual)
        Me.GroupBox2.Controls.Add(Me.txtcalsueldoquincenal)
        Me.GroupBox2.Controls.Add(Me.txtnombrecompleto)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 133)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculó"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Enabled = False
        Me.btnlimpiar.Location = New System.Drawing.Point(382, 40)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 73)
        Me.btnlimpiar.TabIndex = 16
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(282, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ISR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nombre Completo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sueldo Mensual"
        '
        'txtisr
        '
        Me.txtisr.Enabled = False
        Me.txtisr.Location = New System.Drawing.Point(245, 93)
        Me.txtisr.Name = "txtisr"
        Me.txtisr.Size = New System.Drawing.Size(100, 20)
        Me.txtisr.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sueldo Quincenal"
        '
        'txtcalsueldomensual
        '
        Me.txtcalsueldomensual.Enabled = False
        Me.txtcalsueldomensual.Location = New System.Drawing.Point(126, 93)
        Me.txtcalsueldomensual.Name = "txtcalsueldomensual"
        Me.txtcalsueldomensual.Size = New System.Drawing.Size(100, 20)
        Me.txtcalsueldomensual.TabIndex = 2
        '
        'txtcalsueldoquincenal
        '
        Me.txtcalsueldoquincenal.Enabled = False
        Me.txtcalsueldoquincenal.Location = New System.Drawing.Point(6, 93)
        Me.txtcalsueldoquincenal.Name = "txtcalsueldoquincenal"
        Me.txtcalsueldoquincenal.Size = New System.Drawing.Size(100, 20)
        Me.txtcalsueldoquincenal.TabIndex = 1
        '
        'txtnombrecompleto
        '
        Me.txtnombrecompleto.Enabled = False
        Me.txtnombrecompleto.Location = New System.Drawing.Point(6, 40)
        Me.txtnombrecompleto.Name = "txtnombrecompleto"
        Me.txtnombrecompleto.Size = New System.Drawing.Size(339, 20)
        Me.txtnombrecompleto.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(501, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 29)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Sueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 359)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sueldo"
        Me.Text = "Sueldo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprimernombre As TextBox
    Friend WithEvents txtsegundonombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtsueldomensual As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtsegundoapellido As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtisr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcalsueldomensual As TextBox
    Friend WithEvents txtcalsueldoquincenal As TextBox
    Friend WithEvents txtnombrecompleto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
