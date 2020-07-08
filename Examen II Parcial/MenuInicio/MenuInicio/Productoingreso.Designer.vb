<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productoingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productoingreso))
        Me.dtsproductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbuscarproducto = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btneliminar = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.PictureBox()
        Me.btnmodificar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        CType(Me.dtsproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtsproductos
        '
        Me.dtsproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsproductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtsproductos.Location = New System.Drawing.Point(337, 19)
        Me.dtsproductos.Name = "dtsproductos"
        Me.dtsproductos.Size = New System.Drawing.Size(357, 427)
        Me.dtsproductos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbuscarproducto)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtnombreproducto)
        Me.GroupBox1.Controls.Add(Me.txtIdProducto)
        Me.GroupBox1.Controls.Add(Me.dtsproductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(876, 452)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Buscar Producto"
        '
        'txtbuscarproducto
        '
        Me.txtbuscarproducto.Location = New System.Drawing.Point(92, 365)
        Me.txtbuscarproducto.Name = "txtbuscarproducto"
        Me.txtbuscarproducto.Size = New System.Drawing.Size(171, 24)
        Me.txtbuscarproducto.TabIndex = 12
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.Location = New System.Drawing.Point(745, 269)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(69, 70)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlimpiar.TabIndex = 11
        Me.btnlimpiar.TabStop = False
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.Location = New System.Drawing.Point(745, 187)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(69, 61)
        Me.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btneliminar.TabIndex = 10
        Me.btneliminar.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.Location = New System.Drawing.Point(5, 324)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(69, 61)
        Me.btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnbuscar.TabIndex = 9
        Me.btnbuscar.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.Location = New System.Drawing.Point(745, 19)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(69, 61)
        Me.btnguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.TabStop = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(745, 101)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(69, 61)
        Me.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmodificar.TabIndex = 7
        Me.btnmodificar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre de Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Producto"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(99, 147)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(145, 109)
        Me.txtdescripcion.TabIndex = 3
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Location = New System.Drawing.Point(160, 106)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(144, 24)
        Me.txtnombreproducto.TabIndex = 2
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(99, 71)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(75, 24)
        Me.txtIdProducto.TabIndex = 1
        '
        'Productoingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productoingreso"
        Me.Text = "Planes"
        CType(Me.dtsproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btneliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmodificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtsproductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents btnbuscar As PictureBox
    Friend WithEvents btnguardar As PictureBox
    Friend WithEvents btnmodificar As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbuscarproducto As TextBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btneliminar As PictureBox
End Class
