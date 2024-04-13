<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NextCharacter
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
        RunButton = New Button()
        SuspendLayout()
        ' 
        ' RunButton
        ' 
        RunButton.Location = New Point(328, 212)
        RunButton.Name = "RunButton"
        RunButton.Size = New Size(136, 37)
        RunButton.TabIndex = 0
        RunButton.Text = "Run"
        RunButton.UseVisualStyleBackColor = True
        ' 
        ' NextCharacter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RunButton)
        Name = "NextCharacter"
        Text = "NextCharacterForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RunButton As Button

End Class
