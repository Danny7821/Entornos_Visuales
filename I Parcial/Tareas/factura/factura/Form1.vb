Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim punitario, cantidad As Integer
        Dim isv, descuento, subtotal, s1, s2 As Double

        If txtpreciounitario.Text = "" Then
            MsgBox("El espacio Precio Unitario esta vacio", vbInformation)
        ElseIf Not IsNumeric(txtpreciounitario.Text) Then
            MsgBox("Ingrese un valor numerico en Precio Unitario", vbInformation)
        ElseIf txtpreciounitario.Text < 0 Then
            MsgBox("El espacio Precio Unitario no puede contener numeros negativos", vbInformation)
        ElseIf IsNumeric(txtpreciounitario.Text) Then
            punitario = Val(txtpreciounitario.Text)
        End If

        If txtcantidad.Text = "" Then
            MsgBox("El espacio Cantidad esta vacio", vbInformation)
        ElseIf Not IsNumeric(txtcantidad.Text) Then
            MsgBox("Ingrese un valor numerico en Cantidad", vbInformation)
        ElseIf txtcantidad.Text < 0 Then
            MsgBox("El espacio cantidad no puede contener numeros negativos", vbInformation)
        ElseIf IsNumeric(txtcantidad.Text) Then
            cantidad = Val(txtcantidad.Text)
        End If
        If mascara.MaskCompleted = False Then
            MsgBox("No puede dejar espacio vacio")
        Else
            txtmask.Text = mascara.Text
        End If
        descuento = Val(combodescuento.Text)
        subtotal = cantidad * punitario
        isv = Val(Comboisv.Text)

        txtdescuento.Text = (subtotal * descuento) / 100
        txtisv.Text = (isv * subtotal) / 100
        txtsubtotal.Text = cantidad * punitario
        s1 = txtdescuento.Text
        s2 = txtisv.Text

        txttotal.Text = subtotal + s2 - s1

        btnnuevo.Enabled = True

    End Sub

    Private Sub CheckBoxdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxdescuento.CheckedChanged
        If CheckBoxdescuento.Checked = False Then
            combodescuento.Enabled = False
            CheckBoxisv.Enabled = True
            txtdescuento.Clear()
            combodescuento.Text = ""
        ElseIf CheckBoxdescuento.Checked = True Then
            combodescuento.Enabled = True
            CheckBoxisv.Enabled = False
            Comboisv.Text = ""
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub combodescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodescuento.SelectedIndexChanged

    End Sub

    Private Sub CheckBoxisv_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxisv.CheckedChanged
        If CheckBoxisv.Checked = False Then
            Comboisv.Enabled = False
            CheckBoxdescuento.Enabled = True
            txtisv.Clear()
            Comboisv.Text = ""
        ElseIf CheckBoxisv.Checked = True Then
            CheckBoxdescuento.Enabled = False
            Comboisv.Enabled = True
            combodescuento.Text = ""
        End If
    End Sub

    Private Sub combodescuento_Click(sender As Object, e As EventArgs) Handles combodescuento.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        combodescuento.Text = ""
        Comboisv.Text = ""
        CheckBoxdescuento.Checked = False
        CheckBoxisv.Checked = False
        txtcantidad.Clear()
        txtdescuento.Clear()
        txtisv.Clear()
        txtpreciounitario.Clear()
        txtsubtotal.Clear()
        txttotal.Clear()
        btnnuevo.Enabled = False
    End Sub
End Class
