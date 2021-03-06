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
Public Class Utilities

    ''' <summary>
    ''' Converts millseconds into seconds.
    ''' </summary>
    ''' <param name="milliseconds">The milliseconds to convert.</param>
    ''' <returns>The seconds.</returns>
    ''' <remarks></remarks>
    Public Shared Function toSeconds(ByVal milliseconds As Integer) As Double
        Return milliseconds / 1000
    End Function
End Class
