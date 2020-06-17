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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncomputadoras = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbprecio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantcomputadoras = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.combocompus = New System.Windows.Forms.ComboBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbprecio)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btncomputadoras)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensional"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combocompus)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtcantcomputadoras)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 308)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'btncomputadoras
        '
        Me.btncomputadoras.Location = New System.Drawing.Point(18, 77)
        Me.btncomputadoras.Name = "btncomputadoras"
        Me.btncomputadoras.Size = New System.Drawing.Size(121, 23)
        Me.btncomputadoras.TabIndex = 1
        Me.btncomputadoras.Text = "btncomputadoras"
        Me.btncomputadoras.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(18, 106)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(121, 21)
        Me.cmbComputadoras.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar Precio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbprecio
        '
        Me.cmbprecio.FormattingEnabled = True
        Me.cmbprecio.Location = New System.Drawing.Point(208, 106)
        Me.cmbprecio.Name = "cmbprecio"
        Me.cmbprecio.Size = New System.Drawing.Size(121, 21)
        Me.cmbprecio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de Computadoras"
        '
        'txtcantcomputadoras
        '
        Me.txtcantcomputadoras.Location = New System.Drawing.Point(147, 31)
        Me.txtcantcomputadoras.Name = "txtcantcomputadoras"
        Me.txtcantcomputadoras.Size = New System.Drawing.Size(100, 20)
        Me.txtcantcomputadoras.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(277, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Solicitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'combocompus
        '
        Me.combocompus.FormattingEnabled = True
        Me.combocompus.Location = New System.Drawing.Point(9, 77)
        Me.combocompus.Name = "combocompus"
        Me.combocompus.Size = New System.Drawing.Size(121, 21)
        Me.combocompus.TabIndex = 3
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(111, 171)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(114, 20)
        Me.btnlimpiar.TabIndex = 5
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btncomputadoras As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbprecio As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents combocompus As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtcantcomputadoras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlimpiar As Button
End Class
