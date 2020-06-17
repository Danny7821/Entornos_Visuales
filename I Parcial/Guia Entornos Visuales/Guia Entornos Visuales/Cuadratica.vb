Public Class Cuadratica
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim a, b, c As Integer
        Dim x1, x2, determinante As Double
        a = Val(txtvalorA.Text)
        b = Val(txtvalorB.Text)
        c = Val(txtvalorC.Text)
        Try
            If Me.ValidateChildren And Val(txtvalorA.Text) = 0 Or Val(txtvalorB.Text) = 0 Or Val(txtvalorC.Text) = 0 Then
                MessageBox.Show("Valor no numerico o hay espacio vacio", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                determinante = Math.Sqrt((b) ^ 2 - (4 * a * (c)))

                x1 = (b + determinante) / 2 * (a)
                x2 = (b - determinante) / 2 * (a)

                txtx1.Text = x1
                txtx2.Text = x2
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Cuadratica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtx2.Clear()
        txtx1.Clear()
        txtvalorA.Clear()
        txtvalorB.Clear()
        txtvalorC.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class