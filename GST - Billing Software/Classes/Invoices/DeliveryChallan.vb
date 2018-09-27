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

Imports Devil7.Billing.GST.Classes.Objects
Imports System.ComponentModel

Namespace Classes.Invoices.DeliveryChallan
    Public Class Voucher

#Region "Fields/Properties"
        <Browsable(False)>
        Property ID As Integer
        <DisplayName("Serial Number")>
        Property SerialNo As String
        <DisplayName("Voucher Date")>
        Property VoucherDate As Date
        Property Consignee As Party
        <DisplayName("List of Goods")>
        Property Goods As List(Of Item)
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.SerialNo = "0"
            Me.VoucherDate = Now
            Me.Consignee = New Party
            Me.Goods = New List(Of Item)
        End Sub
        Sub New(ByVal ID As Integer, ByVal SerialNo As String, ByVal VoucherDate As Date, ByVal Consignee As Party, ByVal Goods As List(Of Item))
            Me.ID = ID
            Me.SerialNo = SerialNo
            Me.VoucherDate = VoucherDate
            Me.Consignee = Consignee
            Me.Goods = Goods
        End Sub
#End Region

    End Class

    Public Class Item

#Region "Fields/Properties"
        Property Good As Good
        Property Quantity As Integer
        <DisplayName("Taxable Value")>
        Property Value As Integer
#End Region

#Region "Constructors"
        Sub New(ByVal Good As Good, ByVal Quantity As Integer, ByVal Value As Integer)
            Me.Good = Good
            Me.Quantity = Quantity
            Me.Value = Value
        End Sub

        Sub New()
            Me.Good = New Good
            Me.Quantity = 0
            Me.Value = 0
        End Sub
#End Region

    End Class
End Namespace