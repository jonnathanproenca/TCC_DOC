Imports System.IO
Imports System.IO.File
Imports System.Drawing.Printing




Public Class FormPrin





    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If controluser = 1 Then
            menuControle.Visible = False
            controltab = 1
            controltabFunc = 1


            botaoCadFunc.Enabled = True
            botaoCadCli.Enabled = True
            botaoCadVest.Enabled = True
        Else


        End If

        Label110.Text = ""

        Timer2.Start()
        Timer3.Start()
        Timer4.Start()

        Timer1.Start()



        TabControl1.TabPages.Remove(TabAluguel)
        TabControl1.TabPages.Remove(TabCadCli)
        TabControl1.TabPages.Remove(TabCadFunc)
        TabControl1.TabPages.Remove(TabCadVest)
        TabControl1.TabPages.Remove(TabCatal)
        TabControl1.TabPages.Remove(TabContCli)
        TabControl1.TabPages.Remove(TabContFunc)
        TabControl1.TabPages.Remove(TabContVest)
        TabControl1.TabPages.Remove(TabContLoc)


    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAluguel.Click
        '  MessageBox.Show("Aguarde, brevemente voce poderá efetuar alugueis!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, True)
        ' Exit Sub


        ListBox1.Enabled = False
        Label104.Text = ""
        totalaserpago.Text = ""






        If TabControl1.TabPages.Contains(TabAluguel) Then

        Else
            TabControl1.TabPages.Add(TabAluguel)

        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCadastro.Click
        TabCadCli.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabCadVest.Enabled = False
        TabControl1.TabPages.Remove(TabCadVest)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.TabPages.Add(TabCadVest)
    End Sub


    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadCliCidade.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAjudaSobre.Click
        AboutBox1.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCadastroCli.Click

        If controluser = 0 And TabControl1.TabPages.Contains(TabContCli) Then
            TabControl1.TabPages.Add(TabContCli)
            TabControl1.Visible = True

        End If







        If Not TabControl1.TabPages.Contains(TabCadCli) Then TabControl1.TabPages.Add(TabCadCli) : TabControl1.Visible = True

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCadastroFunc.Click
        If TabControl1.TabPages.Contains(TabCadFunc) Then

        Else
            TabControl1.TabPages.Add(TabCadFunc)
            TabControl1.Visible = True

        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCadastroVestido.Click
        If TabControl1.TabPages.Contains(TabCadVest) Then

        Else
            TabControl1.TabPages.Add(TabCadVest)
            TabControl1.Visible = True

        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCatalogo.Click
        If Exists("Piear\Vestido\Lista\Lista0.prs") Then

        Else
            varerroreg = 1
            Form1.Show()
            Exit Sub

        End If

        If TabControl1.TabPages.Contains(TabCatal) Then
            Exit Sub
        Else
            TabControl1.TabPages.Add(TabCatal)
            TabControl1.Visible = True
        End If




        Dim LISTAVEST As String
        LISTAVEST = DESCRIPTOGRAFAR("Piear\Vestido\Lista\Lista0.prs")


        Dim vestidocat As Integer = 0
        Dim vestidolista As String



        While vestidocat <= LISTAVEST

            If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                vestidolista = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")


            Else
                vestidocat += 1

                Continue While
            End If

            Dim Dadoscor = Split(vestidolista, SPLITTER1)(0)
            Dim dadospreco = Split(vestidolista, SPLITTER1)(1)
            Dim dadosmodelo = Split(vestidolista, SPLITTER1)(2)
            Dim dadostamanho = Split(vestidolista, SPLITTER1)(3)
            Dim dadosocasiao = Split(vestidolista, SPLITTER1)(4)
            Dim dadosquantidade = Split(vestidolista, SPLITTER1)(5)


            Label41.Text = vestidocat
            Label42.Text = Dadoscor
            Label43.Text = dadospreco
            Label44.Text = dadosmodelo
            Label45.Text = dadostamanho
            Label46.Text = dadosocasiao
            Label122.Text = dadosquantidade

            catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")


            Exit While



        End While




    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuControleCli.Click

        Dim conta As Integer = 0

        controltab = 1

        If Exists("Piear\Client\Lista\lista0.prs") Then
            listad = (DESCRIPTOGRAFAR("Piear\Client\Lista\lista0.prs"))
        Else
            varerroreg = 1
            Form1.Show()
            Exit Sub
        End If



        If TabControl1.TabPages.Contains(TabContCli) Then
            Exit Sub

        Else
            TabControl1.TabPages.Add(TabContCli)
            TabControl1.Visible = True

        End If



        If controltabpage = 1 Then
            TabControl1.TabPages.Add(TabContCli)
            Atualizar()
            Exit Sub
        End If


        controltabpage = 1
        controltab = 1



        cli = 0

        While cli <= listad

            If Exists("Piear\Client\" & cli & ".prs") Then
                listap = DESCRIPTOGRAFAR("Piear\Client\" & cli & ".prs")
                cli += 1
            Else
                cli += 1
                Continue While
            End If



            Dim Dados = Split(listap, SPLITTER1)
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



            ListaContCli.Items.Add(Item)


            If Not conta = 0 Then
                Atualizar()

            End If

        End While
        conta = 1



    End Sub

    Private Sub FuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuControleFunc.Click


        If Exists("Piear\Func\Lista\lista0.prs") Then
            listafunc = (DESCRIPTOGRAFAR("Piear\Func\Lista\lista0.prs"))


        Else
            varerroreg = 1
            Form1.Show()
            Exit Sub
            


        End If

        If TabControl1.TabPages.Contains(TabContFunc) Then

        Else
            TabControl1.TabPages.Add(TabContFunc)
            TabControl1.Visible = True
        End If






        controltabpagefunc = 1
        controltabFunc = 1






        While func <= listafunc

            If Exists("Piear\Func\" & func & ".prs") Then
                listaf = DESCRIPTOGRAFAR("Piear\Func\" & func & ".prs")
                func += 1
            Else
                func += 1
                Continue While
            End If



            Dim Dados = Split(listaf, SPLITTER1)
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
            Item.SubItems.Add(Dados(11))
            Item.SubItems.Add(Dados(12))
            Item.SubItems.Add(Dados(13))
            Item.SubItems.Add(Dados(14))
            Item.SubItems.Add(Dados(15))





            listaContFunc.Items.Add(Item)




        End While


        If controltabpagefunc = 1 Then
            AtualizarFunc()
            Exit Sub

        End If


        controltabFunc = 1



    End Sub

    Private Sub VestidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuControleVestido.Click

        If Exists("Piear\Vestido\Lista\lista0.prs") Then
            listavestido2 = (DESCRIPTOGRAFAR("Piear\Vestido\Lista\lista0.prs"))
        Else
            varerroreg = 1
            Form1.Show()
            Exit Sub
        End If



        While vestido1 <= listavestido2
            vestidocontador = 1

            If Exists("Piear\Vestido\" & vestido1 & ".prs") Then
                listadescVest = DESCRIPTOGRAFAR("Piear\Vestido\" & vestido1 & ".prs")
            Else
                vestido1 += 1
                Continue While
            End If



            Dim Dados = Split(listadescVest, SPLITTER1)

            Dim Item As New ListViewItem



            Item.Text = Dados(0)
            Item.SubItems.Add(Dados(1))
            Item.SubItems.Add(Dados(2))
            Item.SubItems.Add(Dados(3))
            Item.SubItems.Add(Dados(4))
            Item.SubItems.Add(vestido1)
            Item.SubItems.Add(Dados(5))



            listaContVest.Items.Add(Item)
            vestido1 += 1
        End While

        If Exists("Piear\Vestido\Lista\lista0.prs") And vestidocontador = 1 Then


            If TabControl1.TabPages.Contains(TabContVest) Then

            Else
                TabControl1.TabPages.Add(TabContVest)
                TabControl1.Visible = True
            End If

        End If

        Exit Sub


    End Sub
    Private Sub atualizarlocacao()
        Dim listaaluga As String = ""

        If Exists("Piear\Aluguel\Lista\lista0.prs") Then
            listaaluga = (DESCRIPTOGRAFAR("Piear\Aluguel\Lista\lista0.prs"))
        Else
            MessageBox.Show("NÃO EXISTEM REGISTROS - ERRO REG00245", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If



        TextBox10.Text = ""
        ListBox2.Items.Clear()
        Label113.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Label109.Text = ""
        Label107.Text = ""
        ListView1.Items.Clear()



        Dim aluga As Integer = 0
        Dim alugaa As String = ""

        While aluga <= listaaluga

            If Exists("Piear\Aluguel\" & aluga & ".prs") Then
                alugaa = DESCRIPTOGRAFAR("Piear\Aluguel\" & aluga & ".prs")
                aluga += 1
            Else
                aluga += 1
                Continue While
            End If



            Dim Dados = Split(alugaa, SPLITTER1)
            Dim Item1 As New ListViewItem



            Item1.Text = Dados(0)
            Item1.SubItems.Add(Dados(1))
            Item1.SubItems.Add(Dados(2))
            Item1.SubItems.Add(Dados(3))
            Item1.SubItems.Add(Dados(4))
            Item1.SubItems.Add(Dados(5))
            Item1.SubItems.Add(Dados(6))
            Item1.SubItems.Add(Dados(7))
            Item1.SubItems.Add(Dados(8))



            ListView1.Items.Add(Item1)
        End While

    End Sub
    Private Sub LocaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuControleLocacao.Click
        Dim listaaluga As String = ""

        If Exists("Piear\Aluguel\Lista\lista0.prs") Then
            listaaluga = (DESCRIPTOGRAFAR("Piear\Aluguel\Lista\lista0.prs"))
        Else
            varerroreg = 1
            Form1.Show()
            Exit Sub
        End If



        TextBox10.Text = ""
        ListBox2.Items.Clear()
        Label113.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Label109.Text = ""
        Label107.Text = ""
        ListView1.Items.Clear()


        If TabControl1.TabPages.Contains(TabContLoc) Then

        Else
            TabControl1.TabPages.Add(TabContLoc)

        End If
        Dim aluga As Integer = 0
        Dim alugaa As String = ""

        While aluga <= listaaluga

            If Exists("Piear\Aluguel\" & aluga & ".prs") Then
                alugaa = DESCRIPTOGRAFAR("Piear\Aluguel\" & aluga & ".prs")
                aluga += 1
            Else
                aluga += 1
                Continue While
            End If



            Dim Dados = Split(alugaa, SPLITTER1)
            Dim Item1 As New ListViewItem


            Item1.Text = Dados(0)
            Item1.SubItems.Add(Dados(1))
            Item1.SubItems.Add(Dados(2))
            Item1.SubItems.Add(Dados(3))
            Item1.SubItems.Add(Dados(4))
            Item1.SubItems.Add(Dados(5))
            Item1.SubItems.Add(Dados(6))
            Item1.SubItems.Add(Dados(7))
            Item1.SubItems.Add(Dados(8))



            ListView1.Items.Add(Item1)
        End While
        Label109.Text = "Sinal:"
    End Sub

    Private Sub FluxoDeCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Aguarde, brevemente voce poderá visualizar o fluxo de caixa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, True)
        Exit Sub
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloCadCli.Click


        botaocadclivar = 1

        controleform = "Deseja Realmente Fechar?"
        Form1.Show()






    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloCadFunc.Click

        botaocadfuncvar = 1

        controleform = "Deseja Realmente Fechar?"
        Form1.Show()

        Exit Sub

        If MessageBox.Show("Deseja realmente fechar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            TabControl1.TabPages.Remove(TabCadFunc)
            cadFuncNome.Clear()
            cadFuncEndereco.Clear()
            cadFuncNum.Clear()
            cadFuncCompl.Clear()
            cadFuncBairro.Clear()
            cadFuncCidade.Clear()
            cadFuncEstado.Clear()
            cadFuncSalario.Clear()
            cadFuncRG.Clear()
            cadFuncCPF.Clear()
            cadFuncCEP.Clear()
            cadFuncData.Clear()
            cadFuncTelefone.Clear()
            cadFuncCelular.Clear()
            cadFuncCartTrab.Clear()
            cadFuncDataAdm.Clear()
        End If

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloCadVest.Click


        botaocadvestvar = 1
        controleform = "Deseja Realmente Fechar?"
        Form1.Show()


    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloCatalogo.Click

        catalogoImg.Image.Dispose()
        catalogoImg.Image = Nothing
        Label46.Text = ""
        Label45.Text = ""
        Label44.Text = ""
        Label43.Text = ""
        Label42.Text = ""
        Label41.Text = ""

        TabControl1.TabPages.Remove(TabCatal)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloContCli.Click

        If botaoContCliAlt.Text = "Aceitar" Then
            varfecharguia = 1
            varfecharguia1 = 1
            Form1.Show()

            Exit Sub


            If MessageBox.Show("Você tem campos para serem salvos, deseja realmente fechar ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                TabControl1.TabPages.Remove(TabContCli)
                contCliAnota.Text = ""
                contCliBairro.Text = ""
                contCliCEP.Text = ""
                contCliCidade.Text = ""
                contCliCompl.Text = ""
                contCliCPF.Text = ""
                contCliData.Text = ""
                contCliEndereco.Text = ""
                contCliEstado.Text = ""
                contCliNome.Text = ""
                contCliNum.Text = ""
                contCliRG.Text = ""
                MaskedTextBox1.Text = ""
                MaskedTextBox2.Text = ""
                botaoContCliAlt.Text = "Alterar"

                contCliAnota.Enabled = False
                contCliBairro.Enabled = False
                contCliCEP.Enabled = False
                contCliCidade.Enabled = False
                contCliCompl.Enabled = False
                contCliCPF.Enabled = False
                contCliData.Enabled = False
                contCliEndereco.Enabled = False
                contCliEstado.Enabled = False
                contCliNome.Enabled = False
                contCliNum.Enabled = False
                contCliRG.Enabled = False
                MaskedTextBox1.Enabled = False
                MaskedTextBox2.Enabled = False

                controltabpage = 0

                ListaContCli.Items.Clear()




            End If

        Else
            TabControl1.TabPages.Remove(TabContCli)
            contCliAnota.Text = ""
            contCliBairro.Text = ""
            contCliCEP.Text = ""
            contCliCidade.Text = ""
            contCliCompl.Text = ""
            contCliCPF.Text = ""
            contCliData.Text = ""
            contCliEndereco.Text = ""
            contCliEstado.Text = ""
            contCliNome.Text = ""
            contCliNum.Text = ""
            MaskedTextBox1.Text = ""
            MaskedTextBox2.Text = ""
            contCliRG.Text = ""

            contCliAnota.Enabled = False
            contCliBairro.Enabled = False
            contCliCEP.Enabled = False
            contCliCidade.Enabled = False
            contCliCompl.Enabled = False
            contCliCPF.Enabled = False
            contCliData.Enabled = False
            contCliEndereco.Enabled = False
            contCliEstado.Enabled = False
            contCliNome.Enabled = False
            contCliNum.Enabled = False
            contCliRG.Enabled = False
            MaskedTextBox1.Enabled = False
            MaskedTextBox2.Enabled = False

            controltabpage = 0
            ListaContCli.Items.Clear()


        End If

    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloContFunc.Click
        If botaoContFuncAlt.Text = "Aceitar" Then
            varfecharguia4 = 1
            varfecharguia5 = 1
            Form1.Show()

            Exit Sub
        End If


        If botaoContFuncAlt.Text = "Aceitar" Then
            If MessageBox.Show("Você tem campos para serem salvos, deseja realmente fechar ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                TabControl1.TabPages.Remove(TabContFunc)
                contFuncSalario.Text = ""
                contFuncBairro.Text = ""
                contFuncCEP.Text = ""
                contFuncCidade.Text = ""
                contFuncCompl.Text = ""
                contFuncCPF.Text = ""
                contFuncData.Text = ""
                contFuncEndereco.Text = ""
                contFuncEstado.Text = ""
                contFuncNome.Text = ""
                contFuncNum.Text = ""
                contFuncRG.Text = ""
                contFuncCartTrab.Text = ""
                contFuncDataAdm.Text = ""
                controltabpagefunc = 0
                MaskedTextBox3.Text = ""
                MaskedTextBox4.Text = ""

                contFuncSalario.Enabled = False
                contFuncBairro.Enabled = False
                contFuncCEP.Enabled = False
                contFuncCidade.Enabled = False
                contFuncCompl.Enabled = False
                contFuncCPF.Enabled = False
                contFuncData.Enabled = False
                contFuncEndereco.Enabled = False
                contFuncEstado.Enabled = False
                contFuncNome.Enabled = False
                contFuncNum.Enabled = False
                contFuncRG.Enabled = False
                contFuncCartTrab.Enabled = False
                contFuncDataAdm.Enabled = False
                MaskedTextBox3.Enabled = False
                MaskedTextBox4.Enabled = False

            End If

        Else
            TabControl1.TabPages.Remove(TabContFunc)
            contFuncSalario.Text = ""
            contFuncBairro.Text = ""
            contFuncCEP.Text = ""
            contFuncCidade.Text = ""
            contFuncCompl.Text = ""
            contFuncCPF.Text = ""
            contFuncData.Text = ""
            contFuncEndereco.Text = ""
            contFuncEstado.Text = ""
            contFuncNome.Text = ""
            contFuncNum.Text = ""
            contFuncRG.Text = ""
            contFuncCartTrab.Text = ""
            contFuncDataAdm.Text = ""
            controltabpagefunc = 0
            MaskedTextBox3.Text = ""
            MaskedTextBox4.Text = ""

            contFuncSalario.Enabled = False
            contFuncBairro.Enabled = False
            contFuncCEP.Enabled = False
            contFuncCidade.Enabled = False
            contFuncCompl.Enabled = False
            contFuncCPF.Enabled = False
            contFuncData.Enabled = False
            contFuncEndereco.Enabled = False
            contFuncEstado.Enabled = False
            contFuncNome.Enabled = False
            contFuncNum.Enabled = False
            contFuncRG.Enabled = False
            contFuncCartTrab.Enabled = False
            contFuncDataAdm.Enabled = False
            MaskedTextBox3.Enabled = False
            MaskedTextBox4.Enabled = False


        End If

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloContVest.Click

        If botaoalterarvestido = 1 Then
            varFecharVest = 1
            Form1.Show()
            Exit Sub
        End If



        TabControl1.TabPages.Remove(TabContVest)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloAluguel.Click
        varform1close = 1
        Form1.Show()
        Exit Sub



        TabControl1.TabPages.Remove(TabAluguel)
    End Sub



    Private Sub MaskedTextBox9_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub TextBox40_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadFuncSalario.GotFocus
        Dim x As String = cadFuncSalario.Text
        x = x.Replace("R$", "")
        x = x.Replace(".", "")
        Try
            If Mid(x, x.Length - 2, x.Length) = "00" Then
                cadFuncSalario.Text = Mid(x, 0, x.Length - 2)
            Else
                cadFuncSalario.Text = x
            End If
        Catch
        End Try
    End Sub

    Private Sub cadFuncSalario_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles cadFuncSalario.HelpRequested

    End Sub

    Private Sub cadFuncSalario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadFuncSalario.KeyPress
        If Not InStr("0123456789,." & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True
    End Sub

    Private Sub TextBox40_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadFuncSalario.LostFocus
        cadFuncSalario.Text = Format(cadFuncSalario.Text, "currency")

        salario = cadFuncSalario.Text


    End Sub

    Private Sub TextBox40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadFuncSalario.TextChanged

    End Sub

    Private Sub MaskedTextBox18_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub TextBox41_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles contFuncSalario.GotFocus
        Dim z As String = contFuncSalario.Text
        z = z.Replace("R$", "")
        z = z.Replace(".", "")
        Try
            If Mid(z, z.Length - 2, z.Length) = "00" Then
                contFuncSalario.Text = Mid(z, 0, z.Length - 2)
            Else
                contFuncSalario.Text = z
            End If
        Catch
        End Try
    End Sub

    Private Sub TextBox41_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles contFuncSalario.LostFocus
        contFuncSalario.Text = Format(contFuncSalario.Text, "currency")
    End Sub

    Private Sub TextBox41_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contFuncSalario.TextChanged

    End Sub

    Private Sub TextBox20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadVestPreco.GotFocus
        Dim z2 As String = cadVestPreco.Text
        z2 = z2.Replace("R$", "")
        z2 = z2.Replace(".", "")
        Try
            If Mid(z2, z2.Length - 2, z2.Length) = "00" Then
                cadVestPreco.Text = Mid(z2, 0, z2.Length - 2)
            Else
                cadVestPreco.Text = z2
            End If
        Catch
        End Try
    End Sub

    Private Sub TextBox20_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadVestPreco.LostFocus
        cadVestPreco.Text = Format(cadVestPreco.Text, "currency")
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadVestPreco.TextChanged

    End Sub

    Private Sub TextBox39_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub TextBox39_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadVestProcurar.Click

        Dim x As New OpenFileDialog
        x.Filter = "Arquivo de Imagens|*.jpg; *.bmp; *.png; *.gif"
        x.RestoreDirectory = True
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            cadVestImg.Image = Image.FromFile(x.FileName)
            cadVestLocalImag.Text = x.FileName

        End If


    End Sub


    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContVestProcurar.Click
        Dim y As New OpenFileDialog
        y.Filter = "Arquivo de Imagens| *.jpg; *.bmp; *.png; *.gif; *.tiff"
        y.RestoreDirectory = True
        If y.ShowDialog = Windows.Forms.DialogResult.OK Then

            contVestImg.Image = Image.FromFile(y.FileName)

        End If



    End Sub

    Private Sub TextBox55_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadVestLocalImag.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadCli.Click
        If Not IO.Directory.Exists("Piear\Client") Then IO.Directory.CreateDirectory("Piear\Client")


        If Not cadCliCPF.Text <> "" Or cadCliCPF.Text = "000.000.000-00" Then MessageBox.Show("CPF INVALIDO - CÓDIGO 003B4", "ERRO", MessageBoxButtons.OK) : Exit Sub



        If Not VALIDAR_CPF(cadCliCPF.Text) = True Then
            MessageBox.Show("CPF INVALIDO - CÓDIGO 003B7", "ERRO", MessageBoxButtons.OK)
            Exit Sub
        End If

        While IO.File.Exists("Piear\Client\" & cli & ".prs")
            cli += 1
        End While



        CRIPTOGRAFAR("Piear\Client\" & cli & ".prs", cadCliNome.Text & SPLITTER1 & cadCliRG.Text & SPLITTER1 & cadCliCPF.Text & SPLITTER1 & cadCliData.Text & SPLITTER1 & cadCliEndereco.Text & SPLITTER1 & cadCliNum.Text & SPLITTER1 & cadCliCompl.Text & SPLITTER1 & cadCliCEP.Text & SPLITTER1 & cadCliBairro.Text & SPLITTER1 & cadCliCidade.Text & SPLITTER1 & cadCliEstado.Text & SPLITTER1 & cadCliTelefone.Text & SPLITTER1 & cadCliCelular.Text & SPLITTER1 & cadCliAnota.Text)

        For Each x As Control In TabCadCli.Controls

            If x.GetType.Name = "TextBox" Or x.GetType.Name = "MaskedTextBox" Then x.Text = ""

        Next x


        If Exists("Piear\Client\Lista\lista0.prs") Then

            listad = (DESCRIPTOGRAFAR("Piear\Client\lista\lista0.prs"))

            If listad >= cli Then

            Else

                CRIPTOGRAFAR("Piear\Client\Lista\lista0.prs", cli)

            End If

        Else

            CRIPTOGRAFAR("Piear\Client\Lista\lista0.prs", cli)

        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadCliBairro.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If cadCliNome.Text <> "" And cadCliEndereco.Text <> "" And cadCliNum.Text <> "" And cadCliBairro.Text <> "" And cadCliCidade.Text <> "" And cadCliEstado.Text <> "" And cadCliRG.Text <> "" And cadCliCPF.Text <> "" And cadCliData.Text <> "" And cadCliTelefone.Text <> "" And cadCliCelular.Text <> "" And controltab = 1 Then
            botaoCadCli.Enabled = True
        Else
            botaoCadCli.Enabled = False
        End If

        If cadFuncNome.Text <> "" And cadFuncEndereco.Text <> "" And cadFuncNum.Text <> "" And cadFuncBairro.Text <> "" And cadFuncCidade.Text <> "" And cadFuncEstado.Text <> "" And cadFuncRG.Text <> "" And cadFuncCPF.Text <> "" And cadFuncData.Text <> "" And cadFuncTelefone.Text <> "" And cadFuncCelular.Text <> "" And controltabFunc = 1 Then
            botaoCadFunc.Enabled = True
        Else
            botaoCadFunc.Enabled = False
        End If




    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabContCli.Click

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadVest.Click
        If Not IO.Directory.Exists("Piear\Fotos") Then IO.Directory.CreateDirectory("Piear\Fotos")

        If Not IO.Directory.Exists("Piear\Vestido") Then IO.Directory.CreateDirectory("Piear\Vestido")


        While IO.File.Exists("Piear\Fotos\" & foto & ".jpg")
            foto += 1
        End While

        While IO.File.Exists("Piear\Vestido\" & vestido & ".prs")
            vestido += 1
        End While






        cadVestImg.Image.Save("Piear\Fotos\" & vestido & ".jpg", Drawing.Imaging.ImageFormat.Jpeg)

        CRIPTOGRAFAR("Piear\Vestido\" & vestido & ".prs", cadVestCor.Text & SPLITTER1 & cadVestPreco.Text & SPLITTER1 & cadVestModelo.Text & SPLITTER1 & cadVestTamanho.Text & SPLITTER1 & cadVestOcasiao.Text & SPLITTER1 & TextBox11.Text)




        If Exists("Piear\vestido\Lista\lista0.prs") Then
            listaVestido1 = (DESCRIPTOGRAFAR("Piear\Client\lista\lista0.prs"))
            If listaVestido1 < vestido Then
                CRIPTOGRAFAR("Piear\Vestido\Lista\lista0.prs", vestido)
            End If
        Else
            CRIPTOGRAFAR("Piear\Vestido\Lista\lista0.prs", vestido)
        End If


        For Each x As Control In TabCadVest.Controls
            If x.GetType.Name = "TextBox" Or x.GetType.Name = "MaskedTextBox" Then x.Text = x.Text = ""
        Next x

        cadVestCor.Text = ""
        cadVestTamanho.Text = ""
        cadVestOcasiao.Text = ""
        cadVestPreco.Text = ""
        cadVestModelo.Text = ""
        cadVestLocalImag.Text = ""
        cadVestImg.Image = Nothing



    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaContCli.Click
        With ListaContCli.FocusedItem
            If ListaContCli.SelectedItems.Count > 0 Then
                contCliNome.Text = .Text
                contCliRG.Text = .SubItems(1).Text
                contCliCPF.Text = .SubItems(2).Text
                contCliData.Text = .SubItems(3).Text
                contCliEndereco.Text = .SubItems(4).Text
                contCliNum.Text = .SubItems(5).Text
                contCliCompl.Text = .SubItems(6).Text
                contCliCEP.Text = .SubItems(7).Text
                contCliBairro.Text = .SubItems(8).Text
                contCliCidade.Text = .SubItems(9).Text
                contCliEstado.Text = .SubItems(10).Text
                contCliAnota.Text = .SubItems(13).Text
                MaskedTextBox1.Text = .SubItems(11).Text
                MaskedTextBox2.Text = .SubItems(12).Text


            End If
        End With
    End Sub

    Private Sub AtualizarVestido()
        listaContVest.Items.Clear()

        vestido1 = 0





        While vestido1 <= listavestido2
            vestidocontador = 1

            If Exists("Piear\Vestido\" & vestido1 & ".prs") Then
                listadescVest = DESCRIPTOGRAFAR("Piear\Vestido\" & vestido1 & ".prs")
            Else
                vestido1 += 1
                Continue While
            End If



            Dim Dados = Split(listadescVest, SPLITTER1)

            Dim Item As New ListViewItem



            Item.Text = Dados(0)
            Item.SubItems.Add(Dados(1))
            Item.SubItems.Add(Dados(2))
            Item.SubItems.Add(Dados(3))
            Item.SubItems.Add(Dados(4))
            Item.SubItems.Add(vestido1)
            Item.SubItems.Add(Dados(5))

            listaContVest.Items.Add(Item)
            vestido1 += 1
        End While
    End Sub

    Private Sub AtualizarFunc()
        listaContFunc.Items.Clear()

        func = 0


        While func <= listafunc

            If Exists("Piear\Func\" & func & ".prs") Then
                listaf = DESCRIPTOGRAFAR("Piear\Func\" & func & ".prs")
                func += 1
            Else
                func += 1
                Continue While
            End If

            Dim Dados = Split(listaf, SPLITTER1)
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
            Item.SubItems.Add(Dados(11))
            Item.SubItems.Add(Dados(12))
            Item.SubItems.Add(Dados(13))
            Item.SubItems.Add(Dados(14))
            Item.SubItems.Add(Dados(15))

            listaContFunc.Items.Add(Item)

        End While
    End Sub
    Private Sub Atualizar()
        ListaContCli.Items.Clear()

        cli = 0


        While cli <= listad

            If Exists("Piear\Client\" & cli & ".prs") Then
                listap = DESCRIPTOGRAFAR("Piear\Client\" & cli & ".prs")
                cli += 1
            Else
                cli += 1
                Continue While
            End If

            Dim Dados = Split(listap, SPLITTER1)
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

            ListaContCli.Items.Add(Item)

        End While
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContCliAlt.Click
        If contCliNome.Text <> "" Then
            If varCont1 = 0 Then

                contCliNome.Enabled = True
                contCliRG.Enabled = True
                contCliCPF.Enabled = True
                contCliData.Enabled = True
                contCliEndereco.Enabled = True
                contCliNum.Enabled = True
                contCliCompl.Enabled = True
                contCliCEP.Enabled = True
                contCliBairro.Enabled = True
                contCliCidade.Enabled = True
                contCliEstado.Enabled = True
                contCliAnota.Enabled = True
                MaskedTextBox1.Enabled = True
                MaskedTextBox2.Enabled = True
                botaoContCliExc.Enabled = False


                varCont1 = 1
                botaoContCliAlt.Text = "Aceitar"
                Exit Sub

            End If

            If varCont1 = 1 Then

                Dim contAlterar As String
                contAlterar = contCliNome.Text & SPLITTER1 & contCliRG.Text & SPLITTER1 & contCliCPF.Text & SPLITTER1 & contCliData.Text & SPLITTER1 & contCliEndereco.Text & SPLITTER1 & contCliNum.Text & SPLITTER1 & contCliCompl.Text & SPLITTER1 & contCliCEP.Text & SPLITTER1 & contCliBairro.Text & SPLITTER1 & contCliCidade.Text & SPLITTER1 & contCliEstado.Text & SPLITTER1 & MaskedTextBox2.Text & SPLITTER1 & MaskedTextBox1.Text & SPLITTER1 & contCliAnota.Text

                Dim cli12345 As Integer = 0
                Dim listacli12345 As String
                Dim listaCont As String

                listaCont = DESCRIPTOGRAFAR("Piear\Client\lista\lista0.prs")

                While cli12345 <= listaCont


                    If Exists("Piear\Client\" & cli12345 & ".prs") Then

                        listacli12345 = (DESCRIPTOGRAFAR("Piear\Client\" & cli12345 & ".prs"))
                        MsgBox(listacli12345)
                    Else
                        cli12345 += 1
                        Continue While

                    End If

                    Dim dados2 = Split(listacli12345, SPLITTER1)(1)
                    MsgBox(dados2)
                    MsgBox(contCliRG.Text)
                    If dados2 = contCliRG.Text Then
                        MsgBox("OK")
                        CRIPTOGRAFAR("Piear\Client\" & cli12345 & ".prs", contCliNome.Text & SPLITTER1 & contCliRG.Text & SPLITTER1 & contCliCPF.Text & SPLITTER1 & contCliData.Text & SPLITTER1 & contCliEndereco.Text & SPLITTER1 & contCliNum.Text & SPLITTER1 & contCliCompl.Text & SPLITTER1 & contCliCEP.Text & SPLITTER1 & contCliBairro.Text & SPLITTER1 & contCliCidade.Text & SPLITTER1 & contCliEstado.Text & SPLITTER1 & MaskedTextBox2.Text & SPLITTER1 & MaskedTextBox1.Text & SPLITTER1 & contCliAnota.Text)

                        contCliNome.Enabled = False
                        contCliRG.Enabled = False
                        contCliCPF.Enabled = False
                        contCliData.Enabled = False
                        contCliEndereco.Enabled = False
                        contCliNum.Enabled = False
                        contCliCompl.Enabled = False
                        contCliCEP.Enabled = False
                        contCliBairro.Enabled = False
                        contCliCidade.Enabled = False
                        contCliEstado.Enabled = False
                        contCliAnota.Enabled = False
                        MaskedTextBox1.Enabled = False
                        MaskedTextBox2.Enabled = False
                        botaoContCliExc.Enabled = True

                        botaoContCliAlt.Text = "Alterar"
                        ListaContCli.Items.Clear()
                        Atualizar()


                        Exit While

                    Else

                        cli12345 += 1
                    End If


                End While

                varCont1 = 0
            End If

        Else
            varAlterarErr2 = 1
            Form1.Show()
        End If


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContCliExc.Click

        If contCliNome.Text <> "" Then

            botaoContCliAlt.PerformClick()
            botaoContCliAlt.PerformClick()

            ListaContCli.Items.Clear()
            Atualizar()

            Dim contExcluir As String
            contExcluir = contCliNome.Text & SPLITTER1 & contCliRG.Text & SPLITTER1 & contCliCPF.Text & SPLITTER1 & contCliData.Text & SPLITTER1 & contCliEndereco.Text & SPLITTER1 & contCliNum.Text & SPLITTER1 & contCliCompl.Text & SPLITTER1 & contCliCEP.Text & SPLITTER1 & contCliBairro.Text & SPLITTER1 & contCliCidade.Text & SPLITTER1 & contCliEstado.Text & SPLITTER1 & MaskedTextBox2.Text & SPLITTER1 & MaskedTextBox1.Text & SPLITTER1 & contCliAnota.Text

            Dim Cont As Integer = 0
            Dim listacli As String
            listacli = DESCRIPTOGRAFAR("Piear\Client\Lista\Lista0.prs")



            While Cont <= listacli

                If Exists("Piear\Client\" & Cont & ".prs") Then
                    contComp = (DESCRIPTOGRAFAR("Piear\Client\" & Cont & ".prs"))


                    If contComp = contExcluir Then


                        System.IO.File.Delete("Piear\Client\" & Cont & ".prs")
                        ListaContCli.Items.Clear()
                        Atualizar()

                        contCliNome.Text = ""
                        contCliRG.Text = ""
                        contCliCPF.Text = ""
                        contCliData.Text = ""
                        contCliEndereco.Text = ""
                        contCliNum.Text = ""
                        contCliCompl.Text = ""
                        contCliCEP.Text = ""
                        contCliBairro.Text = ""
                        contCliCidade.Text = ""
                        contCliEstado.Text = ""
                        MaskedTextBox2.Text = ""
                        MaskedTextBox1.Text = ""
                        contCliAnota.Text = ""

                        Exit While
                    Else
                        Cont += 1
                        Continue While
                    End If

                Else
                    Cont += 1
                    Continue While
                End If


            End While

        Else
            varExcluirErr2 = 1
            Form1.Show()
        End If


    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadVestOcasiao.TextChanged

    End Sub

    Private Sub ListaContCli_ImeModeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaContCli.ImeModeChanged

    End Sub

    Private Sub ListaContCli_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListaContCli.MouseDoubleClick

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaContCli.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuControle.Click

    End Sub

    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLogoff.Click
        FormLogin.Show()
        varClosing = 1
        Close()
        controluser = 2




    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListaContCli.Items(ListaContCli.FocusedItem.Index + 1).Focused = True
        Catch
            ListaContCli.Items(1).Focused = True
        End Try
    End Sub

    Private Sub cadCliCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadCliCPF.KeyPress

    End Sub

    Private Sub cadCliCPF_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles cadCliCPF.MaskInputRejected

    End Sub

    Private Sub botaoCadFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCadFunc.Click
        If Not cadFuncCPF.Text <> "" Or cadFuncCPF.Text = "000.000.000-00" Then MessageBox.Show("CPF INVALIDO 1 - CÓDIGO 003D4", "ERRO", MessageBoxButtons.OK) : Exit Sub

        If Not IO.Directory.Exists("Piear\Func") Then IO.Directory.CreateDirectory("Piear\Func")


        If Not VALIDAR_CPF(cadFuncCPF.Text) = True Then
            MessageBox.Show("CPF INVALIDO - CÓDIGO 003D7", "ERRO", MessageBoxButtons.OK)
            Exit Sub
        End If

        While IO.File.Exists("Piear\Func\" & func & ".prs")
            func += 1
        End While


        CRIPTOGRAFAR("Piear\Func\" & func & ".prs", cadFuncNome.Text & SPLITTER1 & cadFuncRG.Text & SPLITTER1 & cadFuncCPF.Text & SPLITTER1 & cadFuncData.Text & SPLITTER1 & cadFuncEndereco.Text & SPLITTER1 & cadFuncNum.Text & SPLITTER1 & cadFuncCompl.Text & SPLITTER1 & cadFuncCEP.Text & SPLITTER1 & cadFuncBairro.Text & SPLITTER1 & cadFuncCidade.Text & SPLITTER1 & cadFuncEstado.Text & SPLITTER1 & cadFuncTelefone.Text & SPLITTER1 & cadFuncCelular.Text & SPLITTER1 & cadFuncSalario.Text & SPLITTER1 & cadFuncCartTrab.Text & SPLITTER1 & cadFuncDataAdm.Text)

        For Each x As Control In TabCadFunc.Controls
            If x.GetType.Name = "TextBox" Or x.GetType.Name = "MaskedTextBox" Then x.Text = ""
        Next x


        If Exists("Piear\Func\Lista\lista0.prs") Then

            listafunc = (DESCRIPTOGRAFAR("Piear\Func\lista\lista0.prs"))

            If listafunc >= func Then

            Else
                CRIPTOGRAFAR("Piear\Func\Lista\lista0.prs", func)

            End If

        Else
            CRIPTOGRAFAR("Piear\Func\Lista\lista0.prs", func)


        End If





    End Sub

    Private Sub ListView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles listaContFunc.Click
        With listaContFunc.FocusedItem
            If listaContFunc.SelectedItems.Count > 0 Then
                contFuncNome.Text = .Text
                contFuncRG.Text = .SubItems(1).Text
                contFuncCPF.Text = .SubItems(2).Text
                contFuncData.Text = .SubItems(3).Text
                contFuncEndereco.Text = .SubItems(4).Text
                contFuncNum.Text = .SubItems(5).Text
                contFuncCompl.Text = .SubItems(6).Text
                contFuncCEP.Text = .SubItems(7).Text
                contFuncBairro.Text = .SubItems(8).Text
                contFuncCidade.Text = .SubItems(9).Text
                contFuncEstado.Text = .SubItems(10).Text
                MaskedTextBox4.Text = .SubItems(11).Text
                MaskedTextBox3.Text = .SubItems(12).Text
                contFuncSalario.Text = .SubItems(13).Text
                contFuncCartTrab.Text = .SubItems(14).Text
                contFuncDataAdm.Text = .SubItems(15).Text


            End If
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaContFunc.SelectedIndexChanged

    End Sub

    Private Sub botaoContFuncAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContFuncAlt.Click
        If contFuncNome.Text <> "" Then

            If varCont1 = 0 Then

                contFuncNome.Enabled = True
                contFuncRG.Enabled = True
                contFuncCPF.Enabled = True
                contFuncData.Enabled = True
                contFuncEndereco.Enabled = True
                contFuncNum.Enabled = True
                contFuncCompl.Enabled = True
                contFuncCEP.Enabled = True
                contFuncBairro.Enabled = True
                contFuncCidade.Enabled = True
                contFuncEstado.Enabled = True
                contFuncSalario.Enabled = True
                contFuncCartTrab.Enabled = True
                contFuncDataAdm.Enabled = True
                MaskedTextBox3.Enabled = True
                MaskedTextBox4.Enabled = True
                botaoContFuncExc.Enabled = False


                varCont1 = 1
                botaoContFuncAlt.Text = "Aceitar"
                Exit Sub

            End If

            If varCont1 = 1 Then

                Dim contAlterar As String
                contAlterar = contFuncNome.Text & SPLITTER1 & contFuncRG.Text & SPLITTER1 & contFuncCPF.Text & SPLITTER1 & contFuncData.Text & SPLITTER1 & contFuncEndereco.Text & SPLITTER1 & contFuncNum.Text & SPLITTER1 & contFuncCompl.Text & SPLITTER1 & contFuncCEP.Text & SPLITTER1 & contFuncBairro.Text & SPLITTER1 & contFuncCidade.Text & SPLITTER1 & contFuncEstado.Text & SPLITTER1 & MaskedTextBox4.Text & SPLITTER1 & MaskedTextBox3.Text & SPLITTER1 & contFuncSalario.Text & SPLITTER1 & contFuncCartTrab.Text & SPLITTER1 & contFuncDataAdm.Text

                Dim func12345 As Integer = 0
                Dim listafunc12345 As String
                Dim listaCont As String

                listaCont = DESCRIPTOGRAFAR("Piear\Func\lista\lista0.prs")


                While func12345 <= listaCont


                    If Exists("Piear\Func\" & func12345 & ".prs") Then

                        listafunc12345 = (DESCRIPTOGRAFAR("Piear\Func\" & func12345 & ".prs"))

                    Else
                        func12345 += 1
                        Continue While

                    End If

                    Dim dados2 = Split(listafunc12345, SPLITTER1)(1)

                    If dados2 = contFuncRG.Text Then
                        CRIPTOGRAFAR("Piear\Func\" & func12345 & ".prs", contFuncNome.Text & SPLITTER1 & contFuncRG.Text & SPLITTER1 & contFuncCPF.Text & SPLITTER1 & contFuncData.Text & SPLITTER1 & contFuncEndereco.Text & SPLITTER1 & contFuncNum.Text & SPLITTER1 & contFuncCompl.Text & SPLITTER1 & contFuncCEP.Text & SPLITTER1 & contFuncBairro.Text & SPLITTER1 & contFuncCidade.Text & SPLITTER1 & contFuncEstado.Text & SPLITTER1 & MaskedTextBox4.Text & SPLITTER1 & MaskedTextBox3.Text & SPLITTER1 & contFuncSalario.Text & SPLITTER1 & contFuncCartTrab.Text & SPLITTER1 & contFuncDataAdm.Text)

                        contFuncNome.Enabled = False
                        contFuncRG.Enabled = False
                        contFuncCPF.Enabled = False
                        contFuncData.Enabled = False
                        contFuncEndereco.Enabled = False
                        contFuncNum.Enabled = False
                        contFuncCompl.Enabled = False
                        contFuncCEP.Enabled = False
                        contFuncBairro.Enabled = False
                        contFuncCidade.Enabled = False
                        contFuncEstado.Enabled = False
                        contFuncSalario.Enabled = False
                        contFuncCartTrab.Enabled = False
                        contFuncDataAdm.Enabled = False
                        MaskedTextBox4.Enabled = False
                        MaskedTextBox3.Enabled = False
                        botaoContFuncExc.Enabled = True


                        botaoContFuncAlt.Text = "Alterar"
                        listaContFunc.Items.Clear()
                        AtualizarFunc()


                        Exit While

                    Else

                        func12345 += 1

                    End If


                End While

                varCont1 = 0
            End If


        Else

            varAlterarErr1 = 1
            Form1.Show()
        End If


    End Sub

    Private Sub botaoContFuncExc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContFuncExc.Click
        If contFuncNome.Text <> "" Then

            botaoContFuncAlt.PerformClick()
            botaoContFuncAlt.PerformClick()

            listaContFunc.Items.Clear()
            AtualizarFunc()

            Dim contExcluir As String
            contExcluir = contFuncNome.Text & SPLITTER1 & contFuncRG.Text & SPLITTER1 & contFuncCPF.Text & SPLITTER1 & contFuncData.Text & SPLITTER1 & contFuncEndereco.Text & SPLITTER1 & contFuncNum.Text & SPLITTER1 & contFuncCompl.Text & SPLITTER1 & contFuncCEP.Text & SPLITTER1 & contFuncBairro.Text & SPLITTER1 & contFuncCidade.Text & SPLITTER1 & contFuncEstado.Text & SPLITTER1 & MaskedTextBox4.Text & SPLITTER1 & MaskedTextBox3.Text & SPLITTER1 & contFuncSalario.Text & SPLITTER1 & contFuncCartTrab.Text & SPLITTER1 & contFuncDataAdm.Text

            Dim ContFunc As Integer = 0
            Dim listag As String
            listag = DESCRIPTOGRAFAR("Piear\Func\Lista\Lista0.prs")



            While ContFunc <= listag

                If Exists("Piear\Func\" & ContFunc & ".prs") Then
                    contCompFunc = (DESCRIPTOGRAFAR("Piear\Func\" & ContFunc & ".prs"))


                    If contCompFunc = contExcluir Then


                        System.IO.File.Delete("Piear\Func\" & ContFunc & ".prs")
                        listaContFunc.Items.Clear()
                        AtualizarFunc()

                        contFuncNome.Text = ""
                        contFuncRG.Text = ""
                        contFuncCPF.Text = ""
                        contFuncData.Text = ""
                        contFuncEndereco.Text = ""
                        contFuncNum.Text = ""
                        contFuncCompl.Text = ""
                        contFuncCEP.Text = ""
                        contFuncBairro.Text = ""
                        contFuncCidade.Text = ""
                        contFuncEstado.Text = ""
                        contFuncSalario.Text = ""
                        contFuncCartTrab.Text = ""
                        contFuncDataAdm.Text = ""
                        MaskedTextBox3.Text = ""
                        MaskedTextBox4.Text = ""

                        Exit While
                    Else
                        ContFunc += 1
                        Continue While
                    End If

                Else
                    ContFunc += 1
                    Continue While
                End If


            End While

        Else
            varExcluirErr1 = 1
            Form1.Show()

        End If


    End Sub

    Private Sub TabContFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabContFunc.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If contadorTimer = 1 And TabControl1.TabPages.Contains(TabContFunc) Then
            If MessageBox.Show("Você possui registros para atualizar, clique em ok para atualizar!", "Confirmação", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK Then

                TabControl1.TabPages.Remove(TabContFunc)
                AtualizarFunc()
                TabControl1.TabPages.Add(TabContFunc)
                contadorTimer = 0
            End If

        End If

        If contadorTimerCli = 1 And TabControl1.TabPages.Contains(TabContCli) Then

            If MessageBox.Show("Você possui registros para atualizar, clique em ok para atualizar!", "Confirmação", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK Then
                TabControl1.TabPages.Remove(TabContCli)
                Atualizar()
                TabControl1.TabPages.Add(TabContCli)
                contadorTimerCli = 0
            End If

        End If

       






    End Sub

    Private Sub cadCliNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadCliNome.KeyPress, cadFuncNome.KeyPress

        If Not InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWXYÝZ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True
    End Sub

    Private Sub cadCliNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadCliNome.TextChanged

    End Sub

    Private Sub cadCliEstado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadCliEstado.TextChanged

    End Sub

    Private Sub cadFuncNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadFuncNome.KeyPress

    End Sub

    Private Sub cadFuncNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cadFuncNome.TextChanged

    End Sub

    Private Sub botaoCatalogoAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCatalogoAnt.Click
        Dim var123456 As Integer

        Dim vestidolista1 As String = ""

        Dim listavest1 As New Integer

        listavest1 = DESCRIPTOGRAFAR("Piear\Vestido\Lista\Lista0.prs")



        '
        '
        '
        '
        'começo anterior por codigo
        If varContCatalPesqCodigo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesquisarvar = vestidocat Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao
                    Label122.Text = dadosquantidade



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If

        'fim anterior por codigo
        '
        '
        '
        '

        '
        '
        '
        '
        'começo anterior por cor
        If varContCatalPesqCor = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0
                If var123456 = listavest1 + 1 Then
                    Exit Sub

                End If

                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    var123456 += 1

                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If


                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogopesqcor1 = Dadoscor Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        'fim anterior por cor

        '
        '
        '
        '
        '
        'começo anterior por modelo
        If varContCatalPesqModelo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If


                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqModelo1 = dadosmodelo Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        '
        'fim anterior por modelo

        '
        '
        '
        '
        '
        'começo anterior por tamanho

        If varContCatalPesqModelo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If


                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqModelo1 = dadosmodelo Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        '
        'fim anterior por modelo

        '
        '
        '
        '
        'começo anteior por tamanho

        If varContCatalPesqTamanho = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If


                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqtamanho1 = dadostamanho Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        '
        '
        'fim anterior por modelo


        '
        '
        '
        '
        '
        'começo anterior por ocasiao

        If varContCatalPesqOcasiao = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat -= 1

                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If


                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat -= 1


                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqocasiao1 = dadosocasiao Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat -= 1
                    If vestidocat < 0 Then
                        vestidocat = listavest1

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If

        '
        '
        '
        '
        '
        'fim anterior por ocasiao


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        While vestidocat <= listavest1 And vestidocat >= 0



            If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                vestidocat -= 1

                If vestidocat < 0 Then

                    If vestidocat = listavest1 Then
                        vestidocat -= 1
                    Else
                        vestidocat = listavest1
                    End If


                End If

                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                End If

            Else
                vestidocat -= 1

                If vestidocat < 0 Then

                    If vestidocat = listavest1 Then
                        vestidocat -= 1
                    Else
                        vestidocat = listavest1
                    End If


                End If

                Continue While
            End If


            Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
            Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
            Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
            Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
            Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
            Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

            Label41.Text = vestidocat
            Label42.Text = Dadoscor
            Label43.Text = dadospreco
            Label44.Text = dadosmodelo
            Label45.Text = dadostamanho
            Label46.Text = dadosocasiao

            catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
            Exit Sub

            Exit While

        End While

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''









    End Sub

    Private Sub botaoCatalogoPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCatalogoPro.Click


        Dim vestidolista1 As String = ""

        Dim listavest1 As New Integer

        listavest1 = DESCRIPTOGRAFAR("Piear\Vestido\Lista\Lista0.prs")

        '
        '
        '
        '
        'começo proximo por codigo
        If varContCatalPesqCodigo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If


                    vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")

                Else
                    vestidocat += 1


                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)


                If catalogoPesquisarvar = vestidocat Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")

                Else
                    vestidocat += 1
                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If
                    Continue While

                End If

            End While


        End If

        'fim proximo por codigo
        '
        '
        '
        '

        '
        '
        '
        '
        'começo proximo por cor
        Dim var123456 As Integer

        If varContCatalPesqCor = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0
                If var123456 = listavest1 + 1 Then
                    Exit Sub

                End If

                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    var123456 += 1

                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat += 1


                    If vestidocat > listavest1 Then
                        vestidocat = 0
                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)


                If catalogopesqcor1 = Dadoscor Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat += 1
                    If vestidocat > listavest1 Then
                        vestidocat = 0
                    End If
                    Continue While

                End If
                Exit Sub
            End While

        End If


        '
        '
        '
        'fim proximo por cor

        '
        '
        '
        '
        '
        'começo proximo por modelo
        If varContCatalPesqModelo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If

                Else
                    vestidocat += 1


                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqModelo1 = dadosmodelo Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub

                Else
                    vestidocat += 1
                    If vestidocat > listavest1 Then
                        vestidocat = 0
                    End If
                    Continue While
                End If
                Exit Sub
            End While

        End If


        '
        '
        '
        '
        'fim proximo por modelo

        '
        '
        '
        '
        '
        'começo proximo por tamanho

        If varContCatalPesqModelo = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If
                Else
                    vestidocat += 1


                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqModelo1 = dadosmodelo Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat += 1
                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        '
        'fim proximo por modelo

        '
        '
        '
        '
        'começo proximo por tamanho

        If varContCatalPesqTamanho = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If
                Else
                    vestidocat += 1


                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If


                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)

                If catalogoPesqtamanho1 = dadostamanho Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat += 1
                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If


        '
        '
        '
        '
        '
        'fim proximo por modelo


        '
        '
        '
        '
        '
        'começo proximo por ocasiao

        If varContCatalPesqOcasiao = 1 Then
            While vestidocat <= listavest1 And vestidocat >= 0


                If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If

                    If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                        vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                    End If
                Else
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If



                    Continue While
                End If



                Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
                Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
                Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
                Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
                Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
                Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)


                If catalogoPesqocasiao1 = dadosocasiao Then

                    Label41.Text = vestidocat
                    Label42.Text = Dadoscor
                    Label43.Text = dadospreco
                    Label44.Text = dadosmodelo
                    Label45.Text = dadostamanho
                    Label46.Text = dadosocasiao



                    catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
                    Exit Sub


                Else
                    vestidocat += 1

                    If vestidocat > listavest1 Then
                        vestidocat = 0

                    End If
                    Continue While

                End If
                Exit Sub
            End While


        End If

        '
        '
        '
        '
        '
        'fim proximo por ocasiao

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        While vestidocat <= listavest1 And vestidocat >= 0



            If Exists("Piear\vestido\" & vestidocat & ".prs") Then
                vestidocat += 1

                If vestidocat > listavest1 Then

                    If vestidocat = 0 Then
                        vestidocat += 1
                    Else
                        vestidocat = 0
                    End If


                End If

                If Exists("Piear\vestido\" & vestidocat & ".prs") Then

                    vestidolista1 = DESCRIPTOGRAFAR("Piear\vestido\" & vestidocat & ".prs")
                End If

            Else
                vestidocat -= 1


                If vestidocat > listavest1 Then

                    If vestidocat = 0 Then
                        vestidocat += 1
                    Else
                        vestidocat = 0
                    End If
                End If



                Continue While
            End If



            Dim Dadoscor = Split(vestidolista1, SPLITTER1)(0)
            Dim dadospreco = Split(vestidolista1, SPLITTER1)(1)
            Dim dadosmodelo = Split(vestidolista1, SPLITTER1)(2)
            Dim dadostamanho = Split(vestidolista1, SPLITTER1)(3)
            Dim dadosocasiao = Split(vestidolista1, SPLITTER1)(4)
            Dim dadosquantidade = Split(vestidolista1, SPLITTER1)(5)



            Label41.Text = vestidocat
            Label42.Text = Dadoscor
            Label43.Text = dadospreco
            Label44.Text = dadosmodelo
            Label45.Text = dadostamanho
            Label46.Text = dadosocasiao
            catalogoImg.Image = Image.FromFile("Piear\Fotos\" & vestidocat & ".jpg")
            Exit Sub



            Exit While

        End While



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''







    End Sub

    Private Sub botaoCatalogoPesq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cadVestPreco_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadVestPreco.RightToLeftChanged

    End Sub

    Private Sub listaContVest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listaContVest.Click
        With listaContVest.FocusedItem


            If listaContVest.SelectedItems.Count > 0 Then
                contVestCor.Text = .Text
                contVestPreco.Text = .SubItems(1).Text
                contVestModelo.Text = .SubItems(2).Text
                contVestTamanho.Text = .SubItems(3).Text
                contVestOcasiao.Text = .SubItems(4).Text
                labeldocodigodovestido.Text = .SubItems(5).Text
                TextBox12.Text = .SubItems(6).Text


                Dim variavelqueeuquis As Integer

                variavelqueeuquis = labeldocodigodovestido.Text


                contVestImg.Image = Image.FromFile("Piear\Fotos\" & variavelqueeuquis & ".jpg")
                labeldocodigodovestido.Text = variavelqueeuquis


                Exit Sub








            End If
        End With
    End Sub

    Private Sub listaContVest_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listaContVest.MouseClick

    End Sub

    Private Sub listaContVest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaContVest.SelectedIndexChanged

    End Sub

    Private Sub listaContVest_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listaContVest.SizeChanged

    End Sub

    Private Sub botaoContVestAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContVestAlt.Click
        If labeldocodigodovestido.Text <> "" Then


            If botaoalterarvestido = 0 Then
                botaoContVestAlt.Text = "Aceitar"

                contVestCor.Enabled = True
                contVestModelo.Enabled = True
                contVestOcasiao.Enabled = True
                contVestPreco.Enabled = True
                contVestTamanho.Enabled = True
                botaoContVestProcurar.Enabled = True
                botaoalterarvestido = 1
                botaoContVestExc.Enabled = False
                TextBox12.Enabled = True

                Exit Sub

            End If

            If botaoalterarvestido = 1 Then
                Dim contAlterar As String

                contAlterar = contVestCor.Text & SPLITTER1 & contVestPreco.Text & SPLITTER1 & contVestModelo.Text & SPLITTER1 & contVestTamanho.Text & SPLITTER1 & contVestOcasiao.Text & SPLITTER1 & TextBox12.Text


                Dim vestidovar As Integer = 0
                Dim listavestido1 As String


                listavestido1 = DESCRIPTOGRAFAR("Piear\Vestido\Lista\Lista0.prs")

                While vestidovar <= listavestido1


                    If Not Exists("Piear\Vestido\" & vestidovar & ".prs") Then
                        vestidovar += 1
                        Continue While
                    End If

                    If vestidovar = labeldocodigodovestido.Text Then


                        contVestCor.Enabled = False
                        contVestModelo.Enabled = False
                        contVestOcasiao.Enabled = False
                        contVestPreco.Enabled = False
                        contVestTamanho.Enabled = False
                        botaoContVestProcurar.Enabled = False
                        botaoContVestExc.Enabled = True
                        TextBox12.Enabled = False



                        System.IO.Directory.CreateDirectory("Piear\Temp")


                        contVestImg.Image.Save("Piear\Temp\" & vestidovar & ".jpg", Drawing.Imaging.ImageFormat.Jpeg)




                        contVestImg.Image.Dispose()
                        contVestImg.Image = Nothing



                        Kill("Piear\Fotos\" & vestidovar & ".jpg")

                        System.IO.File.Move("Piear\Temp\" & vestidovar & ".jpg", "Piear\Fotos\" & vestidovar & ".jpg")

                        contVestImg.Image = Image.FromFile("Piear\Fotos\" & vestidovar & ".jpg")



                        CRIPTOGRAFAR("Piear\Vestido\" & vestidovar & ".prs", contVestCor.Text & SPLITTER1 & contVestPreco.Text & SPLITTER1 & contVestModelo.Text & SPLITTER1 & contVestTamanho.Text & SPLITTER1 & contVestOcasiao.Text & SPLITTER1 & TextBox12.Text)


                        botaoContVestAlt.Text = "Alterar"
                        listaContVest.Items.Clear()
                        AtualizarVestido()

                        Exit While

                    Else

                        vestidovar += 1



                    End If


                End While

                botaoalterarvestido = 0

            End If

        Else

            varAlterarErr = 1
            Form1.Show()
        End If


    End Sub

    Private Sub botaoContVestExc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoContVestExc.Click

        If labeldocodigodovestido.Text <> "" Then

            Dim ContVest As Integer = 0
            Dim listav As String
            Dim contexcluir1 As String



            contexcluir1 = contVestCor.Text & SPLITTER1 & contVestPreco.Text & SPLITTER1 & contVestModelo.Text & SPLITTER1 & contVestTamanho.Text & SPLITTER1 & contVestOcasiao.Text & SPLITTER1 & TextBox12.Text


            listav = DESCRIPTOGRAFAR("Piear\Vestido\Lista\Lista0.prs")



            While ContVest <= listav

                If Exists("Piear\Vestido\" & ContVest & ".prs") Then
                    contCompVestido = (DESCRIPTOGRAFAR("Piear\Vestido\" & ContVest & ".prs"))


                    If contCompVestido = contexcluir1 Then


                        contVestCor.Text = ""
                        contVestModelo.Text = ""
                        contVestOcasiao.Text = ""
                        contVestPreco.Text = ""
                        contVestTamanho.Text = ""
                        labeldocodigodovestido.Text = ""
                        TextBox12.Text = ""

                        contVestImg.Image.Dispose()
                        contVestImg.Image = Nothing




                        Kill("Piear\Fotos\" & ContVest & ".jpg")

                        System.IO.File.Delete("Piear\Vestido\" & ContVest & ".prs")


                        listaContVest.Items.Clear()
                        AtualizarVestido()

                        botaoContVestProcurar.Enabled = False



                        Exit While
                    Else
                        ContVest += 1
                        Continue While
                    End If

                Else
                    ContVest += 1
                    Continue While
                End If


            End While

        Else
            varExcluirErr = 1
            Form1.Show()


        End If


    End Sub

    Private Sub cadCliRG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadCliRG.KeyPress
        If Not InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWYÝ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True

    End Sub

    Private Sub cadCliRG_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles cadCliRG.MaskInputRejected

    End Sub

    Private Sub cadCliRG_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cadCliRG.ModifiedChanged
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TabControl1.TabPages.Contains(TabCadCli) Then

            timer3varcadcli = 1

        End If

        If varfecharaluguel = 1 Then
            TabControl1.TabPages.Remove(TabAluguel)
            varfecharaluguel = 0

        End If

        If TabControl1.TabPages.Contains(TabCadFunc) Then

            timer3varcadfunc = 1

        End If

        If TabControl1.TabPages.Contains(TabCadVest) Then

            timer3varcadvest = 1

        End If


        If variavelprafechar = 1 Then

            TabControl1.TabPages.Remove(TabCadCli)
            variavelprafechar = 0

        End If


        If variavelprafechar2 = 1 Then

            TabControl1.TabPages.Remove(TabCadFunc)
            variavelprafechar2 = 0

        End If

        If variavelprafechar3 = 1 Then

            TabControl1.TabPages.Remove(TabCadVest)

            Try
                cadVestImg.Image.Dispose()
            Catch ex As Exception

            End Try
            cadVestImg.Image = Nothing



            variavelprafechar3 = 0

        End If


        If varFechaTAB = 1 Then
            TabControl1.TabPages.Remove(TabContVest)
            varFechaTAB = 0

        End If

    End Sub

    Private Sub cadVestPreco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadVestPreco.KeyPress
        If InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWXYÝZ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True
    End Sub

    Private Sub botaoCadCli_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseDown
        botaoCadCli.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCadCli_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadCli.MouseLeave
        botaoCadCli.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCadCli_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadCli.MouseMove
        botaoCadCli.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloCadCli_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadCli.MouseDown
        botaoCloCadCli.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloCadCli_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloCadCli.MouseLeave
        botaoCloCadCli.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloCadCli_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadCli.MouseMove
        botaoCloCadCli.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCadFunc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadFunc.MouseDown
        botaoCadFunc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCadFunc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadFunc.MouseLeave
        botaoCadFunc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCadFunc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadFunc.MouseMove
        botaoCadFunc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloCadFunc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadFunc.MouseDown
        botaoCloCadFunc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloCadFunc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloCadFunc.MouseLeave
        botaoCloCadFunc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloCadFunc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadFunc.MouseMove
        botaoCloCadFunc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCadVestProcurar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadVestProcurar.MouseDown
        botaoCadVestProcurar.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCadVestProcurar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadVestProcurar.MouseLeave
        botaoCadVestProcurar.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCadVestProcurar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadVestProcurar.MouseMove
        botaoCadVestProcurar.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCadVest_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadVest.MouseDown
        botaoCadVest.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCadVest_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCadVest.MouseLeave
        botaoCadVest.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCadVest_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCadVest.MouseMove
        botaoCadVest.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloCadVest_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadVest.MouseDown
        botaoCloCadVest.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloCadVest_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloCadVest.MouseLeave
        botaoCloCadVest.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloCadVest_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCadVest.MouseMove
        botaoCloCadVest.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCatalogoPesq_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub botaoCatalogoPesq_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub botaoCatalogoPesq_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub botaoCloCatalogo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCatalogo.MouseDown
        botaoCloCatalogo.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloCatalogo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloCatalogo.MouseLeave
        botaoCloCatalogo.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloCatalogo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloCatalogo.MouseMove
        botaoCloCatalogo.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCatalogoAnt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCatalogoAnt.MouseDown
        botaoCatalogoAnt.BackgroundImage = ImageList2.Images(2)
    End Sub

    Private Sub botaoCatalogoAnt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCatalogoAnt.MouseLeave
        botaoCatalogoAnt.BackgroundImage = ImageList2.Images(0)
    End Sub

    Private Sub botaoCatalogoAnt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCatalogoAnt.MouseMove
        botaoCatalogoAnt.BackgroundImage = ImageList2.Images(1)
    End Sub

    Private Sub botaoCatalogoPro_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCatalogoPro.MouseDown
        botaoCatalogoPro.BackgroundImage = ImageList2.Images(5)
    End Sub

    Private Sub botaoCatalogoPro_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCatalogoPro.MouseLeave
        botaoCatalogoPro.BackgroundImage = ImageList2.Images(3)
    End Sub


    Private Sub botaoCatalogoPro_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCatalogoPro.MouseMove
        botaoCatalogoPro.BackgroundImage = ImageList2.Images(4)
    End Sub

    Private Sub botaoContCliAlt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContCliAlt.MouseDown
        botaoContCliAlt.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContCliAlt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContCliAlt.MouseLeave
        botaoContCliAlt.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContCliAlt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContCliAlt.MouseMove
        botaoContCliAlt.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContCliExc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContCliExc.MouseDown
        botaoContCliExc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContCliExc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContCliExc.MouseLeave
        botaoContCliExc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContCliExc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContCliExc.MouseMove
        botaoContCliExc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloContCli_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContCli.MouseDown
        botaoCloContCli.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloContCli_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloContCli.MouseLeave
        botaoCloContCli.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloContCli_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContCli.MouseMove
        botaoCloContCli.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContFuncAlt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContFuncAlt.MouseDown
        botaoContFuncAlt.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContFuncAlt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContFuncAlt.MouseLeave
        botaoContFuncAlt.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContFuncAlt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContFuncAlt.MouseMove
        botaoContFuncAlt.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContFuncExc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContFuncExc.MouseDown
        botaoContFuncExc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContFuncExc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContFuncExc.MouseLeave
        botaoContFuncExc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContFuncExc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContFuncExc.MouseMove
        botaoContFuncExc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloContFunc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContFunc.MouseDown
        botaoCloContFunc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloContFunc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloContFunc.MouseLeave
        botaoCloContFunc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloContFunc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContFunc.MouseMove
        botaoCloContFunc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContVestProcurar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestProcurar.MouseDown
        botaoContVestProcurar.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContVestProcurar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContVestProcurar.MouseLeave
        botaoContVestProcurar.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContVestProcurar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestProcurar.MouseMove
        botaoContVestProcurar.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContVestAlt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestAlt.MouseDown
        botaoContVestAlt.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContVestAlt_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContVestAlt.MouseLeave
        botaoContVestAlt.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContVestAlt_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestAlt.MouseMove
        botaoContVestAlt.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoContVestExc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestExc.MouseDown
        botaoContVestExc.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoContVestExc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoContVestExc.MouseLeave
        botaoContVestExc.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoContVestExc_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoContVestExc.MouseMove
        botaoContVestExc.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloContVest_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContVest.MouseDown
        botaoCloContVest.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloContVest_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloContVest.MouseLeave
        botaoCloContVest.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloContVest_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContVest.MouseMove
        botaoCloContVest.BackgroundImage = ImageList1.Images(1)
    End Sub





    Private Sub botaoCloContLoca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoCloContLoca.Click

        If Button21.Text = "Aceitar" Then
            varfechaaltloc = 1
            Form1.Show()
        Else
            TabControl1.TabPages.Remove(TabContLoc)
        End If
    End Sub

    Private Sub botaoCloAluguel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloAluguel.MouseDown
        botaoCloAluguel.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloAluguel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloAluguel.MouseLeave
        botaoCloAluguel.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloAluguel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloAluguel.MouseMove
        botaoCloAluguel.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub menuAjudaPIEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAjudaPIEAR.Click

        System.Diagnostics.Process.Start("Piear\Manual_do_Usuario.docx")
        'System.IO.File.("Piear\Manual_do_Usuario.docx", FileMode.Open, FileAccess.Read, FileShare.Read)

        Exit Sub

        MessageBox.Show("Aguarde, brevemente voce poderá consultar a ajuda do programa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, True)
        Exit Sub

    End Sub

    Private Sub TabContVest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabContVest.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If TabControl1.TabPages.Count > 0 Then
            TabControl1.Visible = True
        Else
            TabControl1.Visible = False
        End If

    End Sub

    Private Sub FormPrin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If varClosing = 1 Then
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
        botaoCatalogoAnt.Enabled = True
        botaoCatalogoPro.Enabled = True

        varContCatalPesqCor = 0
        varContCatalPesqCodigo = 0
        varContCatalPesqModelo = 0
        varContCatalPesqOcasiao = 0
        varContCatalPesqTamanho = 0

    End Sub
    Private WithEvents m_printdocument As PrintDocument

    Private Sub m_printdocument_printpage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles m_printdocument.PrintPage
        Using caneta As New Pen(Color.Black, 20)
            e.Graphics.DrawRectangle(caneta, e.MarginBounds)
            caneta.DashStyle = Drawing2D.DashStyle.Dash
            caneta.Alignment = Drawing2D.PenAlignment.Inset
            e.Graphics.DrawRectangle(caneta, e.PageBounds)
        End Using
        e.HasMorePages = False
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        m_printdocument = New PrintDocument
        m_printdocument.Print()

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m_printdocument = New PrintDocument

        PrintPreviewDialog1.Text = "Usando - Print"

        PrintPreviewDialog1.Document = m_printdocument
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m_printdocument = New PrintDocument
        PrintDialog1.Document = m_printdocument
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub contFuncRG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles contFuncRG.KeyPress
        If InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWÝ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True

    End Sub

    Private Sub contFuncRG_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles contFuncRG.MaskInputRejected
    End Sub

    Private Sub cadFuncRG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cadFuncRG.KeyPress
        If InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWÝ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True

    End Sub

    Private Sub cadFuncRG_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles cadFuncRG.MaskInputRejected

    End Sub

    Private Sub contCliRG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles contCliRG.KeyPress
        If InStr("AÁÀÃÂBCDEÉÈÊFGHIÍÌÎJKLMNOÓÒÔÕÖPQRSTUÚÙÛÜVWÝ " & Chr(Keys.Back), UCase(e.KeyChar)) > 0 Then e.Handled = True
    End Sub

    Private Sub contCliRG_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles contCliRG.MaskInputRejected

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        variavel1 = 1

        FormPesquisar.Show()
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        horadoaluguel.Text = System.DateTime.Now()

        If varfecharguia3 = 1 Then

            TabControl1.TabPages.Remove(TabContCli)
            varfecharguia3 = 0

        End If


        If varfecharguia6 = 1 Then

            TabControl1.TabPages.Remove(TabContFunc)
            varfecharguia6 = 0

        End If

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        If varbotaopesq1 = 1 Then
            TextBox4.Text = MonthCalendar1.SelectionStart()
            varbotaopesq1 = 0
            MonthCalendar1.Visible = False

        End If

        If varbotaopesq2 = 1 Then
            TextBox5.Text = MonthCalendar1.SelectionStart()
            varbotaopesq2 = 0
            MonthCalendar1.Visible = False
        End If

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If varbotaopesq1 = 1 Or varbotaopesq2 = 1 Then
        Else
            MonthCalendar1.Visible = True
            varbotaopesq1 = 1
        End If



    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If varbotaopesq1 = 1 Or varbotaopesq2 = 1 Then
        Else
            MonthCalendar1.Visible = True
            varbotaopesq2 = 1
        End If

    End Sub

    Private Sub Button6_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseDown
        Button6.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button7_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseDown
        Button7.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button6_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseMove
        Button6.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove
        Button7.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = ImageList1.Images(2)
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button8_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseDown
        Button8.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Try
            Button8.BackgroundImage = ImageList1.Images(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseMove


        Button8.BackgroundImage = ImageList1.Images(1)


    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim z As Double
        z = Label43.Text.Replace("R$", "")

        If Label104.Text.Replace("R$", "") <> "" Then
            valor = Label104.Text
        End If

        Dim a As Integer = 0
        Dim lista As String = ""
        Dim descript As String = ""


        valor += z
        ' If Exists("Piear\Aluguel\Lista\Lista0.prs") Then
        'lista = DESCRIPTOGRAFAR("Piear\Aluguel\Lista\Lista0.prs")
        'End If

        'Dim var1 As Integer


        'While var1 <= lista
        'If Exists("Piear\Aluguel\" & var1 & ".prs") Then
        'descript = DESCRIPTOGRAFAR("Piear\Aluguel\" & var1 & ".prs")

        'End If

        'Dim dadosvestido = Split(descript(1))



        'End While
        Form4.Show()
        Exit Sub




    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim aluguel As Integer
        Dim descript As String



        If Not System.IO.Directory.Exists("Piear\Aluguel") Then
            System.IO.Directory.CreateDirectory("Piear\Aluguel")
        End If

        If Not System.IO.Directory.Exists("Piear\Aluguel\Lista") Then
            System.IO.Directory.CreateDirectory("Piear\Aluguel\Lista")
        End If


        While Exists("Piear\Aluguel\" & aluguel & ".prs")
            aluguel += 1
        End While


        If Not Exists("Piear\Aluguel\Lista\Lista0.prs") Then
            CRIPTOGRAFAR("Piear\Aluguel\Lista\Lista0.prs", aluguel)
        Else
            descript = DESCRIPTOGRAFAR("Piear\Aluguel\Lista\Lista0.prs")
            If aluguel > descript Then
                CRIPTOGRAFAR("Piear\Aluguel\Lista\Lista0.prs", aluguel)
            End If
        End If

        'Exit Sub

        'Dim abc As Integer

        Dim VAR As String = ""
        For x = 0 To ListBox1.Items.Count - 1

            VAR &= ListBox1.Items(x) & splitter2
            cont += 1

        Next x

        varnomealuguel = TextBox1.Text
        varanota = TextBox2.Text
        vardatahora = horadoaluguel.Text
        vardatadev = TextBox4.Text
        vardatapro = TextBox5.Text
        varsinal = TextBox3.Text
        varprecotot = totalaserpago.Text
        varprecoalu = Label104.Text


        abcd = VAR




        CRIPTOGRAFAR("Piear\Aluguel\" & aluguel & ".prs", TextBox1.Text & SPLITTER1 & VAR & SPLITTER1 & horadoaluguel.Text & SPLITTER1 & TextBox4.Text & SPLITTER1 & TextBox5.Text & SPLITTER1 & TextBox3.Text & SPLITTER1 & Label104.Text & SPLITTER1 & totalaserpago.Text & SPLITTER1 & TextBox2.Text)
        TextBox1.Text = ""
        ListBox1.Items.Clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label104.Text = ""
        totalaserpago.Text = ""
        Button8.Enabled = True

        'Dim yui As Integer

        'Dim dados As String = ""
        'Dim dadoscodigo As String = ""
        'Dim dadoscor As String = ""

        '        dados = Split(abcd, SPLITTER1)(yui)
        '       dadoscodigo = Split(dados, ", ")(0)
        '      MsgBox(Split(dados, ", ").Length)
        '     dadoscor = Split(dados, ", ")(1)
        '    Exit Sub

        PrintPreviewDialog1.ShowDialog()



    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click



        If Button10.Text = "Remover" Then
            ListBox1.Enabled = True
            Button10.Text = "Aceitar"
            Button11.Visible = True

            Exit Sub
        End If

        If Button10.Text = "Aceitar" Then
            If ListBox1.SelectedItems.Count > 0 Then

                Dim dados = Split(ListBox1.SelectedItem, ", ")(2).Replace("R$", "")
                Label104.Text -= dados
                Label104.Text = Format(Label104.Text, "Currency")

                ListBox1.Items.Remove(ListBox1.SelectedItem)

            Else
                deletarvest = 1
                Form1.Show()
                Exit Sub
            End If

            Button10.Text = "Remover"
            ListBox1.Enabled = False
            Button11.Visible = False

            Exit Sub
        End If

    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button10.Text = "Remover"
        ListBox1.SelectedItems.Clear()
        deletarvest = 0
        Button11.Visible = False
        ListBox1.Enabled = False


    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        Dim z As String = TextBox3.Text
        z = z.Replace("R$", "")
        z = z.Replace(".", "")
        Try
            If Mid(z, z.Length - 2, z.Length) = "00" Then
                TextBox3.Text = Mid(z, 0, z.Length - 2)
            Else
                TextBox3.Text = z
            End If
        Catch
        End Try
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.Text = Format(TextBox3.Text, "currency")

        salario = TextBox3.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button9_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseDown
        Button9.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button10_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseDown
        Button10.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button11_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseDown
        Button11.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        Button10.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        Button11.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        Button9.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button9_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseMove
        Button9.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button10_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseMove
        Button10.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button11_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseMove
        Button11.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer


        Dim Linha As Integer = 200
        Dim linha1 As Integer = 200
        Dim Titulo As Font = New Font("Arial", 16, FontStyle.Bold)
        'Dim in
        Dim font1 As Font = New Font("Arial", 20, FontStyle.Regular)
        Dim font2 As Font = New Font("Arial", 15, FontStyle.Regular)

        'Bloco de impressao figuras'
        '
        '
        e.Graphics.DrawImage(My.Resources.CABEÇALHO, 0, 0) 'cabeçalho
        e.Graphics.DrawImage(My.Resources.endereço, 0, e.PageBounds.Height - 175) 'endereço rodapé
        e.Graphics.DrawImage(My.Resources.horariodefuncionamento, e.PageBounds.Width - 440, e.PageBounds.Height - 450) 'horariodefuncionamento no meio
        e.Graphics.DrawImage(My.Resources.importante, 0, e.PageBounds.Height - 550) 'noticia importante no meio
        e.Graphics.DrawLine(Pens.Black, 900, e.PageBounds.Height - 155, 0, e.PageBounds.Height - 155)

        '
        '
        'final bloco'
        'Dim dados As String = ""
        'Dim dadoscodigo As String = ""
        ' Dim dadoscor As String = ""
        ' Dim dadospreco As String = ""
        ' Dim dadostamanho As String = ""
        '  Dim dadosocasiao As String = ""
        '  Dim dadosquantidade As String = ""
        '  Dim dadosmodelo As String = ""

        Dim yui As Integer = 0


        'começo bloco de impressao informações'
        '
        '


        Dim cliente = Split(varnomealuguel, ", ")(0)

        e.Graphics.DrawString("Cliente:  ", font1, Brushes.Black, 50, linha1 - 18)
        e.Graphics.DrawString(cliente, font1, Brushes.Black, 150, linha1 - 18)
        e.Graphics.DrawString("Cód Cor     Preço    Modelo          Tamanho   Ocasião   Qntd", font1, Brushes.Black, 20, linha1 + 20)
        e.Graphics.DrawString("Anotações:", font1, Brushes.Black, 20, 625)
        e.Graphics.DrawString(varanota, font2, Brushes.Black, 159, 632)

        linha1 += FontHeight + 7


        For yui = 0 To abcd.Split(splitter2).Length - 2


            dados = Split(abcd, splitter2)(yui)

            dadoscodigo = Split(dados, "@")(0)
            dadoscor = Split(dados, "@")(1)
            dadospreco = Split(dados, "@")(2)
            dadosmodelo = Split(dados, "@")(3)
            dadostamanho = Split(dados, "@")(4)
            dadosocasiao = Split(dados, "@")(5)
            dadosquantidade = Split(dados, "@")(6)

            linha1 += FontHeight + 15
            e.Graphics.DrawString(dadoscodigo, font2, Brushes.Black, 30, linha1)
            e.Graphics.DrawString(dadoscor, font2, Brushes.Black, 65, linha1)
            e.Graphics.DrawString(dadospreco, font2, Brushes.Black, 160, linha1)
            e.Graphics.DrawString(dadosmodelo, font2, Brushes.Black, 265, linha1)
            e.Graphics.DrawString(dadostamanho, font2, Brushes.Black, 500, linha1)
            e.Graphics.DrawString(dadosocasiao, font2, Brushes.Black, 580, linha1)
            e.Graphics.DrawString(dadosquantidade, font2, Brushes.Black, 730, linha1)


            If yui = abcd.Split(splitter2).Length - 1 Then
                Exit For
            End If

        Next yui

        e.Graphics.DrawString("Preço do Aluguel:", font1, Brushes.Black, e.PageBounds.Width - 390, e.PageBounds.Height - 285)
        e.Graphics.DrawString(varprecoalu, font1, Brushes.Black, e.PageBounds.Width - 170, e.PageBounds.Height - 285)

        e.Graphics.DrawString("Sinal:", font1, Brushes.Black, e.PageBounds.Width - 390, e.PageBounds.Height - 255)
        e.Graphics.DrawString(varsinal, font1, Brushes.Black, e.PageBounds.Width - 170, e.PageBounds.Height - 255)

        e.Graphics.DrawString("Preço Total:", font1, Brushes.Black, e.PageBounds.Width - 300, e.PageBounds.Height - 195)
        e.Graphics.DrawString(varprecotot, font1, Brushes.Black, e.PageBounds.Width - 150, e.PageBounds.Height - 195)

        e.Graphics.DrawString("Data da Prova:", font1, Brushes.Black, 10, e.PageBounds.Height - 285)
        e.Graphics.DrawString(vardatapro, font1, Brushes.Black, 265, e.PageBounds.Height - 285)

        e.Graphics.DrawString("Data de Devolução:", font1, Brushes.Black, 10, e.PageBounds.Height - 255)
        e.Graphics.DrawString(vardatadev, font1, Brushes.Black, 265, e.PageBounds.Height - 255)

        Dim data = Split(vardatahora, " ")(0)

        e.Graphics.DrawString("Data do Aluguel:", font1, Brushes.Black, 10, e.PageBounds.Height - 195)
        e.Graphics.DrawString(data, font1, Brushes.Black, 265, e.PageBounds.Height - 195)

        '
        '
        'final bloco'


        '        For y = 0 To 50
        'e.Graphics.DrawString("Linha " & y, Font, Brushes.Red, 50, Linha)
        '
        'e.Graphics.DrawLine(Pens.Black, 50, Linha + Font.Height + 5, e.PageBounds.Width - 50, Linha + Font.Height + 5)
        'Linha += FontHeight + 5
        'Next y
        yui = 0
        x += 1
        cont = 0
        If x > 5 Then e.HasMorePages = True





    End Sub

    Private Sub Button20_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button20.MouseDown
        Button20.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.MouseLeave
        Button20.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button20_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button20.MouseMove
        Button20.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseDown
        Button13.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        Button13.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button13_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseMove
        Button13.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button12_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseDown
        Button12.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave
        Button12.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseMove
        Button12.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button15_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button15.MouseDown
        Button15.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseLeave
        Button15.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button15_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button15.MouseMove
        Button15.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button14_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseDown
        Button14.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseLeave
        Button14.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Button14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseMove
        Button14.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub botaoCloContLoca_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContLoca.MouseDown
        botaoCloContLoca.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub botaoCloContLoca_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botaoCloContLoca.MouseLeave
        botaoCloContLoca.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub botaoCloContLoca_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles botaoCloContLoca.MouseMove
        botaoCloContLoca.BackgroundImage = ImageList1.Images(1)
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If Button13.Text = "Remover" Then
            ListBox2.Enabled = True
            Button13.Text = "Aceitar"
            Button12.Visible = True

            Exit Sub
        End If

        If Button13.Text = "Aceitar" Then
            If ListBox2.SelectedItems.Count > 0 Then
                ListBox2.Items.Remove(ListBox2.SelectedItem)

            Else
                deletarvest = 2
                Form1.Show()
                Exit Sub
            End If

            Button13.Text = "Remover"
            ListBox2.Enabled = False
            Exit Sub
        End If

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button13.Text = "Remover"
        ListBox2.SelectedItems.Clear()
        deletarvest = 0
        Button12.Visible = False
        ListBox2.Enabled = False
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If varbotaopesq3 = 1 Or varbotaopesq4 = 1 Then
        Else
            MonthCalendar2.Visible = True
            varbotaopesq3 = 1
        End If

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If varbotaopesq3 = 1 Or varbotaopesq4 = 1 Then
        Else
            MonthCalendar2.Visible = True
            varbotaopesq4 = 1
        End If
    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
      
    End Sub

    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.GotFocus
        Dim z As String = TextBox8.Text
        z = z.Replace("R$", "")
        z = z.Replace(".", "")
        Try
            If Mid(z, z.Length - 2, z.Length) = "00" Then
                TextBox8.Text = Mid(z, 0, z.Length - 2)
            Else
                TextBox8.Text = z
            End If
        Catch
        End Try
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        TextBox8.Text = Format(TextBox8.Text, "currency")

        salario = TextBox8.Text
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick


    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Dim a As Integer
        If TextBox3.Text = "" Then
            TextBox3.Text = 0
        End If

        Try
            a = Label104.Text.Replace("R$", "") - TextBox3.Text.Replace("R$", "")

        Catch ex As Exception

        End Try

        totalaserpago.Text = Format(a, "Currency")



    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub LoginToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Dim abcde As Integer

        While Exists("Piear\Logs\" & abcde & ".logs")
            abcde += 1
            Continue While

        End While

        If Not abcde > 5 Then Form6.Show()

    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        If TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox3.Text <> "0" And TextBox4.Text <> "" And TextBox5.Text <> "" And ListBox1.Items.Count > 0 Then
            Button9.Enabled = True
        Else
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim VAR As String = ""
        For x = 0 To ListBox1.Items.Count - 1

            VAR &= ListBox1.Items(x) & splitter2
            cont += 1

        Next x

        varnomealuguel = TextBox1.Text
        varanota = TextBox2.Text
        vardatahora = horadoaluguel.Text
        vardatadev = TextBox4.Text
        vardatapro = TextBox5.Text
        varsinal = TextBox3.Text
        varprecotot = totalaserpago.Text
        varprecoalu = Label104.Text


        abcd = VAR

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        Button3.BackgroundImage = ImageList1.Images(2)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = ImageList1.Images(0)

    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.BackgroundImage = ImageList1.Images(1)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        FormPesquisar.Show()

    End Sub

    Private Sub ListView1_Click2(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Dim yui As Integer = 0
        Dim spwhi As String = ""
        Dim whsp As String = ""

        With ListView1.FocusedItem


            If ListView1.SelectedItems.Count > 0 Then
                TextBox10.Text = .Text
                ' contVestPreco.Text = .SubItems(1).Text
                spwhi = .SubItems(1).Text.Split(splitter2).Length
                whsp = .SubItems(1).Text


                While yui < spwhi
                    Dim dados1 = Split(whsp, splitter2)(yui)
                    ListBox2.Items.Add(dados1)
                    yui += 1

                End While
                Label113.Text = .SubItems(2).Text
                TextBox7.Text = .SubItems(3).Text
                TextBox6.Text = .SubItems(4).Text
                TextBox8.Text = .SubItems(5).Text
                Label110.Text = .SubItems(6).Text
                Label107.Text = .SubItems(7).Text
                TextBox9.Text = .SubItems(8).Text



                Exit Sub

            End If
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If TextBox10.Text <> "" Then

            Dim contcompEsc As String
            Dim contExcluir As String

            Dim VAR As String = ""
            For x = 0 To ListBox2.Items.Count - 1

                VAR &= ListBox2.Items(x) & splitter2
                cont += 1

            Next x


            contExcluir = TextBox10.Text & SPLITTER1 & VAR & Label113.Text & SPLITTER1 & TextBox7.Text & SPLITTER1 & TextBox6.Text & TextBox8.Text & SPLITTER1 & Label110.Text & SPLITTER1 & Label110.Text & SPLITTER1 & TextBox9.Text

            Dim ContAluguel As Integer = 0
            Dim listaAluguel As String
            listaAluguel = DESCRIPTOGRAFAR("Piear\Aluguel\Lista\Lista0.prs")



            While ContAluguel <= listaAluguel

                If Exists("Piear\Aluguel\" & ContAluguel & ".prs") Then
                    contcompEsc = (DESCRIPTOGRAFAR("Piear\Aluguel\" & ContAluguel & ".prs"))
                    Dim data = Split(contcompEsc, SPLITTER1)(2)

                    If Label113.Text = data Then


                        System.IO.File.Delete("Piear\Aluguel\" & ContAluguel & ".prs")
                        ListView1.Items.Clear()
                        atualizarlocacao()
                        TextBox10.Text = ""
                        TextBox7.Text = ""
                        TextBox6.Text = ""
                        TextBox9.Text = ""
                        TextBox8.Text = ""
                        ListBox2.Text = ""
                        Label110.Text = ""
                        Label113.Text = ""
                        Label107.Text = ""
                        ListBox2.Items.Clear()


                        Exit While
                    Else
                        ContAluguel += 1
                        Continue While
                    End If

                Else
                    ContAluguel += 1
                    Continue While
                End If


            End While

        Else
            varExcluirErr1 = 1
            Form1.Show()

        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If TextBox10.Text <> "" Then

            If varcont12 = 0 Then

                TextBox10.Enabled = True
                TextBox7.Enabled = True
                TextBox6.Enabled = True
                TextBox9.Enabled = True
                TextBox8.Enabled = True
                ListBox2.Enabled = True
                Button22.Enabled = False
                TextBox13.Enabled = True

                Button20.Enabled = True
                Button13.Enabled = True
                Button15.Enabled = True
                Button14.Enabled = True



                varcont12 = 1
                Button21.Text = "Aceitar"
                Exit Sub

            End If

            Dim VAR As String = ""
            For x = 0 To ListBox2.Items.Count - 1

                VAR &= ListBox2.Items(x) & splitter2
                cont += 1

            Next x

            If varcont12 = 1 Then

                Dim contAlterar12 As String


                Dim aluguel1 As Integer = 0
                Dim listaAluguel12345 As String
                Dim listaContAluguel As String

                listaContAluguel = DESCRIPTOGRAFAR("Piear\Aluguel\lista\lista0.prs")


                While aluguel1 <= listaContAluguel


                    If Exists("Piear\Aluguel\" & aluguel1 & ".prs") Then

                        listaAluguel12345 = (DESCRIPTOGRAFAR("Piear\Aluguel\" & aluguel1 & ".prs"))

                    Else
                        aluguel1 += 1
                        Continue While

                    End If

                    Dim dados2 = Split(listaAluguel12345, SPLITTER1)(2)

                    If dados2 = Label113.Text Then

                        If TextBox13.Text <> "".Replace("R$", "") Then
                            Dim valorpago As Integer = 0
                            valorpago = Label107.Text.Replace("R$", "") - TextBox13.Text.Replace("R$", "")

                            contAlterar12 = TextBox10.Text & SPLITTER1 & VAR & SPLITTER1 & Label113.Text & SPLITTER1 & TextBox7.Text & SPLITTER1 & TextBox6.Text & SPLITTER1 & TextBox8.Text & SPLITTER1 & Label110.Text & SPLITTER1 & valorpago & SPLITTER1 & TextBox9.Text

                        Else
                            contAlterar12 = TextBox10.Text & SPLITTER1 & VAR & SPLITTER1 & Label113.Text & SPLITTER1 & TextBox7.Text & SPLITTER1 & TextBox6.Text & SPLITTER1 & TextBox8.Text & SPLITTER1 & Label110.Text & SPLITTER1 & Label107.Text & SPLITTER1 & TextBox9.Text

                        End If

                        CRIPTOGRAFAR("Piear\Aluguel\" & aluguel1 & ".prs", contAlterar12)
                        TextBox13.Text = ""

                        TextBox10.Enabled = False
                        TextBox7.Enabled = False
                        TextBox6.Enabled = False
                        TextBox9.Enabled = False
                        TextBox8.Enabled = False
                        ListBox2.Enabled = False
                        Button22.Enabled = True
                        TextBox13.Enabled = False

                        Button20.Enabled = False
                        Button13.Enabled = False
                        Button15.Enabled = False
                        Button14.Enabled = False

                        Button21.Text = "Alterar"
                        ListView1.Items.Clear()
                        atualizarlocacao()
                        Label110.Text = ""


                        Exit While

                    Else

                        aluguel1 += 1

                    End If


                End While

                varcont12 = 0
            End If

        Else
            varAlterarErr1 = 1
            Form1.Show()
        End If


    End Sub

    Private Sub TextBox9_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.GotFocus
        
    End Sub

    Private Sub TextBox9_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.LostFocus
    
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Sem Anotações" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Sem Anotações"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Dim VAR As String = ""
        Dim yui As Integer = 0
        Dim calc As Integer

        For x = 0 To ListBox2.Items.Count - 1

            VAR &= ListBox2.Items(x) & splitter2
            cont += 1

        Next x

        For x = 0 To ListBox2.Items.Count - 1

            Dim dados = Split(VAR, splitter2)(x)
            Dim dadospreco = Split(VAR, "$")(2)
            calc += dadospreco

        Next

        Label107.Text = Format(calc, "currency")

    End Sub

    Private Sub MonthCalendar2_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        If varbotaopesq3 = 1 Then
            TextBox7.Text = MonthCalendar2.SelectionStart()
            varbotaopesq3 = 0
            MonthCalendar2.Visible = False

        End If

        If varbotaopesq4 = 1 Then
            TextBox6.Text = MonthCalendar2.SelectionStart()
            varbotaopesq4 = 0
            MonthCalendar2.Visible = False
        End If
    End Sub

    Private Sub MonthCalendar2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthCalendar2.Disposed

    End Sub

    Private Sub TextBox13_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.GotFocus
        Dim z As String = TextBox13.Text
        z = z.Replace("R$", "")
        z = z.Replace(".", "")
        Try
            If Mid(z, z.Length - 2, z.Length) = "00" Then
                TextBox13.Text = Mid(z, 0, z.Length - 2)
            Else
                TextBox13.Text = z
            End If
        Catch
        End Try
    End Sub

    Private Sub TextBox13_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.LostFocus
        TextBox13.Text = Format(TextBox13.Text, "currency")
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        Label107.Text = Format(Label107.Text, "currency")

    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        If varfecharLOC = 1 Then
            TabControl1.TabPages.Remove(TabContLoc)
            varfecharLOC = 0
        End If
    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        If varcontimp = 13 Then
            variavelpare = 1
            Button8.Enabled = False
            Form1.Show()
            varcontimp = 0
        End If
    End Sub

    Private Sub totalaserpago_Click(sender As System.Object, e As System.EventArgs) Handles totalaserpago.Click

    End Sub
End Class