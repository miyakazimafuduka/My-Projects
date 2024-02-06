Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radLarge.Checked = True
        chkChill.Checked = False
        chkGreenPepper.Checked = False
        chkAvocado.Checked = False
        chkChicken.Checked = False
        chkMozzarellaCheese.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim StandardPrice, totalPriceTopping, VatAmount, FinalPrice, ToppingPrice, totalPrice As Double
        Dim CustomerName As String
        Dim TelephoneNumber As String

        CustomerName = CStr(txtCustomerName.Text.Trim)
        TelephoneNumber = CStr(txtTelephoneNumber.Text.Trim)
        If (radSmall).Checked = True Then
            StandardPrice = 40.9
        End If
        If (radMedium).Checked = True Then
            StandardPrice = 56.9
        End If
        If (radLarge).Checked = True Then
            StandardPrice = 79.9
        End If
        If (chkAvocado).Checked = True Then
            ToppingPrice = 7.9
        End If
         If (chkBacon).Checked = True Then
            ToppingPrice = 7.9
        End If
        If (chkChicken).Checked = True Then
            ToppingPrice = 7.9
        End If
        If (chkGreenPepper).Checked = True Then
            ToppingPrice = 5.9
        End If
        If (chkMozzarellaCheese).Checked = True Then
            ToppingPrice = 9.9
        End If
        If (chkChill).Checked = True Then
            ToppingPrice = 5.9
        End If
        txtStandardPrice.Text = CStr(StandardPrice)
        totalPrice = StandardPrice + ToppingPrice
        totalPriceTopping = totalPrice
        txttotalPriceTopping.Text = CStr(totalPriceTopping)

        VatAmount = (totalPrice * 0.14) + (ToppingPrice * 0.14)
        txtVatAmount.Text = CStr(VatAmount)

        FinalPrice = totalPrice + VatAmount
        txtFinalPrice.Text = CStr(FinalPrice)



        If txtCustomerName.Text <> "" Then
            CustomerName = (txtCustomerName.Text).ToUpper.Trim
            For j As Integer = 0 To CustomerName.Length - 1
                Select Case CustomerName.Substring(j, 1)
                    Case "A" To "Z", ""
                    Case Else
                        MsgBox("only Alphabetic values are allowed")
                        txtCustomerName.Text = ""
                        txtCustomerName.Focus()

                End Select
            Next
        Else
            MsgBox("Customer name is not input")
        End If
        If (IsNumeric(txtTelephoneNumber.Text) = False) Then
            MsgBox("alphabetic values are not allowed ")
            txtTelephoneNumber.Text = ""
            txtTelephoneNumber.Focus()

        End If
        If txtTelephoneNumber.Text.StartsWith("0") Then
            txtTelephoneNumber.Text = ""
            txtTelephoneNumber.Focus()
        End If
        If (txtTelephoneNumber.Text.Trim.Length) <> 10 And (txtTelephoneNumber.Text.Trim.Length) < 13 Then
            MsgBox("Telephone number must be  equal 10 and less than 13")
            txtTelephoneNumber.Text = ""
            txtTelephoneNumber.Focus()
        End If

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
