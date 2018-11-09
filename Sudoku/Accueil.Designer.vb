<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.NomJ = New System.Windows.Forms.ComboBox()
        Me.Jouer = New System.Windows.Forms.Button()
        Me.Arret = New System.Windows.Forms.Button()
        Me.Scores = New System.Windows.Forms.Button()
        Me.TitreSudoku = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LesReglesDuJeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyrigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Niveau = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerOnOFF = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomJ
        '
        Me.NomJ.ForeColor = System.Drawing.Color.Black
        Me.NomJ.FormattingEnabled = True
        Me.NomJ.Location = New System.Drawing.Point(327, 191)
        Me.NomJ.Name = "NomJ"
        Me.NomJ.Size = New System.Drawing.Size(204, 24)
        Me.NomJ.TabIndex = 0
        '
        'Jouer
        '
        Me.Jouer.Font = New System.Drawing.Font("Snap ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jouer.ForeColor = System.Drawing.Color.Brown
        Me.Jouer.Location = New System.Drawing.Point(160, 330)
        Me.Jouer.Name = "Jouer"
        Me.Jouer.Size = New System.Drawing.Size(509, 93)
        Me.Jouer.TabIndex = 1
        Me.Jouer.Text = "Play"
        Me.Jouer.UseVisualStyleBackColor = True
        '
        'Arret
        '
        Me.Arret.BackColor = System.Drawing.Color.Transparent
        Me.Arret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Arret.ForeColor = System.Drawing.Color.Firebrick
        Me.Arret.Image = CType(resources.GetObject("Arret.Image"), System.Drawing.Image)
        Me.Arret.Location = New System.Drawing.Point(675, 330)
        Me.Arret.Name = "Arret"
        Me.Arret.Size = New System.Drawing.Size(107, 93)
        Me.Arret.TabIndex = 2
        Me.Arret.UseVisualStyleBackColor = False
        '
        'Scores
        '
        Me.Scores.Image = CType(resources.GetObject("Scores.Image"), System.Drawing.Image)
        Me.Scores.Location = New System.Drawing.Point(12, 330)
        Me.Scores.Name = "Scores"
        Me.Scores.Size = New System.Drawing.Size(142, 93)
        Me.Scores.TabIndex = 3
        Me.Scores.UseVisualStyleBackColor = True
        '
        'TitreSudoku
        '
        Me.TitreSudoku.AutoSize = True
        Me.TitreSudoku.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreSudoku.Location = New System.Drawing.Point(244, 38)
        Me.TitreSudoku.Name = "TitreSudoku"
        Me.TitreSudoku.Size = New System.Drawing.Size(363, 98)
        Me.TitreSudoku.TabIndex = 4
        Me.TitreSudoku.Text = "Sudoku"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LesReglesDuJeuToolStripMenuItem, Me.CopyrigToolStripMenuItem})
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.AProposToolStripMenuItem.Text = "A Propos"
        '
        'LesReglesDuJeuToolStripMenuItem
        '
        Me.LesReglesDuJeuToolStripMenuItem.Name = "LesReglesDuJeuToolStripMenuItem"
        Me.LesReglesDuJeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LesReglesDuJeuToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.LesReglesDuJeuToolStripMenuItem.Text = "&Regles du jeu "
        '
        'CopyrigToolStripMenuItem
        '
        Me.CopyrigToolStripMenuItem.Name = "CopyrigToolStripMenuItem"
        Me.CopyrigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyrigToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.CopyrigToolStripMenuItem.Text = "&Copyright "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom du Joueur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Niveau"
        '
        'Niveau
        '
        Me.Niveau.AutoCompleteCustomSource.AddRange(New String() {"Facile", "Intermédiaire", "Difficile"})
        Me.Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Niveau.FormattingEnabled = True
        Me.Niveau.Location = New System.Drawing.Point(364, 268)
        Me.Niveau.Name = "Niveau"
        Me.Niveau.Size = New System.Drawing.Size(121, 24)
        Me.Niveau.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Creation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimerOnOFF
        '
        Me.TimerOnOFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimerOnOFF.FormattingEnabled = True
        Me.TimerOnOFF.Items.AddRange(New Object() {"Timer ON", "Timer OFF"})
        Me.TimerOnOFF.Location = New System.Drawing.Point(514, 268)
        Me.TimerOnOFF.Name = "TimerOnOFF"
        Me.TimerOnOFF.Size = New System.Drawing.Size(121, 24)
        Me.TimerOnOFF.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 37)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Timer"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TimerOnOFF)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Niveau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitreSudoku)
        Me.Controls.Add(Me.Scores)
        Me.Controls.Add(Me.Arret)
        Me.Controls.Add(Me.Jouer)
        Me.Controls.Add(Me.NomJ)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Firebrick
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NomJ As ComboBox
    Friend WithEvents Jouer As Button
    Friend WithEvents Arret As Button
    Friend WithEvents Scores As Button
    Friend WithEvents TitreSudoku As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesReglesDuJeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyrigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Niveau3 As RadioButton
    Friend WithEvents Niveau1 As RadioButton
    Friend WithEvents Niveau2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Niveau As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerOnOFF As ComboBox
    Friend WithEvents Label3 As Label
End Class
