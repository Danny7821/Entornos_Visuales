Imports System.ComponentModel

Public Class Productoingreso
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Private Sub Planes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarproductos()
    End Sub

    Private Sub mostrarproductos()
        conexion.consulta("select idProducto as 'ID de Producto', nombreProducto as 'Nombre de Producto', descripcion as 'Descripcion de Producto' from factura.producto", "factura.producto")
        dtsproductos.DataSource = conexion.ds.Tables("factura.producto")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dtsPlanes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsproductos.CellContentClick
        llenarCampos(e)
    End Sub

    Private Sub mostrarBusqueda()
        Try
            dt = conexion.buscarproducto("idProducto like '%" + txtbuscarproducto.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtsproductos.DataSource = dt
                conexion.conexion.Close()
            Else
                dtsproductos.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        mostrarBusqueda()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim guardar As String =
             "insert into factura.producto values(" + txtIdProducto.Text + ",'" + txtnombreproducto.Text + "','" + txtdescripcion.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarproductos()

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If (conexion.eliminar("factura.producto", "idProducto=" + txtIdProducto.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarproductos()
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

    Public Sub Limpiar()
        txtIdProducto.Clear()
        txtnombreproducto.Clear()
        txtdescripcion.Clear()
        txtbuscarproducto.Clear()
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtsproductos.Rows(e.RowIndex)
            txtIdProducto.Text = dtg.Cells(0).Value.ToString()
            txtnombreproducto.Text = dtg.Cells(1).Value.ToString()
            txtdescripcion.Text = dtg.Cells(2).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Try

            Dim modificar As String =
            "idProducto='" + txtIdProducto.Text + "', nombreProducto='" + txtnombreproducto.Text + "', descripcion ='" + txtdescripcion.Text + "'"
            If (conexion.modificar("factura.producto", modificar, " idProducto=" + txtIdProducto.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarproductos()
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
        mostrarproductos()
    End Sub
End Class