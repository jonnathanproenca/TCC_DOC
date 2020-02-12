<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.botaoCadCli = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cadCliNome = New System.Windows.Forms.TextBox()
        Me.cadCliEndereco = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'botaoCadCli
        '
        Me.botaoCadCli.BackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.BackgroundImage = CType(resources.GetObject("botaoCadCli.BackgroundImage"), System.Drawing.Image)
        Me.botaoCadCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.botaoCadCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.botaoCadCli.FlatAppearance.BorderSize = 0
        Me.botaoCadCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.botaoCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botaoCadCli.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botaoCadCli.ForeColor = System.Drawing.Color.White
        Me.botaoCadCli.ImageList = Me.ImageList1
        Me.botaoCadCli.Location = New System.Drawing.Point(344, 242)
        Me.botaoCadCli.Name = "botaoCadCli"
        Me.botaoCadCli.Size = New System.Drawing.Size(89, 37)
        Me.botaoCadCli.TabIndex = 0
        Me.botaoCadCli.Text = "&OK"
        Me.botaoCadCli.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "botaoMouseLeaveFinal.png")
        Me.ImageList1.Images.SetKeyName(1, "botaoMouseMoveFinal.png")
        Me.ImageList1.Images.SetKeyName(2, "botaoMouseDownFinal.png")
        '
        'cadCliNome
        '
        Me.cadCliNome.BackColor = System.Drawing.Color.Thistle
        Me.cadCliNome.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadCliNome.ForeColor = System.Drawing.Color.Indigo
        Me.cadCliNome.Location = New System.Drawing.Point(123, 150)
        Me.cadCliNome.Name = "cadCliNome"
        Me.cadCliNome.Size = New System.Drawing.Size(186, 29)
        Me.cadCliNome.TabIndex = 2
        '
        'cadCliEndereco
        '
        Me.cadCliEndereco.BackColor = System.Drawing.Color.Thistle
        Me.cadCliEndereco.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadCliEndereco.ForeColor = System.Drawing.Color.Indigo
        Me.cadCliEndereco.Location = New System.Drawing.Point(123, 213)
        Me.cadCliEndereco.Name = "cadCliEndereco"
        Me.cadCliEndereco.Size = New System.Drawing.Size(186, 29)
        Me.cadCliEndereco.TabIndex = 4
        Me.cadCliEndereco.UseSystemPasswordChar = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(448, 308)
        Me.Controls.Add(Me.cadCliEndereco)
        Me.Controls.Add(Me.cadCliNome)
        Me.Controls.Add(Me.botaoCadCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botaoCadCli As System.Windows.Forms.Button
    Friend WithEvents cadCliNome As System.Windows.Forms.TextBox
    Friend WithEvents cadCliEndereco As System.Windows.Forms.TextBox
    Protected Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
