<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        grvetement = New GroupBox()
        rdchemise = New RadioButton()
        rdpantalon = New RadioButton()
        rdrobe = New RadioButton()
        grtype = New GroupBox()
        rdrepassage = New RadioButton()
        rdlavage = New RadioButton()
        rdnettoyage = New RadioButton()
        grsupplementaires = New GroupBox()
        chtraitement = New CheckBox()
        chdefroissage = New CheckBox()
        num = New NumericUpDown()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        dgvetement = New DataGridViewTextBoxColumn()
        dgnettoyage = New DataGridViewTextBoxColumn()
        dgsupplementaires = New DataGridViewTextBoxColumn()
        dgnombre = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button3 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        grvetement.SuspendLayout()
        grtype.SuspendLayout()
        grsupplementaires.SuspendLayout()
        CType(num, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grvetement
        ' 
        grvetement.Controls.Add(rdchemise)
        grvetement.Controls.Add(rdpantalon)
        grvetement.Controls.Add(rdrobe)
        grvetement.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grvetement.Location = New Point(12, 21)
        grvetement.Name = "grvetement"
        grvetement.Size = New Size(250, 216)
        grvetement.TabIndex = 0
        grvetement.TabStop = False
        grvetement.Text = "choix vetement"
        ' 
        ' rdchemise
        ' 
        rdchemise.AutoSize = True
        rdchemise.Location = New Point(6, 168)
        rdchemise.Name = "rdchemise"
        rdchemise.Size = New Size(144, 42)
        rdchemise.TabIndex = 1
        rdchemise.TabStop = True
        rdchemise.Text = "chemise"
        rdchemise.UseVisualStyleBackColor = True
        ' 
        ' rdpantalon
        ' 
        rdpantalon.AutoSize = True
        rdpantalon.Location = New Point(6, 111)
        rdpantalon.Name = "rdpantalon"
        rdpantalon.Size = New Size(155, 42)
        rdpantalon.TabIndex = 1
        rdpantalon.TabStop = True
        rdpantalon.Text = "pantalon"
        rdpantalon.UseVisualStyleBackColor = True
        ' 
        ' rdrobe
        ' 
        rdrobe.AutoSize = True
        rdrobe.Location = New Point(6, 63)
        rdrobe.Name = "rdrobe"
        rdrobe.Size = New Size(98, 42)
        rdrobe.TabIndex = 0
        rdrobe.TabStop = True
        rdrobe.Text = "robe"
        rdrobe.UseVisualStyleBackColor = True
        ' 
        ' grtype
        ' 
        grtype.Controls.Add(rdrepassage)
        grtype.Controls.Add(rdlavage)
        grtype.Controls.Add(rdnettoyage)
        grtype.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grtype.Location = New Point(312, 21)
        grtype.Name = "grtype"
        grtype.Size = New Size(271, 216)
        grtype.TabIndex = 2
        grtype.TabStop = False
        grtype.Text = "type de nettoyage"
        ' 
        ' rdrepassage
        ' 
        rdrepassage.AutoSize = True
        rdrepassage.Location = New Point(6, 168)
        rdrepassage.Name = "rdrepassage"
        rdrepassage.Size = New Size(167, 42)
        rdrepassage.TabIndex = 1
        rdrepassage.TabStop = True
        rdrepassage.Text = "repassage"
        rdrepassage.UseVisualStyleBackColor = True
        ' 
        ' rdlavage
        ' 
        rdlavage.AutoSize = True
        rdlavage.Location = New Point(6, 111)
        rdlavage.Name = "rdlavage"
        rdlavage.Size = New Size(123, 42)
        rdlavage.TabIndex = 1
        rdlavage.TabStop = True
        rdlavage.Text = "lavage"
        rdlavage.UseVisualStyleBackColor = True
        ' 
        ' rdnettoyage
        ' 
        rdnettoyage.AutoSize = True
        rdnettoyage.Location = New Point(6, 63)
        rdnettoyage.Name = "rdnettoyage"
        rdnettoyage.Size = New Size(242, 42)
        rdnettoyage.TabIndex = 0
        rdnettoyage.TabStop = True
        rdnettoyage.Text = "nettoyage a sec"
        rdnettoyage.UseVisualStyleBackColor = True
        ' 
        ' grsupplementaires
        ' 
        grsupplementaires.Controls.Add(chtraitement)
        grsupplementaires.Controls.Add(chdefroissage)
        grsupplementaires.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grsupplementaires.Location = New Point(12, 260)
        grsupplementaires.Name = "grsupplementaires"
        grsupplementaires.Size = New Size(571, 160)
        grsupplementaires.TabIndex = 3
        grsupplementaires.TabStop = False
        grsupplementaires.Text = "supplémentaires"
        ' 
        ' chtraitement
        ' 
        chtraitement.AutoSize = True
        chtraitement.Location = New Point(216, 70)
        chtraitement.Name = "chtraitement"
        chtraitement.Size = New Size(332, 42)
        chtraitement.TabIndex = 1
        chtraitement.Text = "traitement anti-taches"
        chtraitement.UseVisualStyleBackColor = True
        ' 
        ' chdefroissage
        ' 
        chdefroissage.AutoSize = True
        chdefroissage.Location = New Point(0, 70)
        chdefroissage.Name = "chdefroissage"
        chdefroissage.Size = New Size(189, 42)
        chdefroissage.TabIndex = 0
        chdefroissage.Text = "defroissage"
        chdefroissage.UseVisualStyleBackColor = True
        ' 
        ' num
        ' 
        num.Location = New Point(667, 84)
        num.Name = "num"
        num.Size = New Size(150, 27)
        num.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(667, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 38)
        Label1.TabIndex = 5
        Label1.Text = "nombre article"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {dgvetement, dgnettoyage, dgsupplementaires, dgnombre})
        DataGridView1.Location = New Point(667, 173)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(522, 188)
        DataGridView1.TabIndex = 6
        ' 
        ' dgvetement
        ' 
        dgvetement.HeaderText = "vetement"
        dgvetement.MinimumWidth = 6
        dgvetement.Name = "dgvetement"
        dgvetement.Width = 125
        ' 
        ' dgnettoyage
        ' 
        dgnettoyage.HeaderText = "type de nettayage"
        dgnettoyage.MinimumWidth = 6
        dgnettoyage.Name = "dgnettoyage"
        dgnettoyage.Width = 125
        ' 
        ' dgsupplementaires
        ' 
        dgsupplementaires.HeaderText = "supplementaires"
        dgsupplementaires.MinimumWidth = 6
        dgsupplementaires.Name = "dgsupplementaires"
        dgsupplementaires.Width = 125
        ' 
        ' dgnombre
        ' 
        dgnombre.HeaderText = "nombre"
        dgnombre.MinimumWidth = 6
        dgnombre.Name = "dgnombre"
        dgnombre.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button1.Location = New Point(885, 84)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 42)
        Button1.TabIndex = 7
        Button1.Text = "ajouter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button3.Location = New Point(1050, 87)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 42)
        Button3.TabIndex = 9
        Button3.Text = "annuler"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1217, 450)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(num)
        Controls.Add(grsupplementaires)
        Controls.Add(grtype)
        Controls.Add(grvetement)
        Name = "Form1"
        Text = "Form1"
        grvetement.ResumeLayout(False)
        grvetement.PerformLayout()
        grtype.ResumeLayout(False)
        grtype.PerformLayout()
        grsupplementaires.ResumeLayout(False)
        grsupplementaires.PerformLayout()
        CType(num, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grvetement As GroupBox
    Friend WithEvents rdpantalon As RadioButton
    Friend WithEvents rdrobe As RadioButton
    Friend WithEvents rdchemise As RadioButton
    Friend WithEvents grtype As GroupBox
    Friend WithEvents rdrepassage As RadioButton
    Friend WithEvents rdlavage As RadioButton
    Friend WithEvents rdnettoyage As RadioButton
    Friend WithEvents grsupplementaires As GroupBox
    Friend WithEvents chtraitement As CheckBox
    Friend WithEvents chdefroissage As CheckBox
    Friend WithEvents num As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvetement As DataGridViewTextBoxColumn
    Friend WithEvents dgnettoyage As DataGridViewTextBoxColumn
    Friend WithEvents dgsupplementaires As DataGridViewTextBoxColumn
    Friend WithEvents dgnombre As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
