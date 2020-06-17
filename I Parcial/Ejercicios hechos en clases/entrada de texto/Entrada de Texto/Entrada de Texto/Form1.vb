Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese Numero", "Ingreso")
        txtvalor.Text = valor
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double
        valor = Val(txtvalor.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = valor / i
            combosuma.Items.Add(valor & " + " & i & " = " & suma)
            comboresta.Items.Add(valor & " - " & i & " = " & resta)
            combomulti.Items.Add(valor & " * " & i & " = " & multiplicacion)
            combodivision.Items.Add(valor & " / " & i & " = " & division)
        Next
    End Sub

    Private Sub ErrorProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorProviderToolStripMenuItem.Click
        Validaciones.show()
    End Sub
End Class
