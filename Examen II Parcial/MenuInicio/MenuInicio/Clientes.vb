Imports System.ComponentModel

Public Class Clientes
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Private Sub solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarcliente()
    End Sub

    Private Sub mostrarcliente()
        conexion.consulta("select idCliente as 'ID Cliente', nombre as 'Nombres', Apellido as 'Apellido', direccion as 'Direccion' from factura.cliente", "factura.cliente")
        dtclientes.DataSource = conexion.ds.Tables("factura.cliente")
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim guardar As String =
             "insert into factura.cliente values(" + txtidcliente.Text + ",'" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtdireccion.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarcliente()

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Try

            Dim modificar As String =
            "idCliente='" + txtidcliente.Text + "', nombre='" + txtnombre.Text + "', apellido='" + txtapellido.Text + "', direccion ='" + txtdireccion.Text + "'"
            If (conexion.modificar("factura.cliente", modificar, " idCliente=" + txtidcliente.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarcliente()
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
        mostrarcliente()
    End Sub
    Public Sub Limpiar()
        txtidcliente.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtdireccion.Clear()
        mostrarcliente()
        btnguardar.Enabled = True
        txtidcliente.Enabled = True
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If (conexion.eliminar("factura.cliente", "idCliente=" + txtidcliente.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarcliente()
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

    Private Sub mostrarBusqueda()
        Try
            dt = conexion.buscarcliente("idCliente like '%" + txtidcliente.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtclientes.DataSource = dt
                conexion.conexion.Close()
            Else
                dtclientes.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        mostrarBusqueda()
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtclientes.Rows(e.RowIndex)
            txtidcliente.Text = dtg.Cells(0).Value.ToString()
            txtnombre.Text = dtg.Cells(1).Value.ToString()
            txtapellido.Text = dtg.Cells(2).Value.ToString()
            txtdireccion.Text = dtg.Cells(3).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtclientes.CellContentClick
        mostrarcliente()
        llenarCampos(e)
    End Sub
End Class