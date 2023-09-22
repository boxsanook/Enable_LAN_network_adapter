Imports System.Windows.Forms
Imports System.Windows.Input
Imports System.Management
Imports System.IO
Imports Microsoft.VisualBasic.Devices


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 
        ' Assuming you have a setting named "MyStringSetting"
        txt_LAN_MACAddress.Text = My.Settings.LAN_MACAddress
        txt_WiFi_MACAddress.Text = My.Settings.WiFi_MACAddress 

        Timer1.Stop()
        Timer1.Start()
        ConnectToLANButton_Click(sender, e)

    End Sub

    Private WithEvents keyHook As New KeyboardHookX()
    Private Sub keyHook_KeyDown(sender As Object, e As KeyEventArgs) Handles keyHook.KeyDown 
        ' Check if the "A" key is pressed and the Ctrl key is pressed simultaneously
        If e.KeyCode = Keys.A AndAlso (Control.ModifierKeys And Keys.Control) = Keys.Control AndAlso (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
            ' Perform an action when the "A" key and Ctrl key are pressed simultaneously
            'MessageBox.Show("Ctrl + A key combination is pressed.")
            'If ConnectToLANButton.Enabled = True Then 
            '    ConnectToWifiButton_Click(sender, e)
            'Else
            '    ConnectToLANButton_Click(sender, e)
            'End If
        End If
    End Sub
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        ' Unhook the keyboard hook when the form is closing
        keyHook.Unhook()
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        AddToStartup()
    End Sub
    Private Sub AddToStartup()
        ' Get the path to the user's Startup folder
        Dim startupFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        ' Specify the name of the shortcut (e.g., your application name)
        Dim shortcutName As String = Application.ProductName & ".lnk" '= "YourApplication.lnk"
        ' Create the full path to the shortcut
        Dim shortcutPath As String = Path.Combine(startupFolderPath, shortcutName)

        ' Check if the shortcut already exists
        If Not File.Exists(shortcutPath) Then
            ' Create a WshShell object (Windows Script Host)
            Dim shell As Object = CreateObject("WScript.Shell")

            ' Create a shortcut object
            Dim shortcut As Object = shell.CreateShortcut(shortcutPath)

            ' Set the properties of the shortcut (e.g., target path, working directory, icon)
            shortcut.TargetPath = Application.CommonAppDataPath ' "C:\Path\To\Your\Application.exe" ' Replace with the actual path to your application
            'shortcut.WorkingDirectory = Application. '"C:\Path\To\Your\ApplicationDirectory" ' Replace with the actual directory of your application
            shortcut.IconLocation = "C:\Users\anulak\documents\visual studio 2010\Projects\WindowsApplication1\WindowsApplication1\wifi-signal.ico" ' Replace with the actual path to your application's icon

            ' Save the shortcut
            shortcut.Save()

            ' Inform the user that the application has been added to Startup
            MessageBox.Show("Your application has been added to Startup.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Inform the user that the shortcut already exists
            MessageBox.Show("Your application is already in Startup.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub ConnectToWifiButton_Click(sender As Object, e As EventArgs) Handles ConnectToWifiButton.Click 
        ' Assuming you have a setting named "MyStringSetting"
        My.Settings.LAN_MACAddress = txt_LAN_MACAddress.Text
        My.Settings.WiFi_MACAddress = txt_WiFi_MACAddress.Text
        My.Settings.Save() ' Save the settings to the application configuration file 

        ' Disconnect LAN
        DisconnectLAN()
        'ConnectWiFi()
        ' Connect to Wi-Fi (replace "YourSSID" and "YourPassword" with your Wi-Fi details)


        'ConnectToAdapter(txt_WiFi_MACAddress.Text)
        'DisconnectAdapter(txt_LAN_MACAddress.Text)

        ConnectToWiFi("Alucon-TestServer", "AB00B00683")
        ConnectToLANButton.Enabled = True
        ConnectToWifiButton.Enabled = False
    End Sub

    Private Sub ConnectToLANButton_Click(sender As Object, e As EventArgs) Handles ConnectToLANButton.Click

        ' Assuming you have a setting named "MyStringSetting"
        My.Settings.LAN_MACAddress = txt_LAN_MACAddress.Text
        My.Settings.WiFi_MACAddress = txt_WiFi_MACAddress.Text
        My.Settings.Save() ' Save the settings to the application configuration file 

        ConnectToAdapter(txt_LAN_MACAddress.Text)
        DisconnectAdapter(txt_WiFi_MACAddress.Text)

        ' Disconnect Wi-Fi
        DisconnectWiFi()
        Disconnect_WiFi()
        ' Connect to LAN
        ConnectToLAN()
        ConnectToLANButton.Enabled = False
        ConnectToWifiButton.Enabled = True
    End Sub

    Private Sub ConnectToLAN()
        ' Enable LAN network adapter 
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND NetConnectionStatus = 0"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Enable", Nothing)
        Next
    End Sub

    Private Sub DisconnectLAN()
        ' Disable LAN network adapter
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND NetConnectionStatus = 2"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Disable", Nothing)
        Next
    End Sub

    Private Sub ConnectWiFi()
        ' Enable LAN network adapter 
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND NetConnectionStatus = 0"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Enable", Nothing)
        Next
    End Sub

    Private Sub Disconnect_WiFi()
        ' Disable LAN network adapter
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND NetConnectionStatus = 7"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Disable", Nothing)
        Next
    End Sub


    Private Sub ConnectToWiFi(ssid As String, password As String)
        ' Connect to Wi-Fi network using netsh (replace "YourSSID" and "YourPassword" with your Wi-Fi details)
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = "netsh"
        processStartInfo.Arguments = "wlan connect name=" & ssid & " ssid=" & ssid & " keyMaterial=" & password
        processStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(processStartInfo)
    End Sub

    Private Sub DisconnectWiFi()
        ' Disconnect from the currently connected Wi-Fi network using netsh
        Dim processStartInfo As New ProcessStartInfo()
        processStartInfo.FileName = "netsh"
        processStartInfo.Arguments = "wlan disconnect"
        processStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(processStartInfo)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ' Create a DataTable to store network adapter information
        Dim networkAdapterTable As New DataTable() 
        networkAdapterTable.Columns.Add("DeviceID")
        networkAdapterTable.Columns.Add("NetConnectionId")
        networkAdapterTable.Columns.Add("Name")
        networkAdapterTable.Columns.Add("Description")
        networkAdapterTable.Columns.Add("AdapterType")
        networkAdapterTable.Columns.Add("MACAddress")
        networkAdapterTable.Columns.Add("NetConnectionStatus")


        ' Query network adapter information using WMI
        Dim query As New SelectQuery("SELECT * FROM Win32_NetworkAdapter")
        Dim searcher As New ManagementObjectSearcher(query)

        For Each networkAdapter As ManagementObject In searcher.Get()
            If networkAdapter IsNot Nothing Then

                Dim DeviceID As String = If(networkAdapter("DeviceID"), String.Empty).ToString()
                Dim NetConnectionId As String = If(networkAdapter("NetConnectionId"), String.Empty).ToString()
                Dim name As String = If(networkAdapter("Name"), String.Empty).ToString()
                Dim description As String = If(networkAdapter("Description"), String.Empty).ToString()
                Dim adapterType As String = If(networkAdapter("AdapterType"), String.Empty).ToString()
                Dim macAddress As String = If(networkAdapter("MACAddress"), String.Empty).ToString()
                Dim NetConnectionStatus As String = If(networkAdapter("NetConnectionStatus"), String.Empty).ToString()

                networkAdapterTable.Rows.Add(DeviceID, NetConnectionId, name, description, adapterType, macAddress, NetConnectionStatus)
            End If
        Next

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = networkAdapterTable
    End Sub

End Class
