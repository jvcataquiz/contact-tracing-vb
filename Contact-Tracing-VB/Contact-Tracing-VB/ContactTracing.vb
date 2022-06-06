Public Class ContactTracing
    'i declare this string to use it public and if the user turn on or off the capslock it will work
    Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim digits As String = "1234567890"

    'when this button clicked, it has a function to show the next page and closing this page
    Private Sub ButtonNextPage2_Click(sender As Object, e As EventArgs) Handles ButtonNextPage2.Click
        Try

            Dim Page3 As New ContactTracing2


            Page3.f_name = TextBoxFirstName.Text + " " + TextBoxMiddleInitial.Text + ". " + TextBoxSurname.Text
            Page3.email_add = TextBoxEmail.Text
            Page3.add = RichTextBoxAddress.Text
            Page3.ph_number = TextBoxPhoneNumber.Text
            Page3.label_date = DateTimePickerNowDate.Text

            Me.Hide()
            Page3.Show()

        Catch ex As Exception
            Me.Show()
            MessageBox.Show("Something's Wrong!!!")
        End Try

    End Sub
    'i used this clock to become an updater for the input of the user
    Private Sub AutoUpdate_Tick(sender As Object, e As EventArgs) Handles AutoUpdate.Tick
        Try
            'This if else statement is for SurnameTextbox to validate the input of the user
            If TextBoxSurname.Text.Length = 1 Then
                SurnameError.Visible = True
            Else
                SurnameError.Visible = False
            End If
            'This if else statement is for FirstnameTextbox to validate the input of the user
            If TextBoxFirstName.Text.Length = 1 Then
                FirstnameError.Visible = True
            Else
                FirstnameError.Visible = False
            End If
            'This if else statement is for Address to validate the input of the user
            If RichTextBoxAddress.Text.Length = 1 Then
                AddressError.Visible = True
            Else
                AddressError.Visible = False
            End If

            'This if else statement is for Email to validate the input of the user
            If TextBoxEmail.Text.Equals("") Then
                EmailError.Visible = False
            ElseIf Not TextBoxEmail.Text.Contains("@gmail.com") Then
                EmailError.Visible = True
            Else
                EmailError.Visible = False
            End If

            'This if else statement is for PhoneNumber to validate the input of the user
            If TextBoxPhoneNumber.Text.Equals("") Then
                PhonenumberError.Visible = False
            ElseIf Not TextBoxPhoneNumber.Text.StartsWith("0") Then
                PhonenumberError.Visible = True
                PhonenumberError.Text = "Phone Number must start with 0"
            ElseIf TextBoxPhoneNumber.Text.Length < 11 Then
                PhonenumberError.Visible = True
                PhonenumberError.Text = "Phone Number must be 11 digits"
            Else
                PhonenumberError.Visible = False
            End If


            'using this condition i short my code it can determine whether the textbox is not empty and not equal to 1
            If TextBoxSurname.Text.Length > 1 And TextBoxFirstName.Text.Length > 1 And
             RichTextBoxAddress.Text.Length > 1 And TextBoxEmail.Text.Length > 1 And
               TextBoxPhoneNumber.Text.Length = 11 Then
                ButtonNextPage2.Enabled = True
            Else
                ButtonNextPage2.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Something's Wrong!!!")
        End Try
    End Sub

    'i create this function to minimize the space and i can use it for those element i can limit only with text
    Sub AlphabetOnly(key)
        'note the e.keychar = 8 means BACKSPACE
        Try
            If Not (Asc(key.KeyChar) = 8) Then
                If Not allowedChars.Contains(key.KeyChar.ToString) Then
                    key.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Something's Wrong!!!")
        End Try

    End Sub
    Private Sub SurnameTextbox(sender As Object, e As KeyPressEventArgs) Handles TextBoxSurname.KeyPress

        'calling the function AlphabetOnly with parameter
        AlphabetOnly(e)
    End Sub

    Private Sub FirstNameTextbox(sender As Object, e As KeyPressEventArgs) Handles TextBoxFirstName.KeyPress
        'calling the function AlphabetOnly with parameter
        AlphabetOnly(e)
    End Sub

    Private Sub MiddleinitialTextbox(sender As Object, e As KeyPressEventArgs) Handles TextBoxMiddleInitial.KeyPress
        'calling the function AlphabetOnly with parameter
        AlphabetOnly(e)
    End Sub

    'i used this event to input numbers only
    Private Sub PhoneNumberOnly(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhoneNumber.KeyPress
        Try
            'note the e.keychar = 8 means BACKSPACE
            If Not (Asc(e.KeyChar) = 8) Then
                If Not digits.Contains(e.KeyChar.ToString) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Something's Wrong!!!")
        End Try
    End Sub


End Class
