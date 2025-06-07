<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerInformation
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayUserName = New System.Windows.Forms.Label()
        Me.lblDisplayComputerName = New System.Windows.Forms.Label()
        Me.lblDisplayCPUName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayOperatingSystem = New System.Windows.Forms.Label()
        Me.lblDisplayOSPlatform = New System.Windows.Forms.Label()
        Me.lblDisplayOSVersion = New System.Windows.Forms.Label()
        Me.lblDisplayLanguage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayAvailableMemory = New System.Windows.Forms.Label()
        Me.lblDisplayTotalMemory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrDisplayMemory = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDisplayUserName)
        Me.GroupBox1.Controls.Add(Me.lblDisplayComputerName)
        Me.GroupBox1.Controls.Add(Me.lblDisplayCPUName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox1.Location = New System.Drawing.Point(28, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1189, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Information"
        '
        'lblDisplayUserName
        '
        Me.lblDisplayUserName.AutoSize = True
        Me.lblDisplayUserName.Location = New System.Drawing.Point(560, 138)
        Me.lblDisplayUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayUserName.Name = "lblDisplayUserName"
        Me.lblDisplayUserName.Size = New System.Drawing.Size(250, 25)
        Me.lblDisplayUserName.TabIndex = 11
        Me.lblDisplayUserName.Text = "Display User Name"
        '
        'lblDisplayComputerName
        '
        Me.lblDisplayComputerName.AutoSize = True
        Me.lblDisplayComputerName.Location = New System.Drawing.Point(560, 93)
        Me.lblDisplayComputerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayComputerName.Name = "lblDisplayComputerName"
        Me.lblDisplayComputerName.Size = New System.Drawing.Size(306, 25)
        Me.lblDisplayComputerName.TabIndex = 10
        Me.lblDisplayComputerName.Text = "Display Computer Name"
        '
        'lblDisplayCPUName
        '
        Me.lblDisplayCPUName.AutoSize = True
        Me.lblDisplayCPUName.Location = New System.Drawing.Point(560, 46)
        Me.lblDisplayCPUName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayCPUName.Name = "lblDisplayCPUName"
        Me.lblDisplayCPUName.Size = New System.Drawing.Size(236, 25)
        Me.lblDisplayCPUName.TabIndex = 9
        Me.lblDisplayCPUName.Text = "Display CPU Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Current User:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 93)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Computer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplayOperatingSystem)
        Me.GroupBox2.Controls.Add(Me.lblDisplayOSPlatform)
        Me.GroupBox2.Controls.Add(Me.lblDisplayOSVersion)
        Me.GroupBox2.Controls.Add(Me.lblDisplayLanguage)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox2.Location = New System.Drawing.Point(28, 212)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1189, 265)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operating System Information"
        '
        'lblDisplayOperatingSystem
        '
        Me.lblDisplayOperatingSystem.AutoSize = True
        Me.lblDisplayOperatingSystem.Location = New System.Drawing.Point(560, 46)
        Me.lblDisplayOperatingSystem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayOperatingSystem.Name = "lblDisplayOperatingSystem"
        Me.lblDisplayOperatingSystem.Size = New System.Drawing.Size(348, 25)
        Me.lblDisplayOperatingSystem.TabIndex = 12
        Me.lblDisplayOperatingSystem.Text = "Display Operating System"
        '
        'lblDisplayOSPlatform
        '
        Me.lblDisplayOSPlatform.AutoSize = True
        Me.lblDisplayOSPlatform.Location = New System.Drawing.Point(560, 100)
        Me.lblDisplayOSPlatform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayOSPlatform.Name = "lblDisplayOSPlatform"
        Me.lblDisplayOSPlatform.Size = New System.Drawing.Size(278, 25)
        Me.lblDisplayOSPlatform.TabIndex = 13
        Me.lblDisplayOSPlatform.Text = "Display OS Platform"
        '
        'lblDisplayOSVersion
        '
        Me.lblDisplayOSVersion.AutoSize = True
        Me.lblDisplayOSVersion.Location = New System.Drawing.Point(559, 149)
        Me.lblDisplayOSVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayOSVersion.Name = "lblDisplayOSVersion"
        Me.lblDisplayOSVersion.Size = New System.Drawing.Size(264, 25)
        Me.lblDisplayOSVersion.TabIndex = 14
        Me.lblDisplayOSVersion.Text = "Display OS Version"
        '
        'lblDisplayLanguage
        '
        Me.lblDisplayLanguage.AutoSize = True
        Me.lblDisplayLanguage.Location = New System.Drawing.Point(560, 197)
        Me.lblDisplayLanguage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayLanguage.Name = "lblDisplayLanguage"
        Me.lblDisplayLanguage.Size = New System.Drawing.Size(236, 25)
        Me.lblDisplayLanguage.TabIndex = 15
        Me.lblDisplayLanguage.Text = "Display Language"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Language:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OS Version:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 100)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "OS Platform:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Operating System:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDisplayAvailableMemory)
        Me.GroupBox4.Controls.Add(Me.lblDisplayTotalMemory)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox4.Location = New System.Drawing.Point(28, 485)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1189, 191)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Physical Memory (MB)"
        '
        'lblDisplayAvailableMemory
        '
        Me.lblDisplayAvailableMemory.AutoSize = True
        Me.lblDisplayAvailableMemory.Location = New System.Drawing.Point(560, 121)
        Me.lblDisplayAvailableMemory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayAvailableMemory.Name = "lblDisplayAvailableMemory"
        Me.lblDisplayAvailableMemory.Size = New System.Drawing.Size(348, 25)
        Me.lblDisplayAvailableMemory.TabIndex = 16
        Me.lblDisplayAvailableMemory.Text = "Display Available Memory"
        '
        'lblDisplayTotalMemory
        '
        Me.lblDisplayTotalMemory.AutoSize = True
        Me.lblDisplayTotalMemory.Location = New System.Drawing.Point(560, 69)
        Me.lblDisplayTotalMemory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayTotalMemory.Name = "lblDisplayTotalMemory"
        Me.lblDisplayTotalMemory.Size = New System.Drawing.Size(292, 25)
        Me.lblDisplayTotalMemory.TabIndex = 17
        Me.lblDisplayTotalMemory.Text = "Display Total Memory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Memory:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Available Memory: "
        '
        'tmrDisplayMemory
        '
        Me.tmrDisplayMemory.Enabled = True
        '
        'fromComputerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1245, 691)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.AliceBlue
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fromComputerInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Computer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDisplayTotalMemory As Label
    Friend WithEvents lblDisplayAvailableMemory As Label
    Friend WithEvents lblDisplayLanguage As Label
    Friend WithEvents lblDisplayOSVersion As Label
    Friend WithEvents lblDisplayOSPlatform As Label
    Friend WithEvents lblDisplayOperatingSystem As Label
    Friend WithEvents lblDisplayUserName As Label
    Friend WithEvents lblDisplayComputerName As Label
    Friend WithEvents lblDisplayCPUName As Label
    Friend WithEvents tmrDisplayMemory As Timer
End Class
