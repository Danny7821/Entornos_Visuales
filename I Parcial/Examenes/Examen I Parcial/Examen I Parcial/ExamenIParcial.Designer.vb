<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExamenIParcial
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
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkregistrar = New System.Windows.Forms.CheckBox()
        Me.txtregistrousuario = New System.Windows.Forms.TextBox()
        Me.txtregistrocontra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(12, 124)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 0
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(116, 124)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Enabled = False
        Me.btnregistrar.Location = New System.Drawing.Point(12, 312)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 2
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(12, 39)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 3
        '
        'txtcontra
        '
        Me.txtcontra.Location = New System.Drawing.Point(12, 87)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(100, 20)
        Me.txtcontra.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'checkregistrar
        '
        Me.checkregistrar.AutoSize = True
        Me.checkregistrar.Location = New System.Drawing.Point(6, 181)
        Me.checkregistrar.Name = "checkregistrar"
        Me.checkregistrar.Size = New System.Drawing.Size(79, 17)
        Me.checkregistrar.TabIndex = 7
        Me.checkregistrar.Text = "Registrarse"
        Me.checkregistrar.UseVisualStyleBackColor = True
        '
        'txtregistrousuario
        '
        Me.txtregistrousuario.Enabled = False
        Me.txtregistrousuario.Location = New System.Drawing.Point(6, 227)
        Me.txtregistrousuario.Name = "txtregistrousuario"
        Me.txtregistrousuario.Size = New System.Drawing.Size(100, 20)
        Me.txtregistrousuario.TabIndex = 8
        '
        'txtregistrocontra
        '
        Me.txtregistrocontra.Enabled = False
        Me.txtregistrocontra.Location = New System.Drawing.Point(6, 274)
        Me.txtregistrocontra.Name = "txtregistrocontra"
        Me.txtregistrocontra.Size = New System.Drawing.Size(100, 20)
        Me.txtregistrocontra.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Contraseña"
        '
        'ExamenIParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(203, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtregistrocontra)
        Me.Controls.Add(Me.txtregistrousuario)
        Me.Controls.Add(Me.checkregistrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btningresar)
        Me.Name = "ExamenIParcial"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btningresar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents checkregistrar As CheckBox
    Friend WithEvents txtregistrousuario As TextBox
    Friend WithEvents txtregistrocontra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
