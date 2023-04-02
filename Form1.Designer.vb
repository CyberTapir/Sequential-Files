<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstOutput = New ListBox()
        btnEOFRead = New Button()
        btnRead = New Button()
        SuspendLayout()
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.ItemHeight = 48
        lstOutput.Location = New Point(34, 38)
        lstOutput.Margin = New Padding(9, 10, 9, 10)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(553, 1060)
        lstOutput.TabIndex = 0
        ' 
        ' btnEOFRead
        ' 
        btnEOFRead.Location = New Point(729, 544)
        btnEOFRead.Margin = New Padding(9, 10, 9, 10)
        btnEOFRead.Name = "btnEOFRead"
        btnEOFRead.Size = New Size(214, 74)
        btnEOFRead.TabIndex = 3
        btnEOFRead.Text = "EOF Read"
        btnEOFRead.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(685, 379)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(307, 69)
        btnRead.TabIndex = 4
        btnRead.Text = "Read First 10"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(20F, 48F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1129, 1155)
        Controls.Add(btnRead)
        Controls.Add(btnEOFRead)
        Controls.Add(lstOutput)
        Margin = New Padding(9, 10, 9, 10)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnEOFRead As Button
    Friend WithEvents btnRead As Button
End Class
