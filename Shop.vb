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
Public Class Shop

    ''' <summary>
    ''' What to do on form load up.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub initiateForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_coins.Text = Game.lblCoins.Text

        Me.autoTree.SetToolTip(Label4, "This item costs 25 coins.")
    End Sub

    ''' <summary>
    ''' Buy automated trees.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub buyAutomaticTrees(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tree_auto.Click
        If GlobalConstants.coins < 25 Then
            MessageBox.Show("You need 25 coins to purchase this.")
            Return
        End If
        GlobalConstants.coins -= 25
        GlobalConstants.treeAutomatic = True
        MessageBox.Show("You purchased automatic tree planting!")
    End Sub

    ''' <summary>
    ''' Buy x2 profit on trees.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub buyMultipliedTrees(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tree_x2.Click
        GlobalConstants.treeMultiplier = 2
        MessageBox.Show("You purchased the tree multiplier!")
    End Sub

    ''' <summary>
    ''' Buy automated animals.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub buyAutoAnimals(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animal_auto.Click
        GlobalConstants.animalAutomatic = True
        MessageBox.Show("You purchased automatic animal saving!")
    End Sub

    ''' <summary>
    ''' The main process to update game components.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub process(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrProcess.Tick
        lbl_coins.Text = GlobalConstants.coins.ToString
    End Sub

    ''' <summary>
    ''' Allows the player to prestige.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub prestige(sender As System.Object, e As System.EventArgs) Handles btn_prestige.Click
        Select Case GlobalConstants.prestige
            Case 1
                If GlobalConstants.coins < 1000 Then
                    MessageBox.Show("You need 1000 coins to prestige!")
                    Return
                Else
                    GlobalConstants.prestige += 1
                End If

            Case 2
                If GlobalConstants.coins < 2500 Then
                    MessageBox.Show("You need 2,500 coins to prestige again.")
                    Return
                Else
                    GlobalConstants.prestige += 1
                End If

            Case 3
                If GlobalConstants.coins < 5000 Then
                    MessageBox.Show("You need 5,000 coins to prestige again.")
                    Return
                Else
                    GlobalConstants.prestige += 1
                End If

            Case 4
                If GlobalConstants.coins < 10000 Then
                    MessageBox.Show("You need 10,000 coins to prestige again.")
                    Return
                Else
                    GlobalConstants.prestige += 1
                End If

            Case 5
                If GlobalConstants.coins < 25000 Then
                    MessageBox.Show("You need 25,000 coins to prestige again.")
                    Return
                Else
                    GlobalConstants.prestige += 1
                End If
        End Select
    End Sub
End Class
