Imports System.Diagnostics
Imports AForge.Video.DirectShow
Imports System.IO
Imports AForge

Imports System.Drawing.Imaging
Imports AForge.Video
Imports System.Drawing

Public Class Homepage

    Dim Camera As VideoCaptureDevice
    Dim bitmapDisplay As Bitmap


    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Dim cameraDisplay As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()

        If cameraDisplay.ShowDialog() = DialogResult.OK Then
            Camera = cameraDisplay.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf CaptureDisplay)
            Camera.Start()

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
End Class