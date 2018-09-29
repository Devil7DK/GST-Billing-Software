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
    Public Class Address

#Region "Fields/Properties"
        <DisplayName("Address Line 1")>
        Property AddressLine1 As String
        <DisplayName("Address Line 2")>
        Property AddressLine2 As String
        Property City As String
        <DisplayName("PIN Code")>
        Property PinCode As Integer
        Property State As State

        ReadOnly Property Address As String
            Get
                Return String.Join(vbNewLine, AddressLine1, AddressLine2, String.Format("{0} - {1}", City, PinCode.ToString("000000")), State.ToString)
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New()
            Me.AddressLine1 = ""
            Me.AddressLine2 = ""
            Me.City = ""
            Me.PinCode = 0
            Me.State = New State
        End Sub

        Sub New(ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As Integer, ByVal State As State)
            Me.AddressLine1 = AddressLine1
            Me.AddressLine2 = AddressLine2
            Me.City = City
            Me.PinCode = PinCode
            Me.State = State
        End Sub
#End Region

#Region "Subs/Functions"
        Public Overrides Function ToString() As String
            Return Address
        End Function
#End Region

    End Class
End Namespace