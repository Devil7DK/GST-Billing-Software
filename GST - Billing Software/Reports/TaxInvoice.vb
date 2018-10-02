Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class TaxInvoice

    Private Sub Lbl_PageNumber_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles lbl_PageNumber.PrintOnPage
        lbl_PageNumber.Visible = e.PageCount > 1
    End Sub

    Private Sub TaxInvoice_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Dim TI As Classes.Invoices.TaxInvoice.Voucher = BindingSource1.DataSource

        If TI.Sender.Address.State.Code = TI.Receiver.Address.State.Code Then
            table_Total.DeleteRow(row_IGST)
        Else
            table_Total.DeleteRow(row_CGST)
            table_Total.DeleteRow(row_SGST)
        End If
    End Sub

End Class