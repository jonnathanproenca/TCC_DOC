Imports System.IO

Public Class FormLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.Click

        Dim x1c As String
        Dim x1g As Integer
        Dim x1e As String

        x1e = cadCliNome.Text & SPLITTER1 & cadCliEndereco.Text

        While x1g <= 5

            x1c = DESCRIPTOGRAFAR("Piear\Logs\" & x1d & ".PRS")

            If x1c = x1e Then
                If x1d = 0 Then
                    controluser = 0
                    FormPrin.Show()
                    Close()
                End If
                controluser = 1
                FormPrin.Show()
                Close()
                Exit While

            Else
                If x1g = 5 Then

                    controleform = "Login Incorreto"

                    Form1.Show()



                End If
            End If

            If x1d = "0" Then
                x1d = "1"
            ElseIf x1d = "1" Then
                x1d = "2"
            ElseIf x1d = "2" Then
                x1d = "3"
            ElseIf x1d = "3" Then
                x1d = "4"
            ElseIf x1d = "4" Then
                x1d = "5"
            End If
            x1g += 1
        End While
        x1g = 0
        x1d = "0"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub botaoCadCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.MouseLeave
        Try
            botaoCadCli.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try
    End Sub

    Private Sub botaoCadCli_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.MouseEnter
        botaoCadCli.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub botaoCadCli_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseDown
        botaoCadCli.BackgroundImage = ImageList1.Images.Item(2)

    End Sub
End Class
