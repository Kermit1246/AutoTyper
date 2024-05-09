<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoTyper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoTyper))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudMins = New System.Windows.Forms.NumericUpDown()
        Me.nudSecs = New System.Windows.Forms.NumericUpDown()
        Me.nudMilli = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudRepeat = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbnLoop = New System.Windows.Forms.RadioButton()
        Me.rbnRepeat = New System.Windows.Forms.RadioButton()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiSaveConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiOpenConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudMins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMilli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(24, 331)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(206, 46)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStop.Font = New System.Drawing.Font("Malgun Gothic", 9.75!)
        Me.btnStop.Location = New System.Drawing.Point(258, 331)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(206, 46)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudMins)
        Me.GroupBox1.Controls.Add(Me.nudSecs)
        Me.GroupBox1.Controls.Add(Me.nudMilli)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Interval"
        '
        'nudMins
        '
        Me.nudMins.Location = New System.Drawing.Point(49, 33)
        Me.nudMins.Name = "nudMins"
        Me.nudMins.Size = New System.Drawing.Size(85, 20)
        Me.nudMins.TabIndex = 7
        Me.nudMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSecs
        '
        Me.nudSecs.Location = New System.Drawing.Point(181, 33)
        Me.nudSecs.Name = "nudSecs"
        Me.nudSecs.Size = New System.Drawing.Size(85, 20)
        Me.nudSecs.TabIndex = 6
        Me.nudSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudMilli
        '
        Me.nudMilli.Location = New System.Drawing.Point(312, 33)
        Me.nudMilli.Name = "nudMilli"
        Me.nudMilli.Size = New System.Drawing.Size(85, 20)
        Me.nudMilli.TabIndex = 5
        Me.nudMilli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Milliseconds"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(181, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seconds"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(49, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Minutes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudRepeat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rbnLoop)
        Me.GroupBox2.Controls.Add(Me.rbnRepeat)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 113)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repetition"
        '
        'nudRepeat
        '
        Me.nudRepeat.Location = New System.Drawing.Point(81, 35)
        Me.nudRepeat.Name = "nudRepeat"
        Me.nudRepeat.Size = New System.Drawing.Size(51, 20)
        Me.nudRepeat.TabIndex = 4
        Me.nudRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(138, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "times"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbnLoop
        '
        Me.rbnLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnLoop.Location = New System.Drawing.Point(6, 71)
        Me.rbnLoop.Name = "rbnLoop"
        Me.rbnLoop.Size = New System.Drawing.Size(162, 20)
        Me.rbnLoop.TabIndex = 1
        Me.rbnLoop.TabStop = True
        Me.rbnLoop.Text = "Repeat until Stopped"
        Me.rbnLoop.UseVisualStyleBackColor = True
        '
        'rbnRepeat
        '
        Me.rbnRepeat.Location = New System.Drawing.Point(6, 33)
        Me.rbnRepeat.Name = "rbnRepeat"
        Me.rbnRepeat.Size = New System.Drawing.Size(91, 20)
        Me.rbnRepeat.TabIndex = 0
        Me.rbnRepeat.TabStop = True
        Me.rbnRepeat.Text = "Repeat"
        Me.rbnRepeat.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(184, 37)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(200, 20)
        Me.txtString.TabIndex = 6
        Me.txtString.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtString)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 85)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Typing Phrase"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Enter the phrase to autoype:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiSaveConfig, Me.smiOpenConfig})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'smiSaveConfig
        '
        Me.smiSaveConfig.Name = "smiSaveConfig"
        Me.smiSaveConfig.Size = New System.Drawing.Size(180, 22)
        Me.smiSaveConfig.Text = "Save Configuration"
        '
        'smiOpenConfig
        '
        Me.smiOpenConfig.Name = "smiOpenConfig"
        Me.smiOpenConfig.Size = New System.Drawing.Size(180, 22)
        Me.smiOpenConfig.Text = "Open Config"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiExit})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'smiExit
        '
        Me.smiExit.Name = "smiExit"
        Me.smiExit.Size = New System.Drawing.Size(180, 22)
        Me.smiExit.Text = "Exit"
        '
        'frmAutoTyper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 417)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAutoTyper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoTyper"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudMins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMilli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbnLoop As RadioButton
    Friend WithEvents rbnRepeat As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents nudRepeat As NumericUpDown
    Friend WithEvents txtString As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudMins As NumericUpDown
    Friend WithEvents nudSecs As NumericUpDown
    Friend WithEvents nudMilli As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents smiSaveConfig As ToolStripMenuItem
    Friend WithEvents smiOpenConfig As ToolStripMenuItem
    Friend WithEvents smiExit As ToolStripMenuItem
End Class
