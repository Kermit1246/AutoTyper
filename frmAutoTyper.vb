#Region "Imports"
Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports Newtonsoft.Json
#End Region
#Region "Form Settings"
Public Class frmAutoTyper
    Dim WithEvents timer As New Timer()
    Dim repeatCount As Integer = 0
    Dim remainingRepeats As Integer = 0
    Private _settings As New Settings()

    Public Class Settings
        Public Property IntervalMinutes As String
        Public Property IntervalSeconds As String
        Public Property IntervalMilliseconds As String
        Public Property RepeatCount As Integer
        Public Property StringToType As String
        Public Property LoopEnabled As Boolean
        Public Property RepeatEnabled As Boolean
    End Class

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
        btnStop.Enabled = False
        LoadSettings()
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub frmAutoTyper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Save on close
        SaveSettings()
    End Sub
#End Region
#Region "SubMenuItems"
    Private Sub smiExit_Click(sender As Object, e As EventArgs) Handles smiExit.Click
        End
    End Sub

    Private Sub smiOpenConfig_Click(sender As Object, e As EventArgs) Handles smiOpenConfig.Click
        ' Open folder check for json
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "JSON files (*.json)|*.json"
        openFileDialog.Title = "Open Configuration File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim configFile As String = openFileDialog.FileName
            LoadSettingsFromFile(configFile)
        End If
    End Sub

    Private Sub smiSaveConfig_Click(sender As Object, e As EventArgs) Handles smiSaveConfig.Click
        ' Save open folder
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "JSON files (*.json)|*.json"
        saveFileDialog.Title = "Save Configuration File"
        saveFileDialog.FileName = "settings.json"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim configFile As String = saveFileDialog.FileName
            SaveSettingsToFile(configFile)
        End If
    End Sub

    Private Sub LoadSettingsFromFile(configFile As String)
        If File.Exists(configFile) Then
            Dim json As String = File.ReadAllText(configFile)
            _settings = JsonConvert.DeserializeObject(Of Settings)(json)

            ' Structure
            nudMins.Text = _settings.IntervalMinutes
            nudSecs.Text = _settings.IntervalSeconds
            nudMilli.Text = _settings.IntervalMilliseconds
            nudRepeat.Value = _settings.RepeatCount
            txtString.Text = _settings.StringToType
            rbnLoop.Checked = _settings.LoopEnabled
            rbnRepeat.Checked = _settings.RepeatEnabled
        Else
            MessageBox.Show("The specified configuration file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SaveSettingsToFile(configFile As String)
        ' Structure
        _settings.IntervalMinutes = nudMins.Text
        _settings.IntervalSeconds = nudSecs.Text
        _settings.IntervalMilliseconds = nudMilli.Text
        _settings.RepeatCount = nudRepeat.Value
        _settings.StringToType = txtString.Text
        _settings.LoopEnabled = rbnLoop.Checked
        _settings.RepeatEnabled = rbnRepeat.Checked

        Dim json As String = JsonConvert.SerializeObject(_settings)

        File.WriteAllText(configFile, json)
    End Sub
#End Region
#Region "StopStart"
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTyping()
        btnStart.Enabled = False
        btnStop.Enabled = True
        SaveSettings() ' Save on start
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopTyping()
        btnStop.Enabled = False
        btnStart.Enabled = True
        SaveSettings() ' Save on stop
    End Sub

    Private Sub NumberChecker(sender As Object, e As KeyPressEventArgs)
        ' Allow only digits, Backspace, and Delete key
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso Asc(e.KeyChar) <> 127 Then
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Typing"
    Private Sub StartTyping()
        Dim interval As Integer = CalculateInterval()
        ' Console validation, developer tool - Tests for valid response (1)
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
        Dim mins As Integer = If(String.IsNullOrEmpty(nudMins.Text), 0, Integer.Parse(nudMins.Text))
        Dim secs As Integer = If(String.IsNullOrEmpty(nudSecs.Text), 0, Integer.Parse(nudSecs.Text))
        Dim milli As Integer = If(String.IsNullOrEmpty(nudMilli.Text), 0, Integer.Parse(nudMilli.Text))

        ' If no input, automatically make 1 mls
        Dim totalMilliseconds As Integer = (mins * 60 + secs) * 1000 + milli
        If totalMilliseconds <= 0 Then
            totalMilliseconds = 1
        End If

        Return totalMilliseconds
    End Function

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Check for loop rbn selected
        If rbnLoop.Checked Then
            SendKeys.Send(txtString.Text)
            SendKeys.Send("{ENTER}")
            ' Check for rbn loop until selected
        ElseIf rbnRepeat.Checked AndAlso remainingRepeats > 0 Then
            SendKeys.Send(txtString.Text)
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
#End Region
#Region "Autosave Settings"
    Private Sub SaveSettings()
        ' Structure
        _settings.IntervalMinutes = nudMins.Text
        _settings.IntervalSeconds = nudSecs.Text
        _settings.IntervalMilliseconds = nudMilli.Text
        _settings.RepeatCount = nudRepeat.Value
        _settings.StringToType = txtString.Text
        _settings.LoopEnabled = rbnLoop.Checked
        _settings.RepeatEnabled = rbnRepeat.Checked

        ' Saving to json
        Dim settingsFile As String = "settings.json"
        Dim json As String = JsonConvert.SerializeObject(_settings)
        File.WriteAllText(settingsFile, json)
    End Sub

    Private Sub LoadSettings()
        ' Load from json
        Dim settingsFile As String = "settings.json"
        If File.Exists(settingsFile) Then
            Dim json As String = File.ReadAllText(settingsFile)
            _settings = JsonConvert.DeserializeObject(Of Settings)(json)

            ' Structure
            nudMins.Text = _settings.IntervalMinutes
            nudSecs.Text = _settings.IntervalSeconds
            nudMilli.Text = _settings.IntervalMilliseconds
            nudRepeat.Value = _settings.RepeatCount
            txtString.Text = _settings.StringToType
            rbnLoop.Checked = _settings.LoopEnabled
            rbnRepeat.Checked = _settings.RepeatEnabled
        End If
    End Sub
#End Region
End Class
