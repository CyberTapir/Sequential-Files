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
        SuspendLayout()
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.ItemHeight = 15
        lstOutput.Location = New Point(12, 12)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(196, 334)
        lstOutput.TabIndex = 0
        ' 
        ' btnEOFRead
        ' 
        btnEOFRead.Location = New Point(255, 170)
        btnEOFRead.Name = "btnEOFRead"
        btnEOFRead.Size = New Size(75, 23)
        btnEOFRead.TabIndex = 3
        btnEOFRead.Text = "EOF Read"
        btnEOFRead.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 361)
        Controls.Add(btnEOFRead)
        Controls.Add(lstOutput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnEOFRead As Button
End Class
