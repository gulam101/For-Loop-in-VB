Public Class Form1
    Private Sub Tut_Cmd_Click(sender As Object, e As EventArgs) Handles Tut_Cmd.Click
        Dim I As Integer = 0
        For I = 0 To 10
            MessageBox.Show("Hello=" & I)
        Next
    End Sub
End Class
