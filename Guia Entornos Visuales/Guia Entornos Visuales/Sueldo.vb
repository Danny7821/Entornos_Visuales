Public Class Sueldo
    Dim primernombre, segundonombre, apellido1, apellido2 As String

    Private Sub txtsueldomensual_TextChanged(sender As Object, e As EventArgs) Handles txtsueldomensual.TextChanged
        validarcalcular()
    End Sub

    Dim sueldomensual, sueldoquincenal, isr, i1, i2, i3, i4, i5, i6 As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtsueldomensual.Clear()
        txtprimernombre.Clear()
        txtsegundonombre.Clear()
        txtsegundoapellido.Clear()
        txtapellido.Clear()
        txtnombrecompleto.Clear()
        txtisr.Clear()
        txtcalsueldomensual.Clear()
        txtcalsueldoquincenal.Clear()
        btncalcular.Enabled = False
        btnlimpiar.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtsegundonombre_TextChanged(sender As Object, e As EventArgs) Handles txtsegundonombre.TextChanged
        validarcalcular()
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged
        validarcalcular()
    End Sub

    Private Sub txtsegundoapellido_TextChanged(sender As Object, e As EventArgs) Handles txtsegundoapellido.TextChanged
        validarcalcular()
    End Sub

    Private Sub txtprimernombre_TextChanged(sender As Object, e As EventArgs) Handles txtprimernombre.TextChanged
        validarcalcular()
    End Sub

    Private Sub Sueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        i1 = 158995.07
        i2 = 242439.29
        i3 = 563812.3
        i4 = 242439.28
        i5 = 563812.29

        If sueldomensual < i1 Then
            isr = 0
            txtisr.Text = isr
        ElseIf sueldomensual >= i1 & sueldomensual <= i4 Then
            isr = sueldomensual * 15%
            txtisr.Text = isr
        ElseIf sueldomensual >= i2 & sueldomensual <= i5 Then
            isr = sueldomensual * 20%
            txtsueldomensual.Text = isr
        ElseIf sueldomensual >= i3 Then
            isr = sueldomensual * 25%
            txtisr.Text = isr
        End If

        If IsNumeric(txtprimernombre.Text) Or IsNumeric(txtsegundonombre.Text) Or IsNumeric(txtapellido.Text) Or IsNumeric(txtsegundoapellido.Text) Or Not IsNumeric(sueldomensual) Then
            MessageBox.Show("Solo ingrese valores numerico en sueldo", "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            txtnombrecompleto.Text = primernombre & " " & segundonombre & " " & apellido1 & " " & apellido2
            sueldomensual = Val(txtsueldomensual.Text)
            sueldoquincenal = sueldomensual / 2
            txtcalsueldoquincenal.Text = sueldoquincenal
            txtcalsueldomensual.Text = sueldomensual
            btnlimpiar.Enabled = True
            btncalcular.Enabled = False
        End If
    End Sub
    Private Sub validarcalcular()
        primernombre = txtprimernombre.Text
        segundonombre = txtsegundonombre.Text
        apellido1 = txtapellido.Text
        apellido2 = txtsegundoapellido.Text

        If txtprimernombre.Text = "" Or txtsegundonombre.Text = "" Or txtapellido.Text = "" Or txtsegundoapellido.Text = "" Or txtsueldomensual.Text = "" Then
            btncalcular.Enabled = False
        Else
            btncalcular.Enabled = True
        End If
    End Sub
End Class