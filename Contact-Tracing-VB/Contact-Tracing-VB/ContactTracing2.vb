Public Class ContactTracing2
    Public Property f_name As String
    Public Property add As String
    Public Property email_add As String
    Public Property label_date As String
    Public Property ph_number As String

    Private Sub ButtonNextPage3_Click(sender As Object, e As EventArgs) Handles ButtonNextPage3.Click
        Try
            Dim Page4 As New ContactTracing3
            'Dim btnonetoninereset() As RadioButton = {RadioButtonSymptoms1No, RadioButtonSymptoms2No, RadioButtonSymptoms3No, RadioButtonExposure1No, RadioButtonExposure2No, RadioButtonExposure3No}
            'For Each radiono In btnonetoninereset
            '    MessageBox.Show(radiono.Text.ToString())
            'Next
            Page4.page4f_name = f_name
            Page4.page4add = add
            Page4.page4email_add = email_add
            Page4.page4label_date = label_date
            Page4.page4ph_number = ph_number


            Me.Hide()
            Page4.Show()
        Catch ex As Exception

        End Try


    End Sub


End Class