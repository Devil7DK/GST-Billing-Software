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

Namespace Forms.Dialogs
    Public Class frm_Login

        Private Async Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
            Invoke(Sub()
                       ProgressPanel.Description = "Authendicating..."
                       ProgressPanel.Visible = True
                   End Sub)

            Dim User As Classes.Objects.User = Nothing

            Try
                User = Await Classes.Database.User.Login(txt_Username.Text, txt_Password.Text)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try

            If User IsNot Nothing Then
                Dim th As New Threading.Thread(Sub() Application.Run(New frm_Main(User, Me)))
                th.SetApartmentState(Threading.ApartmentState.STA)
                th.Start()
            Else
                MsgBox("Invalid Username/Password!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Invoke(Sub() ProgressPanel.Visible = False)
            End If
        End Sub

        Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
            Close()
        End Sub

        Private Async Sub frm_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Invoke(Sub()
                       ProgressPanel.Description = "Loading Usernames..."
                       ProgressPanel.Visible = True
                   End Sub)

            Try
                Dim Users As List(Of String) = Await Classes.Database.User.GetUserNames
                Invoke(Sub()
                           txt_Username.Properties.Items.AddRange(Users)
                           If Users.Count > 0 Then txt_Username.SelectedIndex = If(My.Settings.LastSelectedIndex < Users.Count, My.Settings.LastSelectedIndex, 0)
                       End Sub)
            Catch ex As Exception
                MsgBox("Unable to load usernames." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try

            Invoke(Sub() ProgressPanel.Visible = False)
        End Sub

        Private Sub txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Password.KeyDown
            If e.KeyCode = Keys.Enter Then
                If e.Alt = False Then
                    btn_Login.PerformClick()
                Else
                    InputBox("Copy the Encrypted Password :", "Encrypted Password", Classes.Encryption.Encrypt(txt_Password.Text))
                End If
                e.Handled = True
            End If
        End Sub

    End Class
End Namespace