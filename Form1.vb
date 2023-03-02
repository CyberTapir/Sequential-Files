Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        FileSystem.FileOpen(1, "\\Mac\Home\Desktop\numbers.txt.txt", OpenMode.Input)

    End Sub
End Class
