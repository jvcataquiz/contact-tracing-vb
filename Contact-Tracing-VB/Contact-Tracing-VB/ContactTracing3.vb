Imports System.IO

Public Class ContactTracing3
    Public Property page4f_name As String
    Public Property page4s_name As String
    Public Property page4m_name As String
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
    Dim flag As Boolean = False

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

        Try
            Dim filecreate As System.IO.StreamWriter


            If File.Exists(FullName.Text + "txt") Then
                Dim result As DialogResult = MessageBox.Show("Data Found!!! Do you want to Overwrite it?", "Caption", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    filecreate = File.CreateText(FullName.Text + "txt")
                    filecreate.WriteLine(vbCrLf + LabelDate.Text + " " + DateLabel.Text)
                    filecreate.WriteLine(LabelFullname.Text + " " + FullName.Text)
                    filecreate.WriteLine(LabelEmail.Text + " " + Email.Text)
                    filecreate.WriteLine(LabelPhoneNumber.Text + " " + Number.Text)

                    filecreate.WriteLine(LabelCoughs.Text + " " + Coughs.Text)
                    filecreate.WriteLine(LabelBreathing.Text + " " + Breathing.Text)
                    filecreate.WriteLine(LabelDiarrhea.Text + " " + Diarrhea.Text)
                    filecreate.WriteLine(LabelExposureQuestion1.Text + " " + Exposure1.Text)
                    filecreate.WriteLine(LabelExposureQuestion2.Text + " " + Exposure2.Text)
                    filecreate.WriteLine(LabelExposureQuestion2.Text + " " + Exposure2.Text)
                    filecreate.Close()
                    MessageBox.Show("Information Updated!!!")
                    GoingBack()
                Else
                    MessageBox.Show("Going to First Page!!!")
                    GoingBack()
                End If
            Else
                filecreate = My.Computer.FileSystem.OpenTextFileWriter(FullName.Text + "txt", True)
                filecreate.WriteLine(vbCrLf + LabelDate.Text + " " + DateLabel.Text)
                filecreate.WriteLine(LabelFullname.Text + " " + FullName.Text)
                filecreate.WriteLine(LabelEmail.Text + " " + Email.Text)
                filecreate.WriteLine(LabelPhoneNumber.Text + " " + Number.Text)

                filecreate.WriteLine(LabelCoughs.Text + " " + Coughs.Text)
                filecreate.WriteLine(LabelBreathing.Text + " " + Breathing.Text)
                filecreate.WriteLine(LabelDiarrhea.Text + " " + Diarrhea.Text)
                filecreate.WriteLine(LabelExposureQuestion1.Text + " " + Exposure1.Text)
                filecreate.WriteLine(LabelExposureQuestion2.Text + " " + Exposure2.Text)
                filecreate.WriteLine(LabelExposureQuestion2.Text + " " + Exposure2.Text)
                filecreate.Close()
                MessageBox.Show("Information Added!!!")
                GoingBack()
            End If



        Catch ex As Exception
            MessageBox.Show("Something Wrong!!!")
        End Try

    End Sub

    Private Sub ContactTracing3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FullName.Text = page4s_name + ", " + page4f_name + " " + page4m_name + "."
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
    Sub GoingBack()
        Dim goingback As New ContactTracing
        goingback.Show()
        Me.Hide()

    End Sub
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim page2 As New ContactTracing2
        page2.Show()
        Me.Hide()
    End Sub
End Class