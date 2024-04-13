<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interest
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
        InterestListBox = New ListBox()
        Label1 = New Label()
        AmountLabel = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' InterestListBox
        ' 
        InterestListBox.FormattingEnabled = True
        InterestListBox.ItemHeight = 15
        InterestListBox.Location = New Point(318, 165)
        InterestListBox.Name = "InterestListBox"
        InterestListBox.Size = New Size(120, 94)
        InterestListBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(469, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 1
        Label1.Text = "Amount: "
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(526, 244)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(0, 15)
        AmountLabel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(318, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 3
        Label2.Text = "Year List"
        ' 
        ' Interest
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(AmountLabel)
        Controls.Add(Label1)
        Controls.Add(InterestListBox)
        Name = "Interest"
        Text = "InterestForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InterestListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents Label2 As Label

End Class
