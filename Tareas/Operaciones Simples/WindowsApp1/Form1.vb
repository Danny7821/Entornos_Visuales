Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multi As Integer
        Dim div As Double


        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)

        suma = valor1 + valor2
        resta = valor1 - valor2
        multi = valor1 * valor2
        div = valor1 / valor2

        txtsuma.Text = suma
        txtresta.Text = resta
        txtmulti.Text = multi
        If valor2 = 0 Then
            MsgBox("Math error")
        ElseIf valor2 <> 0 Then
            txtdiv.Text = div
        End If

    End Sub

    Private Sub btlimpiar_Click(sender As Object, e As EventArgs) Handles btlimpiar.Click
        txtvalor1.Clear()
        txtvalor2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmulti.Clear()
        txtdiv.Clear()
        txtresultado.Clear()
        txtpotencia.Clear()
        txtraiz.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Checksuma.CheckedChanged
        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Favor escriba un numero", vbInformation)
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("escriba un valor numerico")
        End If

        Dim valor1 As Double
        Dim valor2 As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)



        If Checksuma.Checked = True Then
            checkresta.Enabled = False
            Checkdiv.Enabled = False
            Checkmulti.Enabled = False
            txtresultado.Text = valor1 + valor2
            txtraiz.Text = Math.Sqrt(valor1)
            txtpotencia.Text = valor1 ^ valor2
        End If

        If Checksuma.Checked = False Then
            checkresta.Enabled = True
            Checkdiv.Enabled = True
            Checkmulti.Enabled = True
        End If



    End Sub

    Private Sub checkresta_CheckedChanged(sender As Object, e As EventArgs) Handles checkresta.CheckedChanged
        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Favor escriba un numero", vbInformation)
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("escriba un valor numerico")
        End If

        Dim valor1 As Double
        Dim valor2 As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)



        If checkresta.Checked = True Then
            Checksuma.Enabled = False
            Checkdiv.Enabled = False
            Checkmulti.Enabled = False
            txtresultado.Text = valor1 - valor2
            txtraiz.Text = Math.Sqrt(valor1)
            txtpotencia.Text = valor1 ^ valor2
        End If

        If checkresta.Checked = False Then
            Checksuma.Enabled = True
            Checkdiv.Enabled = True
            Checkmulti.Enabled = True
        End If
    End Sub

    Private Sub Checkdiv_CheckedChanged(sender As Object, e As EventArgs) Handles Checkdiv.CheckedChanged
        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Favor escriba un numero", vbInformation)
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("escriba un valor numerico")
        End If

        Dim valor1 As Double
        Dim valor2 As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)



        If Checkdiv.Checked = True Then
            checkresta.Enabled = False
            Checksuma.Enabled = False
            Checkmulti.Enabled = False
            txtraiz.Text = Math.Sqrt(valor1)
            txtpotencia.Text = valor1 ^ valor2
        End If

        If Checkdiv.Checked = False Then
            checkresta.Enabled = True
            Checksuma.Enabled = True
            Checkmulti.Enabled = True
        End If

        If valor2 = 0 Then
            MsgBox("Math error")
        ElseIf valor2 <> 0 Then
            txtresultado.Text = valor1 / valor2
        End If
    End Sub

    Private Sub Checkmulti_CheckedChanged(sender As Object, e As EventArgs) Handles Checkmulti.CheckedChanged
        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Favor escriba un numero", vbInformation)
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("escriba un valor numerico")
        End If

        Dim valor1 As Double
        Dim valor2 As Double

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)



        If Checkmulti.Checked = True Then
            checkresta.Enabled = False
            Checkdiv.Enabled = False
            Checksuma.Enabled = False
            txtresultado.Text = valor1 * valor2
            txtraiz.Text = Math.Sqrt(valor1)
            txtpotencia.Text = valor1 ^ valor2
        End If

        If Checkmulti.Checked = False Then
            checkresta.Enabled = True
            Checkdiv.Enabled = True
            Checksuma.Enabled = True
        End If
    End Sub

    Private Sub txtvalor1_TextChanged(sender As Object, e As EventArgs) Handles txtvalor1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
