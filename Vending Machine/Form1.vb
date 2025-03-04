Public Class Form1
    Public Sub CalculateCost()
        Dim totalCost As Decimal
        totalCost = 0

        If chkCocaCola.Checked Then
            totalCost += 2 * numCoke.Value
            Dim cokeCost As Decimal
            cokeCost = numCoke.Value * 2
            IstOrders.Items.Add(numCoke.Value & " Coca Cola is £" & cokeCost)
        End If

        If chkPrime.Checked Then
            totalCost += 2.5 * numPrime.Value
            IstOrders.Items.Add("Prime" & numPrime.Value & 2.5 & "£")

        End If

        If chkSprite.Checked Then
            totalCost += 2.5 * numSprite.Value
            IstOrders.Items.Add("Sprite" & numSprite.Value & 2.5 & "£")

        End If

        If chkWater.Checked Then
            totalCost += 1.0 * numWater.Value
            IstOrders.Items.Add("Water" & numWater.Value & 1 & "£")
        End If

        If chkTango.Checked Then
            totalCost += 2.5 * numTango.Value

            IstOrders.Items.Add("Tango" & numTango.Value & 2.5 & "£")
        End If


        If totalCost < 3 Then
            IblCost.Text = "Minimum Order is £3 - buy more"
        End If

        If totalCost > 20 Then
            totalCost *= 0.15
        Else
            IblCost.Text = totalCost & " £"
        End If




    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        CalculateCost()

    End Sub

    Private Sub chkCocaCola_CheckedChanged(sender As Object, e As EventArgs) Handles chkCocaCola.CheckedChanged
        CalculateCost()
    End Sub
End Class
