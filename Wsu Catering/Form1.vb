Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radDouble.Checked = True
        chkAdditionalBed.Checked = False
    End Sub

    Function ValidateName(GuestName As String) As Boolean
        GuestName = Trim(GuestName)
        If GuestName = "" Then

            Return False
        End If
        For i As Integer = 0 To GuestName.Length - 1
            Select Case GuestName.Substring(1, i)
                Case "A" To "Z", "a" To "z", " "
                    Return False
            End Select
        Next
        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim TotalDailyCharge, TotalCharge, VatAmount, TotalChargeV As Double
        Dim NumOfDays, Price As Integer
        Dim RoomCharge, AdditionalBedCharge As Integer
        Dim GuestName As String

        If Not (ValidateName(txtGuestName.Text)) = False Then
            MsgBox("only alphabetic values as Spaces allowed")
            txtGuestName.Text = ""
            txtGuestName.Focus()
        End If
        If (IsNumeric(txtNumOfDays.Text) = False) Then
            MsgBox("only numeric values allowed")
            txtNumOfDays.Text = ""
            txtNumOfDays.Focus()
        End If
        If NumOfDays > 1 Then
            MsgBox("number of days should be greater than 1")
            txtNumOfDays.Text = ""
            txtNumOfDays.Focus()
        End If

        If (radSingle).Checked = True Then
            Price = 250
        End If
        If (radDouble).Checked = True Then
            Price = 350
        End If
        If (radSuite).Checked = True Then
            Price = 500
        End If
        If (chkAdditionalBed).Checked = True Then
            AdditionalBedCharge = 50
        End If
        GuestName = CStr(txtGuestName.Text.Trim)
        NumOfDays = CInt(txtNumOfDays.Text.Trim)

        RoomCharge = Price + AdditionalBedCharge

        TotalDailyCharge = RoomCharge
        txtTotalDailyCharge.Text = CStr(RoomCharge)



        TotalCharge = NumOfDays * RoomCharge
        txtTotalCharge.Text = CStr(TotalCharge)

        VatAmount = TotalCharge * 0.14
        txtVatAmount.Text = CStr(VatAmount)

        TotalChargeV = TotalDailyCharge + VatAmount

        txtTotalChargeVat.Text = CStr(TotalChargeV)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
