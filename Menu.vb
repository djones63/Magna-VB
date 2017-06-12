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
Public Class Menu

    ''' <summary>
    ''' Allows for the game to start.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub startClick(sender As System.Object, e As System.EventArgs) Handles lblStart.Click
        Me.Hide()
        Game.Show()
    End Sub

    ''' <summary>
    ''' Toggles developer mode.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub developerMode(sender As System.Object, e As System.EventArgs) Handles cbDeveloperMode.CheckedChanged
        GlobalConstants.developerMode = Not GlobalConstants.developerMode
    End Sub

    ''' <summary>
    ''' Closes the game.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub quitClick(sender As System.Object, e As System.EventArgs) Handles lblQuit.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' What to do on form load.
    ''' </summary>
    ''' <param name="sender">The stimulus.</param>
    ''' <param name="e">The event.</param>
    ''' <remarks></remarks>
    Private Sub initiateForm(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
