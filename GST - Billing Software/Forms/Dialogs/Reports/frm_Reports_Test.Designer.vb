Namespace Forms.Dialogs.Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Frm_Reports_Test
        Inherits Classes.XtraFormTemp

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reports_Test))
            Me.btn_DeliveryChallan_JobWork = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_DeliveryChallan_Supply = New DevExpress.XtraEditors.SimpleButton()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.btn_TaxInvoice = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_JobWorkTaxInvoice = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_GoodsReceipt = New DevExpress.XtraEditors.SimpleButton()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btn_DeliveryChallan_JobWork
            '
            Me.btn_DeliveryChallan_JobWork.Location = New System.Drawing.Point(3, 3)
            Me.btn_DeliveryChallan_JobWork.Name = "btn_DeliveryChallan_JobWork"
            Me.btn_DeliveryChallan_JobWork.Size = New System.Drawing.Size(155, 23)
            Me.btn_DeliveryChallan_JobWork.TabIndex = 0
            Me.btn_DeliveryChallan_JobWork.Text = "Delivery Challan for Job Work"
            '
            'btn_DeliveryChallan_Supply
            '
            Me.btn_DeliveryChallan_Supply.Location = New System.Drawing.Point(164, 3)
            Me.btn_DeliveryChallan_Supply.Name = "btn_DeliveryChallan_Supply"
            Me.btn_DeliveryChallan_Supply.Size = New System.Drawing.Size(209, 23)
            Me.btn_DeliveryChallan_Supply.TabIndex = 0
            Me.btn_DeliveryChallan_Supply.Text = "Delivery Challan for Supply on Approval"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.btn_DeliveryChallan_JobWork)
            Me.FlowLayoutPanel1.Controls.Add(Me.btn_DeliveryChallan_Supply)
            Me.FlowLayoutPanel1.Controls.Add(Me.btn_TaxInvoice)
            Me.FlowLayoutPanel1.Controls.Add(Me.btn_JobWorkTaxInvoice)
            Me.FlowLayoutPanel1.Controls.Add(Me.btn_GoodsReceipt)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(425, 111)
            Me.FlowLayoutPanel1.TabIndex = 1
            '
            'btn_TaxInvoice
            '
            Me.btn_TaxInvoice.Location = New System.Drawing.Point(3, 32)
            Me.btn_TaxInvoice.Name = "btn_TaxInvoice"
            Me.btn_TaxInvoice.Size = New System.Drawing.Size(75, 23)
            Me.btn_TaxInvoice.TabIndex = 1
            Me.btn_TaxInvoice.Text = "Tax Invoice"
            '
            'btn_JobWorkTaxInvoice
            '
            Me.btn_JobWorkTaxInvoice.Location = New System.Drawing.Point(84, 32)
            Me.btn_JobWorkTaxInvoice.Name = "btn_JobWorkTaxInvoice"
            Me.btn_JobWorkTaxInvoice.Size = New System.Drawing.Size(121, 23)
            Me.btn_JobWorkTaxInvoice.TabIndex = 2
            Me.btn_JobWorkTaxInvoice.Text = "Job Work Tax Invoice"
            '
            'btn_GoodsReceipt
            '
            Me.btn_GoodsReceipt.Location = New System.Drawing.Point(211, 32)
            Me.btn_GoodsReceipt.Name = "btn_GoodsReceipt"
            Me.btn_GoodsReceipt.Size = New System.Drawing.Size(89, 23)
            Me.btn_GoodsReceipt.TabIndex = 3
            Me.btn_GoodsReceipt.Text = "Goods Receipt"
            '
            'Frm_Reports_Test
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(425, 111)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Frm_Reports_Test"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Reports Test/Demo"
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btn_DeliveryChallan_JobWork As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_DeliveryChallan_Supply As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents btn_TaxInvoice As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_JobWorkTaxInvoice As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_GoodsReceipt As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace