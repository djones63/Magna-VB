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
Public Class GlobalConstants

#Region "Tree"
    Public Shared treePrice = 0
    Public Shared treeProfit = 1 * treeMultiplier
    Public Shared treeAutomatic = False
    Public Shared treeMultiplier = 1
#End Region

#Region "Save An Animal"
    Public Shared animalPrice = 3
    Public Shared animalProfit = 5
    Public Shared animalAutomatic = False
    Public Shared animalMultiplier = 1
#End Region

#Region "Sign a Petition"
    Public Shared petitionPrice = 5
    Public Shared petitionProfit = 10
    Public Shared petitionAutomatic = False
    Public Shared petitionMultiplier = 1
#End Region

#Region "Wildlife Exploration"
    Public Shared wildlifePrice = 13
    Public Shared wildlifeProfit = 25
    Public Shared wildlifeAutomatic = False
    Public Shared wildlifeMultiplier = 1
#End Region

#Region "Filter Water"
    Public Shared filterPrice = 178
    Public Shared filterProfit = 180
    Public Shared filterutomatic = False
    Public Shared filterMultiplier = 1
#End Region

#Region "Coconut Essence"
    Public Shared coconutPrice = 234
    Public Shared coconutProfit = 250
    Public Shared coconutAutomatic = False
    Public Shared coconutMultiplier = 1
#End Region

#Region "Make Chocolate"
    Public Shared chocolatePrice = 404
    Public Shared chocolateProfit = 500
    Public Shared chocolateAutomatic = False
    Public Shared chocolateMultiplier = 1
#End Region

#Region "Protect a tribe"
    Public Shared tribePrice = 506
    Public Shared tribeProfit = 800
    Public Shared tribeAutomatic = False
    Public Shared tribeMultiplier = 1
#End Region

#Region "Extract Oil"
    Public Shared oilPrice = 1000
    Public Shared oilProfit = 1250
    Public Shared oilAutomatic = False
    Public Shared oilMultiplier = 1
#End Region

    'If the player is in developer mode.
    Public Shared developerMode As Boolean

    'How many coins the player has.
    Public Shared coins As Integer = 0

    'What prestige the player is.
    Public Shared prestige As Integer = 0
End Class
