Public Class Game

    ''' <summary>
    ''' What to do on form load up.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub initiateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.CenterToScreen()
        Me.Show()
        Me.Focus()

        tooltips()
    End Sub

    ''' <summary>
    ''' Sets all our tooltips to have information and tags on them.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tooltips()
        Me.tool_pat.SetToolTip(btn_pat, "Cost: " & GlobalConstants.treePrice & " coin" & vbCrLf & _
                                        "Gain: " & GlobalConstants.treeProfit & " coin" & vbCrLf & _
                                        "Time: " & Utilities.toSeconds(tmr_pat.Interval) & " seconds")

        Me.tool_animal.SetToolTip(btn_saa, "Cost: " & GlobalConstants.animalPrice & " coin" & vbCrLf & _
                                       "Gain: " & GlobalConstants.animalProfit & " coin" & vbCrLf & _
                                       "Time: " & Utilities.toSeconds(tmr_animal.Interval) & " seconds")

        Me.tool_petition.SetToolTip(btn_petition, "Cost: " & GlobalConstants.petitionPrice & " coin" & vbCrLf & _
                                       "Gain: " & GlobalConstants.petitionProfit & " coin" & vbCrLf & _
                                       "Time: " & Utilities.toSeconds(tmr_petition.Interval) & " seconds")

        Me.tool_wildlife.SetToolTip(btn_we, "Cost: " & GlobalConstants.wildlifePrice & " coin" & vbCrLf & _
                                       "Gain: " & GlobalConstants.wildlifeProfit & " coin" & vbCrLf & _
                                       "Time: " & Utilities.toSeconds(tmr_wildlife.Interval) & " seconds")

        Me.tool_filter.SetToolTip(btn_filter, "Cost: " & GlobalConstants.filterPrice & " coin" & vbCrLf & _
                                        "Gain: " & GlobalConstants.filterProfit & " coin" & vbCrLf & _
                                        "Time: " & Utilities.toSeconds(tmr_filter.Interval) & " seconds")

        Me.tool_filter.SetToolTip(btn_filter, "Cost: " & GlobalConstants.filterPrice & " coin" & vbCrLf & _
                                        "Gain: " & GlobalConstants.filterProfit & " coin" & vbCrLf & _
                                        "Time: " & Utilities.toSeconds(tmr_filter.Interval) & " seconds")

        Me.tool_coconut.SetToolTip(btn_coconut, "Cost: " & GlobalConstants.coconutPrice & " coin" & vbCrLf & _
                                        "Gain: " & GlobalConstants.coconutProfit & " coin" & vbCrLf & _
                                        "Time: " & Utilities.toSeconds(tmr_coconut.Interval) & " seconds")

        Me.tool_chocolate.SetToolTip(btn_chocolate, "Cost: " & GlobalConstants.chocolatePrice & " coin" & vbCrLf & _
                                        "Gain: " & GlobalConstants.chocolateProfit & " coin" & vbCrLf & _
                                        "Time: " & Utilities.toSeconds(tmr_chocolate.Interval) & " seconds")
    End Sub

    ''' <summary>
    ''' Allows us to check if we meet criteria based on a <code>code</code>.
    ''' </summary>
    ''' <param name="code">The code to relate to.</param>
    ''' <returns>true or false.</returns>
    ''' <remarks></remarks>
    Private Function meetCriterian(ByVal code As Integer) As Boolean
        Select Case code
            Case 1
                If GlobalConstants.coins < GlobalConstants.animalPrice Then
                    MessageBox.Show("You do not have enough money.")
                    Return False
                End If

            Case 2
                If GlobalConstants.coins < GlobalConstants.petitionPrice Then
                    MessageBox.Show("You do not have enough money.")
                    Return False
                End If

            Case 3
                If GlobalConstants.coins < GlobalConstants.wildlifePrice Then
                    MessageBox.Show("You do not have enough money.")
                    Return False
                End If

            Case 4
                If GlobalConstants.coins < GlobalConstants.filterPrice Then
                    MessageBox.Show("You do not have enough money.")
                    Return False
                End If

            Case 5
                If GlobalConstants.coins < GlobalConstants.coconutPrice Then
                    MessageBox.Show("You do not have enough money.")
                    Return False
                End If
        End Select

        Return True
    End Function

#Region "Plant a Tree"
    ''' <summary>
    ''' Triggers the events for planting a tree.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonPlant(sender As System.Object, e As System.EventArgs) Handles btn_pat.Click
        If pb_prog_pat.Value >= 100 Then
            Return
        End If
        pb_prog_pat.Value += 100
        tmr_pat.Start()
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_pat.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerPlant(sender As System.Object, e As System.EventArgs) Handles tmr_pat.Tick
        GlobalConstants.coins += 1 * GlobalConstants.treeMultiplier
        pb_prog_pat.Value = 0
        tmr_pat.Stop()
    End Sub
#End Region
#Region "Save An Animal"

    ''' <summary>
    ''' Triggers the events for saving an animal.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonAnimal(sender As System.Object, e As System.EventArgs) Handles btn_saa.Click
        If Not meetCriterian(1) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.animalPrice
        tmr_animal.Enabled = True
        bar_animal.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_animal.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerAnimal(sender As System.Object, e As System.EventArgs) Handles tmr_animal.Tick
        GlobalConstants.coins += GlobalConstants.animalProfit
        pb_prog_saa.Value = 0
        tmr_animal.Enabled = False
        bar_animal.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_animal.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barAnimal(sender As System.Object, e As System.EventArgs) Handles bar_animal.Tick
        pb_prog_saa.Increment(25)
    End Sub
#End Region
#Region "Sign a Petition"

    ''' <summary>
    ''' Triggers the events for signing a petition.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonPetition(sender As System.Object, e As System.EventArgs) Handles btn_petition.Click
        If Not meetCriterian(2) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.petitionPrice
        tmr_petition.Enabled = True
        bar_petition.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_petition.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerPetition(sender As System.Object, e As System.EventArgs) Handles tmr_petition.Tick
        GlobalConstants.coins += GlobalConstants.petitionProfit
        pb_prog_petition.Value = 0
        tmr_petition.Enabled = False
        bar_petition.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_petition.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barPetition(sender As System.Object, e As System.EventArgs) Handles bar_petition.Tick
        pb_prog_petition.Increment(14)
    End Sub
#End Region
#Region "Wildlife Exploration"

    ''' <summary>
    ''' Triggers the events for wildlife exploration.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonExploration(sender As System.Object, e As System.EventArgs) Handles btn_we.Click
        If Not meetCriterian(3) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.wildlifePrice
        tmr_wildlife.Enabled = True
        bar_we.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_we.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerExploration(sender As System.Object, e As System.EventArgs) Handles tmr_wildlife.Tick
        GlobalConstants.coins += GlobalConstants.wildlifeProfit
        pb_prog_we.Value = 0
        tmr_wildlife.Enabled = False
        bar_we.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_we.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barExploration(sender As System.Object, e As System.EventArgs) Handles bar_we.Tick
        pb_prog_we.Increment(10)
    End Sub
#End Region
#Region "Filter Water"

    ''' <summary>
    ''' Triggers the events for filter water.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonFilter(sender As System.Object, e As System.EventArgs) Handles btn_filter.Click
        If Not meetCriterian(4) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.filterPrice
        tmr_filter.Enabled = True
        bar_filter.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_filter.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerFilter(sender As System.Object, e As System.EventArgs) Handles tmr_filter.Tick
        GlobalConstants.coins += GlobalConstants.filterProfit
        pb_prog_filter.Value = 0
        tmr_filter.Enabled = False
        bar_filter.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_filter.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barFilter(sender As System.Object, e As System.EventArgs) Handles bar_filter.Tick
        pb_prog_we.Increment(Int(pb_prog_we.Maximum / tmr_filter.Interval))
    End Sub
#End Region
#Region "Coconut Essence"

    ''' <summary>
    ''' Triggers the events for coconut.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonCoconut(sender As System.Object, e As System.EventArgs) Handles btn_coconut.Click
        If Not meetCriterian(5) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.coconutPrice
        tmr_coconut.Enabled = True
        bar_coconut.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_coconut.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerCoconut(sender As System.Object, e As System.EventArgs) Handles tmr_coconut.Tick
        GlobalConstants.coins += GlobalConstants.coconutProfit
        pb_prog_coconut.Value = 0
        tmr_coconut.Enabled = False
        bar_coconut.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_coconut.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barCoconut(sender As System.Object, e As System.EventArgs) Handles bar_coconut.Tick
        pb_prog_coconut.Increment(1)
    End Sub
#End Region
#Region "Make Chocolate"

    ''' <summary>
    ''' Triggers the events for making chocolate.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub buttonChocolate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_chocolate.Click
        If Not meetCriterian(5) Then
            Return
        End If

        GlobalConstants.coins -= GlobalConstants.chocolatePrice
        tmr_chocolate.Enabled = True
        bar_chocolate.Enabled = True
    End Sub

    ''' <summary>
    ''' Counts to <code>tmr_chocolate.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub timerChocolate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_chocolate.Tick
        GlobalConstants.coins += GlobalConstants.chocolateProfit
        pb_prog_chocolate.Value = 0
        tmr_chocolate.Enabled = False
        bar_chocolate.Enabled = False
    End Sub

    ''' <summary>
    ''' Counts to <code>bar_chocolate.Interval</code> before executing code inside.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The reaction.</param>
    ''' <remarks></remarks>
    Private Sub barChocolate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bar_chocolate.Tick
        pb_prog_chocolate.Increment(5)
    End Sub
#End Region

    ''' <summary>
    ''' Opens our shop.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub openShop(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_shop.Click
        Shop.Show()
    End Sub

    ''' <summary>
    ''' The main process.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub process(sender As System.Object, e As System.EventArgs) Handles globaltime.Tick
        If GlobalConstants.treeAutomatic Then
            tmr_pat.Start()
        End If

        If GlobalConstants.animalAutomatic Then
            tmr_animal.Start()
            bar_animal.Start()
        End If

        Select Case GlobalConstants.prestige
            Case 1
                rhino.Visible = True
            Case 3
                tiger.Visible = True
            Case 5
                pb_elephant.Visible = True
            Case 6
                globaltime.Stop()
                MessageBox.Show("You saved the rainforest and have thus completed this demo!")
        End Select

        'Update values on the toolbar.
        lblCoins.Text = GlobalConstants.coins.ToString
        lblPrestige.Text = GlobalConstants.prestige.ToString
    End Sub

    ''' <summary>
    ''' Opens the cheat menu.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub openCheatMenu(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCheat.LinkClicked
        Cheat.Show()
    End Sub
End Class
