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
        Dim chkfromage As CheckBox
        GroupBox1 = New GroupBox()
        rdpates = New RadioButton()
        rdburger = New RadioButton()
        rdpizza = New RadioButton()
        grsupplements = New GroupBox()
        chkdessert = New CheckBox()
        chkfrites = New CheckBox()
        Label1 = New Label()
        txtboisson = New ListBox()
        lblafficher = New Label()
        Button2 = New Button()
        Button3 = New Button()
        chkfromage = New CheckBox()
        GroupBox1.SuspendLayout()
        grsupplements.SuspendLayout()
        SuspendLayout()
        ' 
        ' chkfromage
        ' 
        chkfromage.AutoSize = True
        chkfromage.Location = New Point(0, 55)
        chkfromage.Name = "chkfromage"
        chkfromage.Size = New Size(160, 45)
        chkfromage.TabIndex = 0
        chkfromage.Text = "fromage"
        chkfromage.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdpates)
        GroupBox1.Controls.Add(rdburger)
        GroupBox1.Controls.Add(rdpizza)
        GroupBox1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(227, 218)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "choix du plat"
        ' 
        ' rdpates
        ' 
        rdpates.AutoSize = True
        rdpates.Location = New Point(0, 158)
        rdpates.Name = "rdpates"
        rdpates.Size = New Size(115, 45)
        rdpates.TabIndex = 2
        rdpates.TabStop = True
        rdpates.Text = "pates"
        rdpates.UseVisualStyleBackColor = True
        ' 
        ' rdburger
        ' 
        rdburger.AutoSize = True
        rdburger.Location = New Point(0, 97)
        rdburger.Name = "rdburger"
        rdburger.Size = New Size(135, 45)
        rdburger.TabIndex = 1
        rdburger.TabStop = True
        rdburger.Text = "burger"
        rdburger.UseVisualStyleBackColor = True
        ' 
        ' rdpizza
        ' 
        rdpizza.AutoSize = True
        rdpizza.Location = New Point(0, 46)
        rdpizza.Name = "rdpizza"
        rdpizza.Size = New Size(111, 45)
        rdpizza.TabIndex = 0
        rdpizza.TabStop = True
        rdpizza.Text = "pizza"
        rdpizza.UseVisualStyleBackColor = True
        ' 
        ' grsupplements
        ' 
        grsupplements.Controls.Add(chkdessert)
        grsupplements.Controls.Add(chkfrites)
        grsupplements.Controls.Add(chkfromage)
        grsupplements.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grsupplements.Location = New Point(12, 236)
        grsupplements.Name = "grsupplements"
        grsupplements.Size = New Size(227, 218)
        grsupplements.TabIndex = 3
        grsupplements.TabStop = False
        grsupplements.Text = "supplement"
        ' 
        ' chkdessert
        ' 
        chkdessert.AutoSize = True
        chkdessert.Location = New Point(0, 157)
        chkdessert.Name = "chkdessert"
        chkdessert.Size = New Size(142, 45)
        chkdessert.TabIndex = 2
        chkdessert.Text = "dessert"
        chkdessert.UseVisualStyleBackColor = True
        ' 
        ' chkfrites
        ' 
        chkfrites.AutoSize = True
        chkfrites.Location = New Point(0, 106)
        chkfrites.Name = "chkfrites"
        chkfrites.Size = New Size(114, 45)
        chkfrites.TabIndex = 1
        chkfrites.Text = "frites"
        chkfrites.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(302, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 41)
        Label1.TabIndex = 6
        Label1.Text = "boisson"
        ' 
        ' txtboisson
        ' 
        txtboisson.FormattingEnabled = True
        txtboisson.Location = New Point(434, 31)
        txtboisson.Name = "txtboisson"
        txtboisson.Size = New Size(296, 84)
        txtboisson.TabIndex = 7
        ' 
        ' lblafficher
        ' 
        lblafficher.AutoSize = True
        lblafficher.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblafficher.ForeColor = Color.Red
        lblafficher.Location = New Point(302, 159)
        lblafficher.Name = "lblafficher"
        lblafficher.Size = New Size(118, 41)
        lblafficher.TabIndex = 8
        lblafficher.Text = "facture"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(404, 356)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 29)
        Button2.TabIndex = 9
        Button2.Text = "commander"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(569, 358)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 10
        Button3.Text = "annuler"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(lblafficher)
        Controls.Add(txtboisson)
        Controls.Add(Label1)
        Controls.Add(grsupplements)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grsupplements.ResumeLayout(False)
        grsupplements.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdpates As RadioButton
    Friend WithEvents rdburger As RadioButton
    Friend WithEvents rdpizza As RadioButton
    Friend WithEvents grsupplements As GroupBox
    Friend WithEvents chkdessert As CheckBox
    Friend WithEvents chkfrites As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboisson As ListBox
    Friend WithEvents lblafficher As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
