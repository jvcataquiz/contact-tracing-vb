Public Class ContactTracing3
    Public Property page4f_name As String
    Public Property page4add As String
    Public Property page4email_add As String
    Public Property page4label_date As String
    Public Property page4ph_number As String

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

    End Sub

    Private Sub ContactTracing3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullName.Text = page4f_name
        Email.Text = page4email_add
        Address.Text = page4add
        DateLabel.Text = page4label_date
        Number.Text = page4ph_number
    End Sub
End Class