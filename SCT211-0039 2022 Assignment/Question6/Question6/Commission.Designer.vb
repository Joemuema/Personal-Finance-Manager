<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Commission
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
        NamesListBox = New ListBox()
        Label1 = New Label()
        WeekListBox = New ListBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        InsertNameButton = New Button()
        InsertNameTextBox = New TextBox()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        DisplayButton = New Button()
        WeekSalaryTextBox = New TextBox()
        Label8 = New Label()
        WeekSalesTextBox = New TextBox()
        Label7 = New Label()
        DaySalesTextBox = New TextBox()
        DaySalesLabel = New Label()
        NameTextBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        RecordSalesTextBox = New TextBox()
        RecordSalesButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' NamesListBox
        ' 
        NamesListBox.FormattingEnabled = True
        NamesListBox.ItemHeight = 15
        NamesListBox.Location = New Point(148, 55)
        NamesListBox.Name = "NamesListBox"
        NamesListBox.Size = New Size(143, 94)
        NamesListBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 15)
        Label1.TabIndex = 1
        Label1.Text = "Salesperson Name"
        ' 
        ' WeekListBox
        ' 
        WeekListBox.FormattingEnabled = True
        WeekListBox.ItemHeight = 15
        WeekListBox.Location = New Point(347, 55)
        WeekListBox.Name = "WeekListBox"
        WeekListBox.Size = New Size(78, 94)
        WeekListBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(347, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 3
        Label2.Text = "Sales Day"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(InsertNameButton)
        GroupBox1.Controls.Add(InsertNameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(130, 204)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(526, 63)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Insert Details"
        ' 
        ' InsertNameButton
        ' 
        InsertNameButton.Location = New Point(434, 23)
        InsertNameButton.Name = "InsertNameButton"
        InsertNameButton.Size = New Size(75, 23)
        InsertNameButton.TabIndex = 2
        InsertNameButton.Text = "Add"
        InsertNameButton.UseVisualStyleBackColor = True
        ' 
        ' InsertNameTextBox
        ' 
        InsertNameTextBox.Location = New Point(69, 22)
        InsertNameTextBox.Name = "InsertNameTextBox"
        InsertNameTextBox.Size = New Size(185, 23)
        InsertNameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 0
        Label3.Text = "Name: "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(DisplayButton)
        GroupBox2.Controls.Add(WeekSalaryTextBox)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(WeekSalesTextBox)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(DaySalesTextBox)
        GroupBox2.Controls.Add(DaySalesLabel)
        GroupBox2.Controls.Add(NameTextBox)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(130, 297)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(526, 141)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "View Sales Information"
        ' 
        ' DisplayButton
        ' 
        DisplayButton.Location = New Point(434, 112)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(75, 23)
        DisplayButton.TabIndex = 8
        DisplayButton.Text = "Display"
        DisplayButton.UseVisualStyleBackColor = True
        ' 
        ' WeekSalaryTextBox
        ' 
        WeekSalaryTextBox.Location = New Point(359, 69)
        WeekSalaryTextBox.Name = "WeekSalaryTextBox"
        WeekSalaryTextBox.ReadOnly = True
        WeekSalaryTextBox.Size = New Size(150, 23)
        WeekSalaryTextBox.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(280, 72)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 15)
        Label8.TabIndex = 6
        Label8.Text = "Week Salary:"
        ' 
        ' WeekSalesTextBox
        ' 
        WeekSalesTextBox.Location = New Point(92, 69)
        WeekSalesTextBox.Name = "WeekSalesTextBox"
        WeekSalesTextBox.ReadOnly = True
        WeekSalesTextBox.Size = New Size(162, 23)
        WeekSalesTextBox.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 15)
        Label7.TabIndex = 4
        Label7.Text = "Week Sales:"
        ' 
        ' DaySalesTextBox
        ' 
        DaySalesTextBox.Location = New Point(348, 30)
        DaySalesTextBox.Name = "DaySalesTextBox"
        DaySalesTextBox.ReadOnly = True
        DaySalesTextBox.Size = New Size(161, 23)
        DaySalesTextBox.TabIndex = 3
        ' 
        ' DaySalesLabel
        ' 
        DaySalesLabel.AutoSize = True
        DaySalesLabel.Location = New Point(280, 33)
        DaySalesLabel.Name = "DaySalesLabel"
        DaySalesLabel.Size = New Size(62, 15)
        DaySalesLabel.TabIndex = 2
        DaySalesLabel.Text = "Day Sales: "
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(69, 28)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.ReadOnly = True
        NameTextBox.Size = New Size(185, 23)
        NameTextBox.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 0
        Label5.Text = "Name: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(449, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 6
        Label4.Text = "Sales Made: "
        ' 
        ' RecordSalesTextBox
        ' 
        RecordSalesTextBox.Location = New Point(527, 91)
        RecordSalesTextBox.Name = "RecordSalesTextBox"
        RecordSalesTextBox.Size = New Size(100, 23)
        RecordSalesTextBox.TabIndex = 7
        ' 
        ' RecordSalesButton
        ' 
        RecordSalesButton.Location = New Point(552, 126)
        RecordSalesButton.Name = "RecordSalesButton"
        RecordSalesButton.Size = New Size(75, 23)
        RecordSalesButton.TabIndex = 8
        RecordSalesButton.Text = "Record"
        RecordSalesButton.UseVisualStyleBackColor = True
        ' 
        ' Commission
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(RecordSalesButton)
        Controls.Add(RecordSalesTextBox)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(WeekListBox)
        Controls.Add(Label1)
        Controls.Add(NamesListBox)
        Name = "Commission"
        Text = "CommissionForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NamesListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WeekListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents InsertNameTextBox As TextBox
    Friend WithEvents InsertNameButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RecordSalesTextBox As TextBox
    Friend WithEvents RecordSalesButton As Button
    Friend WithEvents DaySalesLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DaySalesTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents WeekSalesTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents WeekSalaryTextBox As TextBox

End Class
