<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactTracing3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactTracing3))
        Me.LabelFullname = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.LabelSymptoms = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelCoughs = New System.Windows.Forms.Label()
        Me.LabelBreathing = New System.Windows.Forms.Label()
        Me.LabelDiarrhea = New System.Windows.Forms.Label()
        Me.LabelExposure = New System.Windows.Forms.Label()
        Me.LabelExposureQuestion1 = New System.Windows.Forms.Label()
        Me.LabelExposureQuestion2 = New System.Windows.Forms.Label()
        Me.LabelExposureQuestion3 = New System.Windows.Forms.Label()
        Me.LabelHereby = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.FullName = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.Label()
        Me.Coughs = New System.Windows.Forms.Label()
        Me.Breathing = New System.Windows.Forms.Label()
        Me.Diarrhea = New System.Windows.Forms.Label()
        Me.Exposure1 = New System.Windows.Forms.Label()
        Me.Exposure2 = New System.Windows.Forms.Label()
        Me.Exposure3 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelFullname
        '
        Me.LabelFullname.AutoSize = True
        Me.LabelFullname.Location = New System.Drawing.Point(21, 27)
        Me.LabelFullname.Name = "LabelFullname"
        Me.LabelFullname.Size = New System.Drawing.Size(62, 15)
        Me.LabelFullname.TabIndex = 0
        Me.LabelFullname.Text = "Fullname: "
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(21, 46)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(39, 15)
        Me.LabelEmail.TabIndex = 1
        Me.LabelEmail.Text = "Email:"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(21, 65)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(55, 15)
        Me.LabelAddress.TabIndex = 2
        Me.LabelAddress.Text = "Address: "
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(21, 85)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(94, 15)
        Me.LabelPhoneNumber.TabIndex = 3
        Me.LabelPhoneNumber.Text = "Mobile Number:"
        '
        'LabelSymptoms
        '
        Me.LabelSymptoms.AutoSize = True
        Me.LabelSymptoms.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSymptoms.Location = New System.Drawing.Point(9, 106)
        Me.LabelSymptoms.Name = "LabelSymptoms"
        Me.LabelSymptoms.Size = New System.Drawing.Size(66, 15)
        Me.LabelSymptoms.TabIndex = 4
        Me.LabelSymptoms.Text = "Symptoms"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(7, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Personal Information"
        '
        'LabelCoughs
        '
        Me.LabelCoughs.AutoSize = True
        Me.LabelCoughs.Location = New System.Drawing.Point(23, 127)
        Me.LabelCoughs.Name = "LabelCoughs"
        Me.LabelCoughs.Size = New System.Drawing.Size(127, 15)
        Me.LabelCoughs.TabIndex = 6
        Me.LabelCoughs.Text = "Coughs, Cold or Fever:"
        '
        'LabelBreathing
        '
        Me.LabelBreathing.AutoSize = True
        Me.LabelBreathing.Location = New System.Drawing.Point(23, 146)
        Me.LabelBreathing.Name = "LabelBreathing"
        Me.LabelBreathing.Size = New System.Drawing.Size(126, 15)
        Me.LabelBreathing.TabIndex = 7
        Me.LabelBreathing.Text = "Difficulty of Breathing:"
        '
        'LabelDiarrhea
        '
        Me.LabelDiarrhea.AutoSize = True
        Me.LabelDiarrhea.Location = New System.Drawing.Point(23, 167)
        Me.LabelDiarrhea.Name = "LabelDiarrhea"
        Me.LabelDiarrhea.Size = New System.Drawing.Size(54, 15)
        Me.LabelDiarrhea.TabIndex = 8
        Me.LabelDiarrhea.Text = "Diarrhea:"
        '
        'LabelExposure
        '
        Me.LabelExposure.AutoSize = True
        Me.LabelExposure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelExposure.Location = New System.Drawing.Point(9, 187)
        Me.LabelExposure.Name = "LabelExposure"
        Me.LabelExposure.Size = New System.Drawing.Size(58, 15)
        Me.LabelExposure.TabIndex = 9
        Me.LabelExposure.Text = "Exposure"
        '
        'LabelExposureQuestion1
        '
        Me.LabelExposureQuestion1.AutoSize = True
        Me.LabelExposureQuestion1.Location = New System.Drawing.Point(21, 212)
        Me.LabelExposureQuestion1.Name = "LabelExposureQuestion1"
        Me.LabelExposureQuestion1.Size = New System.Drawing.Size(365, 30)
        Me.LabelExposureQuestion1.TabIndex = 10
        Me.LabelExposureQuestion1.Text = "Did you have unprotected exposure to a suspect/confirmed  COVID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "case for the pa" &
    "st 14 days?"
        '
        'LabelExposureQuestion2
        '
        Me.LabelExposureQuestion2.AutoSize = True
        Me.LabelExposureQuestion2.Location = New System.Drawing.Point(21, 250)
        Me.LabelExposureQuestion2.Name = "LabelExposureQuestion2"
        Me.LabelExposureQuestion2.Size = New System.Drawing.Size(371, 15)
        Me.LabelExposureQuestion2.TabIndex = 11
        Me.LabelExposureQuestion2.Text = "Did you have a family member experiencing those symptoms above?"
        '
        'LabelExposureQuestion3
        '
        Me.LabelExposureQuestion3.AutoSize = True
        Me.LabelExposureQuestion3.Location = New System.Drawing.Point(23, 273)
        Me.LabelExposureQuestion3.Name = "LabelExposureQuestion3"
        Me.LabelExposureQuestion3.Size = New System.Drawing.Size(325, 15)
        Me.LabelExposureQuestion3.TabIndex = 12
        Me.LabelExposureQuestion3.Text = "Have you traveled to areas with high instances of COVID-19?"
        '
        'LabelHereby
        '
        Me.LabelHereby.AutoSize = True
        Me.LabelHereby.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHereby.Location = New System.Drawing.Point(60, 313)
        Me.LabelHereby.Name = "LabelHereby"
        Me.LabelHereby.Size = New System.Drawing.Size(582, 60)
        Me.LabelHereby.TabIndex = 13
        Me.LabelHereby.Text = resources.GetString("LabelHereby.Text")
        Me.LabelHereby.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.BackColor = System.Drawing.Color.Black
        Me.ButtonSubmit.FlatAppearance.BorderSize = 0
        Me.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubmit.Font = New System.Drawing.Font("Wide Latin", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSubmit.Location = New System.Drawing.Point(567, 385)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(91, 44)
        Me.ButtonSubmit.TabIndex = 14
        Me.ButtonSubmit.Text = "SUBMIT"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
        '
        'FullName
        '
        Me.FullName.AutoSize = True
        Me.FullName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FullName.ForeColor = System.Drawing.Color.Red
        Me.FullName.Location = New System.Drawing.Point(78, 27)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(39, 15)
        Me.FullName.TabIndex = 15
        Me.FullName.Text = "Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Email.ForeColor = System.Drawing.Color.Red
        Me.Email.Location = New System.Drawing.Point(58, 46)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(36, 15)
        Me.Email.TabIndex = 16
        Me.Email.Text = "Email"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Address.ForeColor = System.Drawing.Color.Red
        Me.Address.Location = New System.Drawing.Point(75, 65)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(49, 15)
        Me.Address.TabIndex = 17
        Me.Address.Text = "Address"
        '
        'Number
        '
        Me.Number.AutoSize = True
        Me.Number.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Number.ForeColor = System.Drawing.Color.Red
        Me.Number.Location = New System.Drawing.Point(110, 85)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(51, 15)
        Me.Number.TabIndex = 18
        Me.Number.Text = "Number"
        '
        'Coughs
        '
        Me.Coughs.AutoSize = True
        Me.Coughs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Coughs.ForeColor = System.Drawing.Color.Red
        Me.Coughs.Location = New System.Drawing.Point(145, 127)
        Me.Coughs.Name = "Coughs"
        Me.Coughs.Size = New System.Drawing.Size(47, 15)
        Me.Coughs.TabIndex = 19
        Me.Coughs.Text = "Coughs"
        '
        'Breathing
        '
        Me.Breathing.AutoSize = True
        Me.Breathing.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Breathing.ForeColor = System.Drawing.Color.Red
        Me.Breathing.Location = New System.Drawing.Point(145, 146)
        Me.Breathing.Name = "Breathing"
        Me.Breathing.Size = New System.Drawing.Size(58, 15)
        Me.Breathing.TabIndex = 20
        Me.Breathing.Text = "Breathing"
        '
        'Diarrhea
        '
        Me.Diarrhea.AutoSize = True
        Me.Diarrhea.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Diarrhea.ForeColor = System.Drawing.Color.Red
        Me.Diarrhea.Location = New System.Drawing.Point(75, 167)
        Me.Diarrhea.Name = "Diarrhea"
        Me.Diarrhea.Size = New System.Drawing.Size(52, 15)
        Me.Diarrhea.TabIndex = 21
        Me.Diarrhea.Text = "Diarrhea"
        '
        'Exposure1
        '
        Me.Exposure1.AutoSize = True
        Me.Exposure1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Exposure1.ForeColor = System.Drawing.Color.Red
        Me.Exposure1.Location = New System.Drawing.Point(158, 227)
        Me.Exposure1.Name = "Exposure1"
        Me.Exposure1.Size = New System.Drawing.Size(60, 15)
        Me.Exposure1.TabIndex = 22
        Me.Exposure1.Text = "Exposure1"
        '
        'Exposure2
        '
        Me.Exposure2.AutoSize = True
        Me.Exposure2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Exposure2.ForeColor = System.Drawing.Color.Red
        Me.Exposure2.Location = New System.Drawing.Point(389, 250)
        Me.Exposure2.Name = "Exposure2"
        Me.Exposure2.Size = New System.Drawing.Size(62, 15)
        Me.Exposure2.TabIndex = 23
        Me.Exposure2.Text = "Exposure2"
        '
        'Exposure3
        '
        Me.Exposure3.AutoSize = True
        Me.Exposure3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Exposure3.ForeColor = System.Drawing.Color.Red
        Me.Exposure3.Location = New System.Drawing.Point(346, 273)
        Me.Exposure3.Name = "Exposure3"
        Me.Exposure3.Size = New System.Drawing.Size(62, 15)
        Me.Exposure3.TabIndex = 24
        Me.Exposure3.Text = "Exposure3"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(488, 27)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(34, 15)
        Me.LabelDate.TabIndex = 25
        Me.LabelDate.Text = "Date:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateLabel.ForeColor = System.Drawing.Color.Red
        Me.DateLabel.Location = New System.Drawing.Point(522, 27)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 15)
        Me.DateLabel.TabIndex = 26
        Me.DateLabel.Text = "date"
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Black
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Wide Latin", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonBack.Location = New System.Drawing.Point(23, 385)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 44)
        Me.ButtonBack.TabIndex = 27
        Me.ButtonBack.Text = "BACK"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(317, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(567, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(457, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'ContactTracing3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 437)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Exposure3)
        Me.Controls.Add(Me.Exposure2)
        Me.Controls.Add(Me.Exposure1)
        Me.Controls.Add(Me.Diarrhea)
        Me.Controls.Add(Me.Breathing)
        Me.Controls.Add(Me.Coughs)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelHereby)
        Me.Controls.Add(Me.LabelExposureQuestion3)
        Me.Controls.Add(Me.LabelExposureQuestion2)
        Me.Controls.Add(Me.LabelExposureQuestion1)
        Me.Controls.Add(Me.LabelExposure)
        Me.Controls.Add(Me.LabelDiarrhea)
        Me.Controls.Add(Me.LabelBreathing)
        Me.Controls.Add(Me.LabelCoughs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelSymptoms)
        Me.Controls.Add(Me.LabelPhoneNumber)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelFullname)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ContactTracing3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContactTracing3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFullname As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents LabelSymptoms As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelCoughs As Label
    Friend WithEvents LabelBreathing As Label
    Friend WithEvents LabelDiarrhea As Label
    Friend WithEvents LabelExposure As Label
    Friend WithEvents LabelExposureQuestion1 As Label
    Friend WithEvents LabelExposureQuestion2 As Label
    Friend WithEvents LabelExposureQuestion3 As Label
    Friend WithEvents LabelHereby As Label
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents FullName As Label
    Friend WithEvents Email As Label
    Friend WithEvents Address As Label
    Friend WithEvents Number As Label
    Friend WithEvents Coughs As Label
    Friend WithEvents Breathing As Label
    Friend WithEvents Diarrhea As Label
    Friend WithEvents Exposure1 As Label
    Friend WithEvents Exposure2 As Label
    Friend WithEvents Exposure3 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
