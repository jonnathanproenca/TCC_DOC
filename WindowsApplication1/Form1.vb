Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        Label1.Text = ""
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Me.Text = ""

        Dim font2 As Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)

        If variavelpare = 1 Then
            variavelpare = 0
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = False
            PictureBox2.Visible = True
            Me.Text = "BLOQUEIO DE SISTEMA"
            Label1.Font = font2

            Label1.Text = "MUITOS ITENS EM UM ALUGUEL," & vbCrLf & "PARA SUA SEGURANÇA, SOMENTE" & vbCrLf & "13 ITENS PODEM SER SELECIONADOS" & vbCrLf & "POR ALUGUEL."
            Label1.Font.Dispose()

        End If

        If varerroreg = 1 Then
            varerroreg = 0
            Me.Text = "ERRO"
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = False
            PictureBox2.Visible = True
            Label1.Text = "NÃO EXISTEM REGISTROS - ERRO REG00245"
            Exit Sub
        End If


        If varfechaaltloc = 1 Then
            varfechaaltloc = 2
            Me.Text = "Confirmação"
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
            PictureBox1.Visible = True
            Label1.Text = "Existem campos a serem" & vbCrLf & "alterados, deseja realmente" & vbCrLf & "sair ?"
            Exit Sub
        End If

        If varloginbranco = 1 Then
            varloginbranco = 0
            Me.Text = "ERRO"
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = False
            PictureBox2.Visible = True
            Label1.Text = "Login E/OU Senha em Branco !"
            varapoio = 3
            Exit Sub

        End If

        If vardoform2 = 1 Then
            vardoform2 = 0
            Me.Text = "ERRO"
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = False
            PictureBox2.Visible = True
            Label1.Text = "Login E/OU Senha Incorretos !"
            varapoio = 1
            Exit Sub

        ElseIf vardoform2 = 2 Then
            vardoform2 = 0
            Me.Text = "OK"
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button4.Visible = False
            PictureBox2.Visible = True
            Label1.Text = "Login Excluido com Sucesso !"
            varapoio = 2
            Exit Sub

        End If

        If varfecharguia4 = 1 Then
            varfecharguia4 = 0
            Me.Text = "Confirmação"
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
            Label1.Text = "Existem campos a serem" & vbCrLf & "alterados, deseja realmente" & vbCrLf & "sair ?"
            PictureBox1.Visible = True
            Exit Sub

        End If



        If varfecharguia = 1 Then
            varfecharguia = 0
            Me.Text = "Confirmação"
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False
            Button4.Visible = False
            Label1.Text = "Existem campos a serem" & vbCrLf & "alterados, deseja realmente" & vbCrLf & "sair ?"
            PictureBox1.Visible = True
            Exit Sub

        End If

        If deletarvest = 1 Or deletarvest = 2 Then
            Me.Text = "Erro"
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button3.Location = New Point(210, 119)
            Button4.Location = New Point(365, 119)
            Button4.Visible = True
            Label1.Text = "Clique em OK caso queira" & vbCrLf & "voltar e selecionar um registro" & vbCrLf & "para apagar ou CANCELAR" & vbCrLf & "caso queira cancelar a exclusão!"
            PictureBox2.Visible = True
            Exit Sub
        End If

        If varform1close = 1 Then
            varform1close = 0
            varform1close1 = 1
            Me.Text = "Confirmação"
            PictureBox1.Visible = True
            Label1.Text = "Deseja Realmente Fechar?"
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False
            Exit Sub

        End If


        If controleform = "Deseja Realmente Fechar?" Then

            Me.Text = "Confirmação"
            PictureBox1.Visible = True
            Label1.Text = controleform
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False

        End If


        If controleform = "Login Incorreto" Then
            Me.Text = "ERRO"
            PictureBox2.Visible = True
            Label1.Text = controleform
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True

        End If


        If varFecharVest = 1 Then
            Me.Text = "Confirmação"
            PictureBox1.Visible = True
            Label1.Text = "Existem campos que estão sendo" & vbCrLf & "alterados, deseja realmente" & vbCrLf & "fechar ?"

            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = False

        End If


        If varAlterarErr = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder alterar!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varAlterarErr = 0

        End If

        If varExcluirErr = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder excluir!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varExcluirErr = 0
        End If

        If varExcluirErr1 = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder excluir!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varExcluirErr1 = 0
        End If


        If varExcluirErr2 = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder excluir!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varExcluirErr2 = 0
        End If

        If varAlterarErr1 = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder alterar!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varAlterarErr1 = 0

        End If

        If varAlterarErr2 = 1 Then
            Me.Text = "ERRO"
            Label1.Text = "Você precisa selecionar um registro" & vbCrLf & "para poder alterar!"
            PictureBox2.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            varAlterarErr2 = 0

        End If

    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = ImageList1.Images.Item(2)
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Try
            Button1.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Button2.BackgroundImage = ImageList1.Images.Item(2)
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Try
            Button2.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If varfechaaltloc = 2 Then
            varfechaaltloc = 0
            FormPrin.TextBox10.Enabled = False
            FormPrin.TextBox7.Enabled = False
            FormPrin.TextBox6.Enabled = False
            FormPrin.TextBox9.Enabled = False
            FormPrin.TextBox8.Enabled = False
            FormPrin.ListBox2.Enabled = False
            FormPrin.Button22.Enabled = True
            FormPrin.TextBox13.Enabled = False

            FormPrin.Button20.Enabled = False
            FormPrin.Button13.Enabled = False
            FormPrin.Button15.Enabled = False
            FormPrin.Button14.Enabled = False

            FormPrin.Button21.Text = "Alterar"
            FormPrin.ListView1.Items.Clear()
            FormPrin.Label110.Text = ""
            varfecharLOC = 1
            varcont12 = 0
            Me.Close()
            Exit Sub

        End If

        If varfecharguia5 = 1 Then
            varfecharguia5 = 0
            FormPrin.contFuncSalario.Text = ""
            FormPrin.contFuncBairro.Text = ""
            FormPrin.contFuncCEP.Text = ""
            FormPrin.contFuncCidade.Text = ""
            FormPrin.contFuncCompl.Text = ""
            FormPrin.contFuncCPF.Text = ""
            FormPrin.contFuncData.Text = ""
            FormPrin.contFuncEndereco.Text = ""
            FormPrin.contFuncEstado.Text = ""
            FormPrin.contFuncNome.Text = ""
            FormPrin.contFuncNum.Text = ""
            FormPrin.contFuncRG.Text = ""
            FormPrin.contFuncCartTrab.Text = ""
            FormPrin.contFuncDataAdm.Text = ""
            controltabpagefunc = 0
            FormPrin.MaskedTextBox3.Text = ""
            FormPrin.MaskedTextBox4.Text = ""

            FormPrin.contFuncSalario.Enabled = False
            FormPrin.contFuncBairro.Enabled = False
            FormPrin.contFuncCEP.Enabled = False
            FormPrin.contFuncCidade.Enabled = False
            FormPrin.contFuncCompl.Enabled = False
            FormPrin.contFuncCPF.Enabled = False
            FormPrin.contFuncData.Enabled = False
            FormPrin.contFuncEndereco.Enabled = False
            FormPrin.contFuncEstado.Enabled = False
            FormPrin.contFuncNome.Enabled = False
            FormPrin.contFuncNum.Enabled = False
            FormPrin.contFuncRG.Enabled = False
            FormPrin.contFuncCartTrab.Enabled = False
            FormPrin.contFuncDataAdm.Enabled = False
            FormPrin.MaskedTextBox3.Enabled = False
            FormPrin.MaskedTextBox4.Enabled = False
            FormPrin.botaoContFuncExc.Enabled = True

            FormPrin.botaoContCliAlt.Text = "Alterar"
            varfecharguia6 = 1

            controltabpage = 0

            FormPrin.listaContFunc.Items.Clear()

            controleform = ""
            Me.Close()

            Exit Sub

        End If

        If varfecharguia1 = 1 Then
            varfecharguia1 = 0

            FormPrin.contCliAnota.Text = ""
            FormPrin.contCliBairro.Text = ""
            FormPrin.contCliCEP.Text = ""
            FormPrin.contCliCidade.Text = ""
            FormPrin.contCliCompl.Text = ""
            FormPrin.contCliCPF.Text = ""
            FormPrin.contCliData.Text = ""
            FormPrin.contCliEndereco.Text = ""
            FormPrin.contCliEstado.Text = ""
            FormPrin.contCliNome.Text = ""
            FormPrin.contCliNum.Text = ""
            FormPrin.contCliRG.Text = ""
            FormPrin.MaskedTextBox1.Text = ""
            FormPrin.MaskedTextBox2.Text = ""
            FormPrin.botaoContCliAlt.Text = "Alterar"

            FormPrin.contCliAnota.Enabled = False
            FormPrin.contCliBairro.Enabled = False
            FormPrin.contCliCEP.Enabled = False
            FormPrin.contCliCidade.Enabled = False
            FormPrin.contCliCompl.Enabled = False
            FormPrin.contCliCPF.Enabled = False
            FormPrin.contCliData.Enabled = False
            FormPrin.contCliEndereco.Enabled = False
            FormPrin.contCliEstado.Enabled = False
            FormPrin.contCliNome.Enabled = False
            FormPrin.contCliNum.Enabled = False
            FormPrin.contCliRG.Enabled = False
            FormPrin.MaskedTextBox1.Enabled = False
            FormPrin.MaskedTextBox2.Enabled = False
            FormPrin.botaoContCliExc.Enabled = True

            varfecharguia3 = 1

            controltabpage = 0

            FormPrin.ListaContCli.Items.Clear()

            controleform = ""
            Me.Close()

            Exit Sub


        End If


        If Label1.Text = "Deseja Realmente Fechar?" Then

            

            If timer3varcadcli = 1 And botaocadclivar = 1 Then
                FormPrin.cadCliNome.Clear()
                FormPrin.cadCliEndereco.Clear()
                FormPrin.cadCliNum.Clear()
                FormPrin.cadCliCompl.Clear()
                FormPrin.cadCliBairro.Clear()
                FormPrin.cadCliCidade.Clear()
                FormPrin.cadCliEstado.Clear()
                FormPrin.cadCliAnota.Clear()
                FormPrin.cadCliRG.Clear()
                FormPrin.cadCliCPF.Clear()
                FormPrin.cadCliCEP.Clear()
                FormPrin.cadCliData.Clear()
                FormPrin.cadCliTelefone.Clear()
                FormPrin.cadCliCelular.Clear()
                botaocadclivar = 0
                variavelprafechar = 1
            End If

            If varform1close1 = 1 Then
                FormPrin.TextBox1.Text = ""
                FormPrin.TextBox2.Text = ""
                FormPrin.TextBox3.Text = ""
                FormPrin.TextBox4.Text = ""
                FormPrin.TextBox5.Text = ""
                FormPrin.Label104.Text = ""
                FormPrin.ListBox1.Items.Clear()
                varfecharaluguel = 1
                varform1close1 = 0
                FormPrin.Button8.Enabled = True


            End If

            If timer3varcadfunc = 1 And botaocadfuncvar = 1 Then




                FormPrin.cadFuncNome.Clear()
                FormPrin.cadFuncEndereco.Clear()
                FormPrin.cadFuncNum.Clear()
                FormPrin.cadFuncCompl.Clear()
                FormPrin.cadFuncBairro.Clear()
                FormPrin.cadFuncCidade.Clear()
                FormPrin.cadFuncEstado.Clear()
                FormPrin.cadFuncSalario.Clear()
                FormPrin.cadFuncRG.Clear()
                FormPrin.cadFuncCPF.Clear()
                FormPrin.cadFuncCEP.Clear()
                FormPrin.cadFuncData.Clear()
                FormPrin.cadFuncTelefone.Clear()
                FormPrin.cadFuncCelular.Clear()
                FormPrin.cadFuncCartTrab.Clear()
                FormPrin.cadFuncDataAdm.Clear()
                botaocadfuncvar = 0
                variavelprafechar2 = 1

            End If

            If timer3varcadvest = 1 And botaocadvestvar = 1 Then


                FormPrin.cadVestCor.Clear()
                FormPrin.cadVestTamanho.Clear()
                FormPrin.cadVestOcasiao.Clear()
                FormPrin.cadVestPreco.Clear()
                FormPrin.cadVestModelo.Clear()
                FormPrin.cadVestLocalImag.Clear()
                FormPrin.cadVestImg.Image = Nothing

                botaocadvestvar = 0
                variavelprafechar3 = 1

            End If

        End If



        If varFecharVest = 1 Then
            FormPrin.TextBox12.Enabled = False

            FormPrin.contVestCor.Enabled = False
            FormPrin.contVestModelo.Enabled = False
            FormPrin.contVestOcasiao.Enabled = False
            FormPrin.contVestPreco.Enabled = False
            FormPrin.contVestTamanho.Enabled = False
            FormPrin.botaoContVestProcurar.Enabled = False
            FormPrin.botaoContVestAlt.Text = "Alterar"
            botaoalterarvestido = 0
            FormPrin.botaoContVestExc.Enabled = True

            FormPrin.TextBox12.Text = ""
            FormPrin.contVestCor.Text = ""
            FormPrin.contVestModelo.Text = ""
            FormPrin.contVestOcasiao.Text = ""
            FormPrin.contVestPreco.Text = ""
            FormPrin.contVestTamanho.Text = ""
            FormPrin.labeldocodigodovestido.Text = ""



            varFecharVest = 0
            varFechaTAB = 1
            FormPrin.contVestImg.Image.Dispose()
            FormPrin.contVestImg.Image = Nothing


        End If



        controleform = ""
        Me.Close()





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        variavelprafechar = 0
        variavelprafechar2 = 0
        variavelprafechar3 = 0
        botaocadclivar = 0
        botaocadfuncvar = 0
        botaocadvestvar = 0
        varform1close1 = 0
        varform1close = 0


        
        controleform = ""
        Me.Close()

    End Sub

    Private Sub Button3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        Button3.BackgroundImage = ImageList1.Images.Item(2)
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.BackgroundImage = ImageList1.Images.Item(1)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Try
            Button3.BackgroundImage = ImageList1.Images.Item(0)
        Catch
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If varapoio = 1 Then
            Form2.Label32.Text = "Login Antigo"
            Form2.Label1.Text = "Senha Antiga"
            varapoio = 0
        ElseIf varapoio = 2 Then
            Form2.Close()
            varapoio = 0
        ElseIf varapoio = 3 Then
            Me.Close()
            varapoio = 0
        End If

        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If deletarvest = 1 Then
            FormPrin.ListBox1.Enabled = False
            FormPrin.Button10.Text = "Remover"
            deletarvest = 0
            FormPrin.Button11.Visible = False
        ElseIf deletarvest = 2 Then
            FormPrin.ListBox2.Enabled = False
            FormPrin.Button13.Text = "Remover"
            deletarvest = 0
            FormPrin.Button12.Visible = False
        End If
        
        Me.Close()


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class