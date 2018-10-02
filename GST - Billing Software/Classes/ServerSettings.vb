'==========================================================================
'
'                   (C) Copyright 2018 Devil7 Softwares.
' 
' Licensed under the Apache License, Version 2.0 (the "License");
' you may Not use this file except in compliance with the License.
' You may obtain a copy of the License at
' 
'     http://www.apache.org/licenses/LICENSE-2.0
' 
' Unless required by applicable law Or agreed to in writing, software
' distributed under the License Is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES Or CONDITIONS OF ANY KIND, either express Or implied.
' See the License for the specific language governing permissions And
' limitations under the License.
' 
' Contributors:
'     Dineshkumar T
'==========================================================================

Imports System.Reflection

Namespace Classes
    Public Class ServerSettings

        Private Shared ReadOnly ConfigFilePath As String = IO.Path.Combine(My.Computer.FileSystem.GetFileInfo((New System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath.Replace("%20", " ")).Directory.FullName, "DatabseServer.config")

        Public Shared Function GetSettings() As ServerSettings
            On Error Resume Next
            Dim R As New ServerSettings
            If My.Computer.FileSystem.FileExists(ConfigFilePath) Then
                R = Serializer.FromFile(Of ServerSettings)(ConfigFilePath)
                CheckPassword(R)
            Else
                Serializer.ToFile(New ServerSettings, ConfigFilePath)
            End If
            Return R
        End Function

        Private Shared Sub CheckPassword(ByVal Settings As ServerSettings)
            If Settings.Password = Encryption.Decrypt(Settings.Password) Then
                Settings.Password = Encryption.Encrypt(Settings.Password)
                Serializer.ToFile(Settings, ConfigFilePath)
            End If
        End Sub

        Property DatabaseName As String = "GACMS"
        Property ServerName As String = "LOCALHOST"
        Property UserName As String = "admin"
        Property Password As String = "admin"
        Property Pooling As Boolean = False

    End Class
End Namespace