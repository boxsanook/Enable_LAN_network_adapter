Imports System.Management

Module NetWorkAP
   
    Public Sub ConnectToAdapter(MACAddress As String)
        ' Enable LAN network adapter 
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND MACAddress ='" & MACAddress & "'"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Enable", Nothing)
        Next
    End Sub

    Public Sub DisconnectAdapter(MACAddress As String)
        ' Disable LAN network adapter
        Dim query As String = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL AND MACAddress ='" & MACAddress & "'"
        Dim searcher As New ManagementObjectSearcher(query)
        Dim collection As ManagementObjectCollection = searcher.Get()
        For Each adapter As ManagementObject In collection
            adapter.InvokeMethod("Disable", Nothing)
        Next
    End Sub

End Module
