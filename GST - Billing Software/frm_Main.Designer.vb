<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.MainTab = New DevExpress.XtraTab.XtraTabControl()
        Me.tb_Home = New DevExpress.XtraTab.XtraTabPage()
        Me.tb_DeliveryChallan = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl_DC = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup_DC = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.dt_From_DC = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem_From_DC = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dt_To_DC = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem_To_DC = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btn_Fetch_DC = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem_Fetch_DC = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gc_DC = New DevExpress.XtraGrid.GridControl()
        Me.gv_DC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem_GridControl_DC = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTab.SuspendLayout()
        Me.tb_DeliveryChallan.SuspendLayout()
        CType(Me.LayoutControl_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl_DC.SuspendLayout()
        CType(Me.LayoutControlGroup_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_From_DC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_From_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem_From_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_To_DC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_To_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem_To_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem_Fetch_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem_GridControl_DC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(696, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(696, 31)
        '
        'MainTab
        '
        Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.MainTab.Location = New System.Drawing.Point(0, 143)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.SelectedTabPage = Me.tb_Home
        Me.MainTab.Size = New System.Drawing.Size(696, 275)
        Me.MainTab.TabIndex = 2
        Me.MainTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tb_Home, Me.tb_DeliveryChallan})
        '
        'tb_Home
        '
        Me.tb_Home.Name = "tb_Home"
        Me.tb_Home.Size = New System.Drawing.Size(690, 247)
        Me.tb_Home.Text = "Home"
        '
        'tb_DeliveryChallan
        '
        Me.tb_DeliveryChallan.Controls.Add(Me.LayoutControl_DC)
        Me.tb_DeliveryChallan.Name = "tb_DeliveryChallan"
        Me.tb_DeliveryChallan.Size = New System.Drawing.Size(690, 247)
        Me.tb_DeliveryChallan.Text = "Delivery Challan"
        '
        'LayoutControl_DC
        '
        Me.LayoutControl_DC.Controls.Add(Me.gc_DC)
        Me.LayoutControl_DC.Controls.Add(Me.btn_Fetch_DC)
        Me.LayoutControl_DC.Controls.Add(Me.dt_To_DC)
        Me.LayoutControl_DC.Controls.Add(Me.dt_From_DC)
        Me.LayoutControl_DC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl_DC.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl_DC.Name = "LayoutControl_DC"
        Me.LayoutControl_DC.Root = Me.LayoutControlGroup_DC
        Me.LayoutControl_DC.Size = New System.Drawing.Size(690, 247)
        Me.LayoutControl_DC.TabIndex = 0
        Me.LayoutControl_DC.Text = "LayoutControl1"
        '
        'LayoutControlGroup_DC
        '
        Me.LayoutControlGroup_DC.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup_DC.GroupBordersVisible = False
        Me.LayoutControlGroup_DC.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem_From_DC, Me.LayoutControlItem_To_DC, Me.LayoutControlItem_Fetch_DC, Me.LayoutControlItem_GridControl_DC})
        Me.LayoutControlGroup_DC.Name = "LayoutControlGroup_DC"
        Me.LayoutControlGroup_DC.Size = New System.Drawing.Size(690, 247)
        Me.LayoutControlGroup_DC.TextVisible = False
        '
        'dt_From_DC
        '
        Me.dt_From_DC.EditValue = Nothing
        Me.dt_From_DC.Location = New System.Drawing.Point(74, 12)
        Me.dt_From_DC.MenuManager = Me.RibbonControl
        Me.dt_From_DC.Name = "dt_From_DC"
        Me.dt_From_DC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_From_DC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_From_DC.Size = New System.Drawing.Size(242, 20)
        Me.dt_From_DC.StyleController = Me.LayoutControl_DC
        Me.dt_From_DC.TabIndex = 4
        '
        'LayoutControlItem_From_DC
        '
        Me.LayoutControlItem_From_DC.Control = Me.dt_From_DC
        Me.LayoutControlItem_From_DC.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem_From_DC.Name = "LayoutControlItem_From_DC"
        Me.LayoutControlItem_From_DC.Size = New System.Drawing.Size(308, 26)
        Me.LayoutControlItem_From_DC.Text = "From Date :"
        Me.LayoutControlItem_From_DC.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem_From_DC.TextSize = New System.Drawing.Size(57, 13)
        Me.LayoutControlItem_From_DC.TextToControlDistance = 5
        '
        'dt_To_DC
        '
        Me.dt_To_DC.EditValue = Nothing
        Me.dt_To_DC.Location = New System.Drawing.Point(370, 12)
        Me.dt_To_DC.MenuManager = Me.RibbonControl
        Me.dt_To_DC.Name = "dt_To_DC"
        Me.dt_To_DC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_To_DC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_To_DC.Size = New System.Drawing.Size(249, 20)
        Me.dt_To_DC.StyleController = Me.LayoutControl_DC
        Me.dt_To_DC.TabIndex = 5
        '
        'LayoutControlItem_To_DC
        '
        Me.LayoutControlItem_To_DC.Control = Me.dt_To_DC
        Me.LayoutControlItem_To_DC.Location = New System.Drawing.Point(308, 0)
        Me.LayoutControlItem_To_DC.Name = "LayoutControlItem_To_DC"
        Me.LayoutControlItem_To_DC.Size = New System.Drawing.Size(303, 26)
        Me.LayoutControlItem_To_DC.Text = "To Date :"
        Me.LayoutControlItem_To_DC.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem_To_DC.TextSize = New System.Drawing.Size(45, 13)
        Me.LayoutControlItem_To_DC.TextToControlDistance = 5
        '
        'btn_Fetch_DC
        '
        Me.btn_Fetch_DC.Location = New System.Drawing.Point(623, 12)
        Me.btn_Fetch_DC.Name = "btn_Fetch_DC"
        Me.btn_Fetch_DC.Size = New System.Drawing.Size(55, 22)
        Me.btn_Fetch_DC.StyleController = Me.LayoutControl_DC
        Me.btn_Fetch_DC.TabIndex = 6
        Me.btn_Fetch_DC.Text = "Fetch"
        '
        'LayoutControlItem_Fetch_DC
        '
        Me.LayoutControlItem_Fetch_DC.Control = Me.btn_Fetch_DC
        Me.LayoutControlItem_Fetch_DC.Location = New System.Drawing.Point(611, 0)
        Me.LayoutControlItem_Fetch_DC.Name = "LayoutControlItem_Fetch_DC"
        Me.LayoutControlItem_Fetch_DC.Size = New System.Drawing.Size(59, 26)
        Me.LayoutControlItem_Fetch_DC.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem_Fetch_DC.TextVisible = False
        '
        'gc_DC
        '
        Me.gc_DC.Location = New System.Drawing.Point(12, 38)
        Me.gc_DC.MainView = Me.gv_DC
        Me.gc_DC.MenuManager = Me.RibbonControl
        Me.gc_DC.Name = "gc_DC"
        Me.gc_DC.Size = New System.Drawing.Size(666, 197)
        Me.gc_DC.TabIndex = 7
        Me.gc_DC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_DC})
        '
        'gv_DC
        '
        Me.gv_DC.GridControl = Me.gc_DC
        Me.gv_DC.Name = "gv_DC"
        '
        'LayoutControlItem_GridControl_DC
        '
        Me.LayoutControlItem_GridControl_DC.Control = Me.gc_DC
        Me.LayoutControlItem_GridControl_DC.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem_GridControl_DC.Name = "LayoutControlItem_GridControl_DC"
        Me.LayoutControlItem_GridControl_DC.Size = New System.Drawing.Size(670, 201)
        Me.LayoutControlItem_GridControl_DC.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem_GridControl_DC.TextVisible = False
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 449)
        Me.Controls.Add(Me.MainTab)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTab.ResumeLayout(False)
        Me.tb_DeliveryChallan.ResumeLayout(False)
        CType(Me.LayoutControl_DC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl_DC.ResumeLayout(False)
        CType(Me.LayoutControlGroup_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_From_DC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_From_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem_From_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_To_DC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_To_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem_To_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem_Fetch_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_DC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem_GridControl_DC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents MainTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tb_Home As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tb_DeliveryChallan As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl_DC As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btn_Fetch_DC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_To_DC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dt_From_DC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlGroup_DC As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem_From_DC As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem_To_DC As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem_Fetch_DC As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gc_DC As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_DC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem_GridControl_DC As DevExpress.XtraLayout.LayoutControlItem
End Class
