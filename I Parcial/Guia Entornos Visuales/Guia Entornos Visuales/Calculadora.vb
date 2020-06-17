Public Class Calculadora
    Dim valor1 As Nullable(Of Double) = Nothing
    Dim operaciones As String
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim valorresultado As Nullable(Of Double) = Nothing
    Dim seleccion As Boolean

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        restricciones()
        txtoperacion.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        restricciones()
        txtoperacion.Text &= "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        selecionaroperaciones()
        operaciones = "+"
        valor1 = Val(txtoperacion.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnresultado.Click
        selecionaroperaciones()
        operaciones = ""
        seleccion = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        restricciones()
        txtoperacion.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        restricciones()
        txtoperacion.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        restricciones()
        txtoperacion.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        restricciones()
        txtoperacion.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        restricciones()
        txtoperacion.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        restricciones()
        txtoperacion.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        restricciones()
        txtoperacion.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        restricciones()
        txtoperacion.Text &= "0"
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        selecionaroperaciones()
        operaciones = "-"
        valor1 = Val(txtoperacion.Text)
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        selecionaroperaciones()
        operaciones = "*"
        valor1 = Val(txtoperacion.Text)
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        selecionaroperaciones()
        operaciones = "/"
        valor1 = Val(txtoperacion.Text)
    End Sub
    Private Sub selecionaroperaciones()
        seleccion = True
        valor2 = Val(txtoperacion.Text)
        If valor1 IsNot Nothing Then
            Select Case operaciones
                Case "+"
                    valorresultado = valor1 + valor2
                Case "-"
                    valorresultado = valor1 - valor2
                Case "*"
                    valorresultado = valor1 * valor2
                Case "/"
                    If valor2 = 0 Then
                        MsgBox("No se puede dividir entre 0")
                    Else
                        valorresultado = valor1 / valor2
                    End If
            End Select
            txtoperacion.Text = valorresultado
            txthistorial.Text = valor1 & " " & operaciones & " " & valor2 & " = " & valorresultado
        Else
                valor1 = valor2
        End If
    End Sub
    Private Sub restricciones()
        If seleccion = True Then
            txtoperacion.Text = ""
            seleccion = False
        ElseIf txtoperacion.Text = "0" Then
            txtoperacion.Text = ""
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtoperacion.Text = "0"
        valor1 = Nothing
        valor2 = Nothing
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        restricciones()
        If InStr(txtoperacion.Text, ".", CompareMethod.Text) = 0 Then
            txtoperacion.Text &= "."
        End If
    End Sub

    Private Sub btnmasmenos_Click(sender As Object, e As EventArgs) Handles btnmasmenos.Click
        Try
            If txtoperacion.Text <> "" Then
                txtoperacion.Text = txtoperacion.Text * (-1)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class