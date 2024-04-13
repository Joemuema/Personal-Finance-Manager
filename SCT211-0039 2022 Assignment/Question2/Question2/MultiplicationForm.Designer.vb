<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiplicationForm
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
        MultTextBox = New TextBox()
        GenTableButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        factor1TextBox = New TextBox()
        factor2TextBox = New TextBox()
        SuspendLayout()
        ' 
        ' MultTextBox
        ' 
        MultTextBox.Location = New Point(111, 50)
        MultTextBox.Multiline = True
        MultTextBox.Name = "MultTextBox"
        MultTextBox.Size = New Size(495, 354)
        MultTextBox.TabIndex = 0
        ' 
        ' GenTableButton
        ' 
        GenTableButton.Location = New Point(710, 282)
        GenTableButton.Name = "GenTableButton"
        GenTableButton.Size = New Size(75, 23)
        GenTableButton.TabIndex = 1
        GenTableButton.Text = "Generate"
        GenTableButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 15)
        Label1.TabIndex = 2
        Label1.Text = "Multiplication Table"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(624, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 3
        Label2.Text = "Factor 1: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(624, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 4
        Label3.Text = "Factor 2: "
        ' 
        ' factor1TextBox
        ' 
        factor1TextBox.Location = New Point(685, 176)
        factor1TextBox.Name = "factor1TextBox"
        factor1TextBox.Size = New Size(100, 23)
        factor1TextBox.TabIndex = 5
        ' 
        ' factor2TextBox
        ' 
        factor2TextBox.Location = New Point(685, 229)
        factor2TextBox.Name = "factor2TextBox"
        factor2TextBox.Size = New Size(100, 23)
        factor2TextBox.TabIndex = 6
        ' 
        ' MultiplicationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(factor2TextBox)
        Controls.Add(factor1TextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GenTableButton)
        Controls.Add(MultTextBox)
        Name = "MultiplicationForm"
        Text = "Multiplication Table"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MultTextBox As TextBox
    Friend WithEvents GenTableButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents factor1TextBox As TextBox
    Friend WithEvents factor2TextBox As TextBox

End Class
