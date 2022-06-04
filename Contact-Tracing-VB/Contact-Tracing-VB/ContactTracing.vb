Public Class ContactTracing
    Private Sub ButtonNextPage2_Click(sender As Object, e As EventArgs) Handles ButtonNextPage2.Click
        Dim Page3 As New ContactTracing2
        Me.Hide()
        Page3.Show()

    End Sub
End Class
