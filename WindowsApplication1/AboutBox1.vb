Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TableLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel.Paint

    End Sub

    Private Sub OKButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.MouseEnter
        OKButton.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub OKButton_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OKButton.MouseDown
        OKButton.BackgroundImage = ImageList1.Images.Item(2)
    End Sub

    Private Sub OKButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.MouseLeave
        Try
            OKButton.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try
    End Sub

    Private Sub OKButton_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OKButton.KeyPress

    End Sub
End Class
