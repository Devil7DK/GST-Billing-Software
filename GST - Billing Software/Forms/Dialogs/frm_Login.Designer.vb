Namespace Forms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Login
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
            Me.pic_SidePanel = New System.Windows.Forms.PictureBox()
            Me.lbl_Username = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Username = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
            Me.btn_Login = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
            Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
            CType(Me.pic_SidePanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pic_SidePanel
            '
            Me.pic_SidePanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.pic_SidePanel.Image = Global.Devil7.Billing.GST.My.Resources.Resources.secure_screen
            Me.pic_SidePanel.Location = New System.Drawing.Point(0, 0)
            Me.pic_SidePanel.Name = "pic_SidePanel"
            Me.pic_SidePanel.Size = New System.Drawing.Size(130, 141)
            Me.pic_SidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pic_SidePanel.TabIndex = 0
            Me.pic_SidePanel.TabStop = False
            '
            'lbl_Username
            '
            Me.lbl_Username.Location = New System.Drawing.Point(142, 12)
            Me.lbl_Username.Name = "lbl_Username"
            Me.lbl_Username.Size = New System.Drawing.Size(48, 13)
            Me.lbl_Username.TabIndex = 1
            Me.lbl_Username.Text = "Username"
            '
            'txt_Username
            '
            Me.txt_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Username.EditValue = ""
            Me.txt_Username.EnterMoveNextControl = True
            Me.txt_Username.Location = New System.Drawing.Point(142, 31)
            Me.txt_Username.Name = "txt_Username"
            Me.txt_Username.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txt_Username.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.txt_Username.Size = New System.Drawing.Size(248, 20)
            Me.txt_Username.TabIndex = 0
            '
            'lbl_Password
            '
            Me.lbl_Password.Location = New System.Drawing.Point(142, 57)
            Me.lbl_Password.Name = "lbl_Password"
            Me.lbl_Password.Size = New System.Drawing.Size(46, 13)
            Me.lbl_Password.TabIndex = 3
            Me.lbl_Password.Text = "Password"
            '
            'txt_Password
            '
            Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txt_Password.Location = New System.Drawing.Point(142, 76)
            Me.txt_Password.Name = "txt_Password"
            Me.txt_Password.Properties.UseSystemPasswordChar = True
            Me.txt_Password.Size = New System.Drawing.Size(248, 20)
            Me.txt_Password.TabIndex = 1
            '
            'btn_Login
            '
            Me.btn_Login.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btn_Login.Location = New System.Drawing.Point(315, 106)
            Me.btn_Login.Name = "btn_Login"
            Me.btn_Login.Size = New System.Drawing.Size(75, 23)
            Me.btn_Login.TabIndex = 2
            Me.btn_Login.Text = "Login"
            '
            'btn_Cancel
            '
            Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btn_Cancel.Location = New System.Drawing.Point(142, 106)
            Me.btn_Cancel.Name = "btn_Cancel"
            Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
            Me.btn_Cancel.TabIndex = 3
            Me.btn_Cancel.Text = "Cancel"
            '
            'ProgressPanel
            '
            Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ProgressPanel.Appearance.Options.UseBackColor = True
            Me.ProgressPanel.BarAnimationElementThickness = 2
            Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ProgressPanel.Description = "Validating Credentials..."
            Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProgressPanel.Location = New System.Drawing.Point(130, 0)
            Me.ProgressPanel.Name = "ProgressPanel"
            Me.ProgressPanel.Size = New System.Drawing.Size(272, 141)
            Me.ProgressPanel.TabIndex = 4
            Me.ProgressPanel.Visible = False
            Me.ProgressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
            '
            'frm_Login
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(402, 141)
            Me.ControlBox = False
            Me.Controls.Add(Me.ProgressPanel)
            Me.Controls.Add(Me.btn_Cancel)
            Me.Controls.Add(Me.btn_Login)
            Me.Controls.Add(Me.txt_Password)
            Me.Controls.Add(Me.lbl_Password)
            Me.Controls.Add(Me.txt_Username)
            Me.Controls.Add(Me.lbl_Username)
            Me.Controls.Add(Me.pic_SidePanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frm_Login"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            CType(Me.pic_SidePanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pic_SidePanel As PictureBox
        Friend WithEvents lbl_Username As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Username As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
        Friend WithEvents btn_Login As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    End Class
End Namespace