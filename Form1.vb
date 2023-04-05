Imports System.Xml.Schema
Public Class Form1
    Private Sub btnEOFRead_Click(sender As Object, e As EventArgs)
        Dim count As Integer
        Dim totalNum As Integer
        Dim temp As Integer
        Dim average As Single ' Single is a Floating Point value
        FileSystem.FileOpen(1, "\\Mac\Home\Desktop\numberlist.txt", OpenMode.Input)
        
        ' This code applies to all of the values in the file
        While Not EOF(1) ' EOF stands for End of File. While the end of the file has not been reached...
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

    ' This code only reads the first ten items in the file, because of the For Next loop.
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
