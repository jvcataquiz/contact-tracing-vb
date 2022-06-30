<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.PictureBoxImageIco = New System.Windows.Forms.PictureBox()
        Me.PictureBoxwelcome = New System.Windows.Forms.PictureBox()
        Me.PictureBoxtitle = New System.Windows.Forms.PictureBox()
        Me.PictureBoxImageuserico = New System.Windows.Forms.PictureBox()
        Me.ButtonScan = New System.Windows.Forms.Button()
        Me.ButtonDirect = New System.Windows.Forms.Button()
        Me.LabelRegister = New System.Windows.Forms.Label()
        CType(Me.PictureBoxImageIco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxwelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxtitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImageuserico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxImageIco
        '
        Me.PictureBoxImageIco.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PictureBoxImageIco.Image = CType(resources.GetObject("PictureBoxImageIco.Image"), System.Drawing.Image)
        Me.PictureBoxImageIco.Location = New System.Drawing.Point(285, 208)
        Me.PictureBoxImageIco.Name = "PictureBoxImageIco"
        Me.PictureBoxImageIco.Size = New System.Drawing.Size(123, 114)
        Me.PictureBoxImageIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImageIco.TabIndex = 1
        Me.PictureBoxImageIco.TabStop = False
        '
        'PictureBoxwelcome
        '
        Me.PictureBoxwelcome.Image = CType(resources.GetObject("PictureBoxwelcome.Image"), System.Drawing.Image)
        Me.PictureBoxwelcome.Location = New System.Drawing.Point(119, 3)
        Me.PictureBoxwelcome.Name = "PictureBoxwelcome"
        Me.PictureBoxwelcome.Size = New System.Drawing.Size(289, 71)
        Me.PictureBoxwelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxwelcome.TabIndex = 2
        Me.PictureBoxwelcome.TabStop = False
        '
        'PictureBoxtitle
        '
        Me.PictureBoxtitle.Image = CType(resources.GetObject("PictureBoxtitle.Image"), System.Drawing.Image)
        Me.PictureBoxtitle.Location = New System.Drawing.Point(1, 80)
        Me.PictureBoxtitle.Name = "PictureBoxtitle"
        Me.PictureBoxtitle.Size = New System.Drawing.Size(529, 104)
        Me.PictureBoxtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxtitle.TabIndex = 3
        Me.PictureBoxtitle.TabStop = False
        '
        'PictureBoxImageuserico
        '
        Me.PictureBoxImageuserico.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.PictureBoxImageuserico.Image = CType(resources.GetObject("PictureBoxImageuserico.Image"), System.Drawing.Image)
        Me.PictureBoxImageuserico.Location = New System.Drawing.Point(119, 208)
        Me.PictureBoxImageuserico.Name = "PictureBoxImageuserico"
        Me.PictureBoxImageuserico.Size = New System.Drawing.Size(123, 114)
        Me.PictureBoxImageuserico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImageuserico.TabIndex = 4
        Me.PictureBoxImageuserico.TabStop = False
        '
        'ButtonScan
        '
        Me.ButtonScan.BackColor = System.Drawing.Color.Black
        Me.ButtonScan.FlatAppearance.BorderSize = 0
        Me.ButtonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonScan.ForeColor = System.Drawing.Color.White
        Me.ButtonScan.Location = New System.Drawing.Point(293, 341)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(109, 37)
        Me.ButtonScan.TabIndex = 5
        Me.ButtonScan.Text = "Scan QR CODE"
        Me.ButtonScan.UseVisualStyleBackColor = False
        '
        'ButtonDirect
        '
        Me.ButtonDirect.BackColor = System.Drawing.Color.Black
        Me.ButtonDirect.FlatAppearance.BorderSize = 0
        Me.ButtonDirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDirect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonDirect.ForeColor = System.Drawing.Color.White
        Me.ButtonDirect.Location = New System.Drawing.Point(126, 341)
        Me.ButtonDirect.Name = "ButtonDirect"
        Me.ButtonDirect.Size = New System.Drawing.Size(109, 37)
        Me.ButtonDirect.TabIndex = 6
        Me.ButtonDirect.Text = "Direct Input"
        Me.ButtonDirect.UseVisualStyleBackColor = False
        '
        'LabelRegister
        '
        Me.LabelRegister.AutoSize = True
        Me.LabelRegister.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegister.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LabelRegister.Location = New System.Drawing.Point(168, 156)
        Me.LabelRegister.Name = "LabelRegister"
        Me.LabelRegister.Size = New System.Drawing.Size(195, 39)
        Me.LabelRegister.TabIndex = 7
        Me.LabelRegister.Text = "REGISTRATION"
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 414)
        Me.Controls.Add(Me.LabelRegister)
        Me.Controls.Add(Me.ButtonDirect)
        Me.Controls.Add(Me.ButtonScan)
        Me.Controls.Add(Me.PictureBoxImageuserico)
        Me.Controls.Add(Me.PictureBoxImageIco)
        Me.Controls.Add(Me.PictureBoxwelcome)
        Me.Controls.Add(Me.PictureBoxtitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        CType(Me.PictureBoxImageIco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxwelcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxtitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImageuserico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxImageIco As PictureBox
    Friend WithEvents PictureBoxwelcome As PictureBox
    Friend WithEvents PictureBoxtitle As PictureBox
    Friend WithEvents PictureBoxImageuserico As PictureBox
    Friend WithEvents ButtonScan As Button
    Friend WithEvents ButtonDirect As Button
    Friend WithEvents LabelRegister As Label
End Class
