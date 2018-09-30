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
            Me.btn_DeliveryChallan = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'btn_DeliveryChallan
            '
            Me.btn_DeliveryChallan.Location = New System.Drawing.Point(12, 12)
            Me.btn_DeliveryChallan.Name = "btn_DeliveryChallan"
            Me.btn_DeliveryChallan.Size = New System.Drawing.Size(100, 23)
            Me.btn_DeliveryChallan.TabIndex = 0
            Me.btn_DeliveryChallan.Text = "Delivery Challan"
            '
            'frm_Reports_Test
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(425, 111)
            Me.Controls.Add(Me.btn_DeliveryChallan)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_Reports_Test"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Reports Test/Demo"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btn_DeliveryChallan As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace