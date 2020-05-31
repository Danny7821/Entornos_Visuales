Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor1, valor2 As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)

        txtresultado.Text = valor1 + valor2
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtresultado.Clear()
        txtvalor1.Clear()
        txtvalor2.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
