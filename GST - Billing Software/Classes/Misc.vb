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
'=========================================================================='

Namespace Classes
    Module Misc

        Function GenerateLogo(ByVal Name As String) As Image
            If String.IsNullOrEmpty(Name) Then
                Name = "D"
            End If

            Dim Image As New Bitmap(100, 100)
            Dim G As Graphics = Graphics.FromImage(Image)
            Dim Rect As New Rectangle(10, 10, 80, 80)
            G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            G.FillEllipse(Brushes.LightGreen, Rect)
            G.DrawEllipse(New Pen(Brushes.Black, 2), Rect)
            G.DrawString(Name.Substring(0, 1), New Font("Century Gothic", 30, FontStyle.Bold), Brushes.White, Rect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            G.Dispose()

            Return Image
        End Function

        Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
            'Let's make sure entered value is numeric
            If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

            Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
            nAmount = Replace(nAmount, tempDecValue, String.Empty)

            Try
                Dim intAmount As Long = nAmount
                If intAmount > 0 Then
                    nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                    Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                    Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                    Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                    Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                    Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                    intAmount = eAmount

                    Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                    Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                    Dim nOne As Integer = intAmount \ 1

                    If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred and " 'This is for hundreds                
                    If nTen > 0 Then 'This is for tens and teens
                        If nTen = 1 And nOne > 0 Then 'This is for teens 
                            wAmount = wAmount & Teens(nOne) & " "
                        Else 'This is for tens, 10 to 90
                            wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                            If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                        End If
                    Else 'This is for ones, 1 to 9
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                    wAmount = wAmount & HMBT(nSet) & " "
                    wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else
                    If Val(nAmount) = 0 Then nAmount = nAmount &
                tempDecValue : tempDecValue = String.Empty
                    If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
                  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
                  wAmount.Trim & " Pesos And ", 1)) & " Cents"
                End If
            Catch ex As Exception
                MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "!#ERROR_ENCOUNTERED"
            End Try

            'Trap null values

            'Display the result
            If wAmount.Trim.EndsWith(" and") Then
                wAmount = wAmount.Trim.TrimEnd(("and").ToCharArray)
            End If
            Return wAmount
        End Function

    End Module
End Namespace