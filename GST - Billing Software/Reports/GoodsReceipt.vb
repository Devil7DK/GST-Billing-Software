Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class GoodsReceipt

    Private Sub Lbl_PageNumber_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles lbl_PageNumber.PrintOnPage
        lbl_PageNumber.Visible = e.PageCount > 1
    End Sub

End Class