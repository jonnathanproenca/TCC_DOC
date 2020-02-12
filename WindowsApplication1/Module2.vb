Imports System.Security.Cryptography
Imports System.IO.File

#Region "Estruturas"
'arquivo dos clientes (nome & SPLITTER1 & codigo)

#End Region



Module Module2


    Friend varcont12 As Integer = 0

    Friend dados As String = ""
    Friend dadoscodigo As String = ""
    Friend dadoscor As String = ""
    Friend dadospreco As String = ""
    Friend dadostamanho As String = ""
    Friend dadosocasiao As String = ""
    Friend dadosquantidade As String = ""
    Friend dadosmodelo As String = ""


    Friend item As String
    Friend valor As Double
    Friend varloginbranco As Integer = 0
    Friend varstring As String

    Friend abcd As String
    Friend a1d As Integer = 0
    Friend a1e As Integer = 0

    Friend vardoform2 As Integer = 0
    Friend varapoio As Integer = 0
    Friend variavel1 As Integer
    Friend vartimer6 As Integer

    Friend varfecharguia As Integer
    Friend varfecharguia1 As Integer
    Friend varfecharguia3 As Integer

    Friend varfecharguia4 As Integer
    Friend varfecharguia5 As Integer
    Friend varfecharguia6 As Integer


    Friend deletarvest As Integer

    Friend varformpesq As String
    Friend varform1close As Integer
    Friend varform1close1 As Integer
    Friend varfecharaluguel As Integer

    Friend varbotaopesq3 As Integer
    Friend varbotaopesq4 As Integer

    Friend varbotaopesq1 As Integer
    Friend varbotaopesq2 As Integer

    Friend varClosing As Integer
    Friend varLabeldocodigo As Integer


    Friend varTimerSplash As Integer
    Friend botaoalterarvestido As Integer = 0
    Friend varFecharVest As Integer
    Friend varFechaTAB
    Friend varAlterarErr As Integer
    Friend varExcluirErr As Integer
    Friend varAlterarErr1 As Integer
    Friend varAlterarErr2 As Integer
    Friend varExcluirErr1 As Integer
    Friend varExcluirErr2 As Integer

    Friend timer3varcadcli As Integer
    Friend botaocadclivar As Integer
    Friend botaocadfuncvar As Integer
    Friend botaocadvestvar As Integer
    Friend timer3varcadfunc As Integer
    Friend timer3varcadvest As Integer
    Friend vestidocontador As Integer


    Friend variavelprafechar As Integer
    Friend variavelprafechar2 As Integer
    Friend variavelprafechar3 As Integer
    Friend variavelpare As Integer

    Friend varerroreg As Integer
    Friend varcontimp As Integer = 0

    Friend controleform As String

    Friend contadorTimer As Integer
    Friend contadorTimerCli As Integer
    Friend vestido1 As Integer = 0
    Friend listaVestido1 As String
    Friend listavestido2 As String
    Friend controleanterior As Integer
    Friend vestidocat As Integer
    Friend varfechaaltloc As Integer = 0
    Friend varfecharLOC As Integer = 0
    Friend login As Integer
    Friend SPLITTER1 As String = "蠫"
    Friend splitter2 As String = "#"
    Public x1a As Integer = 0
    Public x1b As Integer = 0
    Dim x1c As UInteger
    Public x1d As Double = 0
    Public salario As String
    Friend controltab As Integer = 0
    Friend controltabFunc As Integer = 0
    Friend listadescVest As String
    Friend controlCliCad = 0
    Friend cli As Integer = 0
    Friend func As Integer = 0
    Friend vest As Integer = 0

    Friend clit
    Friend controluser As String
    Friend controltabpage As Integer
    Friend controltabpagefunc As Integer

    Friend contreg As Integer = 0
    Friend foto As Integer = 0
    Friend vestido As Integer = 0
    Friend lista1 As Integer = 0
    Friend listad As String
    Friend listafunc As String
    Friend listavest As String



    Friend listacontrole As Integer = 0
    Friend listap As String
    Friend listaf As String
    Friend cont As Integer
    Friend varnomealuguel As String
    Friend vardatadev As String
    Friend vardatapro As String
    Friend varsinal As String
    Friend varanota As String
    Friend varprecotot As String
    Friend varprecoalu As String
    Friend vardatahora As String


    Friend contComp As String
    Friend contCompFunc As String
    Friend contCompVestido As String


    Friend cli123 As Integer
    Friend varCont1 As Integer = 0

    Friend varContCatalPesqCor As Integer
    Friend varContCatalPesqModelo As Integer
    Friend varContCatalPesqOcasiao As Integer
    Friend varContCatalPesqTamanho As Integer
    Friend varContCatalPesqCodigo As Integer
    Friend catalogopesqcor1 As String
    Friend catalogoPesqModelo1 As String
    Friend catalogoPesqtamanho1 As String
    Friend catalogoPesqocasiao1 As String
    Friend catalogoPesquisarvar As String




    Dim Senha As String = "0000"
    Private MD5 As New MD5CryptoServiceProvider
    Private CODIFICACAO As New System.Text.UTF32Encoding
    Friend Sub CRIPTOGRAFAR(ByVal Caminho_Do_Arquivo As String, ByVal Texto As String)
        Dim RIJ As New RijndaelManaged
        RIJ.Key = MD5.ComputeHash(CODIFICACAO.GetBytes(Senha))
        RIJ.Mode = CipherMode.ECB
        Dim Buffer = CODIFICACAO.GetBytes(Texto)
        WriteAllText(Caminho_Do_Arquivo, Convert.ToBase64String(RIJ.CreateEncryptor.TransformFinalBlock(Buffer, 0, Buffer.Length)))
    End Sub
    Friend Function DESCRIPTOGRAFAR(ByVal Caminho_Do_Arquivo As String) As String
        Try
            Dim RIJ As New RijndaelManaged
            RIJ.Key = MD5.ComputeHash(CODIFICACAO.GetBytes(Senha))
            RIJ.Mode = CipherMode.ECB
            Dim Buffer = Convert.FromBase64String(ReadAllText(Caminho_Do_Arquivo))
            Return CODIFICACAO.GetString(RIJ.CreateDecryptor.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function VALIDAR_CPF(ByVal CPF As String) As Boolean
        If CPF.Length <> 11 Then Return False
        Dim Digito As String = Mid(CPF, 10, 2)
        Dim DigitoV As String = 0
        Dim Numero As String = Mid(CPF, 1, 9)
        Dim S1 As Integer = 0
        For x = 1 To 9
            S1 += Mid(Numero, x, 1) * (11 - x)
        Next x

        If S1 Mod 11 > 1 Then
            DigitoV = (11 - (S1 Mod 11)) * 10
        End If
        Dim S2 As Integer = 0
        For x = 1 To 9
            S2 += Mid(Numero, x, 1) * (12 - x)
        Next x
        S2 += DigitoV / 5
        If S2 Mod 11 > 1 Then
            DigitoV += (11 - (S2 Mod 11))
        End If
        If DigitoV < 10 Then
            DigitoV = "0" & DigitoV
        End If
        If DigitoV = Digito Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
