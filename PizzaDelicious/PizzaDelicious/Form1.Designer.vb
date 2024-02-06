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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.chkChill = New System.Windows.Forms.CheckBox()
        Me.chkGreenPepper = New System.Windows.Forms.CheckBox()
        Me.chkAvocado = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkMozzarellaCheese = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStandardPrice = New System.Windows.Forms.TextBox()
        Me.txttotalPriceTopping = New System.Windows.Forms.TextBox()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.txtFinalPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelephoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CustomerDetails"
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(114, 76)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephoneNumber.TabIndex = 5
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(114, 29)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TelephoneNumber"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CustomerName"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radLarge)
        Me.GroupBox2.Controls.Add(Me.radMedium)
        Me.GroupBox2.Controls.Add(Me.radSmall)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PizzaSizes"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(18, 76)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(18, 52)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(18, 29)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(30, 193)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(279, 160)
        Me.ListBox1.TabIndex = 2
        '
        'chkChill
        '
        Me.chkChill.AutoSize = True
        Me.chkChill.Location = New System.Drawing.Point(360, 154)
        Me.chkChill.Name = "chkChill"
        Me.chkChill.Size = New System.Drawing.Size(45, 17)
        Me.chkChill.TabIndex = 3
        Me.chkChill.Text = "Chill"
        Me.chkChill.UseVisualStyleBackColor = True
        '
        'chkGreenPepper
        '
        Me.chkGreenPepper.AutoSize = True
        Me.chkGreenPepper.Location = New System.Drawing.Point(360, 177)
        Me.chkGreenPepper.Name = "chkGreenPepper"
        Me.chkGreenPepper.Size = New System.Drawing.Size(89, 17)
        Me.chkGreenPepper.TabIndex = 4
        Me.chkGreenPepper.Text = "GreenPepper"
        Me.chkGreenPepper.UseVisualStyleBackColor = True
        '
        'chkAvocado
        '
        Me.chkAvocado.AutoSize = True
        Me.chkAvocado.Location = New System.Drawing.Point(360, 200)
        Me.chkAvocado.Name = "chkAvocado"
        Me.chkAvocado.Size = New System.Drawing.Size(69, 17)
        Me.chkAvocado.TabIndex = 5
        Me.chkAvocado.Text = "Avocado"
        Me.chkAvocado.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(360, 223)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 6
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Location = New System.Drawing.Point(360, 246)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(65, 17)
        Me.chkChicken.TabIndex = 7
        Me.chkChicken.Text = "Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkMozzarellaCheese
        '
        Me.chkMozzarellaCheese.AutoSize = True
        Me.chkMozzarellaCheese.Location = New System.Drawing.Point(360, 269)
        Me.chkMozzarellaCheese.Name = "chkMozzarellaCheese"
        Me.chkMozzarellaCheese.Size = New System.Drawing.Size(115, 17)
        Me.chkMozzarellaCheese.TabIndex = 8
        Me.chkMozzarellaCheese.Text = "Mozzarella Cheese"
        Me.chkMozzarellaCheese.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(42, 384)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "StandardPrice"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "totaPriceTopping"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "VatAmount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "FinalPrice"
        '
        'txtStandardPrice
        '
        Me.txtStandardPrice.Location = New System.Drawing.Point(133, 220)
        Me.txtStandardPrice.Name = "txtStandardPrice"
        Me.txtStandardPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtStandardPrice.TabIndex = 6
        '
        'txttotalPriceTopping
        '
        Me.txttotalPriceTopping.Location = New System.Drawing.Point(133, 257)
        Me.txttotalPriceTopping.Name = "txttotalPriceTopping"
        Me.txttotalPriceTopping.Size = New System.Drawing.Size(100, 20)
        Me.txttotalPriceTopping.TabIndex = 15
        '
        'txtVatAmount
        '
        Me.txtVatAmount.Location = New System.Drawing.Point(133, 293)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtVatAmount.TabIndex = 16
        '
        'txtFinalPrice
        '
        Me.txtFinalPrice.Location = New System.Drawing.Point(133, 325)
        Me.txtFinalPrice.Name = "txtFinalPrice"
        Me.txtFinalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalPrice.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 484)
        Me.Controls.Add(Me.txtFinalPrice)
        Me.Controls.Add(Me.txtVatAmount)
        Me.Controls.Add(Me.txttotalPriceTopping)
        Me.Controls.Add(Me.txtStandardPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkMozzarellaCheese)
        Me.Controls.Add(Me.chkChicken)
        Me.Controls.Add(Me.chkBacon)
        Me.Controls.Add(Me.chkAvocado)
        Me.Controls.Add(Me.chkGreenPepper)
        Me.Controls.Add(Me.chkChill)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Pizza Delicious"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents chkChill As System.Windows.Forms.CheckBox
    Friend WithEvents chkGreenPepper As System.Windows.Forms.CheckBox
    Friend WithEvents chkAvocado As System.Windows.Forms.CheckBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkChicken As System.Windows.Forms.CheckBox
    Friend WithEvents chkMozzarellaCheese As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStandardPrice As System.Windows.Forms.TextBox
    Friend WithEvents txttotalPriceTopping As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalPrice As System.Windows.Forms.TextBox

End Class
