Imports System.ComponentModel


Public Class RegistroVentas
    Dim conexion As New conexion()
    Dim dt As New DataTable



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RegistroEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()

    End Sub

    Private Sub mostrarDatos()
        conexion.consulta("select idVenta as 'Identidad Venta', fechaVenta as 'Fecha de Venta', precio as 'Precio de Producto', cantidad as Cantidad, idCliente as 'Identidad Cliente', idProducto as 'Identidad Producto' from factura.Venta", "factura.Venta")
        dtsVentas.DataSource = conexion.ds.Tables("factura.Venta")
    End Sub

    Private Sub btnGuardarRegistro_Click(sender As Object, e As EventArgs)

        Try
            Dim guardar As String =
             "insert into factura.Venta values(" + txtidventa.Text + ",'" + Fechaventa.Text + "',
             '" + txtventaprecio.Text + "','" + txtventacantidad.Text + "','" + txtventaidcliente.Text + "','" + txtventaproducto.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos()

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Limpiar()
        txtidventa.Clear()
        txtventacantidad.Clear()
        txtventaidcliente.Clear()
        txtventaproducto.Clear()
        txtventaprecio.Clear()
        conexion.conexion.Close()
        mostrarDatos()
        btnguardar.Enabled = True
        txtidventa.Enabled = True
    End Sub

    Private Sub mostrarBusqueda()
        Try
            dt = conexion.buscarventas("idCliente like '%" + txtventaidcliente.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtsVentas.DataSource = dt
                conexion.conexion.Close()
            Else
                dtsVentas.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtsVentas.Rows(e.RowIndex)
            txtidventa.Text = dtg.Cells(0).Value.ToString()
            Fechaventa.Text = dtg.Cells(1).Value.ToString()
            txtventaprecio.Text = dtg.Cells(2).Value.ToString()
            txtventacantidad.Text = dtg.Cells(3).Value.ToString()
            txtventaidcliente.Text = dtg.Cells(4).Value.ToString()
            txtventaproducto.Text = dtg.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminarregistro_Click(sender As Object, e As EventArgs)
        Try
            If (conexion.eliminar("factura.Venta", "idVenta=" + txtidventa.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarRegistro_Click(sender As Object, e As EventArgs)
        mostrarBusqueda()
        Dim valor As Int16
        If txtventaidcliente.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtventaidcliente.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtventaidcliente.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtventaidcliente.Text)
            If valor = 0 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            ElseIf valor < 1 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            ElseIf valor > 100 Then
                MsgBox("Ingrese una edad valida entre 1 y 100", vbInformation)
            End If
        End If
    End Sub

    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs)
        Limpiar()
    End Sub

    Private Sub dtsEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsVentas.CellContentClick
        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        llenarCampos(e)
    End Sub

    Private Sub btnModificarRegistro_Click(sender As Object, e As EventArgs)

        Try

            Dim modificar As String =
            "idVenta='" + txtidventa.Text + "', fechaVenta='" + Fechaventa.Text + "', precio='" + txtventaprecio.Text + "', cantidad='" + txtventacantidad.Text + "', idCliente ='" + txtventaidcliente.Text + "', idProducto ='" + txtventaproducto.Text + "'"
            If (conexion.modificar("factura.Venta", modificar, " idVenta=" + txtidventa.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Private Sub txtidventa_TextChanged(sender As Object, e As EventArgs) Handles txtidventa.TextChanged

    End Sub

    Private Sub txtidventa_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtidventa, "Ingrese el numero de identidad")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidventa_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            Dim guardar As String =
             "insert into factura.Venta values(" + txtidventa.Text + ",'" + Fechaventa.Text + "',
             '" + txtventaprecio.Text + "','" + txtventacantidad.Text + "','" + txtventaidcliente.Text + "','" + txtventaproducto.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos()

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        Dim valor As Int16
        If txtventaidcliente.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtventaidcliente.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtventaidcliente.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtventaidcliente.Text)
            If valor = 0 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            Else
                mostrarBusqueda()
            End If
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Try

            Dim modificar As String =
            "idVenta='" + txtidventa.Text + "', fechaVenta='" + Fechaventa.Text + "', precio='" + txtventaprecio.Text + "', cantidad='" + txtventacantidad.Text + "', idCliente ='" + txtventaidcliente.Text + "', idProducto ='" + txtventaproducto.Text + "'"
            If (conexion.modificar("factura.Venta", modificar, " idVenta=" + txtidventa.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If (conexion.eliminar("factura.Venta", "idVenta=" + txtidventa.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class