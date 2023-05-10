<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCMonitor
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MCMonitor))
        Me.実行 = New System.Windows.Forms.Button()
        Me.IPAddrTextBox = New System.Windows.Forms.TextBox()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.Device = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceCombo = New System.Windows.Forms.ComboBox()
        Me.PointsBOX = New System.Windows.Forms.NumericUpDown()
        Me.書込ラジオ = New System.Windows.Forms.RadioButton()
        Me.読込ラジオ = New System.Windows.Forms.RadioButton()
        Me.PortNumBOX = New System.Windows.Forms.NumericUpDown()
        Me.符号付表示 = New System.Windows.Forms.CheckBox()
        Me.NumBox = New System.Windows.Forms.TextBox()
        Me.PointsLabel = New System.Windows.Forms.Label()
        Me.表更新と同時に読込 = New System.Windows.Forms.CheckBox()
        Me.ダブルワード = New System.Windows.Forms.CheckBox()
        Me.DeviceLabel = New System.Windows.Forms.Label()
        Me.FormatLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComPanel = New System.Windows.Forms.Panel()
        Me.COMBINARY = New System.Windows.Forms.ComboBox()
        Me.PLCDev = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SoftName = New System.Windows.Forms.Label()
        Me.TimeOutBOX = New System.Windows.Forms.NumericUpDown()
        Me.TimeOutLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PointsBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortNumBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComPanel.SuspendLayout()
        CType(Me.TimeOutBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '実行
        '
        Me.実行.Location = New System.Drawing.Point(311, 62)
        Me.実行.Name = "実行"
        Me.実行.Size = New System.Drawing.Size(118, 48)
        Me.実行.TabIndex = 0
        Me.実行.Text = "Read/Write"
        Me.実行.UseVisualStyleBackColor = True
        '
        'IPAddrTextBox
        '
        Me.IPAddrTextBox.Location = New System.Drawing.Point(500, 83)
        Me.IPAddrTextBox.Name = "IPAddrTextBox"
        Me.IPAddrTextBox.Size = New System.Drawing.Size(79, 19)
        Me.IPAddrTextBox.TabIndex = 2
        Me.IPAddrTextBox.Text = "192.168.1.10"
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(583, 87)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(26, 12)
        Me.PortLabel.TabIndex = 4
        Me.PortLabel.Text = "Port"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(441, 85)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(55, 12)
        Me.AddressLabel.TabIndex = 5
        Me.AddressLabel.Text = "IPAdrress"
        '
        'Grid1
        '
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Device, Me.Value})
        Me.Grid1.Location = New System.Drawing.Point(6, 116)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RowTemplate.Height = 21
        Me.Grid1.Size = New System.Drawing.Size(681, 476)
        Me.Grid1.TabIndex = 6
        '
        'Device
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.Device.DefaultCellStyle = DataGridViewCellStyle1
        Me.Device.HeaderText = "PLC Device"
        Me.Device.MaxInputLength = 12
        Me.Device.Name = "Device"
        Me.Device.ReadOnly = True
        Me.Device.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Device.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Value
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Value.DefaultCellStyle = DataGridViewCellStyle2
        Me.Value.HeaderText = "Value"
        Me.Value.MaxInputLength = 15
        Me.Value.Name = "Value"
        Me.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Value.Width = 200
        '
        'DeviceCombo
        '
        Me.DeviceCombo.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DeviceCombo.FormattingEnabled = True
        Me.DeviceCombo.ItemHeight = 19
        Me.DeviceCombo.Items.AddRange(New Object() {"D", "M", "X", "Y", "L", "B", "W", "TS", "TC", "CS", "CC"})
        Me.DeviceCombo.Location = New System.Drawing.Point(10, 27)
        Me.DeviceCombo.Name = "DeviceCombo"
        Me.DeviceCombo.Size = New System.Drawing.Size(92, 27)
        Me.DeviceCombo.TabIndex = 13
        Me.DeviceCombo.Text = "D"
        '
        'PointsBOX
        '
        Me.PointsBOX.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.PointsBOX.Location = New System.Drawing.Point(215, 28)
        Me.PointsBOX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.PointsBOX.Name = "PointsBOX"
        Me.PointsBOX.Size = New System.Drawing.Size(86, 26)
        Me.PointsBOX.TabIndex = 14
        '
        '書込ラジオ
        '
        Me.書込ラジオ.AutoSize = True
        Me.書込ラジオ.Location = New System.Drawing.Point(380, 35)
        Me.書込ラジオ.Name = "書込ラジオ"
        Me.書込ラジオ.Size = New System.Drawing.Size(49, 16)
        Me.書込ラジオ.TabIndex = 15
        Me.書込ラジオ.Text = "Write"
        Me.書込ラジオ.UseVisualStyleBackColor = True
        '
        '読込ラジオ
        '
        Me.読込ラジオ.AutoSize = True
        Me.読込ラジオ.Checked = True
        Me.読込ラジオ.Location = New System.Drawing.Point(316, 35)
        Me.読込ラジオ.Name = "読込ラジオ"
        Me.読込ラジオ.Size = New System.Drawing.Size(49, 16)
        Me.読込ラジオ.TabIndex = 16
        Me.読込ラジオ.TabStop = True
        Me.読込ラジオ.Text = "Read"
        Me.読込ラジオ.UseVisualStyleBackColor = True
        '
        'PortNumBOX
        '
        Me.PortNumBOX.Location = New System.Drawing.Point(615, 84)
        Me.PortNumBOX.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.PortNumBOX.Name = "PortNumBOX"
        Me.PortNumBOX.Size = New System.Drawing.Size(69, 19)
        Me.PortNumBOX.TabIndex = 17
        Me.PortNumBOX.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        '符号付表示
        '
        Me.符号付表示.AutoSize = True
        Me.符号付表示.Checked = True
        Me.符号付表示.CheckState = System.Windows.Forms.CheckState.Checked
        Me.符号付表示.Location = New System.Drawing.Point(69, 87)
        Me.符号付表示.Name = "符号付表示"
        Me.符号付表示.Size = New System.Drawing.Size(100, 16)
        Me.符号付表示.TabIndex = 21
        Me.符号付表示.Text = "signed decimal"
        Me.符号付表示.UseVisualStyleBackColor = True
        '
        'NumBox
        '
        Me.NumBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NumBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.NumBox.Location = New System.Drawing.Point(105, 28)
        Me.NumBox.Name = "NumBox"
        Me.NumBox.Size = New System.Drawing.Size(87, 26)
        Me.NumBox.TabIndex = 22
        Me.NumBox.Text = "0"
        '
        'PointsLabel
        '
        Me.PointsLabel.AutoSize = True
        Me.PointsLabel.Location = New System.Drawing.Point(213, 9)
        Me.PointsLabel.Name = "PointsLabel"
        Me.PointsLabel.Size = New System.Drawing.Size(40, 12)
        Me.PointsLabel.TabIndex = 23
        Me.PointsLabel.Text = "figures"
        '
        '表更新と同時に読込
        '
        Me.表更新と同時に読込.AutoSize = True
        Me.表更新と同時に読込.Location = New System.Drawing.Point(317, 12)
        Me.表更新と同時に読込.Name = "表更新と同時に読込"
        Me.表更新と同時に読込.Size = New System.Drawing.Size(116, 16)
        Me.表更新と同時に読込.TabIndex = 25
        Me.表更新と同時に読込.Text = "Event-driven read"
        Me.表更新と同時に読込.UseVisualStyleBackColor = True
        '
        'ダブルワード
        '
        Me.ダブルワード.AutoSize = True
        Me.ダブルワード.Location = New System.Drawing.Point(12, 87)
        Me.ダブルワード.Name = "ダブルワード"
        Me.ダブルワード.Size = New System.Drawing.Size(57, 16)
        Me.ダブルワード.TabIndex = 26
        Me.ダブルワード.Text = "DWord"
        Me.ダブルワード.UseVisualStyleBackColor = True
        '
        'DeviceLabel
        '
        Me.DeviceLabel.AutoSize = True
        Me.DeviceLabel.Location = New System.Drawing.Point(11, 9)
        Me.DeviceLabel.Name = "DeviceLabel"
        Me.DeviceLabel.Size = New System.Drawing.Size(65, 12)
        Me.DeviceLabel.TabIndex = 28
        Me.DeviceLabel.Text = "PLC Device"
        '
        'FormatLabel
        '
        Me.FormatLabel.AutoSize = True
        Me.FormatLabel.Location = New System.Drawing.Point(8, 66)
        Me.FormatLabel.Name = "FormatLabel"
        Me.FormatLabel.Size = New System.Drawing.Size(41, 12)
        Me.FormatLabel.TabIndex = 29
        Me.FormatLabel.Text = "Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Com dest(PLC)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-1, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 38)
        Me.Panel1.TabIndex = 32
        '
        'ComPanel
        '
        Me.ComPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComPanel.Controls.Add(Me.COMBINARY)
        Me.ComPanel.Controls.Add(Me.Panel1)
        Me.ComPanel.Location = New System.Drawing.Point(438, 70)
        Me.ComPanel.Name = "ComPanel"
        Me.ComPanel.Size = New System.Drawing.Size(358, 38)
        Me.ComPanel.TabIndex = 31
        '
        'COMBINARY
        '
        Me.COMBINARY.FormattingEnabled = True
        Me.COMBINARY.Items.AddRange(New Object() {"binary", "ASCII"})
        Me.COMBINARY.Location = New System.Drawing.Point(251, 11)
        Me.COMBINARY.Name = "COMBINARY"
        Me.COMBINARY.Size = New System.Drawing.Size(76, 20)
        Me.COMBINARY.TabIndex = 37
        Me.COMBINARY.Text = "binary"
        '
        'PLCDev
        '
        Me.PLCDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLCDev.Location = New System.Drawing.Point(7, 12)
        Me.PLCDev.Name = "PLCDev"
        Me.PLCDev.Size = New System.Drawing.Size(299, 47)
        Me.PLCDev.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(7, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 38)
        Me.Panel2.TabIndex = 33
        '
        'SoftName
        '
        Me.SoftName.AutoSize = True
        Me.SoftName.Location = New System.Drawing.Point(645, 9)
        Me.SoftName.Name = "SoftName"
        Me.SoftName.Size = New System.Drawing.Size(128, 12)
        Me.SoftName.TabIndex = 34
        Me.SoftName.Text = "MELSEC Q PLC Monitor"
        '
        'TimeOutBOX
        '
        Me.TimeOutBOX.Location = New System.Drawing.Point(443, 34)
        Me.TimeOutBOX.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.TimeOutBOX.Name = "TimeOutBOX"
        Me.TimeOutBOX.Size = New System.Drawing.Size(69, 19)
        Me.TimeOutBOX.TabIndex = 35
        Me.TimeOutBOX.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'TimeOutLabel
        '
        Me.TimeOutLabel.AutoSize = True
        Me.TimeOutLabel.Location = New System.Drawing.Point(437, 16)
        Me.TimeOutLabel.Name = "TimeOutLabel"
        Me.TimeOutLabel.Size = New System.Drawing.Size(90, 12)
        Me.TimeOutLabel.TabIndex = 36
        Me.TimeOutLabel.Text = "timeout(10msec)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MCMonitor.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(779, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 37)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'MCMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 604)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TimeOutLabel)
        Me.Controls.Add(Me.TimeOutBOX)
        Me.Controls.Add(Me.SoftName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FormatLabel)
        Me.Controls.Add(Me.DeviceLabel)
        Me.Controls.Add(Me.ダブルワード)
        Me.Controls.Add(Me.表更新と同時に読込)
        Me.Controls.Add(Me.PointsLabel)
        Me.Controls.Add(Me.NumBox)
        Me.Controls.Add(Me.符号付表示)
        Me.Controls.Add(Me.PortNumBOX)
        Me.Controls.Add(Me.読込ラジオ)
        Me.Controls.Add(Me.書込ラジオ)
        Me.Controls.Add(Me.PointsBOX)
        Me.Controls.Add(Me.DeviceCombo)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.IPAddrTextBox)
        Me.Controls.Add(Me.実行)
        Me.Controls.Add(Me.ComPanel)
        Me.Controls.Add(Me.PLCDev)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MCMonitor"
        Me.Text = "MCMonitor"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PointsBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortNumBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComPanel.ResumeLayout(False)
        CType(Me.TimeOutBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 実行 As System.Windows.Forms.Button
    Friend WithEvents IPAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents DeviceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PointsBOX As System.Windows.Forms.NumericUpDown
    Friend WithEvents 書込ラジオ As System.Windows.Forms.RadioButton
    Friend WithEvents 読込ラジオ As System.Windows.Forms.RadioButton
    Friend WithEvents PortNumBOX As System.Windows.Forms.NumericUpDown
    Friend WithEvents 符号付表示 As System.Windows.Forms.CheckBox
    Friend WithEvents NumBox As System.Windows.Forms.TextBox
    Friend WithEvents PointsLabel As System.Windows.Forms.Label
    Friend WithEvents 表更新と同時に読込 As System.Windows.Forms.CheckBox
    Friend WithEvents ダブルワード As System.Windows.Forms.CheckBox
    Friend WithEvents DeviceLabel As System.Windows.Forms.Label
    Friend WithEvents FormatLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComPanel As System.Windows.Forms.Panel
    Friend WithEvents PLCDev As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SoftName As System.Windows.Forms.Label
    Friend WithEvents Device As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOutBOX As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimeOutLabel As System.Windows.Forms.Label
    Friend WithEvents COMBINARY As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
