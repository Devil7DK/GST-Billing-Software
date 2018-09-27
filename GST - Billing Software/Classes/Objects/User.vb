'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Namespace Classes.Objects
    Public Class User

#Region "Fields/Properties"
        Property ID As Integer
        Property FullName As String
        Property Username As String
        Property Position As String
        Property DOB As Date
        Property JoinDate As Date
        Property Address As Address
        Property Mobile As String
        Property Picture As Image
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.FullName = ""
            Me.Username = ""
            Me.Position = ""
            Me.DOB = Now
            Me.JoinDate = Now
            Me.Address = New Address
            Me.Picture = My.Resources.staff_128x128
        End Sub

        Sub New(ByVal ID As Integer, ByVal FullName As String, ByVal Username As String, ByVal Position As String, ByVal DOB As Date, ByVal JoinDate As Date, ByVal Address As Address, ByVal Mobile As String, ByVal Picture As Image)
            Me.ID = ID
            Me.FullName = FullName
            Me.Username = Username
            Me.Position = Position
            Me.DOB = DOB
            Me.JoinDate = JoinDate
            Me.Address = Address
            Me.Picture = Picture
        End Sub
#End Region

#Region "Subs/Functions"
        Public Overrides Function ToString() As String
            Return Username
        End Function
#End Region

    End Class
End Namespace