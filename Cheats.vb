''' <license> 
''' Copyright (C) 2017  Dominick Jones
''' 
''' This program is free software: you can redistribute it and/or modify
''' it under the terms of the GNU General Public License as published by 
''' the Free Software Foundation, either version 3 of the License, or
''' any later version.
''' 
''' This program is distributed in the hope that it will be useful,
''' but WITHOUT ANY WARRANTY; without even the implied warranty of
''' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
''' GNU General Public License for more details.
''' 
''' You should have received a copy of the GNU General Public License 
''' along with this program. If not, see <a>http://www.gnu.org/licenses/"</a>.
''' </license>
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
