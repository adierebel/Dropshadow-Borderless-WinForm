Imports System.Runtime.InteropServices
Public Class FormShadow
    Private AeroEnabled As Boolean
    Private Drag As Boolean
    Private MouseX As Integer
    Private MouseY As Integer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or NativeConstants.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case NativeConstants.WM_NCPAINT
                Dim val = 2
                If aeroEnabled Then
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, val, 4)
                    Dim bla As New NativeStructs.MARGINS()
                    With bla
                        .bottomHeight = 1
                        .leftWidth = 0
                        .rightWidth = 0
                        .topHeight = 0
                    End With
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, bla)
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            AeroEnabled = (enabled = 1)
        Else
            AeroEnabled = False
        End If
    End Sub
    Private Sub PanelMove_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMove.MouseDown
        Drag = True
        MouseX = Cursor.Position.X - Me.Left
        MouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PanelMove_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMove.MouseMove
        If Drag Then
            Me.Top = Cursor.Position.Y - MouseY
            Me.Left = Cursor.Position.X - MouseX
        End If
    End Sub
    Private Sub PanelMove_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelMove.MouseUp
        Drag = False
    End Sub
    Private Sub PanelExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelExit.Click
        End
    End Sub
    Private Sub LabelExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelExit.Click
        End
    End Sub
End Class
Public Class NativeStructs
    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure
End Class
Public Class NativeMethods
    <DllImport("dwmapi")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As NativeStructs.MARGINS) As Integer
    End Function
    <DllImport("dwmapi")> _
    Friend Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function
End Class
Public Class NativeConstants
    Public Const CS_DROPSHADOW As Integer = &H20000
    Public Const WM_NCPAINT As Integer = &H85
End Class