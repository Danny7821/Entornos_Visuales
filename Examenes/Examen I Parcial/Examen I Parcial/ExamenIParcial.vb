Public Class ExamenIParcial
    Dim Usuario, password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        ingreso()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim salir As DialogResult
        Try
            salir = MessageBox.Show("Desea Salir", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If salir = DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExamenIParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkregistrar.CheckedChanged
        If checkregistrar.Checked = False Then
            txtregistrousuario.Enabled = False
            txtregistrocontra.Enabled = False
            btnregistrar.Enabled = False
            txtregistrocontra.Clear()
            txtregistrousuario.Clear()
        Else
            txtregistrousuario.Enabled = True
            txtregistrocontra.Enabled = True
            btnregistrar.Enabled = True
        End If
    End Sub

    Private Sub ingreso()

        Try
            If Me.ValidateChildren And txtusuario.Text <> Usuario And txtcontra.Text <> password Then
                MessageBox.Show("Datos Erroneos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Me.ValidateChildren And txtusuario.Text = "" Or txtcontra.Text = "" Then
                MessageBox.Show("Campos Vacios", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtusuario.Text = Usuario And txtcontra.Text = password Then
                Me.Hide()
                Formulario.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        registro()
    End Sub

    Private Sub txtcontra_TextChanged(sender As Object, e As EventArgs) Handles txtcontra.TextChanged
        txtcontra.PasswordChar = "*"
    End Sub

    Private Sub txtregistrocontra_TextChanged(sender As Object, e As EventArgs) Handles txtregistrocontra.TextChanged
        txtregistrocontra.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Formulario.Show()
    End Sub

    Private Sub registro()
        Try
            If txtregistrocontra.Text = "" Or txtregistrousuario.Text = "" Then
                MessageBox.Show("Campos Vacios", "Registrarse", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datos ingresados correctamente", "Registro completo", MessageBoxButtons.OK)
                Usuario = txtregistrousuario.Text
                password = txtregistrocontra.Text
                txtregistrocontra.Clear()
                txtregistrousuario.Clear()
                checkregistrar.Enabled = False
                checkregistrar.Checked = False
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
