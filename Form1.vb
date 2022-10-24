Public Class Form1

    Private Sub txtUno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDos.Focus()
        End If
    End Sub

    Private Sub txtDos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            bttAceptar.PerformClick()
        End If
    End Sub

    Private Sub bttAceptar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bttAceptar.KeyPress
        If Asc(e.KeyChar) = 8 Then
            MsgBox("Presionaste BACKSPACE")
        Else
            MsgBox("Lo presionaste con el MOUSE! ")
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
