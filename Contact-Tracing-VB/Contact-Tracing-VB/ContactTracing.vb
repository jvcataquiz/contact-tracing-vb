Public Class ContactTracing
    'if the user turn on or off the capslock it will work
    Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim digits As String = "1234567890"

    Private Sub ButtonNextPage2_Click(sender As Object, e As EventArgs) Handles ButtonNextPage2.Click
        Try
            Dim Page3 As New ContactTracing2
            Me.Hide()
            Page3.Show()

        Catch ex As Exception
            Me.Show()
            MessageBox.Show("Something's Wrong!!!")
        End Try

    End Sub

    Private Sub AutoUpdate_Tick(sender As Object, e As EventArgs) Handles AutoUpdate.Tick
        Try
            'This if else statement is for SurnameTextbox to validate the input of the user
            If TextBoxSurname.Text.Length = 1 Then
                SurnameError.Visible = True
            Else
                SurnameError.Visible = False
            End If

            If TextBoxFirstName.Text.Length = 1 Then
                FirstnameError.Visible = True
            Else
                FirstnameError.Visible = False
            End If

            If RichTextBoxAddress.Text.Length = 1 Then
                AddressError.Visible = True
            Else
                AddressError.Visible = False
            End If


            If TextBoxEmail.Text.Equals("") Then
                EmailError.Visible = False
            ElseIf Not TextBoxEmail.Text.Contains("@gmail.com") Then
                EmailError.Visible = True
            Else
                EmailError.Visible = False
            End If



            If TextBoxPhoneNumber.Text.Equals("") Then
                PhonenumberError.Visible = False
            ElseIf Not TextBoxPhoneNumber.Text.StartsWith("0") Then
                PhonenumberError.Visible = True
            Else
                PhonenumberError.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Something's Wrong!!!")
        End Try
    End Sub
    Sub AlphabetOnly(key)
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
        AlphabetOnly(e)
    End Sub

    Private Sub FirstNameTextbox(sender As Object, e As KeyPressEventArgs) Handles TextBoxFirstName.KeyPress
        AlphabetOnly(e)
    End Sub

    Private Sub MiddleinitialTextbox(sender As Object, e As KeyPressEventArgs) Handles TextBoxMiddleInitial.KeyPress
        AlphabetOnly(e)
    End Sub

    Private Sub PhoneNumberOnly(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhoneNumber.KeyPress
        Try
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
