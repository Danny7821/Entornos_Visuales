Public Class conjuntos


    Private Sub btningreso_Click(sender As Object, e As EventArgs) Handles btningreso.Click
        Dim valores, positivos, negativos, pares, impares, suma, rest As Integer
        Dim conjunto As Integer
        conjunto = Val(txtconjunto.Text)
        Try
            If Me.ValidateChildren And Val(conjunto) <= 0 Then
                MessageBox.Show("Ingrese un valor", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                For i = 1 To conjunto Step 1
                    Do
                        valores = InputBox("Ingrese valor" & " " & i, " Ingreso de valores")
                    Loop While i > conjunto
                    combonumeros.Items.Add(valores)
                    If valores < 0 Then
                        negativos += 1
                        suma += valores
                        txtsuma.Text = suma
                        txtnegativos.Text = negativos
                    Else
                        positivos += 1
                        suma += valores
                        txtsuma.Text = suma
                        txtpositivos.Text = positivos
                    End If
                    rest = valores Mod 2
                    If rest = 0 Then
                        pares += 1
                        txtpares.Text = pares
                    Else
                        impares += 1
                        txtimpares.Text = impares
                    End If

                Next
                btningreso.Enabled = False
                btnlimpiar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtconjunto.Clear()
        txtpositivos.Clear()
        txtnegativos.Clear()
        txtpares.Clear()
        txtimpares.Clear()
        txtsuma.Clear()
        btnlimpiar.Enabled = False
        btningreso.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class