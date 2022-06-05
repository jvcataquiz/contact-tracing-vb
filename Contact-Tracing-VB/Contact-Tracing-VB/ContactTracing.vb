Public Class ContactTracing
    'if the user turn on or off the capslock it will work
    Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ"
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
            If TextBoxSurname.Text.Equals("") Then
                SurnameError.Visible = False
            ElseIf TextBoxSurname.Text.Length = 1 Then
                SurnameError.Visible = True
            Else
                SurnameError.Visible = False
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
End Class
