Option Strict On
Option Explicit On


Public Class Form1
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        'Declare the variables
        Const Pizza As Decimal = 100D
        Const chicken As Decimal = 15D
        Const BBQ As Decimal = 10D
        Const Steak As Decimal = 19.2D
        Const cheese As Decimal = 5D
        Const meat As Decimal = 20D
        Const crust As Decimal = 45D
        Dim Quantity, Price, finalprice As Decimal
        Dim valid As Boolean

        'Get the inputs 
        Quantity = CDec(nucQuantity.Value)

        'Calculate pizza price 
        Price = Quantity * Pizza

        Try
            'Determine which radio button is selected and is related to which price
            If rdochicken.Checked = True Then
                finalprice = Price + chicken
            ElseIf rdobbq.Checked = True Then
                finalprice = Price + BBQ
            ElseIf rdosteak.Checked = True Then
                finalprice = Price + Steak
            Else
                Throw New Exception("PLease select an option")
            End If

            ' Determine which checkbox is selected and is related to which price 
            If chkcheese.Checked Then
                finalprice += cheese
            ElseIf chkmeat.Checked Then
                finalprice += meat
            ElseIf chkCrust.Checked Then
                finalprice += crust
            Else
                Throw New Exception("PLease select an option")
            End If


            'Display final price 
            lblDisplay.Text = finalprice.ToString("C1")


        Catch ex As Exception
            valid = False
            MessageBox.Show("PLease select an option")
        End Try




    End Sub

    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        nucQuantity.Value = 0
        rdochicken.Checked = False
        rdobbq.Checked = False
        rdosteak.Checked = False
        chkcheese.Checked = False
        chkmeat.Checked = False
        chkCrust.Checked = False
        lblDisplay.Text = ""
    End Sub


End Class
