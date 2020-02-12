Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
    End Sub

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ProgressBar1.MarqueeAnimationSpeed = 100
        Me.Opacity = 0
        ProgressBar1.Value = 0
        Timer1.Start()
        Timer2.Interval = 100
        Timer2.Start()
        Dim yy As Integer = 0


    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()


        End If


        If Me.Opacity = 100 Then
            Timer2.Stop()

        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity += 1

    End Sub

    Private Sub SplashScreen1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1
        Me.Opacity -= 1



    End Sub
End Class
