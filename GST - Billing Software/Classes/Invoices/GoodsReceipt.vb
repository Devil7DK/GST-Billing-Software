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

Namespace Classes.Invoices.GoodsReceipt
    Public Class Voucher

#Region "Fields/Properties"
        <Browsable(False)>
        Property ID As Integer
        <DisplayName("Serial Number")>
        Property SerialNo As String
        <DisplayName("Voucher Date")>
        Property VoucherDate As Date
        Property Sender As Sender
        <DisplayName("Shipped from")>
        Property Consignor As Party
        <DisplayName("List of Goods")>
        Property Goods As List(Of Item)
        Property User As User
        Property TaxRate As Integer = 0
        ReadOnly Property IGST As Double
            Get
                Return GrossTotal * (TaxRate / 100)
            End Get
        End Property
        ReadOnly Property CGST As Double
            Get
                Return GrossTotal * ((TaxRate / 2) / 100)
            End Get
        End Property
        ReadOnly Property SGST As Double
            Get
                Return CGST
            End Get
        End Property
        <DisplayName("Gross Total")>
        ReadOnly Property GrossTotal As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.MakingCharges
                Next
                Return R
            End Get
        End Property

        ReadOnly Property Total As Double
            Get
                Return GrossTotal + IGST
            End Get
        End Property
        <DisplayName("Amount in Words")>
        ReadOnly Property AmountInWords As String
            Get
                Return Misc.AmountInWords(Total).Trim
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.SerialNo = "GR-0001"
            Me.VoucherDate = Now
            Me.Sender = New Sender
            Me.Consignor = New Party
            Me.Goods = New List(Of Item)
            Me.User = New User
            Me.TaxRate = 0
        End Sub
        Sub New(ByVal ID As Integer, ByVal SerialNo As String, ByVal VoucherDate As Date, ByVal Sender As Sender, ByVal Consignor As Party, ByVal Goods As List(Of Item), ByVal User As User, ByVal TaxRate As Integer)
            Me.ID = ID
            Me.SerialNo = SerialNo
            Me.VoucherDate = VoucherDate
            Me.Sender = Sender
            Me.Consignor = Consignor
            Me.Goods = Goods
            Me.User = User
            Me.TaxRate = TaxRate
        End Sub
#End Region

    End Class

    Public Class Item

#Region "Fields/Properties"
        Property Good As Good
        <DisplayName("Gross Weight")>
        Property GrossWeight As Double
        <DisplayName("Net Weight")>
        Property NetWeight As Double
        Property Rate As Double = 0
        <DisplayName("Making Charges")>
        Property MakingCharges As Double
#End Region

#Region "Constructors"
        Sub New(ByVal Good As Good, ByVal GrossWeight As Double, ByVal NetWeight As Double, ByVal Rate As Double, ByVal MakingCharges As Double)
            Me.Good = Good
            Me.GrossWeight = GrossWeight
            Me.NetWeight = NetWeight
            Me.Rate = Rate
            Me.MakingCharges = MakingCharges
        End Sub

        Sub New()
            Me.Good = New Good
            Me.GrossWeight = 0
            Me.NetWeight = 0
            Me.Rate = 0
            Me.MakingCharges = 0
        End Sub
#End Region

    End Class
End Namespace