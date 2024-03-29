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

Namespace Forms.Dialogs.Reports
    Public Class Frm_Reports_Test

#Region "Subs"
        Sub ShowDeliveryChallan(ByVal Type As Classes.Enums.DeliveryChallanType)
            Dim Sender_ As New Classes.Objects.Sender(1, "ABC Enterprise", "33AAAAA9874S1Z2", New Classes.Objects.Address("12/5, Townhall", "Ukkadam", "Coimbatore", 641001, Classes.Objects.States.GetAllStates(32)), "9876543210", Nothing)
            Dim Receiver As New Classes.Objects.Party(1, "XYZ", "33AAAAA4715R1ZA", New Classes.Objects.Address("14, 100ft Road", "Gandhipuram", "Coimbatore", 641105, Classes.Objects.States.GetAllStates(32)), "7986522341")
            Dim Items As New List(Of Classes.Invoices.DeliveryChallan.Item)({
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 8, 6.25, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 6, 7.5, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9, 3.89, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 3, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10, 1, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 10, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 8, 6.25, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 6, 7.5, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9, 3.89, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 3, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10, 1, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 10, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 8, 6.25, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 6, 7.5, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9, 3.89, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 3, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10, 1, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 10, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 8, 6.25, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 6, 7.5, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9, 3.89, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 3, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10, 1, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 10, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 8, 6.25, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 6, 7.5, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9, 3.89, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 3, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10, 1, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5, 10, 50)
                                                                        })
            Dim User As New Classes.Objects.User(1, "Dineshkumar T", "Dev", "Developer", New Date(1999, 4, 29), New Date(2018, 1, 1), New Classes.Objects.Address, "8056684414", Nothing)
            Dim DC As New Classes.Invoices.DeliveryChallan.Voucher(1, "DC-0001", Now, Sender_, Receiver, Items, User, Type)

            Dim Report As New DeliveryChallan With {.DataMember = "Goods"}
            Report.BindingSource1.DataSource = DC
            Dim D As New frm_ReportViewer(Report)
            D.ShowDialog()
        End Sub

        Sub ShowTaxInvoice(ByVal Type As Classes.Enums.TaxInvoiceType)
            Dim Sender_ As New Classes.Objects.Sender(1, "ABC Enterprise", "33AAAAA9874S1Z2", New Classes.Objects.Address("12/5, Townhall", "Ukkadam", "Coimbatore", 641001, Classes.Objects.States.GetAllStates(32)), "9876543210", Nothing)
            Dim Receiver As New Classes.Objects.Party(1, "XYZ", "33AAAAA4715R1ZA", New Classes.Objects.Address("14, 100ft Road", "Gandhipuram", "Coimbatore", 641105, Classes.Objects.States.GetAllStates(32)), "7986522341")
            Dim Consignee As New Classes.Objects.Party(1, "ZYX", "32BBBBB8417D2Z1", New Classes.Objects.Address("MP 13/1388", "Valliyoorkavu Road", "Manathavady", 670645, Classes.Objects.States.GetAllStates(32)), "8744785142")
            Dim Items As New List(Of Classes.Invoices.TaxInvoice.Item)({
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 8, 6.25, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 6, 7.5, 45),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 9, 3.89, 35),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 5, 3, 15),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 10, 1, 10),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 5, 10, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 8, 6.25, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 6, 7.5, 45),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 9, 3.89, 35),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 5, 3, 15),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 10, 1, 10),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 5, 10, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 8, 6.25, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 6, 7.5, 45),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 9, 3.89, 35),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 5, 3, 15),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 10, 1, 10),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 5, 10, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 8, 6.25, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 6, 7.5, 45),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 9, 3.89, 35),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 5, 3, 15),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 10, 1, 10),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 5, 10, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 8, 6.25, 50),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 6, 7.5, 45),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 9, 3.89, 35),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 5), 5, 3, 15),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 12), 10, 1, 10),
                                                                        New Classes.Invoices.TaxInvoice.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 18), 5, 10, 50)
                                                                        })
            Dim User As New Classes.Objects.User(1, "Dineshkumar T", "Dev", "Developer", New Date(1999, 4, 29), New Date(2018, 1, 1), New Classes.Objects.Address, "8056684414", Nothing)
            Dim Invoice As New Classes.Invoices.TaxInvoice.Voucher(1, "INV-0001", Now, Sender_, Receiver, Consignee, Items, User, Type)

            Dim Report As New TaxInvoice With {.DataMember = "Goods"}
            Report.BindingSource1.DataSource = Invoice
            Dim D As New frm_ReportViewer(Report)
            D.ShowDialog()
        End Sub

        Sub ShowGoodsReceipt()
            Dim Receiver As New Classes.Objects.Sender(1, "ABC Enterprise", "33AAAAA9874S1Z2", New Classes.Objects.Address("12/5, Townhall", "Ukkadam", "Coimbatore", 641001, Classes.Objects.States.GetAllStates(32)), "9876543210", Nothing)
            Dim Consignor As New Classes.Objects.Party(1, "XYZ", "33AAAAA4715R1ZA", New Classes.Objects.Address("14, 100ft Road", "Gandhipuram", "Coimbatore", 641105, Classes.Objects.States.GetAllStates(32)), "7986522341")
            Dim Items As New List(Of Classes.Invoices.GoodsReceipt.Item)({
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.5, 10.4, 6.25, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.4, 7.5, 7.5, 45),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9.7, 9.6, 3.89, 35),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5.5, 5.4, 3, 15),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.1, 10, 1, 10),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.5, 7.4, 10, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.5, 10.4, 6.25, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.4, 7.5, 7.5, 45),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9.7, 9.6, 3.89, 35),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5.5, 5.4, 3, 15),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.1, 10, 1, 10),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.5, 7.4, 10, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.5, 10.4, 6.25, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.4, 7.5, 7.5, 45),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9.7, 9.6, 3.89, 35),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5.5, 5.4, 3, 15),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.1, 10, 1, 10),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.5, 7.4, 10, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.5, 10.4, 6.25, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.4, 7.5, 7.5, 45),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9.7, 9.6, 3.89, 35),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5.5, 5.4, 3, 15),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.1, 10, 1, 10),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.5, 7.4, 10, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.5, 10.4, 6.25, 50),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.4, 7.5, 7.5, 45),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 9.7, 9.6, 3.89, 35),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 5.5, 5.4, 3, 15),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 10.1, 10, 1, 10),
                                                                        New Classes.Invoices.GoodsReceipt.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10), 0), 7.5, 7.4, 10, 50)
                                                                        })
            Dim User As New Classes.Objects.User(1, "Dineshkumar T", "Dev", "Developer", New Date(1999, 4, 29), New Date(2018, 1, 1), New Classes.Objects.Address, "8056684414", Nothing)
            Dim GR As New Classes.Invoices.GoodsReceipt.Voucher(1, "DC-0001", Now, Receiver, Consignor, Items, User, 15)

            Dim Report As New GoodsReceipt With {.DataMember = "Goods"}
            Report.Source.DataSource = GR
            Dim D As New frm_ReportViewer(Report)
            D.ShowDialog()
        End Sub
#End Region

#Region "Events"
        Private Sub Btn_DeliveryChallan_JobWork_Click(sender As Object, e As EventArgs) Handles btn_DeliveryChallan_JobWork.Click
            ShowDeliveryChallan(Classes.Enums.DeliveryChallanType.JobWork)
        End Sub

        Private Sub Btn_DeliveryChallan_Supply_Click(sender As Object, e As EventArgs) Handles btn_DeliveryChallan_Supply.Click
            ShowDeliveryChallan(Classes.Enums.DeliveryChallanType.SupplyOnApproval)
        End Sub

        Private Sub Btn_TaxInvoice_Click(sender As Object, e As EventArgs) Handles btn_TaxInvoice.Click
            ShowTaxInvoice(Classes.Enums.TaxInvoiceType.Normal)
        End Sub

        Private Sub Btn_JobWorkTaxInvoice_Click(sender As Object, e As EventArgs) Handles btn_JobWorkTaxInvoice.Click
            ShowTaxInvoice(Classes.Enums.TaxInvoiceType.JobWork)
        End Sub

        Private Sub Btn_GoodsReceipt_Click(sender As Object, e As EventArgs) Handles btn_GoodsReceipt.Click
            ShowGoodsReceipt()
        End Sub
#End Region

    End Class
End Namespace