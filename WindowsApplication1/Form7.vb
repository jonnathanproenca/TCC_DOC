Imports System.IO
Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.Click

      
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub botaoCadCli_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseDown
        Try
            botaoCadCli.BackgroundImage = ImageList1.Images(2)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub botaoCadCli_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadCli.MouseLeave
        Try
            botaoCadCli.BackgroundImage = ImageList1.Images(0)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub botaoCadCli_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseMove
        Try
            botaoCadCli.BackgroundImage = ImageList1.Images(1)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cadCliNome.Text <> "" And cadCliEndereco.Text <> "" Then

            If x1a < 5 Then

                If IO.File.Exists("Piear\Logs\" & x1a & ".prs") Then
                    x1a += 1
                Else
                    IO.Directory.CreateDirectory("Piear\Logs\")

                End If



                CRIPTOGRAFAR("Piear\Logs\" & x1a & ".prs", cadCliNome.Text & SPLITTER1 & cadCliEndereco.Text)

                cadCliNome.Text = ""
                cadCliEndereco.Text = ""
                Me.Close()

            End If
        Else
            varloginbranco = 1
            Form1.Show()

        End If
    End Sub

    Private Sub Button1_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.EnabledChanged

    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = ImageList2.Images(2)

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Try
            Button1.BackgroundImage = ImageList2.Images(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = ImageList2.Images(1)

    End Sub
End Class