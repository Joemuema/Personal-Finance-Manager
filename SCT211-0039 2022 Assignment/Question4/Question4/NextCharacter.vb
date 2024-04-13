Public Class NextCharacter
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim inputChar As Char = InputBox("Enter your character: ", "Input Character", "a")
        MessageBox.Show("Next Character: " & NextChar(inputChar), "Next ASCII value")
    End Sub

    Public Function NextChar(ByVal currentChar As Char) As Char
        Return Chr(Asc(currentChar) + 1)
    End Function
End Class
