Public Class ContactTracing2

    'declaring this variable to passed a data from 1 page to another
    Public Property f_name As String
    Public Property s_name As String
    Public Property m_name As String
    Public Property add As String
    Public Property email_add As String
    Public Property label_date As String
    Public Property ph_number As String

    Private Sub ButtonNextPage3_Click(sender As Object, e As EventArgs) Handles ButtonNextPage3.Click
        Try
            Dim Page4 As New ContactTracing3

            'passing a data form this page to the next page
            Page4.page4f_name = f_name
            Page4.page4s_name = s_name
            Page4.page4m_name = m_name
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
    'to minimize the passing of the value of radio buttons
    Function Radiovalue(myval)
        If myval.Checked Then
            Return myval.Text = "No"
        Else
            Return myval.Text = "Yes"
        End If

    End Function
    'jumping from the prev page
    Private Sub ButtonBackPage3_Click(sender As Object, e As EventArgs) Handles ButtonBackPage3.Click
        Dim page1 As New ContactTracing
        page1.Show()
        Me.Hide()
    End Sub
End Class