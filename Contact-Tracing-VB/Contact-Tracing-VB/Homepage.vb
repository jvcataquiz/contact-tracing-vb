Imports System.Diagnostics
Imports AForge.Video.DirectShow
Imports System.IO
Imports AForge

Imports System.Drawing.Imaging
Imports AForge.Video
Imports System.Drawing
Imports ZXing
Imports ZXing.Aztec
Public Class Homepage

    Dim Camera As VideoCaptureDevice
    Dim bitmapDisplay As Bitmap


    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Dim cameraDisplay As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If ButtonStart.Text.Equals("START") Then
            If cameraDisplay.ShowDialog() = DialogResult.OK Then
                Camera = cameraDisplay.VideoDevice
                AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf CaptureDisplay)
                Camera.Start()
                ButtonStart.Text = "STOP"
                TimerBarcode.Start()
            End If
        Else


            Me.PictureBoxCameraDisplay.BackColor = System.Drawing.Color.White
            TimerBarcode.Stop()

            ButtonStart.Text = "START"




        End If


    End Sub



    Private Sub CaptureDisplay(sender As Object, eventArgs As NewFrameEventArgs)
        bitmapDisplay = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBoxCameraDisplay.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub ButtonDirect_Click(sender As Object, e As EventArgs) Handles ButtonDirect.Click
        Dim contacttracing As New ContactTracing
        Me.Hide()
        contacttracing.Show()

    End Sub

    Private Sub ButtonScan_Click(sender As Object, e As EventArgs) Handles ButtonScan.Click
        CameraLayout.Visible = True
    End Sub


    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TimerBarcode_Tick(sender As Object, e As EventArgs) Handles TimerBarcode.Tick


        If PictureBoxCameraDisplay.Image IsNot Nothing Then

            Dim qrReader As ZXing.BarcodeReader = New ZXing.BarcodeReader()

            Dim output As ZXing.Result = qrReader.Decode(DirectCast(PictureBoxCameraDisplay.Image, Bitmap))

            If output IsNot Nothing Then
                MessageBox.Show(output.ToString())

                Dim contacttracing As New ContactTracing
                Me.Hide()
                contacttracing.Show()

            End If
        End If



    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs)



    End Sub
End Class