Imports System.ComponentModel
Public Class Reporte
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Private Sub dtclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtclientes.CellContentClick

    End Sub

    Private Sub mostrarclientereporte()
        Try
            dt = conexion.consultareporte
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

    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarclientereporte()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

    End Sub
End Class