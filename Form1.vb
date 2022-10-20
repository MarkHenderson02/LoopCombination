Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListLoop.SelectedIndexChanged

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ListLoop.Items.Clear()
        For i = 1 To 10
            ListLoop.Items.Add("For Nexr : " & i)
        Next
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        ListLoop.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            ListLoop.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        ListLoop.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            ListLoop.Items.Add("Do Until " & i)
            i = i + 1
        Loop
    End Sub
End Class
