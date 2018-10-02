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

Imports Devil7.Billing.GST.Classes

Namespace Forms
    Public Class frm_Main

#Region "Variables"
        Dim User As Objects.User
        Dim LoginInstance As Dialogs.frm_Login
#End Region

#Region "Constructor"
        Sub New(User As Objects.User, LoginInstance As Dialogs.frm_Login)
            InitializeComponent()
            Me.User = User
            Me.LoginInstance = LoginInstance
        End Sub
#End Region

#Region "Form Events"
        Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
            LoginInstance.BeginInvoke(Sub() LoginInstance.Close())
            rp_Developer.Visible = (Debugger.IsAttached Or (My.Application.CommandLineArgs.Count > 0 AndAlso My.Application.CommandLineArgs.Item(0).ToString = "-d"))
        End Sub
#End Region

#Region "Control Events"
        Private Sub btn_Testing_Reports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Testing_Reports.ItemClick
            Forms.Dialogs.Reports.Frm_Reports_Test.ShowDialog()
        End Sub
#End Region

    End Class
End Namespace