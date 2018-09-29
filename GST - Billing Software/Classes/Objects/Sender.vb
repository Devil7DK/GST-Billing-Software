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
'                                                                          '
'=========================================================================='

Imports System.ComponentModel

Namespace Classes.Objects
    Public Class Sender

#Region "Fields/Properties"
        <Browsable(False)>
        Property ID As Integer
        Property Name As String
        Property GSTIN As String
        Property Address As Address
        Property Mobile As String
        ReadOnly Property State As State
            Get
                Return If(Address Is Nothing, New State, Address.State)
            End Get
        End Property
        <DisplayName("State Code")>
        ReadOnly Property StateCode As Integer
            Get
                Return If(Address Is Nothing, 0, Address.State.Code)
            End Get
        End Property
        Property Logo As Image
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.Name = ""
            Me.GSTIN = ""
            Me.Address = New Address
            Me.Mobile = ""
            Me.Logo = GenerateLogo("")
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal GSTIN As String, ByVal Address As Address, ByVal Mobile As String, ByVal Logo As Image)
            Me.ID = ID
            Me.Name = Name
            Me.GSTIN = GSTIN
            Me.Address = Address
            Me.Mobile = Mobile
            Me.Logo = If(Logo IsNot Nothing, Logo, GenerateLogo(Name))
        End Sub
#End Region


    End Class
End Namespace