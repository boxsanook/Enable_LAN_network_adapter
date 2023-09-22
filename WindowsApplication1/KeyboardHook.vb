Imports System.Runtime.InteropServices

Public Class KeyboardHookX
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Shared hookID As IntPtr = IntPtr.Zero
    Private Shared hookDelegate As LowLevelKeyboardProc = AddressOf HookCallback

    Public Shared Event KeyDown As KeyEventHandler
    Public Shared Event KeyUp As KeyEventHandler

    Public Sub New()
        hookID = SetHook(hookDelegate)
    End Sub

    Public Sub Unhook()
        UnhookWindowsHookEx(hookID)
    End Sub

    Private Shared Function SetHook(ByVal proc As LowLevelKeyboardProc) As IntPtr
        Using currentProcess As Process = Process.GetCurrentProcess()
            Using currentModule As ProcessModule = currentProcess.MainModule
                Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(currentModule.ModuleName), 0)
            End Using
        End Using
    End Function

    Private Shared Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso (wParam = CType(WM_KEYDOWN, IntPtr) OrElse wParam = CType(WM_KEYUP, IntPtr)) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            Dim keyData As Keys = CType(vkCode, Keys)

            If wParam = CType(WM_KEYDOWN, IntPtr) Then
                RaiseEvent KeyDown(Nothing, New KeyEventArgs(keyData))
            ElseIf wParam = CType(WM_KEYUP, IntPtr) Then
                RaiseEvent KeyUp(Nothing, New KeyEventArgs(keyData))
            End If
        End If
        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function
End Class
