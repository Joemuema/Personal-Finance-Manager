<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DemoForm
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
        Label1 = New Label()
        Label2 = New Label()
        DisplayWidthLabel = New Label()
        DisplayHeightLabel = New Label()
        ResizeButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(256, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 0
        Label1.Text = "DemoForm Width: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(256, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 15)
        Label2.TabIndex = 1
        Label2.Text = "DemoForm Height: "
        ' 
        ' DisplayWidthLabel
        ' 
        DisplayWidthLabel.AutoSize = True
        DisplayWidthLabel.Location = New Point(370, 157)
        DisplayWidthLabel.Name = "DisplayWidthLabel"
        DisplayWidthLabel.Size = New Size(0, 15)
        DisplayWidthLabel.TabIndex = 2
        ' 
        ' DisplayHeightLabel
        ' 
        DisplayHeightLabel.AutoSize = True
        DisplayHeightLabel.Location = New Point(370, 208)
        DisplayHeightLabel.Name = "DisplayHeightLabel"
        DisplayHeightLabel.Size = New Size(0, 15)
        DisplayHeightLabel.TabIndex = 3
        ' 
        ' ResizeButton
        ' 
        ResizeButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ResizeButton.Location = New Point(621, 361)
        ResizeButton.Name = "ResizeButton"
        ResizeButton.Size = New Size(75, 23)
        ResizeButton.TabIndex = 4
        ResizeButton.Text = "Resize"
        ResizeButton.UseVisualStyleBackColor = True
        ' 
        ' DemoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResizeButton)
        Controls.Add(DisplayHeightLabel)
        Controls.Add(DisplayWidthLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DemoForm"
        Text = "DemoForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayWidthLabel As Label
    Friend WithEvents DisplayHeightLabel As Label
    Friend WithEvents ResizeButton As Button

End Class
