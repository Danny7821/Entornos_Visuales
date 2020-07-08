<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtclientes = New System.Windows.Forms.DataGridView()
        Me.ErrorValidacion2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.PictureBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btneliminar = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.PictureBox()
        Me.btnmodificar = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtclientes)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 481)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Clientes"
        '
        'dtclientes
        '
        Me.dtclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtclientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtclientes.Location = New System.Drawing.Point(6, 19)
        Me.dtclientes.Name = "dtclientes"
        Me.dtclientes.Size = New System.Drawing.Size(437, 456)
        Me.dtclientes.TabIndex = 0
        '
        'ErrorValidacion2
        '
        Me.ErrorValidacion2.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Nombre)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtdireccion)
        Me.GroupBox4.Controls.Add(Me.txtapellido)
        Me.GroupBox4.Controls.Add(Me.txtnombre)
        Me.GroupBox4.Controls.Add(Me.txtidcliente)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(291, 244)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Dirección"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Apellido"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(24, 63)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 30
        Me.Nombre.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ID Cliente"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(98, 123)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(169, 91)
        Me.txtdireccion.TabIndex = 14
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(98, 93)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(169, 20)
        Me.txtapellido.TabIndex = 13
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(98, 60)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(169, 20)
        Me.txtnombre.TabIndex = 12
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(98, 29)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(57, 20)
        Me.txtidcliente.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnbuscar)
        Me.GroupBox3.Controls.Add(Me.btnlimpiar)
        Me.GroupBox3.Controls.Add(Me.btneliminar)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Controls.Add(Me.btnmodificar)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 80)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandos"
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.Location = New System.Drawing.Point(7, 20)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(69, 50)
        Me.btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnbuscar.TabIndex = 21
        Me.btnbuscar.TabStop = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.Location = New System.Drawing.Point(226, 18)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(69, 52)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlimpiar.TabIndex = 20
        Me.btnlimpiar.TabStop = False
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.Location = New System.Drawing.Point(299, 18)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(69, 52)
        Me.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btneliminar.TabIndex = 19
        Me.btneliminar.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(80, 20)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(69, 50)
        Me.btnguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.TabStop = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(153, 20)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(69, 50)
        Me.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmodificar.TabIndex = 17
        Me.btnmodificar.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "solicitud"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtclientes As DataGridView
    Friend WithEvents ErrorValidacion2 As ErrorProvider
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnbuscar As PictureBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btneliminar As PictureBox
    Friend WithEvents btnguardar As PictureBox
    Friend WithEvents btnmodificar As PictureBox
End Class
