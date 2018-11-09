<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreationGrille
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreationGrille))
        Me.Creer = New System.Windows.Forms.Button()
        Me.NomFichier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Creer
        '
        Me.Creer.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Creer.ForeColor = System.Drawing.Color.Firebrick
        Me.Creer.Location = New System.Drawing.Point(238, 415)
        Me.Creer.Name = "Creer"
        Me.Creer.Size = New System.Drawing.Size(627, 60)
        Me.Creer.TabIndex = 0
        Me.Creer.Text = "Creer"
        Me.Creer.UseVisualStyleBackColor = True
        '
        'NomFichier
        '
        Me.NomFichier.Location = New System.Drawing.Point(454, 108)
        Me.NomFichier.Name = "NomFichier"
        Me.NomFichier.Size = New System.Drawing.Size(185, 22)
        Me.NomFichier.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(696, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom du Sudoku "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Retour
        '
        Me.Retour.Font = New System.Drawing.Font("Showcard Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retour.Location = New System.Drawing.Point(20, 415)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(201, 60)
        Me.Retour.TabIndex = 3
        Me.Retour.Text = "Retour "
        Me.Retour.UseVisualStyleBackColor = True
        '
        'CreationGrille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NomFichier)
        Me.Controls.Add(Me.Creer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreationGrille"
        Me.Text = "CreationGrille"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Creer As Button
    Friend WithEvents NomFichier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Retour As Button
End Class
