Public Class Form1

    Private countDownSeconds As Integer '// variable that stores countdown value
    Private hours As String
    Private minutes As String
    Private seconds As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countDownSeconds = 18000 '// seconds
        TmrEvent.Interval = 1000 '// 1 second
        TmrEvent.Enabled = True '// timer is enabled
    End Sub

    Private Sub TmrEvent_Tick(sender As Object, e As EventArgs) Handles TmrEvent.Tick
        countDownSeconds -= 1 '// decrement the value

        hours = Fix(countDownSeconds / 3600)
        minutes = Format(Fix((countDownSeconds Mod 3600) / 60), "00")
        seconds = Format(Fix((countDownSeconds Mod 3600) Mod 60), "00")

        lblHours.Text = hours
        lblMinutes.Text = minutes
        lblSeconds.Text = seconds

        If countDownSeconds = 0 Then
            '// time expired
            '// do not allow this procedure to call again.
            TmrEvent.Enabled = False
            MsgBox("Time has expired")
        End If
    End Sub

End Class
