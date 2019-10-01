Public Class Form1

    Dim curOperator As String = Nothing
    Private Sub Verify()
        If (IsNumeric(txtNumber1.Text) And IsNumeric(txtNumber2.Text) And Not IsNothing(curOperator) And Not IsNothing(txtNumber1.Text) And Not IsNothing(txtNumber2.Text)) Then
            Calculate()
        End If
    End Sub

    Private Sub Calculate()
        Dim num1# = CDbl(txtNumber1.Text)
        Dim num2# = CDbl(txtNumber2.Text)

        Select Case curOperator
            Case "+"
                lblResultOutput.Text = num1 + num2
            Case "-"
                lblResultOutput.Text = num1 - num2
            Case "*"
                lblResultOutput.Text = num1 * num2
            Case "/"
                If (num2 = 0) Then
                    lblResultOutput.Text = "Undefined"
                Else
                    lblResultOutput.Text = num1 / num2
                End If

            Case "\"
                If (num2 = 0) Then
                    lblResultOutput.Text = "Undefined"
                Else
                    lblResultOutput.Text = num1 \ num2
                End If

            Case "^"
                lblResultOutput.Text = Math.Pow(num1, num2)
            Case "Mod"
                lblResultOutput.Text = num1 Mod num2
        End Select
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        curOperator = "+"
        Verify()
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        curOperator = "-"
        Verify()
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        curOperator = "*"
        Verify()
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        curOperator = "/"
        Verify()
    End Sub

    Private Sub BtnQuotient_Click(sender As Object, e As EventArgs) Handles btnQuotient.Click
        curOperator = "\"
        Verify()
    End Sub

    Private Sub BtnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        curOperator = "^"
        Verify()
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        curOperator = "Mod"
        Verify()
    End Sub

    Private Sub TxtNumber1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber1.TextChanged
        Verify()
    End Sub

    Private Sub TxtNumber2_TextChanged(sender As Object, e As EventArgs) Handles txtNumber2.TextChanged
        Verify()
    End Sub
End Class
