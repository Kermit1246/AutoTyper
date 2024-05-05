<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoTyper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoTyper))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMins = New System.Windows.Forms.TextBox()
        Me.txtMilli = New System.Windows.Forms.TextBox()
        Me.txtSecs = New System.Windows.Forms.TextBox()
        Me.btnHotkey = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudRepeat = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbnLoop = New System.Windows.Forms.RadioButton()
        Me.rbnRepeat = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(24, 263)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(206, 46)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start (s)"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStop.Font = New System.Drawing.Font("Malgun Gothic", 9.75!)
        Me.btnStop.Location = New System.Drawing.Point(258, 263)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(206, 46)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop (q)"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMins)
        Me.GroupBox1.Controls.Add(Me.txtMilli)
        Me.GroupBox1.Controls.Add(Me.txtSecs)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Interval"
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
        'txtMins
        '
        Me.txtMins.Location = New System.Drawing.Point(49, 33)
        Me.txtMins.Name = "txtMins"
        Me.txtMins.Size = New System.Drawing.Size(85, 20)
        Me.txtMins.TabIndex = 2
        Me.txtMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMilli
        '
        Me.txtMilli.Location = New System.Drawing.Point(312, 33)
        Me.txtMilli.Name = "txtMilli"
        Me.txtMilli.Size = New System.Drawing.Size(85, 20)
        Me.txtMilli.TabIndex = 1
        Me.txtMilli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSecs
        '
        Me.txtSecs.Location = New System.Drawing.Point(181, 33)
        Me.txtSecs.Name = "txtSecs"
        Me.txtSecs.Size = New System.Drawing.Size(85, 20)
        Me.txtSecs.TabIndex = 0
        Me.txtSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnHotkey
        '
        Me.btnHotkey.BackColor = System.Drawing.Color.Transparent
        Me.btnHotkey.Enabled = False
        Me.btnHotkey.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHotkey.Location = New System.Drawing.Point(24, 315)
        Me.btnHotkey.Name = "btnHotkey"
        Me.btnHotkey.Size = New System.Drawing.Size(206, 46)
        Me.btnHotkey.TabIndex = 3
        Me.btnHotkey.Text = "to be added"
        Me.btnHotkey.UseVisualStyleBackColor = False
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.Transparent
        Me.btnRecord.Enabled = False
        Me.btnRecord.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.Location = New System.Drawing.Point(258, 315)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(206, 46)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "to be added"
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nudRepeat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rbnLoop)
        Me.GroupBox2.Controls.Add(Me.rbnRepeat)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 120)
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
        'frmAutoTyper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(490, 405)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.btnHotkey)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAutoTyper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoTyper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMilli As TextBox
    Friend WithEvents txtSecs As TextBox
    Friend WithEvents txtMins As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHotkey As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbnLoop As RadioButton
    Friend WithEvents rbnRepeat As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents nudRepeat As NumericUpDown
End Class
