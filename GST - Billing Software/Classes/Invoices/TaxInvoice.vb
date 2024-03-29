﻿'=========================================================================='
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

Namespace Classes.Invoices.TaxInvoice
    Public Class Voucher

#Region "Variables"
        ReadOnly Type_ As Enums.TaxInvoiceType = Enums.TaxInvoiceType.Normal
#End Region

#Region "Fields/Properties"
        <Browsable(False)>
        Property ID As Integer
        <DisplayName("Serial Number")>
        Property SerialNo As String
        <DisplayName("Voucher Date")>
        Property VoucherDate As Date
        Property Sender As Sender
        <DisplayName("Billed to")>
        Property Receiver As Party
        <DisplayName("Shipped to")>
        Property Consignee As Party
        <DisplayName("List of Goods")>
        Property Goods As List(Of Item)
        Property User As User
        <DisplayName("Gross Total")>
        ReadOnly Property GrossTotal As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.Value
                Next
                Return R
            End Get
        End Property
        <DisplayName("Total IGST")>
        ReadOnly Property TotalIGST As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.IGST
                Next
                Return R
            End Get
        End Property
        <DisplayName("Total CGST")>
        ReadOnly Property TotalCGST As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.CGST
                Next
                Return R
            End Get
        End Property
        <DisplayName("Total SGST")>
        ReadOnly Property TotalSGST As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.SGST
                Next
                Return R
            End Get
        End Property
        ReadOnly Property Total As Double
            Get
                Dim R As Double = 0
                For Each i As Item In Goods
                    R += i.Value + i.IGST
                Next
                Return R
            End Get
        End Property

        <DisplayName("Amount in Words")>
        ReadOnly Property AmountInWords As String
            Get
                Return Misc.AmountInWords(Total).Trim
            End Get
        End Property
        <DisplayName("Invoice Type")>
        ReadOnly Property Type As String
            Get
                Dim R As String = "Tax Invoice"
                Select Case Type_
                    Case Enums.TaxInvoiceType.Normal
                        R = "Tax Invoice"
                    Case Enums.DeliveryChallanType.SupplyOnApproval
                        R = "Job Work Tax Invoice"
                End Select
                Return R
            End Get
        End Property
        <Browsable(False)>
        ReadOnly Property TypeE As Enums.DeliveryChallanType
            Get
                Return Type_
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New()
            Me.ID = -1
            Me.SerialNo = "0"
            Me.VoucherDate = Now
            Me.Sender = New Sender
            Me.Receiver = New Party
            Me.Consignee = New Party
            Me.Goods = New List(Of Item)
            Me.User = New User
            Me.Type_ = Enums.TaxInvoiceType.Normal
        End Sub
        Sub New(ByVal ID As Integer, ByVal SerialNo As String, ByVal VoucherDate As Date, ByVal Sender As Sender, ByVal Receiver As Party, ByVal Consignee As Party, ByVal Goods As List(Of Item), ByVal User As User, ByVal Type As Enums.TaxInvoiceType)
            Me.ID = ID
            Me.SerialNo = SerialNo
            Me.VoucherDate = VoucherDate
            Me.Sender = Sender
            Me.Consignee = Consignee
            Me.Receiver = Receiver
            Me.Goods = Goods
            Me.User = User
            Me.Type_ = Type
        End Sub
#End Region

    End Class

    Public Class Item

#Region "Fields/Properties"
        Property Good As Good
        Property Quantity As Double
        Property Rate As Double = 0
        <DisplayName("Taxable Value")>
        Property Value As Double
        ReadOnly Property CGST As Double
            Get
                Return Value * ((Good.TaxPercentage / 2) / 100)
            End Get
        End Property
        ReadOnly Property SGST As Double
            Get
                Return Value * ((Good.TaxPercentage / 2) / 100)
            End Get
        End Property
        ReadOnly Property IGST As Double
            Get
                Return Value * (Good.TaxPercentage / 100)
            End Get
        End Property
#End Region

#Region "Constructors"
        Sub New(ByVal Good As Good, ByVal Quantity As Double, ByVal Rate As Double, ByVal Value As Double)
            Me.Good = Good
            Me.Quantity = Quantity
            Me.Value = Value
            Me.Rate = Rate
        End Sub

        Sub New()
            Me.Good = New Good
            Me.Quantity = 0
            Me.Value = 0
            Me.Rate = 0
        End Sub
#End Region

    End Class
End Namespace