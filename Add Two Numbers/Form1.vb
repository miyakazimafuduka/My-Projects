Public Class FrmAdd

    Private Sub FrmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOutput.ReadOnly = True
    End Sub


    Function Add(NumA As Integer, numB As Integer) As Integer

        Dim Sum As Double
        Sum = NumA + numB

        Return Sum
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Num1, Num2 As Integer
        Dim Sum1 As Integer
        Num1 = CInt(txtNum1.Text.Trim)
        Num2 = CInt(txtNum2.Text.Trim)

        Sum1 = Add(Num1, Num2)

        txtOutput.Text = CStr(Sum1)
    End Sub

    Sub Divide()
        Dim Num1, Num2 As Integer
        Dim Sum As Double

        Num1 = CInt(txtNum1.Text.Trim)
        Num2 = CInt(txtNum2.Text.Trim)
        Sum = Num1 \ Num2
        txtOutput.Text = CStr(Sum)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Divide()
    End Sub
End Class
