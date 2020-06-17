Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncomputadoras_Click(sender As Object, e As EventArgs) Handles btncomputadoras.Click
        Dim computadoras As (3) String
            computadoras
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Integer

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cant As Integer
        Dim comp() As String

        cant = Val(txtcantcomputadoras.Text)

        ReDim comp(cant)

        For i = 0 To cant Step 1
            comp(1) = InputBox("Ingrese la marca de computadoras", "Ingreso")
        Next

        For j = 0 To cant Step 1
            cmbComputadoras.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        cmbComputadoras.Items.Clear()
        cmbprecio.Items.Clear()

    End Sub
End Class
