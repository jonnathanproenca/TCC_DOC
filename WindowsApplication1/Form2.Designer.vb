<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cadCliEndereco = New System.Windows.Forms.TextBox()
        Me.cadCliNome = New System.Windows.Forms.TextBox()
        Me.botaoCadCli = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(92, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Senha Antiga"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Indigo
        Me.Label32.Location = New System.Drawing.Point(92, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(103, 17)
        Me.Label32.TabIndex = 30
        Me.Label32.Text = "Login Antigo"
        '
        'cadCliEndereco
        '
        Me.cadCliEndereco.Location = New System.Drawing.Point(81, 129)
        Me.cadCliEndereco.Name = "cadCliEndereco"
        Me.cadCliEndereco.Size = New System.Drawing.Size(123, 20)
        Me.cadCliEndereco.TabIndex = 29
        Me.cadCliEndereco.UseSystemPasswordChar = True
        '
        'cadCliNome
        '
        Me.cadCliNome.Location = New System.Drawing.Point(81, 50)
        Me.cadCliNome.Name = "cadCliNome"
        Me.cadCliNome.Size = New System.Drawing.Size(123, 20)
        Me.cadCliNome.TabIndex = 28
        '
        'botaoCadCli
        '
        Me.botaoCadCli.BackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.BackgroundImage = Global.PIEAR.My.Resources.Resources.botaoMouseLeaveFinal2_0
        Me.botaoCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.botaoCadCli.FlatAppearance.BorderSize = 0
        Me.botaoCadCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botaoCadCli.ForeColor = System.Drawing.Color.White
        Me.botaoCadCli.Location = New System.Drawing.Point(106, 174)
        Me.botaoCadCli.Name = "botaoCadCli"
        Me.botaoCadCli.Size = New System.Drawing.Size(75, 33)
        Me.botaoCadCli.TabIndex = 27
        Me.botaoCadCli.Text = "&OK"
        Me.botaoCadCli.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "botaoMouseLeave2.png")
        Me.ImageList1.Images.SetKeyName(1, "botaoMouseMove.png")
        Me.ImageList1.Images.SetKeyName(2, "botaoMouseDown2.png")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PIEAR.My.Resources.Resources.fundo3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cadCliEndereco)
        Me.Controls.Add(Me.cadCliNome)
        Me.Controls.Add(Me.botaoCadCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alteração de Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cadCliEndereco As System.Windows.Forms.TextBox
    Friend WithEvents cadCliNome As System.Windows.Forms.TextBox
    Friend WithEvents botaoCadCli As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
