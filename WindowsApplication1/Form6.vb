﻿Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.Click

        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Try
            Button1.BackgroundImage = ImageList1.Images(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub botaoCadCli_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseDown
        botaoCadCli.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCadCli_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadCli.MouseLeave
        Try
            botaoCadCli.BackgroundImage = ImageList1.Images(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub botaoCadCli_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseMove
        botaoCadCli.BackgroundImage = ImageList1.Images(1)
    End Sub
End Class