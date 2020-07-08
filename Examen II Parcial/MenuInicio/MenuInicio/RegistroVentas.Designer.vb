<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroVentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtsVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtventaproducto = New System.Windows.Forms.TextBox()
        Me.txtventaidcliente = New System.Windows.Forms.TextBox()
        Me.Fechaventa = New System.Windows.Forms.DateTimePicker()
        Me.txtventacantidad = New System.Windows.Forms.TextBox()
        Me.txtventaprecio = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btneliminar = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.PictureBox()
        Me.btnmodificar = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtsVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtsVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 393)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabla Ventas"
        '
        'dtsVentas
        '
        Me.dtsVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtsVentas.Location = New System.Drawing.Point(6, 19)
        Me.dtsVentas.Name = "dtsVentas"
        Me.dtsVentas.Size = New System.Drawing.Size(649, 368)
        Me.dtsVentas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtventaproducto)
        Me.GroupBox2.Controls.Add(Me.txtventaidcliente)
        Me.GroupBox2.Controls.Add(Me.Fechaventa)
        Me.GroupBox2.Controls.Add(Me.txtventacantidad)
        Me.GroupBox2.Controls.Add(Me.txtventaprecio)
        Me.GroupBox2.Controls.Add(Me.txtidventa)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 393)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Ventas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "ID Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID Venta"
        '
        'txtventaproducto
        '
        Me.txtventaproducto.Location = New System.Drawing.Point(86, 318)
        Me.txtventaproducto.Name = "txtventaproducto"
        Me.txtventaproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtventaproducto.TabIndex = 22
        '
        'txtventaidcliente
        '
        Me.txtventaidcliente.Location = New System.Drawing.Point(86, 246)
        Me.txtventaidcliente.Name = "txtventaidcliente"
        Me.txtventaidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtventaidcliente.TabIndex = 21
        '
        'Fechaventa
        '
        Me.Fechaventa.CustomFormat = "dd/MM/yyyy"
        Me.Fechaventa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fechaventa.Location = New System.Drawing.Point(86, 81)
        Me.Fechaventa.Name = "Fechaventa"
        Me.Fechaventa.Size = New System.Drawing.Size(100, 20)
        Me.Fechaventa.TabIndex = 20
        '
        'txtventacantidad
        '
        Me.txtventacantidad.Location = New System.Drawing.Point(86, 189)
        Me.txtventacantidad.Name = "txtventacantidad"
        Me.txtventacantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtventacantidad.TabIndex = 19
        '
        'txtventaprecio
        '
        Me.txtventaprecio.Location = New System.Drawing.Point(86, 134)
        Me.txtventaprecio.Name = "txtventaprecio"
        Me.txtventaprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtventaprecio.TabIndex = 18
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(86, 31)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 17
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnbuscar)
        Me.GroupBox3.Controls.Add(Me.btnlimpiar)
        Me.GroupBox3.Controls.Add(Me.btneliminar)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Controls.Add(Me.btnmodificar)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 413)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 80)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandos"
        '
        'RegistroVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(846, 505)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistroVentas"
        Me.Text = "RegistroEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtsVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtsVentas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtventaproducto As TextBox
    Friend WithEvents txtventaidcliente As TextBox
    Friend WithEvents Fechaventa As DateTimePicker
    Friend WithEvents txtventacantidad As TextBox
    Friend WithEvents txtventaprecio As TextBox
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btneliminar As PictureBox
    Friend WithEvents btnguardar As PictureBox
    Friend WithEvents btnmodificar As PictureBox
    Friend WithEvents btnbuscar As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
