<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Minuteur = New System.Windows.Forms.Label()
        Me.NomJJ = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Abandonner = New System.Windows.Forms.Button()
        Me.LabelErreur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.start = New System.Windows.Forms.Button()
        Me.Reload = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LesReglesDuJeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyrigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterLapplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cache = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Minuteur
        '
        Me.Minuteur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minuteur.AutoSize = True
        Me.Minuteur.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minuteur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Minuteur.Location = New System.Drawing.Point(237, 110)
        Me.Minuteur.Name = "Minuteur"
        Me.Minuteur.Size = New System.Drawing.Size(34, 42)
        Me.Minuteur.TabIndex = 1
        Me.Minuteur.Text = "?"
        '
        'NomJJ
        '
        Me.NomJJ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomJJ.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomJJ.ForeColor = System.Drawing.Color.Firebrick
        Me.NomJJ.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NomJJ.Location = New System.Drawing.Point(90, 23)
        Me.NomJJ.Name = "NomJJ"
        Me.NomJJ.Size = New System.Drawing.Size(652, 74)
        Me.NomJJ.TabIndex = 0
        Me.NomJJ.Text = "Nom du joueur"
        Me.NomJJ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Clear
        '
        Me.Clear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clear.AutoSize = True
        Me.Clear.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.Tomato
        Me.Clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Clear.Location = New System.Drawing.Point(631, 434)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(203, 84)
        Me.Clear.TabIndex = 3
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Abandonner
        '
        Me.Abandonner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Abandonner.AutoSize = True
        Me.Abandonner.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abandonner.ForeColor = System.Drawing.Color.Tomato
        Me.Abandonner.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Abandonner.Location = New System.Drawing.Point(12, 434)
        Me.Abandonner.Name = "Abandonner"
        Me.Abandonner.Size = New System.Drawing.Size(169, 84)
        Me.Abandonner.TabIndex = 4
        Me.Abandonner.Text = "Quit"
        Me.Abandonner.UseVisualStyleBackColor = True
        '
        'LabelErreur
        '
        Me.LabelErreur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelErreur.AutoSize = True
        Me.LabelErreur.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelErreur.ForeColor = System.Drawing.Color.Brown
        Me.LabelErreur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelErreur.Location = New System.Drawing.Point(437, 110)
        Me.LabelErreur.Name = "LabelErreur"
        Me.LabelErreur.Size = New System.Drawing.Size(153, 42)
        Me.LabelErreur.TabIndex = 8
        Me.LabelErreur.Text = "Erreur "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'start
        '
        Me.start.AutoSize = True
        Me.start.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.ForeColor = System.Drawing.Color.Firebrick
        Me.start.Location = New System.Drawing.Point(187, 434)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(438, 84)
        Me.start.TabIndex = 10
        Me.start.Text = "Play"
        Me.start.UseVisualStyleBackColor = True
        '
        'Reload
        '
        Me.Reload.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reload.Location = New System.Drawing.Point(631, 353)
        Me.Reload.Name = "Reload"
        Me.Reload.Size = New System.Drawing.Size(203, 75)
        Me.Reload.TabIndex = 11
        Me.Reload.Text = "Reload"
        Me.Reload.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem, Me.QuitterLapplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LesReglesDuJeuToolStripMenuItem, Me.CopyrigToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.AProposToolStripMenuItem.Text = "A Propos"
        '
        'LesReglesDuJeuToolStripMenuItem
        '
        Me.LesReglesDuJeuToolStripMenuItem.Name = "LesReglesDuJeuToolStripMenuItem"
        Me.LesReglesDuJeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LesReglesDuJeuToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.LesReglesDuJeuToolStripMenuItem.Text = "&Regles du jeu "
        '
        'CopyrigToolStripMenuItem
        '
        Me.CopyrigToolStripMenuItem.Name = "CopyrigToolStripMenuItem"
        Me.CopyrigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyrigToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.CopyrigToolStripMenuItem.Text = "&Copyright "
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.QuitterToolStripMenuItem.Text = "Quitter l'application"
        '
        'QuitterLapplicationToolStripMenuItem
        '
        Me.QuitterLapplicationToolStripMenuItem.Name = "QuitterLapplicationToolStripMenuItem"
        Me.QuitterLapplicationToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.QuitterLapplicationToolStripMenuItem.Text = "Quitter l'application"
        '
        'cache
        '
        Me.cache.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cache.Location = New System.Drawing.Point(187, 168)
        Me.cache.Name = "cache"
        Me.cache.Size = New System.Drawing.Size(438, 260)
        Me.cache.TabIndex = 13
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.cache)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Reload)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.LabelErreur)
        Me.Controls.Add(Me.Abandonner)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Minuteur)
        Me.Controls.Add(Me.NomJJ)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Jeu"
        Me.Text = "Sudoku"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minuteur As Label
    Friend WithEvents NomJJ As Label
    Friend WithEvents Clear As Button
    Friend WithEvents Abandonner As Button
    Friend WithEvents LabelErreur As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents start As Button
    Friend WithEvents Reload As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesReglesDuJeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyrigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cache As Panel
    Friend WithEvents QuitterLapplicationToolStripMenuItem As ToolStripMenuItem
End Class
