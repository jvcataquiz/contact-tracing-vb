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
        Me.LabelInstruction = New System.Windows.Forms.Label()
        Me.LabelSurname = New System.Windows.Forms.Label()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelMiddleInitial = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TextBoxMiddleInitial = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelInstruction
        '
        Me.LabelInstruction.AutoSize = True
        Me.LabelInstruction.Location = New System.Drawing.Point(27, 104)
        Me.LabelInstruction.Name = "LabelInstruction"
        Me.LabelInstruction.Size = New System.Drawing.Size(639, 30)
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
        Me.TextBoxSurname.Location = New System.Drawing.Point(89, 183)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxSurname.TabIndex = 5
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(352, 183)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(160, 23)
        Me.TextBoxFirstName.TabIndex = 6
        '
        'TextBoxMiddleInitial
        '
        Me.TextBoxMiddleInitial.Location = New System.Drawing.Point(615, 183)
        Me.TextBoxMiddleInitial.Name = "TextBoxMiddleInitial"
        Me.TextBoxMiddleInitial.Size = New System.Drawing.Size(49, 23)
        Me.TextBoxMiddleInitial.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(466, 137)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "COMPLETE CURRENT ADDRESS (HOUSE NO., ST., BRGY., MUNICIPALITY/CITY, PROVINCE) :"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 257)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(645, 53)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 334)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 23)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EMAIL:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(466, 334)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 23)
        Me.TextBox2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "MOBILE NUMBER:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContactTracing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxMiddleInitial)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelMiddleInitial)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.LabelSurname)
        Me.Controls.Add(Me.LabelInstruction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ContactTracing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACT TRACING"
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
