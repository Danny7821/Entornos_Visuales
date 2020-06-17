Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btlimpiar_Click(sender As Object, e As EventArgs) Handles btlimpiar.Click
        txtvalor1.Clear()
        txtvalor2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmulti.Clear()
        txtdivi.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Favor escriba un numero", vbInformation)
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("escriba un valor numerico")
        End If



    End Sub

    Private Sub checkresta_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Checkdiv_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Checkmulti_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtvalor1_TextChanged(sender As Object, e As EventArgs) Handles txtvalor1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor1, valor2, suma, resta, multi As Integer
        Dim division As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)

        suma = valor1 + valor2
        resta = valor1 - valor2
        multi = valor1 * valor2

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre 0", vbInformation)
        ElseIf valor2 <> 0 Then
            division = valor1 / valor2
            txtdivi.Text = division
        End If

        txtsuma.Text = suma
        txtresta.Text = resta
        txtmulti.Text = multi
    End Sub
End Class
