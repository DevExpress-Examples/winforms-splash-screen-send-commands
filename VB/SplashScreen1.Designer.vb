Namespace SplashScreen_ProcessCommand

    Partial Class SplashScreen1

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen_ProcessCommand.SplashScreen1))
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.labelControl1.Location = New System.Drawing.Point(23, 107)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(115, 13)
            Me.labelControl1.TabIndex = 6
            Me.labelControl1.Text = "Copyright 1998-2011"
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
            Me.pictureEdit1.EditValue =(CObj((resources.GetObject("pictureEdit1.EditValue"))))
            Me.pictureEdit1.Location = New System.Drawing.Point(305, 98)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Size = New System.Drawing.Size(123, 30)
            Me.pictureEdit1.TabIndex = 8
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Location = New System.Drawing.Point(23, 21)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(405, 27)
            Me.progressBarControl1.TabIndex = 9
            ' 
            ' SplashScreen1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(450, 150)
            Me.Controls.Add(Me.progressBarControl1)
            Me.Controls.Add(Me.pictureEdit1)
            Me.Controls.Add(Me.labelControl1)
            Me.Name = "SplashScreen1"
            Me.Text = "Form1"
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    End Class
End Namespace
