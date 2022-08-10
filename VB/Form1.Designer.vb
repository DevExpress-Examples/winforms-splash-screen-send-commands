Namespace SplashScreen_ProcessCommand

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
            Me.btnShowSplashScreen = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' btnShowSplashScreen
            ' 
            Me.btnShowSplashScreen.Location = New System.Drawing.Point(22, 12)
            Me.btnShowSplashScreen.Name = "btnShowSplashScreen"
            Me.btnShowSplashScreen.Size = New System.Drawing.Size(145, 32)
            Me.btnShowSplashScreen.TabIndex = 0
            Me.btnShowSplashScreen.Text = "Show Splash Screen"
            AddHandler Me.btnShowSplashScreen.Click, New System.EventHandler(AddressOf Me.btnShowSplashScreen_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(732, 428)
            Me.Controls.Add(Me.btnShowSplashScreen)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private btnShowSplashScreen As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
