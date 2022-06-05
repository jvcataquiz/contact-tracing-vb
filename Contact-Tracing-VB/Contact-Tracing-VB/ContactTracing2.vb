Public Class ContactTracing2

    Private Sub ButtonNextPage3_Click(sender As Object, e As EventArgs) Handles ButtonNextPage3.Click
        Try
            Dim Page4 As New ContactTracing3
            Dim btnonetoninereset() As RadioButton = {RadioButtonSymptoms1No, RadioButtonSymptoms2No, RadioButtonSymptoms3No, RadioButtonExposure1No, RadioButtonExposure2No, RadioButtonExposure3No}
            For Each radiono In btnonetoninereset
                MessageBox.Show(radiono.Text.ToString())
            Next
            Me.Hide()
            Page4.Show()
        Catch ex As Exception

        End Try


    End Sub
End Class