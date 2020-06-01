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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opcion2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubFormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combosuma = New System.Windows.Forms.ComboBox()
        Me.comboresta = New System.Windows.Forms.ComboBox()
        Me.combomulti = New System.Windows.Forms.ComboBox()
        Me.combodivision = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.Opcion2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.Formulario2ToolStripMenuItem, Me.Formulario3ToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Opcion2ToolStripMenuItem
        '
        Me.Opcion2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidacionesToolStripMenuItem})
        Me.Opcion2ToolStripMenuItem.Name = "Opcion2ToolStripMenuItem"
        Me.Opcion2ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.Opcion2ToolStripMenuItem.Text = "Opcion 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 230, 55)
        Me.Label1.Size = New System.Drawing.Size(232, 70)
        Me.Label1.TabIndex = 1
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'Formulario2ToolStripMenuItem
        '
        Me.Formulario2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFormularioToolStripMenuItem})
        Me.Formulario2ToolStripMenuItem.Name = "Formulario2ToolStripMenuItem"
        Me.Formulario2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario2ToolStripMenuItem.Text = "Formulario 2"
        '
        'Formulario3ToolStripMenuItem
        '
        Me.Formulario3ToolStripMenuItem.Name = "Formulario3ToolStripMenuItem"
        Me.Formulario3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario3ToolStripMenuItem.Text = "Formulario 3"
        '
        'SubFormularioToolStripMenuItem
        '
        Me.SubFormularioToolStripMenuItem.Name = "SubFormularioToolStripMenuItem"
        Me.SubFormularioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SubFormularioToolStripMenuItem.Text = "Sub Formulario"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorProviderToolStripMenuItem, Me.CondicionalesToolStripMenuItem})
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'ErrorProviderToolStripMenuItem
        '
        Me.ErrorProviderToolStripMenuItem.Name = "ErrorProviderToolStripMenuItem"
        Me.ErrorProviderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ErrorProviderToolStripMenuItem.Text = "Error Provider"
        '
        'CondicionalesToolStripMenuItem
        '
        Me.CondicionalesToolStripMenuItem.Name = "CondicionalesToolStripMenuItem"
        Me.CondicionalesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CondicionalesToolStripMenuItem.Text = "Condicionales"
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(24, 66)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 2
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Enabled = False
        Me.txtvalor.Location = New System.Drawing.Point(121, 69)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Opciones"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(18, 149)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 5
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(115, 149)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 6
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Suma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ingrese Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Multiplicacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Division"
        '
        'combosuma
        '
        Me.combosuma.FormattingEnabled = True
        Me.combosuma.Location = New System.Drawing.Point(8, 240)
        Me.combosuma.Name = "combosuma"
        Me.combosuma.Size = New System.Drawing.Size(121, 21)
        Me.combosuma.TabIndex = 12
        Me.combosuma.Text = "Mostrar Suma"
        '
        'comboresta
        '
        Me.comboresta.FormattingEnabled = True
        Me.comboresta.Location = New System.Drawing.Point(152, 240)
        Me.comboresta.Name = "comboresta"
        Me.comboresta.Size = New System.Drawing.Size(121, 21)
        Me.comboresta.TabIndex = 13
        Me.comboresta.Text = "Mostrar Resta"
        '
        'combomulti
        '
        Me.combomulti.FormattingEnabled = True
        Me.combomulti.Location = New System.Drawing.Point(8, 305)
        Me.combomulti.Name = "combomulti"
        Me.combomulti.Size = New System.Drawing.Size(121, 21)
        Me.combomulti.TabIndex = 14
        Me.combomulti.Text = "Mostrar Multiplicacion"
        '
        'combodivision
        '
        Me.combodivision.FormattingEnabled = True
        Me.combodivision.Location = New System.Drawing.Point(152, 305)
        Me.combodivision.Name = "combodivision"
        Me.combodivision.Size = New System.Drawing.Size(121, 21)
        Me.combodivision.TabIndex = 15
        Me.combodivision.Text = "Mostrar Division"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(8, 118)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 0, 230, 55)
        Me.Label8.Size = New System.Drawing.Size(232, 70)
        Me.Label8.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(0, 196)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 50, 280, 90)
        Me.Label9.Size = New System.Drawing.Size(282, 155)
        Me.Label9.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Resta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 372)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.combodivision)
        Me.Controls.Add(Me.combomulti)
        Me.Controls.Add(Me.comboresta)
        Me.Controls.Add(Me.combosuma)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubFormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Opcion2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondicionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents combosuma As ComboBox
    Friend WithEvents comboresta As ComboBox
    Friend WithEvents combomulti As ComboBox
    Friend WithEvents combodivision As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
