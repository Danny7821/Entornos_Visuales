Public Class Formulario
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub datagridreporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridreporte.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            If Me.ValidateChildren And txtnombre.Text = String.Empty Or txtedad.Text = String.Empty Or combodepto.Text = String.Empty Or combopruebaresultado.Text = String.Empty Or txtmunicipio.Text = String.Empty Or combopruebaresultado.Text = String.Empty Or txtmunicipio.Text = String.Empty Or txtdescripcion.Text = String.Empty Then
                MessageBox.Show("No pueden haber campos vacios", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Me.ValidateChildren And IsNumeric(txtnombre.Text) Or Not IsNumeric(txtedad.Text) Or IsNumeric(txtmunicipio.Text) Then
                MessageBox.Show("Datos incorrectos", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                datagridreporte.Rows.Add(combodepto.Text, txtnombre.Text, txtedad.Text, txtmunicipio.Text, combopruebaresultado.Text, comboestado.Text, txtdescripcion.Text)
                    txtnombre.Clear()
                    txtmunicipio.Clear()
                    txtedad.Clear()
                    txtdescripcion.Clear()
                    combodepto.Text = ""
                    comboestado.Text = ""
                    combopruebaresultado.Text = ""
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtnombre.Clear()
        txtmunicipio.Clear()
        txtedad.Clear()
        txtdescripcion.Clear()
        combodepto.Text = ""
        comboestado.Text = ""
        combopruebaresultado.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodatadepto.SelectedIndexChanged

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim salir As DialogResult
        Try
            salir = MessageBox.Show("Desea Salir", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If salir = DialogResult.Yes Then
                Me.Close()
                ExamenIParcial.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class