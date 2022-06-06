Public Class ContactTracing2
    Public Property f_name As String
    Public Property add As String
    Public Property email_add As String
    Public Property label_date As String
    Public Property ph_number As String

    Private Sub ButtonNextPage3_Click(sender As Object, e As EventArgs) Handles ButtonNextPage3.Click
        Try
            Dim Page4 As New ContactTracing3
            Page4.page4f_name = f_name
            Page4.page4add = add
            Page4.page4email_add = email_add
            Page4.page4label_date = label_date
            Page4.page4ph_number = ph_number

            Page4.page4radio1 = Radiovalue(RadioButtonSymptoms1No)
            Page4.page4radio2 = Radiovalue(RadioButtonSymptoms2No)
            Page4.page4radio3 = Radiovalue(RadioButtonSymptoms3No)
            Page4.page4radio4 = Radiovalue(RadioButtonExposure1No)
            Page4.page4radio5 = Radiovalue(RadioButtonExposure2No)
            Page4.page4radio6 = Radiovalue(RadioButtonExposure3No)


            Me.Hide()
            Page4.Show()
        Catch ex As Exception

        End Try


    End Sub
    Function Radiovalue(myval)
        If myval.Checked Then
            Return myval.Text = "No"
        Else
            Return myval.Text = "Yes"
        End If

    End Function

End Class