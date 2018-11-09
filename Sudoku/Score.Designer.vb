<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Score))
        Me.NomList = New System.Windows.Forms.ListBox()
        Me.recherche = New System.Windows.Forms.ComboBox()
        Me.Temps = New System.Windows.Forms.ListBox()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.Nbpart = New System.Windows.Forms.ListBox()
        Me.Niveau = New System.Windows.Forms.ListBox()
        Me.Remplie = New System.Windows.Forms.ListBox()
        Me.NomR = New System.Windows.Forms.ListBox()
        Me.TempsR = New System.Windows.Forms.ListBox()
        Me.NiveauR = New System.Windows.Forms.ListBox()
        Me.NBpartie = New System.Windows.Forms.ListBox()
        Me.RemplieR = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NomList
        '
        Me.NomList.BackColor = System.Drawing.Color.Gainsboro
        Me.NomList.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomList.FormattingEnabled = True
        Me.NomList.ItemHeight = 22
        Me.NomList.Location = New System.Drawing.Point(71, 111)
        Me.NomList.Name = "NomList"
        Me.NomList.Size = New System.Drawing.Size(164, 158)
        Me.NomList.TabIndex = 0
        '
        'recherche
        '
        Me.recherche.FormattingEnabled = True
        Me.recherche.Location = New System.Drawing.Point(226, 32)
        Me.recherche.Name = "recherche"
        Me.recherche.Size = New System.Drawing.Size(326, 24)
        Me.recherche.TabIndex = 2
        '
        'Temps
        '
        Me.Temps.BackColor = System.Drawing.Color.Gainsboro
        Me.Temps.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temps.FormattingEnabled = True
        Me.Temps.ItemHeight = 22
        Me.Temps.Location = New System.Drawing.Point(241, 110)
        Me.Temps.Name = "Temps"
        Me.Temps.Size = New System.Drawing.Size(115, 158)
        Me.Temps.TabIndex = 1
        '
        'Retour
        '
        Me.Retour.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour.ForeColor = System.Drawing.Color.Firebrick
        Me.Retour.Location = New System.Drawing.Point(91, 20)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(119, 44)
        Me.Retour.TabIndex = 3
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'Rechercher
        '
        Me.Rechercher.Font = New System.Drawing.Font("Showcard Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rechercher.ForeColor = System.Drawing.Color.Firebrick
        Me.Rechercher.Location = New System.Drawing.Point(583, 20)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(126, 44)
        Me.Rechercher.TabIndex = 4
        Me.Rechercher.Text = "Rechercher"
        Me.Rechercher.UseVisualStyleBackColor = True
        '
        'Nbpart
        '
        Me.Nbpart.BackColor = System.Drawing.Color.Gainsboro
        Me.Nbpart.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nbpart.FormattingEnabled = True
        Me.Nbpart.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Nbpart.ItemHeight = 22
        Me.Nbpart.Location = New System.Drawing.Point(362, 111)
        Me.Nbpart.Name = "Nbpart"
        Me.Nbpart.Size = New System.Drawing.Size(108, 158)
        Me.Nbpart.TabIndex = 5
        '
        'Niveau
        '
        Me.Niveau.BackColor = System.Drawing.Color.Gainsboro
        Me.Niveau.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Niveau.FormattingEnabled = True
        Me.Niveau.ItemHeight = 22
        Me.Niveau.Location = New System.Drawing.Point(476, 111)
        Me.Niveau.Name = "Niveau"
        Me.Niveau.Size = New System.Drawing.Size(127, 158)
        Me.Niveau.TabIndex = 6
        '
        'Remplie
        '
        Me.Remplie.BackColor = System.Drawing.Color.Gainsboro
        Me.Remplie.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remplie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Remplie.FormattingEnabled = True
        Me.Remplie.ItemHeight = 22
        Me.Remplie.Location = New System.Drawing.Point(609, 110)
        Me.Remplie.Name = "Remplie"
        Me.Remplie.Size = New System.Drawing.Size(141, 158)
        Me.Remplie.TabIndex = 7
        '
        'NomR
        '
        Me.NomR.BackColor = System.Drawing.Color.Gainsboro
        Me.NomR.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomR.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.NomR.FormattingEnabled = True
        Me.NomR.ItemHeight = 22
        Me.NomR.Location = New System.Drawing.Point(71, 318)
        Me.NomR.Name = "NomR"
        Me.NomR.Size = New System.Drawing.Size(164, 158)
        Me.NomR.TabIndex = 8
        '
        'TempsR
        '
        Me.TempsR.BackColor = System.Drawing.Color.Gainsboro
        Me.TempsR.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsR.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.TempsR.FormattingEnabled = True
        Me.TempsR.ItemHeight = 22
        Me.TempsR.Location = New System.Drawing.Point(241, 318)
        Me.TempsR.Name = "TempsR"
        Me.TempsR.Size = New System.Drawing.Size(115, 158)
        Me.TempsR.TabIndex = 9
        '
        'NiveauR
        '
        Me.NiveauR.BackColor = System.Drawing.Color.Gainsboro
        Me.NiveauR.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiveauR.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.NiveauR.FormattingEnabled = True
        Me.NiveauR.ItemHeight = 22
        Me.NiveauR.Location = New System.Drawing.Point(476, 318)
        Me.NiveauR.Name = "NiveauR"
        Me.NiveauR.Size = New System.Drawing.Size(127, 158)
        Me.NiveauR.TabIndex = 10
        '
        'NBpartie
        '
        Me.NBpartie.BackColor = System.Drawing.Color.Gainsboro
        Me.NBpartie.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NBpartie.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.NBpartie.FormattingEnabled = True
        Me.NBpartie.ItemHeight = 22
        Me.NBpartie.Location = New System.Drawing.Point(362, 318)
        Me.NBpartie.Name = "NBpartie"
        Me.NBpartie.Size = New System.Drawing.Size(108, 158)
        Me.NBpartie.TabIndex = 11
        '
        'RemplieR
        '
        Me.RemplieR.BackColor = System.Drawing.Color.Gainsboro
        Me.RemplieR.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemplieR.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.RemplieR.FormattingEnabled = True
        Me.RemplieR.ItemHeight = 22
        Me.RemplieR.Location = New System.Drawing.Point(609, 318)
        Me.RemplieR.Name = "RemplieR"
        Me.RemplieR.Size = New System.Drawing.Size(141, 158)
        Me.RemplieR.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(68, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Resultat de la Recherche"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(628, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Remplie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(508, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Niveau"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(368, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nb Partie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(260, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Temps"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(131, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Nom"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(-3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 78)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RemplieR)
        Me.Controls.Add(Me.NBpartie)
        Me.Controls.Add(Me.NiveauR)
        Me.Controls.Add(Me.TempsR)
        Me.Controls.Add(Me.NomR)
        Me.Controls.Add(Me.Remplie)
        Me.Controls.Add(Me.Niveau)
        Me.Controls.Add(Me.Nbpart)
        Me.Controls.Add(Me.Rechercher)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.recherche)
        Me.Controls.Add(Me.Temps)
        Me.Controls.Add(Me.NomList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NomList As ListBox
    Friend WithEvents recherche As ComboBox
    Friend WithEvents Temps As ListBox
    Friend WithEvents Retour As Button
    Friend WithEvents Rechercher As Button
    Friend WithEvents Nbpart As ListBox
    Friend WithEvents Niveau As ListBox
    Friend WithEvents Remplie As ListBox
    Friend WithEvents NomR As ListBox
    Friend WithEvents TempsR As ListBox
    Friend WithEvents NiveauR As ListBox
    Friend WithEvents NBpartie As ListBox
    Friend WithEvents RemplieR As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
