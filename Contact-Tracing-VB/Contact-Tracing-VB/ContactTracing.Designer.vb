<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactTracing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactTracing))
        Me.LabelInstruction = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelMiddleInitial = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxMiddleInitial = New System.Windows.Forms.TextBox()
        Me.DateTimePickerNowDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.RichTextBoxAddress = New System.Windows.Forms.RichTextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.ButtonNextPage2 = New System.Windows.Forms.Button()
        Me.SurnameError = New System.Windows.Forms.Label()
        Me.FirstnameError = New System.Windows.Forms.Label()
        Me.EmailError = New System.Windows.Forms.Label()
        Me.PhonenumberError = New System.Windows.Forms.Label()
        Me.AutoUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.AddressError = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelInstruction
        '
        Me.LabelInstruction.AutoSize = True
        Me.LabelInstruction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInstruction.Location = New System.Drawing.Point(7, 109)
        Me.LabelInstruction.Name = "LabelInstruction"
        Me.LabelInstruction.Size = New System.Drawing.Size(673, 26)
        Me.LabelInstruction.TabIndex = 0
        Me.LabelInstruction.Text = "Please fill up the form below in compliance with DTI and DOLE Interim Guidelines " &
    "on Workplace Prevention and Control " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of COVID-19. Your cooperation is greatly a" &
    "ppreciated"
        '
        'LabelSurname
        '
        Me.LabelSurname.AutoSize = True
        Me.LabelSurname.Location = New System.Drawing.Point(18, 188)
        Me.LabelSurname.Name = "LabelSurname"
        Me.LabelSurname.Size = New System.Drawing.Size(65, 15)
        Me.LabelSurname.TabIndex = 1
        Me.LabelSurname.Text = "SURNAME:"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(274, 188)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(75, 15)
        Me.LabelFirstName.TabIndex = 2
        Me.LabelFirstName.Text = "FIRST NAME:"
        '
        'LabelMiddleInitial
        '
        Me.LabelMiddleInitial.AutoSize = True
        Me.LabelMiddleInitial.Location = New System.Drawing.Point(518, 187)
        Me.LabelMiddleInitial.Name = "LabelMiddleInitial"
        Me.LabelMiddleInitial.Size = New System.Drawing.Size(93, 15)
        Me.LabelMiddleInitial.TabIndex = 3
        Me.LabelMiddleInitial.Text = "MIDDLE INITIAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DATE:"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxSurname.Location = New System.Drawing.Point(89, 183)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxSurname.TabIndex = 5
        Me.TextBoxSurname.TabStop = False
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxFirstName.Location = New System.Drawing.Point(352, 183)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(160, 23)
        Me.TextBoxFirstName.TabIndex = 6
        Me.TextBoxFirstName.TabStop = False
        '
        'TextBoxMiddleInitial
        '
        Me.TextBoxMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxMiddleInitial.Location = New System.Drawing.Point(615, 183)
        Me.TextBoxMiddleInitial.MaxLength = 1
        Me.TextBoxMiddleInitial.Name = "TextBoxMiddleInitial"
        Me.TextBoxMiddleInitial.Size = New System.Drawing.Size(49, 23)
        Me.TextBoxMiddleInitial.TabIndex = 7
        Me.TextBoxMiddleInitial.TabStop = False
        '
        'DateTimePickerNowDate
        '
        Me.DateTimePickerNowDate.Location = New System.Drawing.Point(466, 137)
        Me.DateTimePickerNowDate.Name = "DateTimePickerNowDate"
        Me.DateTimePickerNowDate.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerNowDate.TabIndex = 8
        Me.DateTimePickerNowDate.TabStop = False
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(18, 229)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(485, 15)
        Me.LabelAddress.TabIndex = 9
        Me.LabelAddress.Text = "COMPLETE CURRENT ADDRESS (HOUSE NO., ST., BRGY., MUNICIPALITY/CITY, PROVINCE) :"
        '
        'RichTextBoxAddress
        '
        Me.RichTextBoxAddress.Location = New System.Drawing.Point(21, 251)
        Me.RichTextBoxAddress.Name = "RichTextBoxAddress"
        Me.RichTextBoxAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBoxAddress.Size = New System.Drawing.Size(645, 53)
        Me.RichTextBoxAddress.TabIndex = 10
        Me.RichTextBoxAddress.TabStop = False
        Me.RichTextBoxAddress.Text = ""
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(72, 334)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.PlaceholderText = "Needed email with @gmail.com"
        Me.TextBoxEmail.Size = New System.Drawing.Size(258, 23)
        Me.TextBoxEmail.TabIndex = 12
        Me.TextBoxEmail.TabStop = False
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(22, 339)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(44, 15)
        Me.LabelEmail.TabIndex = 11
        Me.LabelEmail.Text = "EMAIL:"
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(466, 334)
        Me.TextBoxPhoneNumber.MaxLength = 11
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.PlaceholderText = "Start with 09"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(198, 23)
        Me.TextBoxPhoneNumber.TabIndex = 14
        Me.TextBoxPhoneNumber.TabStop = False
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(360, 339)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(103, 15)
        Me.LabelPhoneNumber.TabIndex = 13
        Me.LabelPhoneNumber.Text = "MOBILE NUMBER:"
        '
        'ButtonNextPage2
        '
        Me.ButtonNextPage2.BackColor = System.Drawing.Color.Black
        Me.ButtonNextPage2.Enabled = False
        Me.ButtonNextPage2.FlatAppearance.BorderSize = 0
        Me.ButtonNextPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNextPage2.Font = New System.Drawing.Font("Wide Latin", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonNextPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonNextPage2.Location = New System.Drawing.Point(589, 384)
        Me.ButtonNextPage2.Name = "ButtonNextPage2"
        Me.ButtonNextPage2.Size = New System.Drawing.Size(75, 44)
        Me.ButtonNextPage2.TabIndex = 15
        Me.ButtonNextPage2.TabStop = False
        Me.ButtonNextPage2.Text = "NEXT"
        Me.ButtonNextPage2.UseVisualStyleBackColor = False
        '
        'SurnameError
        '
        Me.SurnameError.AutoSize = True
        Me.SurnameError.ForeColor = System.Drawing.Color.Red
        Me.SurnameError.Location = New System.Drawing.Point(89, 209)
        Me.SurnameError.Name = "SurnameError"
        Me.SurnameError.Size = New System.Drawing.Size(157, 15)
        Me.SurnameError.TabIndex = 16
        Me.SurnameError.Text = "Please enter a valid Surname"
        Me.SurnameError.Visible = False
        '
        'FirstnameError
        '
        Me.FirstnameError.AutoSize = True
        Me.FirstnameError.ForeColor = System.Drawing.Color.Red
        Me.FirstnameError.Location = New System.Drawing.Point(352, 209)
        Me.FirstnameError.Name = "FirstnameError"
        Me.FirstnameError.Size = New System.Drawing.Size(162, 15)
        Me.FirstnameError.TabIndex = 17
        Me.FirstnameError.Text = "Please enter a valid Firstname"
        Me.FirstnameError.Visible = False
        '
        'EmailError
        '
        Me.EmailError.AutoSize = True
        Me.EmailError.ForeColor = System.Drawing.Color.Red
        Me.EmailError.Location = New System.Drawing.Point(72, 360)
        Me.EmailError.Name = "EmailError"
        Me.EmailError.Size = New System.Drawing.Size(139, 15)
        Me.EmailError.TabIndex = 19
        Me.EmailError.Text = "Please enter a valid Email"
        Me.EmailError.Visible = False
        '
        'PhonenumberError
        '
        Me.PhonenumberError.AutoSize = True
        Me.PhonenumberError.ForeColor = System.Drawing.Color.Red
        Me.PhonenumberError.Location = New System.Drawing.Point(466, 360)
        Me.PhonenumberError.Name = "PhonenumberError"
        Me.PhonenumberError.Size = New System.Drawing.Size(191, 15)
        Me.PhonenumberError.TabIndex = 20
        Me.PhonenumberError.Text = "Please enter a valid Phone Number"
        Me.PhonenumberError.Visible = False
        '
        'AutoUpdate
        '
        Me.AutoUpdate.Enabled = True
        '
        'AddressError
        '
        Me.AddressError.AutoSize = True
        Me.AddressError.ForeColor = System.Drawing.Color.Red
        Me.AddressError.Location = New System.Drawing.Point(22, 310)
        Me.AddressError.Name = "AddressError"
        Me.AddressError.Size = New System.Drawing.Size(152, 15)
        Me.AddressError.TabIndex = 21
        Me.AddressError.Text = "Please enter a valid Address"
        Me.AddressError.Visible = False
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Black
        Me.ButtonBack.Enabled = False
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Wide Latin", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonBack.Location = New System.Drawing.Point(21, 384)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 44)
        Me.ButtonBack.TabIndex = 22
        Me.ButtonBack.TabStop = False
        Me.ButtonBack.Text = "BACK"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(693, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'ContactTracing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 437)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.AddressError)
        Me.Controls.Add(Me.PhonenumberError)
        Me.Controls.Add(Me.EmailError)
        Me.Controls.Add(Me.FirstnameError)
        Me.Controls.Add(Me.SurnameError)
        Me.Controls.Add(Me.ButtonNextPage2)
        Me.Controls.Add(Me.TextBoxPhoneNumber)
        Me.Controls.Add(Me.LabelPhoneNumber)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.RichTextBoxAddress)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.DateTimePickerNowDate)
        Me.Controls.Add(Me.TextBoxMiddleInitial)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelMiddleInitial)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.LabelSurname)
        Me.Controls.Add(Me.LabelInstruction)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ContactTracing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACT TRACING"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInstruction As Label
    Friend WithEvents LabelSurname As Label
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents LabelMiddleInitial As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxMiddleInitial As TextBox
    Friend WithEvents DateTimePickerNowDate As DateTimePicker
    Friend WithEvents LabelAddress As Label
    Friend WithEvents RichTextBoxAddress As RichTextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxPhoneNumber As TextBox
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents ButtonNextPage2 As Button
    Friend WithEvents SurnameError As Label
    Friend WithEvents FirstnameError As Label
    Friend WithEvents EmailError As Label
    Friend WithEvents PhonenumberError As Label
    Friend WithEvents AutoUpdate As Timer
    Friend WithEvents AddressError As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
