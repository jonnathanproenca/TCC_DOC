Public Class Form4

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox1.Text > FormPrin.Label122.Text Then


            If FormPrin.TabControl1.TabPages.Contains(FormPrin.TabAluguel) Then

            Else
                FormPrin.TabControl1.TabPages.Add(FormPrin.TabAluguel)

            End If

            item = FormPrin.Label41.Text & "@" & FormPrin.Label42.Text & "@" & FormPrin.Label43.Text & "@" & FormPrin.Label44.Text & "@" & FormPrin.Label45.Text & "@" & FormPrin.Label46.Text & "@" & TextBox1.Text
            FormPrin.Label104.Text = Format(valor, "currency")
            FormPrin.ListBox1.Items.Add(item)
            Me.Close()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        End If
        varcontimp += 1

    End Sub
End Class