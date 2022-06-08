Public Class ContactTracing3
    Public Property page4f_name As String
    Public Property page4add As String
    Public Property page4email_add As String
    Public Property page4label_date As String
    Public Property page4ph_number As String


    Public Property page4radio1 As String
    Public Property page4radio2 As String
    Public Property page4radio3 As String
    Public Property page4radio4 As String
    Public Property page4radio5 As String
    Public Property page4radio6 As String


    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

    End Sub

    Private Sub ContactTracing3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Each index In page4ph_radio
        '    MessageBox.Show(index.Text.ToString())
        'Next

        FullName.Text = page4f_name
        Email.Text = page4email_add
        Address.Text = page4add
        DateLabel.Text = page4label_date
        Number.Text = page4ph_number
        Radiovalue(page4radio1, Coughs)
        Radiovalue(page4radio2, Breathing)
        Radiovalue(page4radio3, Diarrhea)
        Radiovalue(page4radio4, Exposure1)
        Radiovalue(page4radio5, Exposure2)
        Radiovalue(page4radio6, Exposure3)

    End Sub

    Sub Radiovalue(myval, myvar)
        If myval.Equals("True") Then
            myvar.Text = "No"
        Else
            myvar.Text = "Yes"
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim page2 As New ContactTracing2
        page2.Show()
        Me.Hide()
    End Sub
End Class