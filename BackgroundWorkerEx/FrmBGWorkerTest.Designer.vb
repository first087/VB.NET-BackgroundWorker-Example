<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBGWorkerTest
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
        Me.components = New System.ComponentModel.Container
        Me.BtnStart = New System.Windows.Forms.Button
        Me.BtnStop = New System.Windows.Forms.Button
        Me.PgbDownloadPercent = New System.Windows.Forms.ProgressBar
        Me.LblDownloadPercent = New System.Windows.Forms.Label
        Me.LblDateTime = New System.Windows.Forms.Label
        Me.TmrNow = New System.Windows.Forms.Timer(Me.components)
        Me.BgwDownload = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnStart.Location = New System.Drawing.Point(68, 66)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnStop.Enabled = False
        Me.BtnStop.Location = New System.Drawing.Point(149, 66)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 1
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'PgbDownloadPercent
        '
        Me.PgbDownloadPercent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PgbDownloadPercent.Location = New System.Drawing.Point(12, 12)
        Me.PgbDownloadPercent.Name = "PgbDownloadPercent"
        Me.PgbDownloadPercent.Size = New System.Drawing.Size(268, 23)
        Me.PgbDownloadPercent.TabIndex = 2
        '
        'LblDownloadPercent
        '
        Me.LblDownloadPercent.AutoSize = True
        Me.LblDownloadPercent.Location = New System.Drawing.Point(12, 38)
        Me.LblDownloadPercent.Name = "LblDownloadPercent"
        Me.LblDownloadPercent.Size = New System.Drawing.Size(106, 13)
        Me.LblDownloadPercent.TabIndex = 3
        Me.LblDownloadPercent.Text = "LblDownloadPercent"
        '
        'LblDateTime
        '
        Me.LblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.Location = New System.Drawing.Point(12, 92)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(67, 13)
        Me.LblDateTime.TabIndex = 4
        Me.LblDateTime.Text = "LblDateTime"
        '
        'TmrNow
        '
        Me.TmrNow.Enabled = True
        '
        'BgwDownload
        '
        Me.BgwDownload.WorkerReportsProgress = True
        Me.BgwDownload.WorkerSupportsCancellation = True
        '
        'FrmBGWorkerTest
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(292, 114)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.LblDownloadPercent)
        Me.Controls.Add(Me.PgbDownloadPercent)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBGWorkerTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackgroundWorker Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents PgbDownloadPercent As System.Windows.Forms.ProgressBar
    Friend WithEvents LblDownloadPercent As System.Windows.Forms.Label
    Friend WithEvents LblDateTime As System.Windows.Forms.Label
    Friend WithEvents TmrNow As System.Windows.Forms.Timer
    Friend WithEvents BgwDownload As System.ComponentModel.BackgroundWorker

End Class
