Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class DeliveryChallan

    Private Sub lbl_PageNumber_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles lbl_PageNumber.PrintOnPage
        lbl_PageNumber.Visible = e.PageCount > 1
    End Sub

    Private Sub DeliveryChallan_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim ShowRate As Boolean = False
        Dim DC As Classes.Invoices.DeliveryChallan.Voucher = BindingSource1.DataSource

        Select Case DC.TypeE
            Case Classes.Enums.DeliveryChallanType.JobWork
                ShowRate = My.Settings.ShowRateForJobWork
            Case Classes.Enums.DeliveryChallanType.forSupplyOnApproval
                ShowRate = My.Settings.ShowRateForSupplyOnApproval
        End Select

        If Not ShowRate Then
            table_Header.DeleteCell(cell_Rate_Header)
            cell_Rate_Item.Row.DeleteCell(cell_Rate_Item)
        End If
    End Sub

End Class