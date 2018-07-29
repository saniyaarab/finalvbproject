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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtWithholdingTax = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnPayrollSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radMarried = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGrossEarnings = New System.Windows.Forms.Label()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblFederalIncomeTaxWithheld = New System.Windows.Forms.Label()
        Me.lblNetEarings = New System.Windows.Forms.Label()
        Me.lblYeartoDateEarnings = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPreviousYTDEarnings = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hourly Wage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hours Working"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Withholding Exemptions"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(112, 53)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(100, 20)
        Me.txtWage.TabIndex = 1
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(112, 83)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 2
        '
        'txtWithholdingTax
        '
        Me.txtWithholdingTax.Location = New System.Drawing.Point(112, 116)
        Me.txtWithholdingTax.Name = "txtWithholdingTax"
        Me.txtWithholdingTax.Size = New System.Drawing.Size(100, 20)
        Me.txtWithholdingTax.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 247)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 34)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(155, 247)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(115, 36)
        Me.btnNextEmployee.TabIndex = 1
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnPayrollSummary
        '
        Me.btnPayrollSummary.Location = New System.Drawing.Point(298, 247)
        Me.btnPayrollSummary.Name = "btnPayrollSummary"
        Me.btnPayrollSummary.Size = New System.Drawing.Size(115, 36)
        Me.btnPayrollSummary.TabIndex = 2
        Me.btnPayrollSummary.Text = "Payroll Summary"
        Me.btnPayrollSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(440, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Marital Status"
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(112, 156)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(54, 17)
        Me.radSingle.TabIndex = 4
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radMarried
        '
        Me.radMarried.AutoSize = True
        Me.radMarried.Location = New System.Drawing.Point(172, 156)
        Me.radMarried.Name = "radMarried"
        Me.radMarried.Size = New System.Drawing.Size(60, 17)
        Me.radMarried.TabIndex = 5
        Me.radMarried.Text = "Married"
        Me.radMarried.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gross Earnings"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "FICA Tax"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 31)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Federal Income Tax Withheld"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Net Earnings"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 29)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Updated Year to Date Earnings"
        '
        'lblGrossEarnings
        '
        Me.lblGrossEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossEarnings.Location = New System.Drawing.Point(108, 21)
        Me.lblGrossEarnings.Name = "lblGrossEarnings"
        Me.lblGrossEarnings.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossEarnings.TabIndex = 20
        '
        'lblFICATax
        '
        Me.lblFICATax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICATax.Location = New System.Drawing.Point(108, 52)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(100, 23)
        Me.lblFICATax.TabIndex = 21
        '
        'lblFederalIncomeTaxWithheld
        '
        Me.lblFederalIncomeTaxWithheld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFederalIncomeTaxWithheld.Location = New System.Drawing.Point(108, 82)
        Me.lblFederalIncomeTaxWithheld.Name = "lblFederalIncomeTaxWithheld"
        Me.lblFederalIncomeTaxWithheld.Size = New System.Drawing.Size(100, 23)
        Me.lblFederalIncomeTaxWithheld.TabIndex = 22
        '
        'lblNetEarings
        '
        Me.lblNetEarings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetEarings.Location = New System.Drawing.Point(108, 131)
        Me.lblNetEarings.Name = "lblNetEarings"
        Me.lblNetEarings.Size = New System.Drawing.Size(100, 23)
        Me.lblNetEarings.TabIndex = 23
        '
        'lblYeartoDateEarnings
        '
        Me.lblYeartoDateEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYeartoDateEarnings.Location = New System.Drawing.Point(108, 163)
        Me.lblYeartoDateEarnings.Name = "lblYeartoDateEarnings"
        Me.lblYeartoDateEarnings.Size = New System.Drawing.Size(100, 23)
        Me.lblYeartoDateEarnings.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'txtPreviousYTDEarnings
        '
        Me.txtPreviousYTDEarnings.Location = New System.Drawing.Point(112, 179)
        Me.txtPreviousYTDEarnings.Name = "txtPreviousYTDEarnings"
        Me.txtPreviousYTDEarnings.Size = New System.Drawing.Size(100, 20)
        Me.txtPreviousYTDEarnings.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 36)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Previous Year to Date Earnings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblYeartoDateEarnings)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblNetEarings)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblFederalIncomeTaxWithheld)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblFICATax)
        Me.GroupBox2.Controls.Add(Me.lblGrossEarnings)
        Me.GroupBox2.Location = New System.Drawing.Point(298, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 220)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payroll Calculation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtHoursWorked)
        Me.GroupBox1.Controls.Add(Me.txtWithholdingTax)
        Me.GroupBox1.Controls.Add(Me.txtPreviousYTDEarnings)
        Me.GroupBox1.Controls.Add(Me.txtWage)
        Me.GroupBox1.Controls.Add(Me.radMarried)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 220)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Payroll Details"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPayrollSummary)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Payroll Application"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtWithholdingTax As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnNextEmployee As System.Windows.Forms.Button
    Friend WithEvents btnPayrollSummary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents radMarried As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGrossEarnings As System.Windows.Forms.Label
    Friend WithEvents lblFICATax As System.Windows.Forms.Label
    Friend WithEvents lblFederalIncomeTaxWithheld As System.Windows.Forms.Label
    Friend WithEvents lblNetEarings As System.Windows.Forms.Label
    Friend WithEvents lblYeartoDateEarnings As System.Windows.Forms.Label
    Friend WithEvents txtPreviousYTDEarnings As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
