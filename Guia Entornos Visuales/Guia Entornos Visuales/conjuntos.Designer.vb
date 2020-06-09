<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conjuntos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conjuntos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btningreso = New System.Windows.Forms.Button()
        Me.combonumeros = New System.Windows.Forms.ComboBox()
        Me.txtconjunto = New System.Windows.Forms.TextBox()
        Me.txtpares = New System.Windows.Forms.TextBox()
        Me.txtimpares = New System.Windows.Forms.TextBox()
        Me.txtpositivos = New System.Windows.Forms.TextBox()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Cuantos valores desea ingresa?"
        '
        'btningreso
        '
        Me.btningreso.Location = New System.Drawing.Point(213, 66)
        Me.btningreso.Name = "btningreso"
        Me.btningreso.Size = New System.Drawing.Size(75, 23)
        Me.btningreso.TabIndex = 1
        Me.btningreso.Text = "Ingresar"
        Me.btningreso.UseVisualStyleBackColor = True
        '
        'combonumeros
        '
        Me.combonumeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combonumeros.FormattingEnabled = True
        Me.combonumeros.Location = New System.Drawing.Point(185, 95)
        Me.combonumeros.Name = "combonumeros"
        Me.combonumeros.Size = New System.Drawing.Size(121, 21)
        Me.combonumeros.TabIndex = 2
        '
        'txtconjunto
        '
        Me.txtconjunto.Location = New System.Drawing.Point(199, 40)
        Me.txtconjunto.Name = "txtconjunto"
        Me.txtconjunto.Size = New System.Drawing.Size(100, 20)
        Me.txtconjunto.TabIndex = 3
        Me.txtconjunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpares
        '
        Me.txtpares.Enabled = False
        Me.txtpares.Location = New System.Drawing.Point(22, 225)
        Me.txtpares.Name = "txtpares"
        Me.txtpares.Size = New System.Drawing.Size(100, 20)
        Me.txtpares.TabIndex = 4
        Me.txtpares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtimpares
        '
        Me.txtimpares.Enabled = False
        Me.txtimpares.Location = New System.Drawing.Point(371, 225)
        Me.txtimpares.Name = "txtimpares"
        Me.txtimpares.Size = New System.Drawing.Size(100, 20)
        Me.txtimpares.TabIndex = 5
        Me.txtimpares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpositivos
        '
        Me.txtpositivos.Enabled = False
        Me.txtpositivos.Location = New System.Drawing.Point(22, 299)
        Me.txtpositivos.Name = "txtpositivos"
        Me.txtpositivos.Size = New System.Drawing.Size(100, 20)
        Me.txtpositivos.TabIndex = 6
        Me.txtpositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnegativos
        '
        Me.txtnegativos.Enabled = False
        Me.txtnegativos.Location = New System.Drawing.Point(374, 299)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.Size = New System.Drawing.Size(100, 20)
        Me.txtnegativos.TabIndex = 7
        Me.txtnegativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsuma
        '
        Me.txtsuma.Enabled = False
        Me.txtsuma.Location = New System.Drawing.Point(206, 266)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(100, 20)
        Me.txtsuma.TabIndex = 8
        Me.txtsuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Numeros Pares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Numeros Impares"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(22, 273)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(94, 13)
        Me.label.TabIndex = 11
        Me.label.Text = "Numeros Positivos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Numeros Negativos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Suma del Conjunto"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Enabled = False
        Me.btnlimpiar.Location = New System.Drawing.Point(213, 132)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 15
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.White
        Me.btnregresar.BackgroundImage = CType(resources.GetObject("btnregresar.BackgroundImage"), System.Drawing.Image)
        Me.btnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregresar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnregresar.Location = New System.Drawing.Point(445, 12)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(50, 29)
        Me.btnregresar.TabIndex = 23
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'conjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 344)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.txtnegativos)
        Me.Controls.Add(Me.txtpositivos)
        Me.Controls.Add(Me.txtimpares)
        Me.Controls.Add(Me.txtpares)
        Me.Controls.Add(Me.txtconjunto)
        Me.Controls.Add(Me.combonumeros)
        Me.Controls.Add(Me.btningreso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "conjuntos"
        Me.Text = "Conjunto de Numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btningreso As Button
    Friend WithEvents combonumeros As ComboBox
    Friend WithEvents txtconjunto As TextBox
    Friend WithEvents txtpares As TextBox
    Friend WithEvents txtimpares As TextBox
    Friend WithEvents txtpositivos As TextBox
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnregresar As Button
End Class
