<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario
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
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.combodepto = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combopruebaresultado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboestado = New System.Windows.Forms.ComboBox()
        Me.txtmunicipio = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combodatadepto = New System.Windows.Forms.ComboBox()
        Me.muertos = New System.Windows.Forms.TextBox()
        Me.txtnegativos = New System.Windows.Forms.TextBox()
        Me.txtpositivos = New System.Windows.Forms.TextBox()
        Me.datagridreporte = New System.Windows.Forms.DataGridView()
        Me.dtagriddepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datanombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datamunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataresultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataestadoactual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datadescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagridreporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(21, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(585, 20)
        Me.txtnombre.TabIndex = 0
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(21, 104)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 20)
        Me.txtedad.TabIndex = 1
        '
        'combodepto
        '
        Me.combodepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodepto.FormattingEnabled = True
        Me.combodepto.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Barbara", "Valle", "Yoro"})
        Me.combodepto.Location = New System.Drawing.Point(175, 103)
        Me.combodepto.Name = "combodepto"
        Me.combodepto.Size = New System.Drawing.Size(121, 21)
        Me.combodepto.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combopruebaresultado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.comboestado)
        Me.GroupBox1.Controls.Add(Me.txtmunicipio)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combodepto)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 232)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'combopruebaresultado
        '
        Me.combopruebaresultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combopruebaresultado.FormattingEnabled = True
        Me.combopruebaresultado.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.combopruebaresultado.Location = New System.Drawing.Point(21, 180)
        Me.combopruebaresultado.Name = "combopruebaresultado"
        Me.combopruebaresultado.Size = New System.Drawing.Size(121, 21)
        Me.combopruebaresultado.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Resultado de Prueba"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Estado"
        '
        'comboestado
        '
        Me.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboestado.FormattingEnabled = True
        Me.comboestado.Items.AddRange(New Object() {"Activo", "Curado", "Muerto"})
        Me.comboestado.Location = New System.Drawing.Point(161, 180)
        Me.comboestado.Name = "comboestado"
        Me.comboestado.Size = New System.Drawing.Size(121, 21)
        Me.comboestado.TabIndex = 15
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Location = New System.Drawing.Point(325, 105)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(129, 20)
        Me.txtmunicipio.TabIndex = 14
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(499, 101)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 8
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Descripción de Estado"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(303, 171)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(200, 53)
        Me.txtdescripcion.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre Completo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.combodatadepto)
        Me.GroupBox2.Controls.Add(Me.muertos)
        Me.GroupBox2.Controls.Add(Me.txtnegativos)
        Me.GroupBox2.Controls.Add(Me.txtpositivos)
        Me.GroupBox2.Controls.Add(Me.datagridreporte)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(772, 230)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Muertos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Negativo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Positivo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Departamento"
        '
        'combodatadepto
        '
        Me.combodatadepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodatadepto.FormattingEnabled = True
        Me.combodatadepto.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Barbara", "Valle", "Yoro"})
        Me.combodatadepto.Location = New System.Drawing.Point(21, 44)
        Me.combodatadepto.Name = "combodatadepto"
        Me.combodatadepto.Size = New System.Drawing.Size(121, 21)
        Me.combodatadepto.TabIndex = 5
        '
        'muertos
        '
        Me.muertos.Enabled = False
        Me.muertos.Location = New System.Drawing.Point(196, 92)
        Me.muertos.Name = "muertos"
        Me.muertos.Size = New System.Drawing.Size(50, 20)
        Me.muertos.TabIndex = 4
        Me.muertos.Text = "0"
        Me.muertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnegativos
        '
        Me.txtnegativos.Enabled = False
        Me.txtnegativos.Location = New System.Drawing.Point(108, 92)
        Me.txtnegativos.Name = "txtnegativos"
        Me.txtnegativos.Size = New System.Drawing.Size(50, 20)
        Me.txtnegativos.TabIndex = 3
        Me.txtnegativos.Text = "0"
        Me.txtnegativos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpositivos
        '
        Me.txtpositivos.Enabled = False
        Me.txtpositivos.Location = New System.Drawing.Point(21, 92)
        Me.txtpositivos.Name = "txtpositivos"
        Me.txtpositivos.Size = New System.Drawing.Size(50, 20)
        Me.txtpositivos.TabIndex = 2
        Me.txtpositivos.Text = "0"
        Me.txtpositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'datagridreporte
        '
        Me.datagridreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridreporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtagriddepartamento, Me.datanombre, Me.dataedad, Me.datamunicipio, Me.dataresultado, Me.dataestadoactual, Me.datadescripcion})
        Me.datagridreporte.Location = New System.Drawing.Point(21, 126)
        Me.datagridreporte.Name = "datagridreporte"
        Me.datagridreporte.Size = New System.Drawing.Size(732, 104)
        Me.datagridreporte.TabIndex = 1
        '
        'dtagriddepartamento
        '
        Me.dtagriddepartamento.HeaderText = "Departamento"
        Me.dtagriddepartamento.Name = "dtagriddepartamento"
        '
        'datanombre
        '
        Me.datanombre.HeaderText = "Nombre"
        Me.datanombre.Name = "datanombre"
        Me.datanombre.ReadOnly = True
        '
        'dataedad
        '
        Me.dataedad.HeaderText = "Edad"
        Me.dataedad.Name = "dataedad"
        Me.dataedad.ReadOnly = True
        '
        'datamunicipio
        '
        Me.datamunicipio.HeaderText = "Municipio"
        Me.datamunicipio.Name = "datamunicipio"
        Me.datamunicipio.ReadOnly = True
        '
        'dataresultado
        '
        Me.dataresultado.HeaderText = "Resultado"
        Me.dataresultado.Name = "dataresultado"
        Me.dataresultado.ReadOnly = True
        '
        'dataestadoactual
        '
        Me.dataestadoactual.HeaderText = "Estado"
        Me.dataestadoactual.Name = "dataestadoactual"
        Me.dataestadoactual.ReadOnly = True
        '
        'datadescripcion
        '
        Me.datadescripcion.HeaderText = "Descripción"
        Me.datadescripcion.Name = "datadescripcion"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(690, 117)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 54)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 492)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Formulario"
        Me.Text = "Formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datagridreporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents combodepto As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btningresar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents datagridreporte As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents comboestado As ComboBox
    Friend WithEvents txtmunicipio As TextBox
    Friend WithEvents combopruebaresultado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents muertos As TextBox
    Friend WithEvents txtnegativos As TextBox
    Friend WithEvents txtpositivos As TextBox
    Friend WithEvents combodatadepto As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtagriddepartamento As DataGridViewTextBoxColumn
    Friend WithEvents datanombre As DataGridViewTextBoxColumn
    Friend WithEvents dataedad As DataGridViewTextBoxColumn
    Friend WithEvents datamunicipio As DataGridViewTextBoxColumn
    Friend WithEvents dataresultado As DataGridViewTextBoxColumn
    Friend WithEvents dataestadoactual As DataGridViewTextBoxColumn
    Friend WithEvents datadescripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnsalir As Button
End Class
