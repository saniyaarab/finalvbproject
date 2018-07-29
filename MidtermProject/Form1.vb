Option Strict On

Public Class Form1


    'Declare Module variables
    Private mdblTotalGross As Double
    Private mdblTotalFICA As Double
    Private mdblTotalFedIncomeTax As Double


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try

            'declare local variables

            Dim strName As String                                'Name
            Dim dblWage As Double = CDbl(txtWage.Text)          'Hourly pay rate
            Dim dblHours As Double = CDbl(txtHoursWorked.Text)  'Hours worked
            Dim intTax As Integer = CInt(txtWithholdingTax.Text) 'Withholding Tax
            Dim dblPreviousYTDEarnings As Double = CInt(txtPreviousYTDEarnings.Text) 'Previous Year to date earnings
            Dim dblFICATax As Double
            Dim dblFedTaxWithheld As Double
            Dim dblGrossIncome As Double
            Dim dblAdjGross As Double                           'Gross after Gross Income - withholding exemptions
            Dim dblSSN As Double                                'Social security deduction
            Dim dblSSNAmountGap As Double                         'Difference of 84000 - previous YTD
            Dim dblMedi As Double                               'Medicare deduction
            Dim dblNetIncome As Double                          'income after tax deductions
            Dim dblUpdateYTDEarnings As Double                  'Previous YTD earning + Gross Income

            'Declare as Constant

            Const dblOVERTIME_RATE As Double = 0.5          'Overtime for hours worked greater than 40
            Const dblSSN_RATE As Double = 0.062              'Social Security Rate
            Const dblMEDICARE_RATE As Double = 0.0145       'Medicare

            'Declare constants for limits and other
            Const shrtREGULAR_HOURS As Short = 40                'more than 40 hours will be overtime
            Const dblSSNMax_Amount As Double = 84000                'ssn applies to first 84000 of earnings
            Const dblTAXWITHHELD_AMOUNT As Double = 55.77       ' amount deducted from gross before federal income tax is applied

            Const dblFRSTPARAMETER_MAXAMOUNT As Double = 51        ' amount upto  min0 - max51
            Const dblSECPARAMETER_MAXAMOUNT As Double = 500        'amount upto min51 - max500
            Const dblTHRDPARAMETER_MAXAMOUNT As Double = 2500      'Amount upto min500 - max2500
            Const dblFRTHPARAMETER_MAXAMOUNT As Double = 5000      'Amount upto min2500 - max5000

            Const dblSECPARAMETERSIN_RATE As Double = 0.1              'rate for single, amount over 50
            Const dblTHRDPARAMETERSIN_RATE As Double = 0.15             'rate for single, amount over 500
            Const dblFRTHPARAMETERSIN_RATE As Double = 0.2              'rate for single, amount over 2500
            Const dblFIFTHPARAMETERSIN_RATE As Double = 0.25            'rate for single, amount over 5000

            Const dblSECPARAMETERMAR_RATE As Double = 0.5              'rate for married, amount over 50
            Const dblTHRDPARAMETERMAR_RATE As Double = 0.1             'rate for married, amount over 500
            Const dblFRTHPARAMETERMAR_RATE As Double = 0.15              'rate for married, amount over 2500
            Const dblFIFTHPARAMETERMAR_RATE As Double = 0.2            'rate for married, amount over 5000


            'Set format when user enters the value as currency
            txtWage.Text = FormatCurrency(txtWage.Text)
            txtPreviousYTDEarnings.Text = FormatCurrency(txtPreviousYTDEarnings.Text)

            If Not Integer.TryParse(txtWithholdingTax.Text, intTax) Then
                MessageBox.Show("Please enter an integer numeric value", "Withholding Exemptions Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtWithholdingTax.Clear()
                txtWithholdingTax.Focus()
                Exit Sub
            End If

            'Error display when name is not entered
            strName = CStr(txtName.Text)
            If strName = "" Then
                MessageBox.Show("Please Enter Name", "Name Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtName.Focus()
                Exit Sub
            End If

            'Error display when hours and wage is 0
            If dblWage <= 0 Then
                MessageBox.Show("Enter Wage greater than 0", "Hourly Wage Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtWage.Focus()
                Exit Sub
            End If

            If dblHours <= 0 Then
                MessageBox.Show("Enter Hours greater than 0", "Hours working Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtHoursWorked.Focus()
                Exit Sub
            End If

            'Calculate Gross Income
            dblGrossIncome = dblHours * dblWage
            If dblHours > shrtREGULAR_HOURS Then
                dblGrossIncome += (dblHours - shrtREGULAR_HOURS) * (dblWage * dblOVERTIME_RATE)
            End If
            lblGrossEarnings.Text = FormatCurrency(dblGrossIncome.ToString("n2"))


            'Calculate  Social Security Tax
            If dblPreviousYTDEarnings + dblGrossIncome < dblSSNMax_Amount Then
                dblSSN = dblGrossIncome * dblSSN_RATE
            Else
                If dblPreviousYTDEarnings > dblSSNMax_Amount Then
                    dblSSN = 0
                ElseIf dblPreviousYTDEarnings < dblSSNMax_Amount Then
                    dblSSNAmountGap = dblSSNMax_Amount - dblPreviousYTDEarnings
                    dblSSN = dblSSNAmountGap * dblSSN_RATE
                End If
            End If

            ' Calculate Medicare Tax
            dblMedi = dblGrossIncome * dblMEDICARE_RATE

            'Calculate FICA Tax
            dblFICATax = dblSSN + dblMedi

            'display FICA TAX calculated value in label
            lblFICATax.Text = FormatCurrency(dblFICATax.ToString("n2"))

            'set limit for withholding exemptions and subtract amount from Gross
            If intTax >= 0 AndAlso intTax <= 10 Then
                dblAdjGross = dblGrossIncome - (intTax * dblTAXWITHHELD_AMOUNT)
            Else : MessageBox.Show("Enter value within range 0 - 10", "Withholding Exemptions Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtWithholdingTax.Focus()
                Exit Sub
            End If

            'Fed income tax withheld calc for single
            If radSingle.Checked = True Then
                Select Case dblAdjGross
                    Case Is <= dblSECPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = (dblAdjGross - dblFRSTPARAMETER_MAXAMOUNT) * dblSECPARAMETERSIN_RATE   ' 10% for above 51
                    Case Is <= dblTHRDPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = 45 + (dblAdjGross - dblSECPARAMETER_MAXAMOUNT) * dblTHRDPARAMETERSIN_RATE  ' 15% for above 500
                    Case Is <= dblFRTHPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = 345 + (dblAdjGross - dblTHRDPARAMETER_MAXAMOUNT) * dblFRTHPARAMETERSIN_RATE '20% for above 2500
                    Case Else
                        dblFedTaxWithheld = 845 + (dblAdjGross - dblFRTHPARAMETER_MAXAMOUNT) * dblFIFTHPARAMETERSIN_RATE  '25% for above 5000
                End Select

                'Fed income tax withheld calc for married
            ElseIf radMarried.Checked = True Then
                Select Case dblAdjGross
                    Case Is <= dblSECPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = (dblAdjGross - dblFRSTPARAMETER_MAXAMOUNT) * dblSECPARAMETERMAR_RATE         '5% for above 51
                    Case Is <= dblTHRDPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = 22.5 + (dblAdjGross - dblSECPARAMETER_MAXAMOUNT) * dblTHRDPARAMETERMAR_RATE  '10% for above 500
                    Case Is <= dblFRTHPARAMETER_MAXAMOUNT
                        dblFedTaxWithheld = 225.5 + (dblAdjGross - dblTHRDPARAMETER_MAXAMOUNT) * dblFRTHPARAMETERMAR_RATE     '15% for above 2500
                    Case Else
                        dblFedTaxWithheld = 600.5 + (dblAdjGross - dblFRTHPARAMETER_MAXAMOUNT) * dblFIFTHPARAMETERMAR_RATE    '20% for above 5000
                End Select
            End If

            'display Federal Income Tax Withheld
            lblFederalIncomeTaxWithheld.Text = FormatCurrency(dblFedTaxWithheld.ToString("n2"))

            'calculate net income
            dblNetIncome = dblGrossIncome - dblFICATax - dblFedTaxWithheld

            'display net income after converting it to string
            lblNetEarings.Text = FormatCurrency(dblNetIncome.ToString("n2"))

            'display error message is Previous YTD earning is less than 0
            If dblPreviousYTDEarnings < 0 Then
                MessageBox.Show("Enter Previous year-to-Date earning greater or equal to 0", "Previous Year to Date Error")
                lblGrossEarnings.Text = String.Empty
                lblFICATax.Text = String.Empty
                lblFederalIncomeTaxWithheld.Text = String.Empty
                lblNetEarings.Text = String.Empty
                lblYeartoDateEarnings.Text = String.Empty
                txtPreviousYTDEarnings.Focus()
                Exit Sub
            End If

            'Display update year to date earning

            dblUpdateYTDEarnings = dblGrossIncome + dblPreviousYTDEarnings
            lblYeartoDateEarnings.Text = FormatCurrency(dblUpdateYTDEarnings.ToString("n2"))

            'Accumulate Total Gross Income, Total FICA paid and Total Federal income tax paid
            mdblTotalGross = mdblTotalGross + dblGrossIncome
            mdblTotalFICA = mdblTotalFICA + dblFICATax
            mdblTotalFedIncomeTax = mdblTotalFedIncomeTax + dblFedTaxWithheld


        Catch ex As Exception
            MessageBox.Show("Enter a valid value. All fields are numeric except Name", "Error")
            lblGrossEarnings.Text = String.Empty
            lblFICATax.Text = String.Empty
            lblFederalIncomeTaxWithheld.Text = String.Empty
            lblNetEarings.Text = String.Empty
            lblYeartoDateEarnings.Text = String.Empty


        End Try
    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click
        txtName.Clear()
        txtHoursWorked.Clear()
        txtPreviousYTDEarnings.Clear()
        txtWage.Clear()
        txtWithholdingTax.Clear()

        lblFederalIncomeTaxWithheld.Text = String.Empty
        lblFICATax.Text = String.Empty
        lblGrossEarnings.Text = String.Empty
        lblNetEarings.Text = String.Empty
        lblYeartoDateEarnings.Text = String.Empty
        radSingle.Checked = True

        txtName.Focus()
    End Sub

    Private Sub btnPayrollSummary_Click(sender As Object, e As EventArgs) Handles btnPayrollSummary.Click


        MessageBox.Show("Total Gross Earnings:  " & FormatCurrency(mdblTotalGross) & ControlChars.CrLf & "Total FICA Tax Paid:  " & FormatCurrency(mdblTotalFICA) & ControlChars.CrLf & "Total Federal Income Tax Paid:  " & FormatCurrency(mdblTotalFedIncomeTax), "Payroll Summary")
    End Sub


   
    
End Class
