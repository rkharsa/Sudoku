<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Resultat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resultat))
        Me.AccueilR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.remplie = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sauvegard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AccueilR
        '
        Me.AccueilR.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccueilR.Location = New System.Drawing.Point(51, 371)
        Me.AccueilR.Name = "AccueilR"
        Me.AccueilR.Size = New System.Drawing.Size(248, 67)
        Me.AccueilR.TabIndex = 1
        Me.AccueilR.Text = "Accueil"
        Me.AccueilR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(288, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Partie Finie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Temps Restant"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Niveau"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Grille Remplie"
        '
        'remplie
        '
        Me.remplie.AutoSize = True
        Me.remplie.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remplie.Location = New System.Drawing.Point(408, 224)
        Me.remplie.Name = "remplie"
        Me.remplie.Size = New System.Drawing.Size(78, 26)
        Me.remplie.TabIndex = 8
        Me.remplie.Text = "Reussi"
        '
        'level
        '
        Me.level.AutoSize = True
        Me.level.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.Location = New System.Drawing.Point(408, 277)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(76, 26)
        Me.level.TabIndex = 7
        Me.level.Text = "Facile"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Time.Location = New System.Drawing.Point(408, 175)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(34, 26)
        Me.Time.TabIndex = 6
        Me.Time.Text = "50"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(526, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Seconde"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(284, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 74)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sudoku"
        '
        'Sauvegard
        '
        Me.Sauvegard.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sauvegard.ForeColor = System.Drawing.Color.Firebrick
        Me.Sauvegard.Location = New System.Drawing.Point(305, 371)
        Me.Sauvegard.Name = "Sauvegard"
        Me.Sauvegard.Size = New System.Drawing.Size(483, 67)
        Me.Sauvegard.TabIndex = 11
        Me.Sauvegard.Text = "Sauvegarde"
        Me.Sauvegard.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(26, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 70)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Resultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Sauvegard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.remplie)
        Me.Controls.Add(Me.level)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AccueilR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Resultat"
        Me.Text = "Resultat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccueilR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents remplie As Label
    Friend WithEvents level As Label
    Friend WithEvents Time As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Sauvegard As Button
    Friend WithEvents Button1 As Button
End Class
