Public Class ContactTracing2
    Private Sub ButtonNextPage3_Click(sender As Object, e As EventArgs) Handles ButtonNextPage3.Click
        Dim Page4 As New ContactTracing3
        Me.Hide()
        Page4.Show()
    End Sub
End Class