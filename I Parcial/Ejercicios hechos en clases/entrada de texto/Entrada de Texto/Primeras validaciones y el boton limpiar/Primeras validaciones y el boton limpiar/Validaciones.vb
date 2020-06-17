Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        txtvalor.Clear()

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btnvalidar.Click
        Dim valor As Int16

        If txtvalor.Text = "" Then
            MsgBox("Ingrese un valor Numerico", vbInformation)
        ElseIf Not IsNumeric(txtvalor.Text) Then
            MsgBox("No es un valor numerico", vbInformation)
        ElseIf IsNumeric(txtvalor.text) Then
            valor = Val(txtvalor.Text)
            If valor = 0 Then
                MsgBox("Numero 0", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo", vbInformation)
            End If
        End If
    End Sub
End Class
