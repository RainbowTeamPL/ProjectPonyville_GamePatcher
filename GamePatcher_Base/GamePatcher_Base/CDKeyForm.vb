﻿Imports System.Net

Public Class CDKeyForm

    Public Sub RegistryRead()
        CDKeyTextBox.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\RainbowTeamPL\ProjectPonyville", "cdkey", "")
    End Sub

    Private Sub CDKeyTextBox_TextChanged(sender As Object, e As EventArgs) Handles CDKeyTextBox.TextChanged
        If VerifyCode(CDKeyTextBox.Text) = True Then
            IncorrectKeyLabel.Visible = False
            KeyCorrectLabel.Visible = True
        Else
            IncorrectKeyLabel.Visible = True
            KeyCorrectLabel.Visible = False
        End If
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If VerifyCode(CDKeyTextBox.Text) = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\RainbowTeamPL\ProjectPonyville", "cdkey", CDKeyTextBox.Text)
            WebRequestPost.WebRequestPost.Main()
            Me.Close()
        Else
            MessageBox.Show("Invalid CD-Key!")
        End If
    End Sub

    Public Function VerifyCode(ByVal Serial As String) As Boolean

        '
        ' If they accidentally put spaces at the start/end,
        ' take them out for them.
        '

        Serial = Serial.Trim(" ")

        '
        ' Make sure they haven't put garbage in.
        ' If they have, give them no clues that
        ' it's the wrong length! (Idiots)
        '

        If Not Serial.Length = 29 Then
            Return False
        End If

        '
        ' Create the list that will contain the 'Char Arrays'
        '

        Dim lst As New List(Of List(Of String))

        ' ################################################################
        ' #  VERY VERY IMPORTANT!!!!                                     #
        ' #                                                              #
        ' #  Initialize __SOME__ of the arrays used in generating        #
        ' #  a key.                                                      #
        ' #  THIS IS YOUR MAIN WEAPON AGAINST HACKERS!!!                 #
        ' #                                                              #
        ' ################################################################

        Dim arr1() As String = {"A", "A", "B", "C", "C", "C", "E", "E", "F", "G", "G", "H", "I", "I", "J", "K", "K", "L", "M", "M", "N", "O", "O", "P", "Q", "Q", "R", "S", "S", "T", "U", "U", "V", "W", "W", "X", "Y", "Y", "Z", "0", "0", "1", "2", "2", "3", "4", "4", "5", "6", "6", "7", "8", "8", "9"}
        Dim arr5() As String = {"0", "1", "2", "6", "7", "8", "A", "B", "C", "G", "H", "I", "3", "N", "O", "S", "T", "U", "Y", "Z"}
        Dim arr9() As String = {"9", "7", "6", "4", "3", "1", "Q", "E", "T", "U", "O", "A", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr10() As String = {"9", "8", "7", "3", "2", "1", "5", "5", "5", "W", "R", "Y", "I", "P", "S", "F", "H", "K", "Z", "C", "B", "M"}
        Dim arr19() As String = {"L", "I", "A", "M", "I", "S", "C", "O", "O", "L", "V", "S", "N", "T", "H", "E", "3", "7", "3"}

        '
        ' Add the few initialized arrays into the list,
        ' using blanks wherever we've left one out
        '

        lst.Add(New List(Of String)(arr1))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr5))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr9))
        lst.Add(New List(Of String)(arr10))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String))
        lst.Add(New List(Of String)(arr19))
        lst.Add(New List(Of String))

        '
        ' Seed the random with the key
        '
        Dim r1 As Random

        '
        ' Be prepared for more garbage
        '
        Try
            r1 = New Random(CConvert.FromBase36(Serial.Substring(0, 5)))
        Catch
            Return False
        End Try

        '
        ' Create the regular expression to test
        ' the key against.
        '
        Dim x As Integer
        Dim chk As String = Serial.Substring(0, 5)
        Do Until chk.Length = 29
            x = chk.Length
            ' Use modulus to determine where "-" chars belong
            If x Mod 6 = 5 Then
                chk &= "-"
            Else
                ' Check to see if the list actually contains anything
                If lst.Item(x - (5 + (x + 1) \ 6)).Count = 0 Then
                    ' Indicate that this character can be anything
                    chk &= "."
                    ' Tick the random number generator along
                    r1.Next(0, 1)
                Else
                    ' Give the required value of this character
                    chk &= lst.Item(x - (5 + (x + 1) \ 6)).Item(r1.Next(0, lst.Item(x - (5 + (x + 1) \ 6)).Count - 1))
                End If
            End If
        Loop

        '
        ' Return whether the serial is valid or not
        '
        Return System.Text.RegularExpressions.Regex.IsMatch(Serial, chk)
    End Function

End Class