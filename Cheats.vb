Public Class Cheat

    ''' <summary>
    ''' Allows for you to set your money.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub moneyCheat(sender As System.Object, e As System.EventArgs) Handles btnCoin.Click
        If Not IsNumeric(txtCoin.Text) Then
            MessageBox.Show("Please ensure you enter numeric values.")
            Return
        End If
        GlobalConstants.coins = txtCoin.Text
    End Sub

    ''' <summary>
    ''' Allows for you to set your prestige.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub prestigeCheat(sender As System.Object, e As System.EventArgs) Handles btnPrestige.Click
        If Not IsNumeric(txtPrestige.Text) Then
            MessageBox.Show("Please ensure you enter numeric values.")
            Return
        End If
        GlobalConstants.prestige = txtPrestige.Text
    End Sub
End Class
