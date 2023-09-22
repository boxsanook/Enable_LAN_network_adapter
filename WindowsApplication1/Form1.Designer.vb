<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ConnectToWifiButton = New System.Windows.Forms.Button()
        Me.ConnectToLANButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_WiFi_MACAddress = New System.Windows.Forms.TextBox()
        Me.txt_LAN_MACAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectToWifiButton
        '
        Me.ConnectToWifiButton.BackColor = System.Drawing.Color.Green
        Me.ConnectToWifiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectToWifiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ConnectToWifiButton.ForeColor = System.Drawing.Color.White
        Me.ConnectToWifiButton.Location = New System.Drawing.Point(472, 15)
        Me.ConnectToWifiButton.Name = "ConnectToWifiButton"
        Me.ConnectToWifiButton.Size = New System.Drawing.Size(150, 28)
        Me.ConnectToWifiButton.TabIndex = 0
        Me.ConnectToWifiButton.Text = "ConnectToWifi"
        Me.ConnectToWifiButton.UseVisualStyleBackColor = False
        '
        'ConnectToLANButton
        '
        Me.ConnectToLANButton.BackColor = System.Drawing.Color.Teal
        Me.ConnectToLANButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectToLANButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ConnectToLANButton.ForeColor = System.Drawing.Color.White
        Me.ConnectToLANButton.Location = New System.Drawing.Point(472, 49)
        Me.ConnectToLANButton.Name = "ConnectToLANButton"
        Me.ConnectToLANButton.Size = New System.Drawing.Size(150, 28)
        Me.ConnectToLANButton.TabIndex = 1
        Me.ConnectToLANButton.Text = "ConnectToLAN"
        Me.ConnectToLANButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(610, 279)
        Me.DataGridView1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Purple
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(472, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Get Network Adapter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_WiFi_MACAddress
        '
        Me.txt_WiFi_MACAddress.Location = New System.Drawing.Point(186, 15)
        Me.txt_WiFi_MACAddress.Multiline = True
        Me.txt_WiFi_MACAddress.Name = "txt_WiFi_MACAddress"
        Me.txt_WiFi_MACAddress.Size = New System.Drawing.Size(280, 26)
        Me.txt_WiFi_MACAddress.TabIndex = 4
        '
        'txt_LAN_MACAddress
        '
        Me.txt_LAN_MACAddress.Location = New System.Drawing.Point(186, 51)
        Me.txt_LAN_MACAddress.Multiline = True
        Me.txt_LAN_MACAddress.Name = "txt_LAN_MACAddress"
        Me.txt_LAN_MACAddress.Size = New System.Drawing.Size(280, 26)
        Me.txt_LAN_MACAddress.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WiFi MAC Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "LAN MAC Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Network Adapter"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "LAN And Wifi Switch"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_LAN_MACAddress)
        Me.Controls.Add(Me.txt_WiFi_MACAddress)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ConnectToLANButton)
        Me.Controls.Add(Me.ConnectToWifiButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 452)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 452)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAN And Wifi Switch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConnectToWifiButton As System.Windows.Forms.Button
    Friend WithEvents ConnectToLANButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txt_WiFi_MACAddress As System.Windows.Forms.TextBox
    Friend WithEvents txt_LAN_MACAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
