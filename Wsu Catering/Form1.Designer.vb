<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblNumOfDays = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtNumOfDays = New System.Windows.Forms.TextBox()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radDouble = New System.Windows.Forms.RadioButton()
        Me.radSuite = New System.Windows.Forms.RadioButton()
        Me.chkAdditionalBed = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalDailyCharge = New System.Windows.Forms.TextBox()
        Me.txtTotalCharge = New System.Windows.Forms.TextBox()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalChargeVat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(28, 39)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(94, 13)
        Me.lblGuestName.TabIndex = 0
        Me.lblGuestName.Text = "Enter Guest Name"
        '
        'lblNumOfDays
        '
        Me.lblNumOfDays.AutoSize = True
        Me.lblNumOfDays.Location = New System.Drawing.Point(9, 93)
        Me.lblNumOfDays.Name = "lblNumOfDays"
        Me.lblNumOfDays.Size = New System.Drawing.Size(113, 13)
        Me.lblNumOfDays.TabIndex = 1
        Me.lblNumOfDays.Text = "Enter Number Of Days"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(128, 36)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(159, 20)
        Me.txtGuestName.TabIndex = 2
        '
        'txtNumOfDays
        '
        Me.txtNumOfDays.Location = New System.Drawing.Point(128, 91)
        Me.txtNumOfDays.Name = "txtNumOfDays"
        Me.txtNumOfDays.Size = New System.Drawing.Size(159, 20)
        Me.txtNumOfDays.TabIndex = 3
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(333, 37)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(54, 17)
        Me.radSingle.TabIndex = 4
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radDouble
        '
        Me.radDouble.AutoSize = True
        Me.radDouble.Location = New System.Drawing.Point(333, 87)
        Me.radDouble.Name = "radDouble"
        Me.radDouble.Size = New System.Drawing.Size(59, 17)
        Me.radDouble.TabIndex = 5
        Me.radDouble.TabStop = True
        Me.radDouble.Text = "Double"
        Me.radDouble.UseVisualStyleBackColor = True
        '
        'radSuite
        '
        Me.radSuite.AutoSize = True
        Me.radSuite.Location = New System.Drawing.Point(333, 143)
        Me.radSuite.Name = "radSuite"
        Me.radSuite.Size = New System.Drawing.Size(49, 17)
        Me.radSuite.TabIndex = 6
        Me.radSuite.TabStop = True
        Me.radSuite.Text = "Suite"
        Me.radSuite.UseVisualStyleBackColor = True
        '
        'chkAdditionalBed
        '
        Me.chkAdditionalBed.AutoSize = True
        Me.chkAdditionalBed.Location = New System.Drawing.Point(476, 93)
        Me.chkAdditionalBed.Name = "chkAdditionalBed"
        Me.chkAdditionalBed.Size = New System.Drawing.Size(91, 17)
        Me.chkAdditionalBed.TabIndex = 7
        Me.chkAdditionalBed.Text = "AdditionalBed"
        Me.chkAdditionalBed.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Daily Charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vat Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TotalCharge including Vat"
        '
        'txtTotalDailyCharge
        '
        Me.txtTotalDailyCharge.Location = New System.Drawing.Point(211, 218)
        Me.txtTotalDailyCharge.Name = "txtTotalDailyCharge"
        Me.txtTotalDailyCharge.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalDailyCharge.TabIndex = 12
        '
        'txtTotalCharge
        '
        Me.txtTotalCharge.Location = New System.Drawing.Point(211, 271)
        Me.txtTotalCharge.Name = "txtTotalCharge"
        Me.txtTotalCharge.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalCharge.TabIndex = 13
        '
        'txtVatAmount
        '
        Me.txtVatAmount.Location = New System.Drawing.Point(211, 318)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.Size = New System.Drawing.Size(159, 20)
        Me.txtVatAmount.TabIndex = 14
        '
        'txtTotalChargeVat
        '
        Me.txtTotalChargeVat.Location = New System.Drawing.Point(211, 362)
        Me.txtTotalChargeVat.Name = "txtTotalChargeVat"
        Me.txtTotalChargeVat.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalChargeVat.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total Charge for number of days"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(75, 410)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 465)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalChargeVat)
        Me.Controls.Add(Me.txtVatAmount)
        Me.Controls.Add(Me.txtTotalCharge)
        Me.Controls.Add(Me.txtTotalDailyCharge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkAdditionalBed)
        Me.Controls.Add(Me.radSuite)
        Me.Controls.Add(Me.radDouble)
        Me.Controls.Add(Me.radSingle)
        Me.Controls.Add(Me.txtNumOfDays)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.lblNumOfDays)
        Me.Controls.Add(Me.lblGuestName)
        Me.Name = "Form1"
        Me.Text = "WSU GUEST HOUSE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents lblNumOfDays As System.Windows.Forms.Label
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumOfDays As System.Windows.Forms.TextBox
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents radDouble As System.Windows.Forms.RadioButton
    Friend WithEvents radSuite As System.Windows.Forms.RadioButton
    Friend WithEvents chkAdditionalBed As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDailyCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalChargeVat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
