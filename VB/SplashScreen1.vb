Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraSplashScreen

Namespace SplashScreen_ProcessCommand

    Public Partial Class SplashScreen1
        Inherits SplashScreen

        Public Sub New()
            InitializeComponent()
        End Sub

'#Region "Overrides"
        Public Overrides Sub ProcessCommand(ByVal cmd As [Enum], ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
            Dim command As SplashScreenCommand = CType(cmd, SplashScreenCommand)
            If command = SplashScreenCommand.SetProgress Then
                Dim pos As Integer = CInt(arg)
                progressBarControl1.Position = pos
            End If
        End Sub

'#End Region
        Public Enum SplashScreenCommand
            SetProgress
            Command2
            Command3
        End Enum
    End Class
End Namespace
