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

Imports System.Data.SqlClient

Namespace Classes.Database
    Public Module Connection

        Dim ServerSettings As ServerSettings
        Dim Connection As SqlConnection

        Public Function GetConnection() As SqlConnection
            If Connection Is Nothing Then
                Connection = CreateConnection()
            End If
            Return Connection
        End Function

        Private Function CreateConnection() As SqlConnection
            If ServerSettings Is Nothing Then
                ServerSettings = ServerSettings.GetSettings
            End If
            Return New SqlConnection(String.Format("Server={0};Database={1};User Id={2};Password={3};Pooling={4}",
                                               ServerSettings.ServerName, ServerSettings.DatabaseName, ServerSettings.UserName, Encryption.Decrypt(ServerSettings.Password), ServerSettings.Pooling))
        End Function

    End Module
End Namespace