Imports System.IO
Imports System.IO.File

Public Class FormPesquisar

    Private Sub FormPesquisar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim listapesquisar As Integer
        Dim cli1 As Integer
        Dim listapesq As String



        If Exists("Piear\Client\Lista\lista0.prs") Then
            listapesquisar = (DESCRIPTOGRAFAR("Piear\Client\Lista\lista0.prs"))
        Else
            MessageBox.Show("NÃO EXISTEM REGISTROS CADASTRADOS - ERRO REG00768", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        While cli1 <= listapesquisar

            If Exists("Piear\Client\" & cli1 & ".prs") Then
                listapesq = DESCRIPTOGRAFAR("Piear\Client\" & cli1 & ".prs")
                cli1 += 1
            Else
                cli1 += 1
                Continue While
            End If



            Dim Dados = Split(listapesq, SPLITTER1)
            Dim Item As New ListViewItem



            Item.Text = Dados(0)
            Item.SubItems.Add(Dados(1))
            Item.SubItems.Add(Dados(2))
            Item.SubItems.Add(Dados(3))
            Item.SubItems.Add(Dados(4))
            Item.SubItems.Add(Dados(5))
            Item.SubItems.Add(Dados(6))
            Item.SubItems.Add(Dados(7))
            Item.SubItems.Add(Dados(8))
            Item.SubItems.Add(Dados(9))
            Item.SubItems.Add(Dados(10))
            Item.SubItems.Add(Dados(12))
            Item.SubItems.Add(Dados(11))
            Item.SubItems.Add(Dados(13))

            ListView1.Items.Add(Item)


        End While



    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = ImageList1.Images.Item(2)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Try
            Button1.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try

    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ListView1.SelectedItems.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        varformpesq = ListView1.FocusedItem.SubItems(0).Text & ", " & ListView1.FocusedItem.SubItems(1).Text
        If variavel1 = 1 Then
            FormPrin.TextBox1.Text = varformpesq
            variavel1 = 0
            Me.Close()
        End If

        FormPrin.TextBox10.Text = varformpesq
        Me.Close()


    End Sub
End Class