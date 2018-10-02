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
    Public Class Good

#Region "Fields/Properties"
        Property ID As Integer
        Property Name As String
        Property HSN As String
        Property Unit As Unit
        Property TaxPercentage As Integer
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.Name = ""
            Me.HSN = ""
            Me.Unit = New Unit
            Me.TaxPercentage = 0
        End Sub

        Sub New(ByVal ID As Integer, ByVal Name As String, ByVal HSN As String, ByVal Unit As Unit, ByVal TaxPercentage As Integer)
            Me.ID = ID
            Me.Name = Name
            Me.HSN = HSN
            Me.Unit = Unit
            Me.TaxPercentage = TaxPercentage
        End Sub
#End Region

    End Class
End Namespace