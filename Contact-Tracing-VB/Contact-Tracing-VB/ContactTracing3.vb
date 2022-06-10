Imports System.IO
Imports System.Diagnostics
Public Class ContactTracing3
    'declaring all this variable to pass a data from 1 page to another
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
    Dim filecreate As System.IO.StreamWriter
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

        Try

            'declaring filereader as system.streamReader
            Dim filereader As System.IO.StreamReader
            'this line of code is to open a specific text file
            filereader = My.Computer.FileSystem.OpenTextFileReader("contacttracing.txt")

            'declaring checker as string
            Dim checker As String
            'declaring counter as byte
            Dim counter As Byte = 0
            'declaring flag as boolean
            Dim flag As Boolean = False


            'using while loop to read every lines in the textfile
            While Not filereader.EndOfStream
                checker = filereader.ReadLine()
                'if the checker cointains a fullname of the user this code will count how many data will found
                If checker.Contains(FullName.Text) Then
                    counter += 1
                    'if checker detect a data in the textfile a change the value of flag
                    flag = True

                End If
            End While
            filereader.Close()
            'getting the value of tehe flag if the flag is true it means the user has data in the textfile otherwise it will added without prompting 
            If flag Then
                'asking the user if he o she want to add the addditional data in the text file
                Dim result As DialogResult = MessageBox.Show(counter & " Data Found!!!  Do you want to Add Another?", "Caption", MessageBoxButtons.YesNo)
                'getting the value from the messagebox
                If result = DialogResult.Yes Then
                    'calling the ydata() function to minimize the workplace place
                    MyData()

                Else
                    MessageBox.Show("Thank you!!!")

                    'going back to the firstpage
                    GoingBack()
                End If
            Else
                'calling the ydata() function to minimize the workplace place
                MyData()
            End If
            'resetting the value of counter
            counter = 0

        Catch ex As Exception
            MessageBox.Show("Something Wrong!!!")
        End Try

    End Sub
    'using this function to insert to the contacttracing text file it will insert neseccary file coming from the user
    Sub MyData()
        filecreate = My.Computer.FileSystem.OpenTextFileWriter("contacttracing.txt", True)
        filecreate.WriteLine(vbCrLf + "################################################")
        filecreate.WriteLine(LabelDate.Text + " " + DateLabel.Text)
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

        'it will open and dispaly the contact tracing text file
        Process.Start("notepad.exe", "contacttracing.txt")
        GoingBack()
    End Sub
    Private Sub ContactTracing3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'passing all the value coming from the prev page 
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
    'to minimize the space of workplace i added this value with two parameters for the radio buttons
    Sub Radiovalue(myval, myvar)
        If myval.Equals("True") Then
            myvar.Text = "No"
        Else
            myvar.Text = "Yes"
        End If

    End Sub
    'this function means it will jump to start
    Sub GoingBack()

        Dim goingback As New ContactTracing
        goingback.Show()
        Me.Hide()

    End Sub
    'this event is youcan go back to the prev page
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim page2 As New ContactTracing2
        page2.Show()
        Me.Hide()
    End Sub

    Private Sub Timerupdater_Tick(sender As Object, e As EventArgs) Handles Timerupdater.Tick
        If CheckBoxHereby.Checked Then
            ButtonSubmit.Visible = True
        Else
            ButtonSubmit.Visible = False
        End If
    End Sub
End Class