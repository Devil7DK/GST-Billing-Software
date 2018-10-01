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

Namespace Forms.Dialogs.Reports
    Public Class frm_Reports_Test

#Region "Events"
        Private Sub btn_DeliveryChallan_Click(sender As Object, e As EventArgs) Handles btn_DeliveryChallan.Click
            Dim Sender_ As New Classes.Objects.Sender(1, "ABC Enterprise", "33AAAAA9874S1Z2", New Classes.Objects.Address("12/5, Townhall", "Ukkadam", "Coimbatore", 641001, Classes.Objects.States.GetAllStates(32)), "9876543210", Nothing)
            Dim Receiver As New Classes.Objects.Party(1, "XYZ", "33AAAAA4715R1ZA", New Classes.Objects.Address("14, 100ft Road", "Gandhipuram", "Coimbatore", 641105, Classes.Objects.States.GetAllStates(32)), "7986522341")
            Dim Items As New List(Of Classes.Invoices.DeliveryChallan.Item)({
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10)), 8, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10)), 6, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10)), 9, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10)), 10, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10)), 8, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10)), 6, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10)), 9, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10)), 10, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(1, "Item1", "7488", Classes.Objects.Units.GetAllUnits(10)), 8, 50),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(2, "Item2", "7488", Classes.Objects.Units.GetAllUnits(10)), 6, 45),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(3, "Item3", "7488", Classes.Objects.Units.GetAllUnits(10)), 9, 35),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(4, "Item4", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 15),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(5, "Item5", "7488", Classes.Objects.Units.GetAllUnits(10)), 10, 10),
                                                                        New Classes.Invoices.DeliveryChallan.Item(New Classes.Objects.Good(6, "Item6", "7488", Classes.Objects.Units.GetAllUnits(10)), 5, 50)
                                                                        })
            Dim User As New Classes.Objects.User(1, "Dineshkumar T", "Dev", "Developer", New Date(1999, 4, 29), New Date(2018, 1, 1), New Classes.Objects.Address, "8056684414", Nothing)
            Dim DC As New Classes.Invoices.DeliveryChallan.Voucher(1, "DC-0001", Now, Sender_, Receiver, Items, User, Classes.Enums.DeliveryChallanType.forSupplyOnApproval)

            Dim Report As New DeliveryChallan
            Report.DataMember = "Goods"
            Report.BindingSource1.DataSource = DC
            Dim D As New frm_ReportViewer(Report)
            D.ShowDialog()
        End Sub
#End Region

    End Class
End Namespace