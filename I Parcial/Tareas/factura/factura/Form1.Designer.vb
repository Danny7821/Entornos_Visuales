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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.CheckBoxdescuento = New System.Windows.Forms.CheckBox()
        Me.combodescuento = New System.Windows.Forms.ComboBox()
        Me.CheckBoxisv = New System.Windows.Forms.CheckBox()
        Me.Comboisv = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtisv = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.mascara = New System.Windows.Forms.MaskedTextBox()
        Me.txtmask = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.Location = New System.Drawing.Point(52, 56)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.Size = New System.Drawing.Size(100, 20)
        Me.txtpreciounitario.TabIndex = 2
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(206, 56)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'CheckBoxdescuento
        '
        Me.CheckBoxdescuento.AutoSize = True
        Me.CheckBoxdescuento.Location = New System.Drawing.Point(52, 103)
        Me.CheckBoxdescuento.Name = "CheckBoxdescuento"
        Me.CheckBoxdescuento.Size = New System.Drawing.Size(113, 17)
        Me.CheckBoxdescuento.TabIndex = 4
        Me.CheckBoxdescuento.Text = "Aplicar Descuento"
        Me.CheckBoxdescuento.UseVisualStyleBackColor = True
        '
        'combodescuento
        '
        Me.combodescuento.Enabled = False
        Me.combodescuento.FormattingEnabled = True
        Me.combodescuento.Items.AddRange(New Object() {"5%", "10%", "8%", "15%", "30%", "20%"})
        Me.combodescuento.Location = New System.Drawing.Point(52, 135)
        Me.combodescuento.Name = "combodescuento"
        Me.combodescuento.Size = New System.Drawing.Size(121, 21)
        Me.combodescuento.TabIndex = 5
        '
        'CheckBoxisv
        '
        Me.CheckBoxisv.AutoSize = True
        Me.CheckBoxisv.Location = New System.Drawing.Point(52, 176)
        Me.CheckBoxisv.Name = "CheckBoxisv"
        Me.CheckBoxisv.Size = New System.Drawing.Size(78, 17)
        Me.CheckBoxisv.TabIndex = 6
        Me.CheckBoxisv.Text = "Aplicar ISV"
        Me.CheckBoxisv.UseVisualStyleBackColor = True
        '
        'Comboisv
        '
        Me.Comboisv.Enabled = False
        Me.Comboisv.FormattingEnabled = True
        Me.Comboisv.Items.AddRange(New Object() {"15%", "17%"})
        Me.Comboisv.Location = New System.Drawing.Point(52, 199)
        Me.Comboisv.Name = "Comboisv"
        Me.Comboisv.Size = New System.Drawing.Size(121, 21)
        Me.Comboisv.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ISV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Location = New System.Drawing.Point(66, 286)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 12
        '
        'txtdescuento
        '
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(206, 286)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 13
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(206, 345)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 14
        '
        'txtisv
        '
        Me.txtisv.Enabled = False
        Me.txtisv.Location = New System.Drawing.Point(66, 345)
        Me.txtisv.Name = "txtisv"
        Me.txtisv.Size = New System.Drawing.Size(100, 20)
        Me.txtisv.TabIndex = 15
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(231, 124)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 16
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Enabled = False
        Me.btnnuevo.Location = New System.Drawing.Point(231, 176)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 17
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(143, 396)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 18
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'mascara
        '
        Me.mascara.Location = New System.Drawing.Point(215, 82)
        Me.mascara.Mask = "000000000"
        Me.mascara.Name = "mascara"
        Me.mascara.Size = New System.Drawing.Size(100, 20)
        Me.mascara.TabIndex = 19
        '
        'txtmask
        '
        Me.txtmask.Location = New System.Drawing.Point(225, 221)
        Me.txtmask.Name = "txtmask"
        Me.txtmask.Size = New System.Drawing.Size(100, 20)
        Me.txtmask.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(363, 450)
        Me.Controls.Add(Me.txtmask)
        Me.Controls.Add(Me.mascara)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtisv)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Comboisv)
        Me.Controls.Add(Me.CheckBoxisv)
        Me.Controls.Add(Me.combodescuento)
        Me.Controls.Add(Me.CheckBoxdescuento)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtpreciounitario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpreciounitario As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents CheckBoxdescuento As CheckBox
    Friend WithEvents combodescuento As ComboBox
    Friend WithEvents CheckBoxisv As CheckBox
    Friend WithEvents Comboisv As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtisv As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents mascara As MaskedTextBox
    Friend WithEvents txtmask As TextBox
End Class
