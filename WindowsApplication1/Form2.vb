Public Class Form2

    Private Sub botaoCadCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.Click
        Dim vardescript As String
        Dim varcomp As String

        varcomp = cadCliNome.Text & SPLITTER1 & cadCliEndereco.Text



        If Label32.Text = "Login Antigo" Then
            If Me.Text = "Exclusão de Login" Then
                While a1e < 6

                If System.IO.File.Exists("Piear\Logs\" & a1e & ".logs") Then
                    vardescript = DESCRIPTOGRAFAR("Piear\Logs\" & a1e & ".logs")

                    If varcomp = vardescript Then
                            System.IO.File.Delete("Piear\Logs\" & a1e & ".logs")
                            cadCliNome.Text = ""
                            cadCliEndereco.Text = ""
                            vardoform2 = 2
                            Form1.Show()
                            Exit Sub
                        Else
                            a1e += 1
                            Continue While
                        End If
                Else
                        a1e += 1
                        Continue While
                    End If
                End While

                vardoform2 = 1
                Form1.Show()
                Exit Sub

            Else
                While a1d < 6

                    If System.IO.File.Exists("Piear\Logs\" & a1d & ".logs") Then
                        vardescript = DESCRIPTOGRAFAR("Piear\Logs\" & a1d & ".logs")

                        If varcomp = vardescript Then

                            Label32.Text = "Login Novo"
                            Label1.Text = "Senha Nova"
                            Exit Sub

                        Else
                            a1d += 1
                            Continue While
                        End If

                    Else
                        a1d += 1
                        Continue While

                    End If

                End While
                vardoform2 = 1
                Form1.Show()
                Exit Sub
            End If

        Else



        End If

    End Sub

    Private Sub botaoCadCli_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseDown
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

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Exclusão de Login" Then

        End If
    End Sub
End Class