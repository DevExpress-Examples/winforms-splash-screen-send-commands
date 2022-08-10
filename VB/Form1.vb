Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Namespace SplashScreen_ProcessCommand

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnShowSplashScreen_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Open a Splash Screen
            SplashScreenManager.ShowForm(Me, GetType(SplashScreen1), True, True, False)
            ' The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.
            For i As Integer = 1 To 100
                SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.SetProgress, i)
                'To process commands, override the SplashScreen.ProcessCommand method.
                Thread.Sleep(25)
            Next

            ' Close the Splash Screen.
            SplashScreenManager.CloseForm(False)
        End Sub
    End Class
End Namespace
