Imports Microsoft.VisualBasic.Devices

Public Class frmAutoTyper
    Dim WithEvents timer As New Timer()
    Dim repeatCount As Integer = 0
    Dim remainingRepeats As Integer = 0

    Private Sub SetFormTitle(isTyping As Boolean)
        ' Modifying title name
        If isTyping Then
            Me.Text = "Typing - AutoTyper"
        Else
            Me.Text = "Idle - AutoTyper"
        End If
    End Sub

    Private Sub frmAutoTyper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbnLoop.Checked = True
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTyping()
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopTyping()
        btnStop.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub NumberChecker(sender As Object, e As KeyPressEventArgs) Handles txtMins.KeyPress, txtSecs.KeyPress, txtMilli.KeyPress
        ' Allow only digits, Backspace, and the Delete key
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso Asc(e.KeyChar) <> 127 Then
            e.Handled = True
        End If
    End Sub

    ' Private Sub frmAutoTyper_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    ' This does not work I do not know why
    ' If e.KeyCode = Keys.S Then
    ' StartTyping()
    ' Else'If e.KeyCode = Keys.Q Then
    ' StopTyping()
    ' End If
    ' End Sub

    Private Sub StartTyping()
        Dim interval As Integer = CalculateInterval()
        ' Checking for #1
        Console.WriteLine("Calculated interval: " & interval)
        timer.Interval = interval

        repeatCount = Convert.ToInt32(nudRepeat.Value)
        remainingRepeats = repeatCount

        ' Start typing script / disable button / set to Typing - Autotyper
        timer.Start()
        btnStart.Enabled = False
        SetFormTitle(True)
    End Sub

    Private Sub StopTyping()
        timer.Stop()
        btnStop.Enabled = False
        remainingRepeats = 0
        SetFormTitle(False)
    End Sub

    Private Function CalculateInterval() As Integer
        Dim mins As Integer = If(String.IsNullOrEmpty(txtMins.Text), 0, Integer.Parse(txtMins.Text))
        Dim secs As Integer = If(String.IsNullOrEmpty(txtSecs.Text), 0, Integer.Parse(txtSecs.Text))
        Dim milli As Integer = If(String.IsNullOrEmpty(txtMilli.Text), 0, Integer.Parse(txtMilli.Text))

        ' If no input, automatically make 1 millisecond
        Dim totalMilliseconds As Integer = (mins * 60 + secs) * 1000 + milli
        If totalMilliseconds <= 0 Then
            totalMilliseconds = 1
        End If

        Return totalMilliseconds
    End Function

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Check for loop rbn selected
        If rbnLoop.Checked Then
            SendKeys.Send("a")
            SendKeys.Send("{ENTER}")
            ' Check for rbn loop until selected
        ElseIf rbnRepeat.Checked AndAlso remainingRepeats > 0 Then
            SendKeys.Send("a")
            Threading.Thread.Sleep(1000)
            SendKeys.Send("{ENTER}")
            remainingRepeats -= 1
            ' Go down by 1 until 0 is met
            If remainingRepeats = 0 Then
                StopTyping()
                btnStart.Enabled = True
                btnStop.Enabled = False
            End If
        Else
            ' If not looping, break
            StopTyping()
        End If
    End Sub
End Class
