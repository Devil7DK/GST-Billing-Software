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
    Public Class User

        Private Shared ReadOnly TableName As String = "Users"

        Public Shared Async Function Login(ByVal UserName As String, ByVal Password As String) As Threading.Tasks.Task(Of Objects.User)
            Dim R As Objects.User = Nothing

            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Await Connection.OpenAsync()

            Dim CommandText As String = String.Format("SELECT * FROM {0} WHERE [UserName]=@UserName AND [Password]=@Password;", TableName)

            Using Command As New SqlCommand(CommandText, Connection)
                Command.Parameters.AddWithValue("@UserName", UserName)
                Command.Parameters.AddWithValue("@Password", Encryption.Encrypt(Password))

                Using Reader As SqlDataReader = Await Command.ExecuteReaderAsync
                    If Reader.Read Then
                        R = Read(Reader)
                    End If
                End Using
            End Using

            Connection.Close()

            Return R
        End Function

        Public Shared Async Function GetUserNames() As Threading.Tasks.Task(Of List(Of String))
            Dim R As New List(Of String)

            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Await Connection.OpenAsync()

            Dim CommandText As String = String.Format("SELECT [UserName] FROM {0}", TableName)

            Using Command As New SqlCommand(CommandText, Connection)
                Using Reader As SqlDataReader = Await Command.ExecuteReaderAsync
                    While Reader.Read
                        Dim Username As String = Reader.Item("UserName").ToString.Trim
                        If Not String.IsNullOrEmpty(Username) AndAlso Not R.Contains(Username) Then
                            R.Add(Username)
                        End If
                    End While
                End Using
            End Using

            Connection.Close()

            Return R
        End Function

        Public Shared Async Function GetUsers() As Threading.Tasks.Task(Of List(Of Objects.User))
            Dim R As New List(Of Objects.User)

            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then Await Connection.OpenAsync()

            Dim CommandText As String = String.Format("SELECT * FROM {0}", TableName)

            Using Command As New SqlCommand(CommandText, Connection)
                Using Reader As SqlDataReader = Await Command.ExecuteReaderAsync
                    While Reader.Read
                        Dim User As Objects.User = Read(Reader)
                        If User IsNot Nothing Then
                            R.Add(User)
                        End If
                    End While
                End Using
            End Using

            Connection.Close()

            Return R
        End Function

        Private Shared Function Read(ByVal Reader As SqlDataReader) As Objects.User
            Try
                Dim ID As Integer = Reader.Item("ID")
                Dim FullName As String = Reader.Item("FullName").ToString
                Dim UserName As String = Reader.Item("UserName").ToString
                Dim Position As String = Reader.Item("Position").ToString
                Dim DOB As Date = Reader.Item("DOB")
                Dim JoinDate As Date = Reader.Item("JoinDate")
                Dim Address As Objects.Address = If(String.IsNullOrEmpty(Reader.Item("Address").ToString), New Objects.Address, Serializer.FromXML(Of Objects.Address)(Reader.Item("Address").ToString))
                Dim Mobile As String = Reader.Item("Mobile").ToString
                Dim Picture As Image = My.Resources.staff_128x128

                If Reader.Item("Picture") IsNot Nothing Then
                    Try
                        Dim PictureData As Byte() = Reader.Item("Picture")
                        Using MS As New IO.MemoryStream(PictureData)
                            Picture = Image.FromStream(MS)
                        End Using
                    Catch ex As Exception

                    End Try
                End If

                Return New Objects.User(ID, FullName, UserName, Position, DOB, JoinDate, Address, Mobile, Picture)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

    End Class
End Namespace