Imports System.Xml.Schema
Public Class Form1
    Private Sub btnEOFRead_Click(sender As Object, e As EventArgs)
        Dim count As Integer
        Dim totalNum As Integer
        Dim temp As Integer
        Dim average As Single
        FileSystem.FileOpen(1, "\\Mac\Home\Desktop\numberlist.txt", OpenMode.Input)
        While Not EOF(1)
            FileSystem.Input(1, temp)
            lstOutput.Items.Add(temp)
            count = count + temp
            totalNum = totalNum + 1
        End While
        FileSystem.FileClose(1)
        average = count / totalNum
        lstOutput.Items.Add("Total Items: " & totalNum)
        lstOutput.Items.Add("Average: " & average)
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click, btnRead.Click, btnRead.Click
        Dim tmp As Integer
        FileSystem.FileOpen(1, "\\Mac\Home\Desktop\numberlist.txt", OpenMode.Input)
        For i = 1 To 10
            FileSystem.Input(1, tmp)
            lstOutput.Items.Add(tmp)
        Next i
        FileSystem.FileClose(1)
    End Sub
End Class
