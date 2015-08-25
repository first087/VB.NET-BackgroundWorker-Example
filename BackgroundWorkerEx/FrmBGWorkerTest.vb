Public Class FrmBGWorkerTest

#Region "Constructor & Destructor"
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UpdateProgress(0)

        LblDateTime.Text = ""
    End Sub
#End Region

#Region "Local Function"
    Private Sub UpdateProgress(ByVal percent As Integer)
        PgbDownloadPercent.Value = percent
        LblDownloadPercent.Text = String.Format("Download {0}%", percent)
    End Sub
#End Region

#Region "Event"
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        BtnStop.Enabled = True
        BtnStart.Enabled = False

        ' ตัวอย่าง RunWorkerAsync แบบไม่มี Input
        BgwDownload.RunWorkerAsync()

        ' ตัวอย่าง RunWorkerAsync แบบมี Input
        'Dim intStart As Integer = 1
        'BgwDownload.RunWorkerAsync(intStart)
    End Sub

    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        BgwDownload.CancelAsync()
    End Sub

    Private Sub TmrNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrNow.Tick
        LblDateTime.Text = String.Format("{0} [Busy = {1}]", Now.ToString(), BgwDownload.IsBusy)
    End Sub

    Private Sub BgwDownload_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgwDownload.DoWork
        Dim intStart As Integer = 1
        If e.Argument IsNot Nothing Then intStart = DirectCast(e.Argument, Integer)

        For i As Integer = intStart To 100
            If BgwDownload.CancellationPending Then e.Cancel = True : Return
            Threading.Thread.Sleep(50)  ' Simulate download
            BgwDownload.ReportProgress(i)

            ' ตัวอย่างการทำให้เกิด Error เพื่อทดสอบการตรวจสอบ Error บน BackgroundWorker
            'If i = 10 Then Throw New Exception("ทดสอบ error")
        Next

        e.Result = "ทดสอบ return ข้อมูล"
    End Sub

    Private Sub BgwDownload_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BgwDownload.ProgressChanged
        UpdateProgress(e.ProgressPercentage)
    End Sub

    Private Sub BgwDownload_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgwDownload.RunWorkerCompleted
        BtnStart.Enabled = True
        BtnStop.Enabled = False

        Select Case True
            Case e.Cancelled
                MessageBox.Show("Download Cancel")
            Case e.Error IsNot Nothing
                MessageBox.Show("Download Error / Error Message = " & e.Error.Message)
            Case Else
                MessageBox.Show("Download Complete / Result = " & DirectCast(e.Result, String))
        End Select
    End Sub
#End Region
End Class
