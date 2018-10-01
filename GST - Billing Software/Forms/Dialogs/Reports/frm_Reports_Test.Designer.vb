Namespace Forms.Dialogs.Reports
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Reports_Test
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reports_Test))
            Me.btn_DeliveryChallan_JobWork = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_DeliveryChallan_Supply = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'btn_DeliveryChallan_JobWork
            '
            Me.btn_DeliveryChallan_JobWork.Location = New System.Drawing.Point(12, 12)
            Me.btn_DeliveryChallan_JobWork.Name = "btn_DeliveryChallan_JobWork"
            Me.btn_DeliveryChallan_JobWork.Size = New System.Drawing.Size(155, 23)
            Me.btn_DeliveryChallan_JobWork.TabIndex = 0
            Me.btn_DeliveryChallan_JobWork.Text = "Delivery Challan for Job Work"
            '
            'btn_DeliveryChallan_Supply
            '
            Me.btn_DeliveryChallan_Supply.Location = New System.Drawing.Point(173, 12)
            Me.btn_DeliveryChallan_Supply.Name = "btn_DeliveryChallan_Supply"
            Me.btn_DeliveryChallan_Supply.Size = New System.Drawing.Size(209, 23)
            Me.btn_DeliveryChallan_Supply.TabIndex = 0
            Me.btn_DeliveryChallan_Supply.Text = "Delivery Challan for Supply on Approval"
            '
            'frm_Reports_Test
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(425, 111)
            Me.Controls.Add(Me.btn_DeliveryChallan_Supply)
            Me.Controls.Add(Me.btn_DeliveryChallan_JobWork)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_Reports_Test"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Reports Test/Demo"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btn_DeliveryChallan_JobWork As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_DeliveryChallan_Supply As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace