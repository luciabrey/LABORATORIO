Public Class Form1
    Dim Operacion As String
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim ResultadoDos As Nullable(Of Double) = Nothing
    Dim Presionado As Boolean

    Private Sub bttDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttDividir.Click
        Realizar()
        Operacion = "/"
        lbMostrar.Text &= " / "
        boxNumeros.Text = ""
    End Sub

    Private Sub bttMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMult.Click
        Realizar()
        Operacion = "*"
        lbMostrar.Text &= " * "
        boxNumeros.Text = ""
    End Sub

    Private Sub bttMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMenos.Click
        Realizar()
        Operacion = "-"
        lbMostrar.Text &= " - "
        boxNumeros.Text = ""
    End Sub

    Private Sub bttSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSuma.Click
        Realizar()
        Operacion = "+"
        lbMostrar.Text &= " + "
        boxNumeros.Text = ""
    End Sub

    Private Sub bttIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIgual.Click
        Realizar()
        Operacion = ""
        boxNumeros.Text = ""
        lbMostrar.Text &= " = "
        lbMostrar.Text &= Resultado
        boxNumeros.Text = Resultado
    End Sub

    Private Sub bttBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrar.Click
        Realizar()
        Operacion = ""
        boxNumeros.Text = ""
        lbMostrar.Text = ""
    End Sub

    Private Sub Realizar()
        Presionado = True
        ResultadoDos = Val(boxNumeros.Text)

        If Resultado IsNot Nothing Then
            Select Operacion
                Case "/"
                    Resultado /= ResultadoDos
                Case "*"
                    Resultado *= ResultadoDos
                Case "-"
                    Resultado = Resultado - ResultadoDos
                Case "+"
                    Resultado = Resultado + ResultadoDos

            End Select

        Else
            Resultado = ResultadoDos
        End If
    End Sub

    Private Sub bttComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttComa.Click
        If InStr(boxNumeros.Text, ",", CompareMethod.Text) = 0 Then
            boxNumeros.Text &= ","
            lbMostrar.Text &= ","
        End If
    End Sub

    ''NUMEROS: 
    Private Sub bttCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCero.Click
        boxNumeros.Text &= "0"
        lbMostrar.Text &= "0"
    End Sub

    Private Sub bttUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttUno.Click
        boxNumeros.Text &= "1"
        lbMostrar.Text &= "1"
    End Sub

    Private Sub bttDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttDos.Click
        boxNumeros.Text &= "2"
        lbMostrar.Text &= "2"
    End Sub

    Private Sub bttTres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTres.Click
        boxNumeros.Text &= "3"
        lbMostrar.Text &= "3"
    End Sub

    Private Sub bttCuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCuatro.Click
        boxNumeros.Text &= "4"
        lbMostrar.Text &= "4"
    End Sub

    Private Sub bttCinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCinco.Click
        boxNumeros.Text &= "5"
        lbMostrar.Text &= "5"
    End Sub

    Private Sub bttSeis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSeis.Click
        boxNumeros.Text &= "6"
        lbMostrar.Text &= "6"
    End Sub

    Private Sub bttSiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSiete.Click
        boxNumeros.Text &= "7"
        lbMostrar.Text &= "7"
    End Sub

    Private Sub bttOcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttOcho.Click
        boxNumeros.Text &= "8"
        lbMostrar.Text &= "8"
    End Sub

    Private Sub bttNueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNueve.Click
        boxNumeros.Text &= "9"
        lbMostrar.Text &= "9"
    End Sub


End Class
